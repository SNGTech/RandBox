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

        [HttpPatch("{countryId:int}")]
        public async Task<ActionResult<IEnumerable<Product>>> RemoveCountryFromProducts(int countryId)
        {
            var products = await _unitOfWork.ProductRepository.GetAll(q => q.CountryID == countryId);

            if (products == null)
            {
                return BadRequest();
            }

            foreach (var product in products)
            {
                product.CountryID = countryId;
                _unitOfWork.ProductRepository.Update(product);
            }

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
            return Ok(products);
        }
    }
}



