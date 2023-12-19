using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class RevertAddedDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "BadgeColour", "DateTimeCreated", "Description", "Name", "ProductID" },
                values: new object[,]
                {
                    { 1, "Yellow", new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bring the well-known festivities and nightlife of Germany to your own home!", "Germany", null },
                    { 2, "Red", new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "The land of the rising sun, experience the iconic cultures and long-standing traditions of Japan! ", "Japan", null }
                });

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

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CustomerID", "DateTimeCheckout", "DeliveryStatus", "OrderItemID", "StaffID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2921), true, null, 1 },
                    { 2, 2, new DateTime(2023, 12, 19, 12, 11, 19, 203, DateTimeKind.Local).AddTicks(2923), false, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "OrderItemID", "OrderID", "ProductID", "Qty" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 2, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "CountryID", "Description", "DiscountedPrice", "ExpiryDate", "ManufacturedDate", "Name", "OrderItemID", "OriginalPrice", "StockNo", "ThumbnailURL" },
                values: new object[,]
                {
                    { 1, 2, 1, "A unique red bean pancake only found in Japan", 12.29m, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dorayaki", null, 17.89m, 501, "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Dorayaki_001.jpg/450px-Dorayaki_001.jpg" },
                    { 2, 2, 2, "Local favourite chips by Lorenz", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunchips Paprika", null, 10.21m, 278, "https://m.media-amazon.com/images/I/71Lnoe-JAkL.__AC_SX300_SY300_QL70_ML2_.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffID", "ContactNumber", "DateOfBirth", "Email", "FirstName", "LastName", "OrderID", "PasswordHash", "SubscriptionPlanID" },
                values: new object[,]
                {
                    { 1, "81004821", new DateTime(2005, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shan2209@gmail.com", "Shan", "Lim", null, "", null },
                    { 2, "91028765", new DateTime(2005, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AtuTriyoso@gmail.com", "Atu", "Triyoso", null, "", null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "OrderItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "OrderItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 3, 30, 755, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 3, 30, 755, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 3, 30, 755, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 3, 30, 755, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 12, 3, 30, 755, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 19, 12, 3, 30, 755, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 10, 19, 12, 3, 30, 755, DateTimeKind.Local).AddTicks(7912));
        }
    }
}
