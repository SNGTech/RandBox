using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RandBox.Server.Models;
using RandBox.Server.Repositories.Contracts;
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

        [Authorize(Roles = "Customer")]
        [HttpGet("current")]
        public async Task<ActionResult<string>> GetCurrentCustomerEmail()
        {
            ClaimsPrincipal currentUser = User;
            var user = await _userManager.GetUserAsync(currentUser);
            return Ok(user!.Email);
        }
    }
}
