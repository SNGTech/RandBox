using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class SubscriptionCategoryConfiguration : IEntityTypeConfiguration<SubscriptionCategory>
    {
        public void Configure(EntityTypeBuilder<SubscriptionCategory> builder)
        {
            builder.HasData(
                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 1,
                    Description = "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.",
                    Duration = 1,
                    BaseMonthlyPrice = 45.50m,
                    NewMonthlyPrice = 45.50m,
                    CategoryID = 1
                },
                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 2,
                    Description = "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.",
                    Duration = 1,
                    BaseMonthlyPrice = 45.50m,
                    NewMonthlyPrice = 46.50m,
                    CategoryID = 2
                },
                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 3,
                    Description = "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.",
                    Duration = 1,
                    BaseMonthlyPrice = 45.50m,
                    NewMonthlyPrice = 46.90m,
                    CategoryID = 3
                },

                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 4,
                    Description = "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.",
                    Duration = 3,
                    BaseMonthlyPrice = 44.00m,
                    NewMonthlyPrice = 44.00m,
                    CategoryID = 1
                },
                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 5,
                    Description = "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.",
                    Duration = 3,
                    BaseMonthlyPrice = 45.00m,
                    NewMonthlyPrice = 45.00m,
                    CategoryID = 2
                },
                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 6,
                    Description = "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.",
                    Duration = 3,
                    BaseMonthlyPrice = 46.40m,
                    NewMonthlyPrice = 46.40m,
                    CategoryID = 3
                },

                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 7,
                    Description = "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.",
                    Duration = 6,
                    BaseMonthlyPrice = 43.50m,
                    NewMonthlyPrice = 43.50m,
                    CategoryID = 1
                },
                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 8,
                    Description = "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.",
                    Duration = 6,
                    BaseMonthlyPrice = 44.50m,
                    NewMonthlyPrice = 44.50m,
                    CategoryID = 2
                },
                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 9,
                    Description = "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.",
                    Duration = 6,
                    BaseMonthlyPrice = 44.90m,
                    NewMonthlyPrice = 44.90m,
                    CategoryID = 3
                },

                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 10,
                    Description = "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.",
                    Duration = 12,
                    BaseMonthlyPrice = 41.35m,
                    NewMonthlyPrice = 41.35m,
                    CategoryID = 1
                },
                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 11,
                    Description = "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.",
                    Duration = 12,
                    BaseMonthlyPrice = 42.35m,
                    NewMonthlyPrice = 42.35m,
                    CategoryID = 2
                },
                new SubscriptionCategory
                {
                    SubscriptionCategoryID = 12,
                    Description = "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.",
                    Duration = 12,
                    BaseMonthlyPrice = 42.75m,
                    NewMonthlyPrice = 42.75m,
                    CategoryID = 3
                }
            );
        }
    }
}
