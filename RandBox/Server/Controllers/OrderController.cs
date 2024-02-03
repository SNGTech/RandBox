using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Client.Services;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)

        {
            _unitOfWork = unitOfWork;
        }

        // Get all Order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orders>>> GetAllOrder()

        {
            var Order = await _unitOfWork.OrderRepository.GetAll(
                includes: q => q.Include(x => x.OrderItems!)!.ThenInclude(x => x.Product).Include(x => x.Customer).Include(x => x.Staff));
            if (Order == null)
            {
                return NotFound();
            }

            return Ok(Order);

        }

        // Get Order by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Orders>>> GetOrder(int id)
        {
            var Order = await _unitOfWork.OrderRepository.GetById(id);

            if (Order == null)
            {
                return NotFound();
            }

            return Ok(Order);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteOrderById(int id)
        {
            await _unitOfWork.OrderRepository.DeleteById(id);
            await _unitOfWork.Save();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Orders>> PostOrder(Orders Order)
        {
            await _unitOfWork.OrderRepository.Insert(Order);
            await _unitOfWork.Save();
            return CreatedAtAction("GetOrder", new { id = Order.OrderID }, Order);
        }
        protected async Task<bool> OrderExists(int id)
        {
            return await _unitOfWork.OrderRepository.GetById(id) != null;
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateOrder(int id, Orders newOrder)
        {
            if (id != newOrder.OrderID)
            {
                return BadRequest();
            }

            _unitOfWork.OrderRepository.Update(newOrder);

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OrderExists(id))
                {
                    return NotFound();
                }
            }
            return Ok(newOrder);
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<List<Orders>>> GetOrdersByEmail(string email) 
        {
            var orders = await _unitOfWork.OrderRepository.GetAll(q => q.Customer!.Email!.Equals(email),
                includes: q => q.Include(x => x.OrderItems!).ThenInclude(x => x.Product!));

            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        [HttpGet("total")]
        public async Task<ActionResult<decimal>> GetTotalIncome()

        {
            var orders = await _unitOfWork.OrderRepository.GetAll(
                includes: q => q.Include(x => x.OrderItems!)!.ThenInclude(x => x.Product!));
            if (orders == null)
            {
                return NotFound();
            }

            decimal totalIncome = 0M;

            foreach (var order in orders) 
            {
                decimal totalPerOrder = order.OrderItems!.Sum(x => x.Product!.DiscountedPrice * x.Qty)!;
                totalIncome += totalPerOrder;
            }

            return Ok(totalIncome);
        }

        [HttpPut("safe-delete/{StaffID:int}")]
        public async Task<ActionResult<IEnumerable<Orders>>> UpdateStaffToNullOnOrder(int StaffID)
        {
            var orders = await _unitOfWork.OrderRepository.GetAll();
            var ordersToUpdate = orders!.Where(order => order.StaffID == StaffID).ToList();

            foreach (var order in ordersToUpdate)
            {
                // Set StaffID to null for the order
                order.StaffID = null;
                _unitOfWork.OrderRepository.Update(order);
                
               
            }
            await _unitOfWork.Save();
            return Ok(orders);
        }

        [HttpPut("mark-delivered/{id:int}")]
        public async Task<ActionResult> MarkDelivered(int id)
        {
            var order = await _unitOfWork.OrderRepository.GetById(id);

            if (order == null)
            {
                return BadRequest();
            }

            order.DeliveryStatus = true;

            _unitOfWork.OrderRepository.Update(order);

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OrderExists(id))
                {
                    return NotFound();
                }
            }
            return Ok(order);
        }
    }
}

