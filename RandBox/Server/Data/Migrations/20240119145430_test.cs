using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 629, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 629, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "SubscriptionItem",
                keyColumn: "SubscriptionItemID",
                keyValue: 3,
                column: "MonthOfYear",
                value: 11);

            migrationBuilder.UpdateData(
                table: "SubscriptionItem",
                keyColumn: "SubscriptionItemID",
                keyValue: 4,
                column: "MonthOfYear",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 19, 22, 54, 30, 630, DateTimeKind.Local).AddTicks(5507));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "SubscriptionItem",
                keyColumn: "SubscriptionItemID",
                keyValue: 3,
                column: "MonthOfYear",
                value: 10);

            migrationBuilder.UpdateData(
                table: "SubscriptionItem",
                keyColumn: "SubscriptionItemID",
                keyValue: 4,
                column: "MonthOfYear",
                value: 11);

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
    }
}
