using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderItemController(IUnitOfWork unitOfWork)

        {
            _unitOfWork = unitOfWork;
        }

        // get all OrderItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetAllOrderItem()

        {
            var OrderItem = await _unitOfWork.OrderItemRepository.GetAll();
            if (OrderItem == null)
            {
                return NotFound();
            }

            return Ok(OrderItem);

        }


        //get OrderItem by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItem(int id)
        {
            var OrderItem = await _unitOfWork.OrderItemRepository.GetById(id);

            if (OrderItem == null)
            {
                return NotFound();
            }

            return Ok(OrderItem);
        }


    }
}



