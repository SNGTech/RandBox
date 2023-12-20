using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // get all Order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrder()

        {
            var Order = await _unitOfWork.OrderRepository.GetAll();
            if (Order == null)
            {
                return NotFound();
            }

            return Ok(Order);

        }


        //get Order by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder(int id)
        {
            var Order = await _unitOfWork.OrderRepository.GetById(id);

            if (Order == null)
            {
                return NotFound();
            }

            return Ok(Order);
        }

        
    }
}

