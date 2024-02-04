using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Client.Shared.Error;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{ 
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public CategoryController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
		{
			var categories = await _unitOfWork.CategoryRepository.GetAll();

            if (categories == null)
			{
				return NotFound();
			}

			return Ok(categories);
		}

		[HttpGet("{id:int}")]
		public async Task<ActionResult<IEnumerable<Category>>> GetCategory(int id)
		{
			var category = await _unitOfWork.CategoryRepository.GetById(id);

			if (category == null)
			{
				return NotFound();
			}

			return Ok(category);
		}

		[HttpPost]
		public async Task<ActionResult> AddCategory(Category category)
		{
            await _unitOfWork.CategoryRepository.Insert(category);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetCategory), new { id = category.CategoryID }, category);
        }

		[HttpPut("{id:int}")]
		public async Task<ActionResult> UpdateCategory(int id, Category newCategory)
		{
			if (id != newCategory.CategoryID)
			{
				return BadRequest();
			}

			_unitOfWork.CategoryRepository.Update(newCategory);

			try
			{
				await _unitOfWork.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if(!await CategoryExists(id))
				{
					return NotFound();
				}
			}
			return Ok(newCategory);
		}

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteCategoryById(int id)
        {
            await _unitOfWork.CategoryRepository.DeleteById(id);
            await _unitOfWork.Save();

            return NoContent();
        }

        protected async Task<bool> CategoryExists(int id)
		{
			return await _unitOfWork.CategoryRepository.GetById(id) != null;
		}

        [HttpGet("ReferenceExistInAnyEntity/{id:int}")]
        public async Task<ActionResult<bool>> ReferenceExistInAnyEntity(int id)
        {
            var products = await _unitOfWork.ProductRepository.GetAll();
			var subscriptions = await _unitOfWork.PlanRepository.GetAll(
				includes: q => q.Include(x => x.SubscriptionCategory!).ThenInclude(x => x.Category!));
			// var subcategories = await _unitOfWork.SubscriptionCategoryRepository.GetAll();

            if (products == null)
            {
                return BadRequest();
            }
            else
            {
                // Check if the category is referenced in any of the products or subscription plans
                bool isReferenced = products.Any(p => p.CategoryID == id) || subscriptions.Any(s => s.SubscriptionCategory!.CategoryID == id);

                if (isReferenced)
                {
                    return Ok(true);
                }

                return Ok(false);
            }
        }
    }
}
