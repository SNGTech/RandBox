using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SubscriptionCategoryController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public SubscriptionCategoryController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		[HttpGet("all")]
		public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> GetAllSubscripionCategories()
		{
			var subscription_categories = await _unitOfWork.SubscriptionCategoryRepository.GetAll(
                includes: q => q.Include(x => x.Category!));

			if (subscription_categories == null)
			{
				return NotFound();
			}
			return Ok(subscription_categories);
		}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> GetAllSubscripionCategoriesByIds(List<int> ids)
        {
            var filtered = await _unitOfWork.SubscriptionCategoryRepository.GetAll(q => ids.Contains(q.SubscriptionCategoryID));

            if (filtered == null)
            {
                return NotFound();
            }
            return Ok(filtered);
        }

        [HttpGet("duration/{duration:int}")]
        public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> GetAllSubscripionCategoriesByDuration(int duration)
        {
            var subscription_categories = await _unitOfWork.SubscriptionCategoryRepository.GetAll(q => q.Duration == duration,
                includes: q => q.Include(x => x.Category!));

            if (subscription_categories == null)
            {
                return NotFound();
            }
            return Ok(subscription_categories);
        }

        [HttpGet("base")]
        public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> GetAllBaseSubscripionCategories()
        {
			var firstId = (await _unitOfWork.SubscriptionCategoryRepository.GetAll()).First().CategoryID;
            var base_subscription_categories = await _unitOfWork.SubscriptionCategoryRepository.GetAll(q => q.CategoryID == firstId);

            if (base_subscription_categories == null)
            {
                return NotFound();
            }
            return Ok(base_subscription_categories);
        }

        [HttpGet("category/{category_id:int}")]
		public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> GetSubscriptionCategoriesByProductCategoriesId(int category_id)
		{
			var subscription_categories = await _unitOfWork.SubscriptionCategoryRepository.GetAll(q => q.CategoryID == category_id,
                includes: q => q.Include(x => x.Category!));

			if (subscription_categories == null)
			{
				return NotFound();
			}
			return Ok(subscription_categories);
		}

		[HttpPut("duration/{duration:int}")]
		public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> UpdateBySubscriptionDuration(int duration, List<SubscriptionCategory> newSubscriptionCategories)
		{
            var subscription_categories = (await _unitOfWork.SubscriptionCategoryRepository.GetAll(q => q.Duration == duration)).ToList();

            if (subscription_categories.Count != newSubscriptionCategories.Count)
            {
                return BadRequest();
            }
            for (int i = 0; i < subscription_categories.Count; i++)
            {
                if (subscription_categories[i].SubscriptionCategoryID != newSubscriptionCategories[i].SubscriptionCategoryID)
                {
                    return BadRequest();
                }
            }

            foreach (var subscriptionCategory in newSubscriptionCategories)
            {
                _unitOfWork.SubscriptionCategoryRepository.Update(subscriptionCategory);
            }

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return Ok(newSubscriptionCategories);
        }

        [HttpPost("duration")]
        public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> AddBySubscriptionDuration(List<SubscriptionCategory> newSubscriptionCategories)
        {
            await _unitOfWork.SubscriptionCategoryRepository.InsertRange(newSubscriptionCategories);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetAllSubscripionCategoriesByIds), new { ids = newSubscriptionCategories.Select(x => x.SubscriptionCategoryID).ToList() }, newSubscriptionCategories);
        }

        [HttpPost("category/{categoryId:int}")]
        public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> AddByProductCategory(int categoryId)
        {
            var firstId = (await _unitOfWork.SubscriptionCategoryRepository.GetAll()).First().CategoryID;
            var base_subscription_categories = await _unitOfWork.SubscriptionCategoryRepository.GetAll(q => q.CategoryID == firstId);

            if (base_subscription_categories == null)
            {
                return NotFound();
            }

            var filtered = base_subscription_categories.Select(x => new SubscriptionCategory
            {
                Description = x.Description,
                Duration = x.Duration,
                BaseMonthlyPrice = x.BaseMonthlyPrice,
                NewMonthlyPrice = x.BaseMonthlyPrice,
                CategoryID = categoryId
            });

            await _unitOfWork.SubscriptionCategoryRepository.InsertRange(filtered);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetAllSubscripionCategoriesByIds), new { ids = filtered.Select(x => x.SubscriptionCategoryID).ToList() }, filtered);
        }

        [HttpDelete("duration/{duration:int}")]
        public async Task<ActionResult> DeleteBySubscriptionDuration(int duration)
        {
            var subscription_categories = await _unitOfWork.SubscriptionCategoryRepository.GetAll(q => q.Duration == duration);

            if (subscription_categories == null)
            {
                return NotFound();
            }

            _unitOfWork.SubscriptionCategoryRepository.DeleteRange(subscription_categories);
            await _unitOfWork.Save();

            return NoContent();
        }

        [HttpDelete("category/{categoryId:int}")]
        public async Task<ActionResult> DeleteByCategoryId(int categoryId)
        {
            var subscription_categories = await _unitOfWork.SubscriptionCategoryRepository.GetAll(q => q.CategoryID == categoryId);

            if (subscription_categories == null)
            {
                return NotFound();
            }

            _unitOfWork.SubscriptionCategoryRepository.DeleteRange(subscription_categories);
            await _unitOfWork.Save();

            return NoContent();
        }
        [HttpPut("safe-delete-category/{CategoryID:int}")]
        public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> UpdateCategoryToNullOnSubCategory(int CategoryID)
        {
            var subscriptionCategories = await _unitOfWork.SubscriptionCategoryRepository.GetAll();
            var subscriptionCategoriesToUpdate = subscriptionCategories!.Where(category => category.CategoryID == CategoryID).ToList();

            foreach (var subscriptionCategory in subscriptionCategoriesToUpdate)
            {
                // Set CategoryID to null for the subscription category
                subscriptionCategory.CategoryID = null;
                _unitOfWork.SubscriptionCategoryRepository.Update(subscriptionCategory);
            }

            await _unitOfWork.Save();
            return Ok(subscriptionCategories);
        }

        [HttpGet("durationAll")]
        public async Task<ActionResult<List<int>>> GetAllDurations()
        {
            var subscriptionCategories = await _unitOfWork.SubscriptionCategoryRepository.GetAll();

            if (subscriptionCategories == null)
            {
                return NotFound();
            }

            var durations = subscriptionCategories.Select(x => x.Duration).Distinct();

            return Ok(durations);
        }

        [HttpGet("ReferenceExistInSubscription/duration/{duration:int}")]
        public async Task<ActionResult<bool>> ReferenceExistInSubscription(int duration)
        {
            var subscriptions = await _unitOfWork.PlanRepository.GetAll(
                includes: q => q.Include(x => x.SubscriptionCategory!));

            if (subscriptions == null)
            {
                return BadRequest();
            }
                
            bool isReferenced = subscriptions.Any(s => s.SubscriptionCategory!.Duration == duration);
            if (isReferenced)
            {
                return Ok(true);
            }

            return Ok(false);
        }
    }
}
