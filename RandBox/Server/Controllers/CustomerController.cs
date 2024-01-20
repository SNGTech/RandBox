using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Models;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;
using System.Security.Claims;

namespace RandBox.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public CustomerController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetAllCustomers()
        {
            var customers = await _unitOfWork.CustomerRepository.GetAll();

            if (customers == null)
            {
                return NotFound();
            }

            return Ok(customers);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _unitOfWork.CustomerRepository.GetById(id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult> AddCustomer(Customer customer)
        {
            await _unitOfWork.CustomerRepository.Insert(customer);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetCustomer), new { id = customer.CustID }, customer);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateCustomer(int id, Customer newCustomer)
        {
            if (id != newCustomer.CustID)
            {
                return BadRequest();
            }

            _unitOfWork.CustomerRepository.Update(newCustomer);

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CustomerExists(id))
                {
                    return NotFound();
                }
            }
            return Ok(newCustomer);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteCustomerById(int id)
        {
            await _unitOfWork.CustomerRepository.DeleteById(id);
            await _unitOfWork.Save();

            return NoContent();
        }

        protected async Task<bool> CustomerExists(int id)
        {
            return await _unitOfWork.CustomerRepository.GetById(id) != null;
        }

        /*[Authorize(Roles = "Customer")]
        [HttpGet("current")]
        public async Task<ActionResult<string>> GetCurrentCustomerEmail()
        {
            ClaimsPrincipal currentUser = User;
            var user = await _userManager.GetUserAsync(currentUser);
            return Ok(user!.Email);
        }*/


    }
}
