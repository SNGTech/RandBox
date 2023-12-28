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
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()

        {
            var Product = await _unitOfWork.ProductRepository.GetAll(
                includes: q => q.Include(x => x.Category!).Include(x => x.Country!));
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


        [HttpPost]
        public async Task<ActionResult> AddProduct(Product Product)
        {
            await _unitOfWork.ProductRepository.Insert(Product);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetProduct), new { id = Product.ProductID }, Product);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateProduct(int id, Product newProduct)
        {
            if (id != newProduct.ProductID)
            {
                return BadRequest();
            }

            _unitOfWork.ProductRepository.Update(newProduct);

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ProductExists(id))
                {
                    return NotFound();
                }
            }
            return Ok(newProduct);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteProductById(int id)
        {
            await _unitOfWork.ProductRepository.DeleteById(id);
            await _unitOfWork.Save();

            return NoContent();
        }

        protected async Task<bool> ProductExists(int id)
        {
            return await _unitOfWork.ProductRepository.GetById(id) != null;
        }
    }
}



