using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetAllOrderItemsByIds(List<int> ids)
        {
            var filtered = await _unitOfWork.OrderItemRepository.GetAll(q => ids.Contains(q.OrderItemID));

            if (filtered == null)
            {
                return NotFound();
            }
            return Ok(filtered);
        }

        [HttpGet("order/{orderId:int}")]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetAllOrderItemsByOrder(int orderId)
        {
            var items = await _unitOfWork.OrderItemRepository.GetAll(q => q.OrderID == orderId,
                includes: q => q.Include(x => x.Product)!.Include(x => x.Product!.Category)!.Include(x => x.Product!.Country)!);

            if (items == null)
            {
                return NotFound();
            }

            return Ok(items);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<OrderItem>>> AddOrderItems(List<OrderItem> newItems)
        {
            await _unitOfWork.OrderItemRepository.InsertRange(newItems);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetAllOrderItemsByIds), new { ids = newItems.Select(x => x.OrderItemID).ToList() }, newItems);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateItem(int id, OrderItem updatedItem)
        {
            if (id != updatedItem.OrderItemID)
            {
                return BadRequest();
            }

            _unitOfWork.OrderItemRepository.Update(updatedItem);

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OrderItemExists(id))
                {
                    return NotFound();
                }
            }
            return Ok(updatedItem);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteItemById(int id)
        {
            await _unitOfWork.OrderItemRepository.DeleteById(id);
            await _unitOfWork.Save();

            return NoContent();
        }

        protected async Task<bool> OrderItemExists(int id)
        {
            return await _unitOfWork.OrderItemRepository.GetById(id) != null;
        }
    }
}
