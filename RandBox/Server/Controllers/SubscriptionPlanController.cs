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

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SubscriptionPlan>> GetSubscription(int id)
        {
            var subscription = (await _unitOfWork.PlanRepository.GetAll(
                q => q.SubscriptionPlanID == id,
                includes: q => q.Include(x => x.SubscriptionCategory).Include(x => x.Customer).Include(x => x.Staff)!)).First();

            if (subscription == null)
            {
                return NotFound();
            }

            return Ok(subscription);
        }
    }
}
