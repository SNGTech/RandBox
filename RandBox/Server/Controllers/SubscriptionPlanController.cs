using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SubscriptionPlanController : ControllerBase
	{
        private readonly IUnitOfWork _unitOfWork;

        public SubscriptionPlanController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubscriptionPlan>>> GetAllSubscriptions()
        {
            var subscriptions = await _unitOfWork.PlanRepository.GetAll(
                includes: q => q.Include(x => x.SubscriptionCategory).Include(x => x.Customer).Include(x => x.Staff)!);

            if (subscriptions == null)
            {
                return NotFound();
            }

            return Ok(subscriptions);
        }
    }
}
