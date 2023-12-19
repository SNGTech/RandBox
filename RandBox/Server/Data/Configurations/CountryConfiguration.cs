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
                    BadgeColour="Yellow",
                    DateTimeCreated = new DateTime(2023,2,21)
                    

                },
                new Country
                {
                    CountryID = 2,
                    Name = "Japan",
                    Description = "The land of the rising sun, experience the iconic cultures and long-standing traditions of Japan! ",
                    BadgeColour = "Red",
                    DateTimeCreated = new DateTime(2023,1,28)

                }
            );
        }
    }
}
