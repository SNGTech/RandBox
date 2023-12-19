using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Order_OrderId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderItem_OrderItemId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_OrderItem_OrderItemId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Order_OrderId",
                table: "Staff");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Staff",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_OrderId",
                table: "Staff",
                newName: "IX_Staff_OrderID");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "Product",
                newName: "OrderItemID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_OrderItemId",
                table: "Product",
                newName: "IX_Product_OrderItemID");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "OrderItem",
                newName: "OrderItemID");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "Order",
                newName: "OrderItemID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Order",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_OrderItemId",
                table: "Order",
                newName: "IX_Order_OrderItemID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Customer",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_OrderId",
                table: "Customer",
                newName: "IX_Customer_OrderID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Order_OrderID",
                table: "Customer",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderItem_OrderItemID",
                table: "Order",
                column: "OrderItemID",
                principalTable: "OrderItem",
                principalColumn: "OrderItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_OrderItem_OrderItemID",
                table: "Product",
                column: "OrderItemID",
                principalTable: "OrderItem",
                principalColumn: "OrderItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Order_OrderID",
                table: "Staff",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Order_OrderID",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderItem_OrderItemID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_OrderItem_OrderItemID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Order_OrderID",
                table: "Staff");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Staff",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_OrderID",
                table: "Staff",
                newName: "IX_Staff_OrderId");

            migrationBuilder.RenameColumn(
                name: "OrderItemID",
                table: "Product",
                newName: "OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_OrderItemID",
                table: "Product",
                newName: "IX_Product_OrderItemId");

            migrationBuilder.RenameColumn(
                name: "OrderItemID",
                table: "OrderItem",
                newName: "OrderItemId");

            migrationBuilder.RenameColumn(
                name: "OrderItemID",
                table: "Order",
                newName: "OrderItemId");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Order",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_OrderItemID",
                table: "Order",
                newName: "IX_Order_OrderItemId");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Customer",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_OrderID",
                table: "Customer",
                newName: "IX_Customer_OrderId");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 10, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Order_OrderId",
                table: "Customer",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderItem_OrderItemId",
                table: "Order",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_OrderItem_OrderItemId",
                table: "Product",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Order_OrderId",
                table: "Staff",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId");
        }
    }
}
