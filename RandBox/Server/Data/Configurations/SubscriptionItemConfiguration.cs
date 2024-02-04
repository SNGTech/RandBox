using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class SubscriptionItemConfiguration : IEntityTypeConfiguration<SubscriptionItem>
    {
        public void Configure(EntityTypeBuilder<SubscriptionItem> builder)
        {
            builder.HasData(
                new SubscriptionItem
                {
                    SubscriptionItemID = 1,
                    Qty = 1,
                    MonthOfYear = 12,
                    ProductID = 16,
                    SubscriptionPlanID = 1
                },
                new SubscriptionItem
                {
                    SubscriptionItemID = 2,
                    Qty = 1,
                    MonthOfYear = 12,
                    ProductID = 12,
                    SubscriptionPlanID = 1
                },
                new SubscriptionItem
                {
                    SubscriptionItemID = 3,
                    Qty = 1,
                    MonthOfYear = 11,
                    ProductID = 7,
                    SubscriptionPlanID = 2
                },
                new SubscriptionItem
                {
                    SubscriptionItemID = 4,
                    Qty = 1,
                    MonthOfYear = 1,
                    ProductID = 10,
                    SubscriptionPlanID = 2
                }
            );
        }
    }
}
