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
                    Name = "Kue Mangkok",
                    Description = "Traditional Steamed Cupcake",
                    ThumbnailURL = "images/products/kue_mangkok.png",
                    StockNo = 501,
                    OriginalPrice = 17.89m,
                    DiscountedPrice = 12.29m,
                    ManufacturedDate = new DateTime(2023, 12, 29),
                    ExpiryDate = new DateTime(2024, 1, 31),
                    CountryID = 3,
                    CategoryID = 1                   
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Zwiebelkuchen",
                    Description = "Traditional Onion Cake",
                    ThumbnailURL = "images/products/zwiebelkuchen.png",
                    StockNo = 278,
                    OriginalPrice = 10.21m,
                    DiscountedPrice = 7.79m,
                    ManufacturedDate = new DateTime(2023, 11, 3),
                    ExpiryDate = new DateTime(2024, 2, 27),
                    CountryID = 1,
                    CategoryID = 1
                },
				new Product
				{
					ProductID = 3,
					Name = "Ruby-cocoa KitKat",
					Description = "Special Chocolate Bar",
					ThumbnailURL = "images/products/ruby_cocoa_kitkat.png",
					StockNo = 1001,
					OriginalPrice = 5.89m,
					DiscountedPrice = 5.89m,
					ManufacturedDate = new DateTime(2023, 11, 29),
					ExpiryDate = new DateTime(2025, 12, 31),
					CountryID = 2,
					CategoryID = 1
				},
				new Product
				{
					ProductID = 4,
					Name = "Ramune Soda Candy",
					Description = "Local favourite chips by Lorenz",
					ThumbnailURL = "images/products/ramune_soda_candy.png",
					StockNo = 456,
					OriginalPrice = 7.21m,
					DiscountedPrice = 6.80m,
					ManufacturedDate = new DateTime(2022, 4, 23),
					ExpiryDate = new DateTime(2025, 5, 17),
					CountryID = 2,
					CategoryID = 1
				},
				new Product
				{
					ProductID = 5,
					Name = "Dorayaki",
					Description = "Unique Red Bean Pancake",
					ThumbnailURL = "images/products/dorayaki.png",
					StockNo = 123,
					OriginalPrice = 12.21m,
					DiscountedPrice = 11.79m,
					ManufacturedDate = new DateTime(2023, 11, 3),
					ExpiryDate = new DateTime(2023, 12, 31),
					CountryID = 3,
					CategoryID = 1
				},
				new Product
				{
					ProductID = 6,
					Name = "Crunchips Paprika",
					Description = "Local favourite chips by Lorenz",
					ThumbnailURL = "https://m.media-amazon.com/images/I/71Lnoe-JAkL.__AC_SX300_SY300_QL70_ML2_.jpg",
					StockNo = 278,
					OriginalPrice = 10.21m,
					DiscountedPrice = 7.79m,
					ManufacturedDate = new DateTime(2023, 11, 3),
					ExpiryDate = new DateTime(2024, 2, 27),
					CountryID = 1,
					CategoryID = 1
				}
			);
        }
    }
}
