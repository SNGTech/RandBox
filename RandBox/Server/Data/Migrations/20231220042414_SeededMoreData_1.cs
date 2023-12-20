using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededMoreData_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                columns: new[] { "BadgeColour", "DateTimeCreated" },
                values: new object[] { "#78A54E", new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                columns: new[] { "BadgeColour", "DateTimeCreated" },
                values: new object[] { "#D45A50", new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "BadgeColour", "DateTimeCreated", "Description", "Name", "ProductID" },
                values: new object[] { 3, "#D48250", new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(7285), "With many diverse ethnic groups, experience the traditional tastes and cultures of the worlds largest island country.", "Indonesia", null });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CountryID", "Description", "Name", "ThumbnailURL" },
                values: new object[] { 1, 3, "Traditional Steamed Cupcake", "Kue Mangkok", "images/products/kue_mangkok.png" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CountryID", "Description", "Name", "ThumbnailURL" },
                values: new object[] { 1, 1, "Traditional Onion Cake", "Zwiebelkuchen", "images/products/zwiebelkuchen.png" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "CountryID", "Description", "DiscountedPrice", "ExpiryDate", "ManufacturedDate", "Name", "OrderItemID", "OriginalPrice", "StockNo", "ThumbnailURL" },
                values: new object[,]
                {
                    { 3, 1, 2, "Special Chocolate Bar", 5.89m, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby-cocoa KitKat", null, 5.89m, 1001, "images/products/ruby_cocoa_kitkat.png" },
                    { 4, 1, 2, "Local favourite chips by Lorenz", 6.80m, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramune Soda Candy", null, 7.21m, 456, "images/products/ramune_soda_candy.png" },
                    { 5, 1, 3, "Unique Red Bean Pancake", 11.79m, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dorayaki", null, 12.21m, 123, "images/products/dorayaki.png" },
                    { 6, 1, 1, "Local favourite chips by Lorenz", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunchips Paprika", null, 10.21m, 278, "https://m.media-amazon.com/images/I/71Lnoe-JAkL.__AC_SX300_SY300_QL70_ML2_.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 10, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4374));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                columns: new[] { "BadgeColour", "DateTimeCreated" },
                values: new object[] { "Yellow", new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                columns: new[] { "BadgeColour", "DateTimeCreated" },
                values: new object[] { "Red", new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CountryID", "Description", "Name", "ThumbnailURL" },
                values: new object[] { 2, 1, "A unique red bean pancake only found in Japan", "Dorayaki", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Dorayaki_001.jpg/450px-Dorayaki_001.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CountryID", "Description", "Name", "ThumbnailURL" },
                values: new object[] { 2, 2, "Local favourite chips by Lorenz", "Crunchips Paprika", "https://m.media-amazon.com/images/I/71Lnoe-JAkL.__AC_SX300_SY300_QL70_ML2_.jpg" });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 10, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2612));
        }
    }
}
