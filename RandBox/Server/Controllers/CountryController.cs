using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CountryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetAllCategories()
        {
            var categories = await _unitOfWork.CountryRepository.GetAll();

            if (categories == null)
            {
                return NotFound();
            }

            return Ok(categories);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountry(int id)
        {
            var Country = await _unitOfWork.CountryRepository.GetById(id);

            if (Country == null)
            {
                return NotFound();
            }

            return Ok(Country);
        }

        [HttpPost]
        public async Task<ActionResult> AddCountry(Country Country)
        {
            await _unitOfWork.CountryRepository.Insert(Country);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetCountry), new { id = Country.CountryID }, Country);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateCountry(int id, Country newCountry)
        {
            if (id != newCountry.CountryID)
            {
                return BadRequest();
            }

            _unitOfWork.CountryRepository.Update(newCountry);

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CountryExists(id))
                {
                    return NotFound();
                }
            }
            return Ok(newCountry);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteCountryById(int id)
        {
            await _unitOfWork.CountryRepository.DeleteById(id);
            await _unitOfWork.Save();

            return NoContent();
        }

        protected async Task<bool> CountryExists(int id)
        {
            return await _unitOfWork.CountryRepository.GetById(id) != null;
        }





        [HttpGet("ReferenceExistInAnyEntity/{id:int}")]
        public async Task<ActionResult<bool>> ReferenceExistInAnyEntity(int id)
        {
            var products = await _unitOfWork.ProductRepository.GetAll();

            if (products == null)
            {
                return BadRequest();
            }
            else
            {
                // Check if the countryId is referenced in any of the products
                bool countryIdReferenced = products.Any(p => p.CountryID == id);

                if (countryIdReferenced)
                {
                    return Ok(true);
                }

                return Ok(false);
            }
        }


    }

}
