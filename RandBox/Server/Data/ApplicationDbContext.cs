using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RandBox.Server.Data.Configurations;
using RandBox.Server.Models;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlan { get; set; }
        public DbSet<SubscriptionCategory> SubscriptionCategory { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new SubscriptionCategoryConfiguration());
            builder.ApplyConfiguration(new SubscriptionPlanConfiguration());
        }
    }
}