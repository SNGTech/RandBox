using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

		protected async Task<bool> CategoryExists(int id)
		{
			return await _unitOfWork.CategoryRepository.GetById(id) != null;
		}
    }
}
