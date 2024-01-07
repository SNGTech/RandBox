using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionItemController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubscriptionItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubscriptionItem>>> GetAllSubscripionItemsByIds(List<int> ids)
        {
            var filtered = await _unitOfWork.SubscriptionItemRepository.GetAll(q => ids.Contains(q.SubscriptionItemID));

            if (filtered == null)
            {
                return NotFound();
            }
            return Ok(filtered);
        }

        [HttpGet("plan/{planId:int}")]
        public async Task<ActionResult<IEnumerable<SubscriptionItem>>> GetAllSubscriptionItemsByPlan(int planId)
        {
            var items = await _unitOfWork.SubscriptionItemRepository.GetAll(q => q.SubscriptionPlanID == planId,
                includes: q => q.Include(x => x.Product)!);

            if (items == null)
            {
                return NotFound();
            }

            return Ok(items);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<SubscriptionItem>>> AddSubscriptionItems(List<SubscriptionItem> newItems)
        {
            await _unitOfWork.SubscriptionItemRepository.InsertRange(newItems);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetAllSubscripionItemsByIds), new { ids = newItems.Select(x => x.SubscriptionItemID).ToList() }, newItems);
        }
    }
}
