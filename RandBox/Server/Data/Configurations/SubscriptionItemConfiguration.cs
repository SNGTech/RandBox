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
                    ProductID = 4,
                    SubscriptionPlanID = 1
                },
                new SubscriptionItem
                {
                    SubscriptionItemID = 2,
                    Qty = 1,
                    MonthOfYear = 12,
                    ProductID = 2,
                    SubscriptionPlanID = 1
                },
                new SubscriptionItem
                {
                    SubscriptionItemID = 3,
                    Qty = 1,
                    MonthOfYear = 11,
                    ProductID = 3,
                    SubscriptionPlanID = 2
                },
                new SubscriptionItem
                {
                    SubscriptionItemID = 4,
                    Qty = 1,
                    MonthOfYear = 1,
                    ProductID = 2,
                    SubscriptionPlanID = 2
                }
            );
        }
    }
}
