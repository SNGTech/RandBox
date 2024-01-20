using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class cascadedeleteorderitem3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Product_ProductID",
                table: "OrderItem");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 20, 16, 16, 4, 132, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Product_ProductID",
                table: "OrderItem",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Product_ProductID",
                table: "OrderItem");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 630, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 630, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 630, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 631, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 631, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 631, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 630, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 630, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 630, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 630, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 20, 16, 10, 8, 631, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 20, 16, 10, 8, 631, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Product_ProductID",
                table: "OrderItem",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
