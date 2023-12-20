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

        // get all Country
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetAllCountry()

        {
            var Country = await _unitOfWork.CountryRepository.GetAll();
            if (Country == null)
            {
                return NotFound();
            }

            return Ok(Country);

        }


        //get Country by id
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


    }
}



