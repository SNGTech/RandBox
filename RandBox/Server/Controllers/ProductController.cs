using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)

        {
            _unitOfWork = unitOfWork;
        }

        // Get all Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProduct()

        {
            var Product = await _unitOfWork.ProductRepository.GetAll();
            if (Product == null)
            {
                return NotFound();
            }

            return Ok(Product);
        }

        // Get Product by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct(int id)
        {
            var Product = await _unitOfWork.ProductRepository.GetById(id);

            if (Product == null)
            {
                return NotFound();
            }

            return Ok(Product);
        }


    }
}



