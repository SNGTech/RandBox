using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class SubscriptionPlanConfiguration : IEntityTypeConfiguration<SubscriptionPlan>
    {
        public void Configure(EntityTypeBuilder<SubscriptionPlan> builder)
        {
            builder.HasData(
                new SubscriptionPlan
                {
                    SubscriptionPlanID = 1,
                    SubscribedDateTime = DateTime.Now,
                    CustID = 1,
                    SubscriptionCategoryID = 12,
                    StaffID = null
                },
                new SubscriptionPlan
                {
                    SubscriptionPlanID = 2,
                    SubscribedDateTime = DateTime.Now.AddMonths(-2),
                    CustID = 2,
                    SubscriptionCategoryID = 5,
                    StaffID = null
                }
            );
        }
    }
}
