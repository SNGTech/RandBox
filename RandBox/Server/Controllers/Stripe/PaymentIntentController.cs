using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Stripe;

namespace RandBox.Server.Controllers.Stripe
{
    [ApiController]
    [Route("api/payment-intent")]
    public class PaymentIntentController : ControllerBase
    {

        /*public PaymentIntentController() 
        {

        }

        [HttpPost]
        public ActionResult Create([FromBody] PaymentIntentCreateRequest request) 
        {
            var productService = new ProductService();
            var product = productService.Get($"plan_{request.Id}");

            if (product.DefaultPriceId == null)
            {
                return NotFound();
            }

            var priceService = new PriceService();
            var price = priceService.Get(product.DefaultPriceId);

            var service = new PaymentIntentService();
            var options = new PaymentIntentCreateOptions
            {
                Amount = price.UnitAmount,
                Currency = "sgd",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true
                }
            };

            // Due to the way the accounts are setup, it will be impossible for customer to be null here
            var customerService = new CustomerService();
            var customer = customerService.Search(new CustomerSearchOptions
            {
                Query = $"email:'{request.CustEmail}'",
            })
            .FirstOrDefault();

            if (customer != null)
            {
                options.AddExtraParam("customer", customer!.Id);
            }

            var paymentIntent = service.Create(options);
            return Ok(new { clientSecret = paymentIntent.ClientSecret });
        }

        public class PaymentIntentCreateRequest
        {
            [JsonProperty("plan_id")]
            public int Id { get; set; }
            [JsonProperty("cust_email")]
            public string? CustEmail { get; set; }
        }*/
    }
}
