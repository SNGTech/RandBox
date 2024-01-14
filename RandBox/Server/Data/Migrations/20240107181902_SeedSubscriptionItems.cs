using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedSubscriptionItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 767, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 767, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 767, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 768, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 768, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 768, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 767, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 767, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 768, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 768, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.InsertData(
                table: "SubscriptionItem",
                columns: new[] { "SubscriptionItemID", "MonthOfYear", "ProductID", "Qty", "SubscriptionPlanID" },
                values: new object[,]
                {
                    { 1, 12, 4, 1, 1 },
                    { 2, 12, 2, 1, 1 },
                    { 3, 10, 3, 1, 2 },
                    { 4, 11, 2, 1, 2 }
                });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 8, 2, 19, 2, 768, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 8, 2, 19, 2, 768, DateTimeKind.Local).AddTicks(912));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubscriptionItem",
                keyColumn: "SubscriptionItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubscriptionItem",
                keyColumn: "SubscriptionItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubscriptionItem",
                keyColumn: "SubscriptionItemID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubscriptionItem",
                keyColumn: "SubscriptionItemID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 10, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(1749));
        }
    }
}
