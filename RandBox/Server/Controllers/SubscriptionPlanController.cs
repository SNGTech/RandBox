using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;
using Stripe;

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
                includes: q => q.Include(x => x.SubscriptionCategory).Include(x => x.Customer).Include(x => x.Staff)!
                .Include(x => x.SubscriptionItems!))).First();

            if (subscription == null)
            {
                return NotFound();
            }

            return Ok(subscription);
        }

        [HttpPost]
        public async Task<ActionResult> AddSubscription(SubscriptionPlan subscription)
        {
            await _unitOfWork.PlanRepository.Insert(subscription);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetSubscription), new { id = subscription.SubscriptionPlanID }, subscription);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateSubscription(int id, SubscriptionPlan newSubscription)
        {
            if (id != newSubscription.SubscriptionPlanID)
            {
                return BadRequest();
            }

            _unitOfWork.PlanRepository.Update(newSubscription);

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SubscriptionExists(id))
                {
                    return NotFound();
                }
            }
            return Ok(newSubscription);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteSubscriptionById(int id)
        {
            await _unitOfWork.PlanRepository.DeleteById(id);
            await _unitOfWork.Save();

            return NoContent();
        }


        [HttpPut("safe-delete/{StaffID:int}")]
        public async Task<ActionResult<IEnumerable<Subscription>>> UpdateStaffToNullOnSubscriptionPlan(int StaffID)
        {
            var plans = await _unitOfWork.PlanRepository.GetAll();
            var planToUpdate = plans!.Where(plan => plan.StaffID == StaffID).ToList();

            foreach (var plan in planToUpdate)
            {
                // Set StaffID to null for the order
                plan.StaffID = null;
                _unitOfWork.PlanRepository.Update(plan);


            }
            await _unitOfWork.Save();
            return Ok(plans);
        }
        protected async Task<bool> SubscriptionExists(int id)
        {
            return await _unitOfWork.PlanRepository.GetById(id) != null;
        }
    }
}
