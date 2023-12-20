using Microsoft.AspNetCore.Mvc;
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

		[HttpGet]
		public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> GetAllSubscripionCategories()
		{
			var subscription_categories = await _unitOfWork.SubscriptionCategoryRepository.GetAll();

			if (subscription_categories == null)
			{
				return NotFound();
			}
			return Ok(subscription_categories);
		}

		[HttpGet("{category_id:int}")]
		public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> GetSubscriptionCategoriesByProductCategoriesId(int category_id)
		{
			var subscription_categories = await _unitOfWork.SubscriptionCategoryRepository.GetAll(q => q.CategoryID == category_id);

			if (subscription_categories == null)
			{
				return NotFound();
			}
			return Ok(subscription_categories);
		}
	}
}
