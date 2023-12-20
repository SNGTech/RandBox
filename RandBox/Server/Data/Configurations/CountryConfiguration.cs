using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    CountryID = 1,
                    Name = "Germany",
                    Description ="Bring the well-known festivities and nightlife of Germany to your own home!",
                    BadgeColour= "#78A54E",
                    DateTimeCreated = DateTime.Now
                },
                new Country
                {
                    CountryID = 2,
                    Name = "Japan",
                    Description = "The land of the rising sun, experience the iconic cultures and long-standing traditions of Japan! ",
                    BadgeColour = "#D45A50",
                    DateTimeCreated = DateTime.Now
				},
				new Country
				{
					CountryID = 3,
					Name = "Indonesia",
					Description = "With many diverse ethnic groups, experience the traditional tastes and cultures of the worlds largest island country.",
					BadgeColour = "#D48250",
					DateTimeCreated = DateTime.Now
				}
			);
        }
    }
}
