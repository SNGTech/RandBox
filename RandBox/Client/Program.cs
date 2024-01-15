using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RandBox.Client;
using RandBox.Client.Services;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Http Client that needs Authentication (private API endpoints)
builder.Services.AddHttpClient("RandBox.ServerAPI.private", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Http Client which can be used Anonymously (public API endpoints)
builder.Services.AddHttpClient("RandBox.ServerAPI.public", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("RandBox.ServerAPI.private"));

builder.Services.AddScoped<IGenericService<Category>, CategoryService>();
builder.Services.AddScoped<IGenericService<Product>, ProductService>();
builder.Services.AddScoped<IGenericService<SubscriptionPlan>, SubscriptionPlanService>();
builder.Services.AddScoped<ISubscriptionCategoryService, SubscriptionCategoryService>();
builder.Services.AddScoped<IPaymentIntentService, PaymentIntentService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IGenericService<Country>, CountryService>();
builder.Services.AddScoped<ISubscriptionItemService, SubscriptionItemService>();
builder.Services.AddScoped<IGenericService<OrderItem>, OrderItemService>();
builder.Services.AddScoped<IGenericService<Order>, OrderService>();

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
