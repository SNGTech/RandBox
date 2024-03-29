﻿using Microsoft.AspNetCore.Mvc;
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
                includes: q => q.Include(x => x.SubscriptionCategory)
                .ThenInclude(x => x!.Category!)
                .Include(x => x.Customer).Include(x => x.Staff)!
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

        [HttpGet("{email}")]
        public async Task<ActionResult<List<SubscriptionPlan>>> GetSubscriptionsByEmail(string email)
        {
            var subscriptions = await _unitOfWork.PlanRepository.GetAll(q => q.Customer!.Email!.Equals(email),
                includes: q => q.Include(x => x.SubscriptionCategory!).ThenInclude(x => x.Category!));

            if (subscriptions == null)
            {
                return NotFound();
            }

            return Ok(subscriptions);
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

        [HttpGet("countByDuration")]
        public async Task<ActionResult<IEnumerable<decimal>>> GetSubscriptionCountByDuration()
        {
            var subscriptions = await _unitOfWork.PlanRepository.GetAll(
                includes: q => q.Include(x => x.SubscriptionCategory!));
            var subscriptionCategories = await _unitOfWork.SubscriptionCategoryRepository.GetAll();

            if (subscriptions == null || subscriptionCategories == null)
            {
                return BadRequest();
            }

            List<decimal> countByDuration = new List<decimal>();

            var durations = subscriptionCategories.Select(x => x.Duration).Distinct();

            foreach (var duration in durations) 
            {
                decimal count = subscriptions.Select(x => x.SubscriptionCategory!).Where(x => x.Duration == duration).Count();
                countByDuration.Add(count);
            }

            return Ok(countByDuration);
        }

        protected async Task<bool> SubscriptionExists(int id)
        {
            return await _unitOfWork.PlanRepository.GetById(id) != null;
        }
    }
}
