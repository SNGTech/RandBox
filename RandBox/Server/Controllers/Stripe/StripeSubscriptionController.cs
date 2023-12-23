using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;
using Stripe;

namespace RandBox.Server.Controllers.Stripe
{
    [ApiController]
    [Route("stripe-api/subscription")]
    public class StripeSubscriptionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StripeSubscriptionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<SubscriptionCategory>>> AddSubscriptionPricingsFromDb()
        {
            var subscriptionCategories = await _unitOfWork.SubscriptionCategoryRepository.GetAll(includes: q => q.Include(x => x.Category!));

            if (subscriptionCategories == null)
            {
                return NotFound();
            }

            // Product refers to individual subscription category/plan
            var service = new ProductService();

            foreach (var subscriptionCategory in subscriptionCategories)
            {
                var productName = $"RandBox: {subscriptionCategory.Duration} Months Plan - {subscriptionCategory.Category!.Name}";

                var productOptions = new ProductCreateOptions
                {
                    Id = $"plan_{subscriptionCategory.SubscriptionCategoryID}",
                    Name = productName,
                    DefaultPriceData = new ProductDefaultPriceDataOptions
                    {
                        UnitAmount = Convert.ToInt64(subscriptionCategory.NewMonthlyPrice.ToString().Replace(".", "")),
                        Currency = "sgd",
                        Recurring = new ProductDefaultPriceDataRecurringOptions { Interval = "month" }
                    }
                };
                service.Create(productOptions);
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> AddSubscriptionPlanAsync([FromBody] PlanCreateRequest request)
        {
            var subscriptionCategory = await _unitOfWork.SubscriptionCategoryRepository.GetById(int.Parse(request.PlanID!.Split("_")[1]));

            if (subscriptionCategory == null)
            {
                return NotFound();
            }

            var options = new SubscriptionScheduleCreateOptions
            {
                Customer = request.CustomerID,
                StartDate = DateTime.Now,
                EndBehavior = "release",
                Phases = new List<SubscriptionSchedulePhaseOptions>
                {
                    new SubscriptionSchedulePhaseOptions
                    {
                        Items = new List<SubscriptionSchedulePhaseItemOptions>
                        {
                            new SubscriptionSchedulePhaseItemOptions
                            {
                                Price = request.PriceId,
                                Quantity = 1,
                            },
                        },
                        Iterations = subscriptionCategory.Duration,
                    }
                },
            };
            var service = new SubscriptionScheduleService();
            service.Create(options);
            return NoContent();
        }

        public class PlanCreateRequest
        {
            [JsonProperty("custId")]
            public string? CustomerID { get; set; }
            [JsonProperty("planId")]
            public string? PlanID { get; set;}
            [JsonProperty("priceId")]
            public string? PriceId { get; set; }
        }
    }
}
