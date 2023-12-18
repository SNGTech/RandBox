using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryID = 1,
                    Name = "Snacks",
                    Description = "Experience local snacks and treats, all while helping to support local family owned businesses!",
                    BadgeColour = "#78A54E",
                    DateTimeCreated = DateTime.Now              
                },
                new Category
                {
                    CategoryID = 2,
                    Name = "Clothing",
                    Description = "Dress up as people from all over the globe! From Kimonos to Hanboks, get a fresh look every month!",
                    BadgeColour = "#D48250",
                    DateTimeCreated = DateTime.Now
                },
                new Category
                {
                    CategoryID = 3,
                    Name = "Arts and Crafts",
                    Description = "Unleash your artistic creativity with arts and crafts from all over the world!",
                    BadgeColour = "#D45A50",
                    DateTimeCreated = DateTime.Now
                }
            );
        }
    }
}
