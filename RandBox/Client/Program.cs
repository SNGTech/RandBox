using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RandBox.Client;
using RandBox.Client.Services;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Http Client that needs Authentication (private API endpoints)
builder.Services.AddHttpClient("RandBox.ServerAPI.private", (sp,
    client) => {
        client.BaseAddress = new
        Uri(builder.HostEnvironment.BaseAddress);
        client.EnableIntercept(sp);
    })
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Http Client which can be used Anonymously (public API endpoints)
builder.Services.AddHttpClient("RandBox.ServerAPI.public", (sp,
    client) => {
        client.BaseAddress = new
        Uri(builder.HostEnvironment.BaseAddress);
        client.EnableIntercept(sp);
    });

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("RandBox.ServerAPI.private"));

builder.Services.AddScoped<HttpInterceptorService>();
builder.Services.AddScoped<IGenericService<Category>, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISubscriptionPlanService, SubscriptionPlanService>();
builder.Services.AddScoped<ISubscriptionCategoryService, SubscriptionCategoryService>();
builder.Services.AddScoped<IPaymentIntentService, PaymentIntentService>();
builder.Services.AddScoped<IGenericService<Customer>, CustomerService>();
builder.Services.AddScoped<IGenericService<Country>, CountryService>();
builder.Services.AddScoped<ISubscriptionItemService, SubscriptionItemService>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IStaffService, StaffService>();

builder.Services.AddHttpClientInterceptor();

builder.Services.AddApiAuthorization();

builder.Services.AddAuthorizationCore(options =>
{
    options.AddPolicy("StaffPolicy", policy => policy.RequireRole("Staff"));
    options.AddPolicy("CustomerPolicy", policy => policy.RequireRole("Customer"));
    options.AddPolicy("UserOrCustomerPolicy", policy =>
        policy.RequireAssertion(context =>
        {
            bool isNotAuthenticated = !context.User.Identity!.IsAuthenticated;
            bool isCustomer = context.User.IsInRole("Customer");
            return isCustomer || isNotAuthenticated;
        })
    );
});

await builder.Build().RunAsync();
