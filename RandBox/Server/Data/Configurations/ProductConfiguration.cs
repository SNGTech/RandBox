using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    ProductID = 1,
                    Name = "Dorayaki",
                    Description = "A unique red bean pancake only found in Japan",
                    ThumbnailURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Dorayaki_001.jpg/450px-Dorayaki_001.jpg",
                    StockNo = 501,
                    OriginalPrice = 17.89m,
                    DiscountedPrice = 12.29m,
                    ManufacturedDate = new DateTime(2023, 12, 29),
                    ExpiryDate = new DateTime(2024, 1, 31),
                    CountryID = 1,
                    CategoryID = 2                   
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Crunchips Paprika",
                    Description = "Local favourite chips by Lorenz",
                    ThumbnailURL = "https://m.media-amazon.com/images/I/71Lnoe-JAkL.__AC_SX300_SY300_QL70_ML2_.jpg",
                    StockNo = 278,
                    OriginalPrice = 10.21m,
                    DiscountedPrice = 7.79m,
                    ManufacturedDate = new DateTime(2023, 11, 3),
                    ExpiryDate = new DateTime(2024, 2, 27),
                    CountryID = 2,
                    CategoryID = 2

                }
            );
        }
    }
}
