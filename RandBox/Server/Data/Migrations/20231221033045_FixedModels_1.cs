using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedModels_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Product_ProductID",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_SubscriptionCategory_SubscriptionCategoryID",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Product_ProductID",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Order_OrderID",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_SubscriptionPlan_SubscriptionPlanID",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_SubscriptionPlan_SubscriptionPlanID",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionCategory_SubscriptionPlan_SubscriptionPlanID",
                table: "SubscriptionCategory");

            migrationBuilder.DropIndex(
                name: "IX_SubscriptionCategory_SubscriptionPlanID",
                table: "SubscriptionCategory");

            migrationBuilder.DropIndex(
                name: "IX_Staff_OrderID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_SubscriptionPlanID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Product_OrderItemID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Order_OrderItemID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Customer_OrderID",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_SubscriptionPlanID",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Country_ProductID",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Category_ProductID",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_SubscriptionCategoryID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "SubscriptionPlanID",
                table: "SubscriptionCategory");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "SubscriptionPlanID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "OrderItemID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "OrderItemID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SubscriptionPlanID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "SubscriptionCategoryID",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "CustomersCustID",
                table: "SubscriptionPlan",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubscriptionItem",
                columns: table => new
                {
                    SubscriptionItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    MonthOfYear = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionItem", x => x.SubscriptionItemID);
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_SubscriptionPlan_SubscriptionPlanID",
                        column: x => x.SubscriptionPlanID,
                        principalTable: "SubscriptionPlan",
                        principalColumn: "SubscriptionPlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 915, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 915, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 915, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 916, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 916, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 916, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 915, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 915, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 916, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 916, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                columns: new[] { "CustomersCustID", "SubscribedDateTime" },
                values: new object[] { null, new DateTime(2023, 12, 21, 11, 30, 44, 915, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                columns: new[] { "CustomersCustID", "SubscribedDateTime" },
                values: new object[] { null, new DateTime(2023, 10, 21, 11, 30, 44, 915, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_CustomersCustID",
                table: "SubscriptionPlan",
                column: "CustomersCustID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_StaffID",
                table: "SubscriptionPlan",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_SubscriptionCategoryID",
                table: "SubscriptionPlan",
                column: "SubscriptionCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionCategory_CategoryID",
                table: "SubscriptionCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CountryID",
                table: "Product",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StaffID",
                table: "Order",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_ProductID",
                table: "SubscriptionItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_SubscriptionPlanID",
                table: "SubscriptionItem",
                column: "SubscriptionPlanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerID",
                table: "Order",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Staff_StaffID",
                table: "Order",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "StaffID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Country_CountryID",
                table: "Product",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionCategory_Category_CategoryID",
                table: "SubscriptionCategory",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlan_Customer_CustomersCustID",
                table: "SubscriptionPlan",
                column: "CustomersCustID",
                principalTable: "Customer",
                principalColumn: "CustID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlan_Staff_StaffID",
                table: "SubscriptionPlan",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "StaffID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlan_SubscriptionCategory_SubscriptionCategoryID",
                table: "SubscriptionPlan",
                column: "SubscriptionCategoryID",
                principalTable: "SubscriptionCategory",
                principalColumn: "SubscriptionCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Staff_StaffID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Product_ProductID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Country_CountryID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionCategory_Category_CategoryID",
                table: "SubscriptionCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlan_Customer_CustomersCustID",
                table: "SubscriptionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlan_Staff_StaffID",
                table: "SubscriptionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlan_SubscriptionCategory_SubscriptionCategoryID",
                table: "SubscriptionPlan");

            migrationBuilder.DropTable(
                name: "SubscriptionItem");

            migrationBuilder.DropIndex(
                name: "IX_SubscriptionPlan_CustomersCustID",
                table: "SubscriptionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SubscriptionPlan_StaffID",
                table: "SubscriptionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SubscriptionPlan_SubscriptionCategoryID",
                table: "SubscriptionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SubscriptionCategory_CategoryID",
                table: "SubscriptionCategory");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CountryID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_StaffID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomersCustID",
                table: "SubscriptionPlan");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPlanID",
                table: "SubscriptionCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Staff",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPlanID",
                table: "Staff",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemID",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemID",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPlanID",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Country",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionCategoryID",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "ProductID", "SubscriptionCategoryID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4076), null, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "ProductID", "SubscriptionCategoryID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4078), null, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "DateTimeCreated", "ProductID", "SubscriptionCategoryID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4080), null, null });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "ProductID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(7273), null });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "ProductID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(7283), null });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                columns: new[] { "DateTimeCreated", "ProductID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(7285), null });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "OrderID", "SubscriptionPlanID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(3841), null, null });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "OrderID", "SubscriptionPlanID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(3850), null, null });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "DateTimeCheckout", "OrderItemID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4651), null });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "DateTimeCheckout", "OrderItemID" },
                values: new object[] { new DateTime(2023, 12, 20, 12, 24, 14, 422, DateTimeKind.Local).AddTicks(4653), null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "OrderItemID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "OrderItemID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "OrderItemID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "OrderItemID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "OrderItemID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "OrderItemID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                columns: new[] { "OrderID", "SubscriptionPlanID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                columns: new[] { "OrderID", "SubscriptionPlanID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 1,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 2,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 3,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 4,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 5,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 6,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 7,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 8,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 9,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 10,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 11,
                column: "SubscriptionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionCategory",
                keyColumn: "SubscriptionCategoryID",
                keyValue: 12,
                column: "SubscriptionPlanID",
                value: null);

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

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionCategory_SubscriptionPlanID",
                table: "SubscriptionCategory",
                column: "SubscriptionPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OrderID",
                table: "Staff",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_SubscriptionPlanID",
                table: "Staff",
                column: "SubscriptionPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderItemID",
                table: "Product",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderItemID",
                table: "Order",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrderID",
                table: "Customer",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_SubscriptionPlanID",
                table: "Customer",
                column: "SubscriptionPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ProductID",
                table: "Country",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ProductID",
                table: "Category",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_SubscriptionCategoryID",
                table: "Category",
                column: "SubscriptionCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Product_ProductID",
                table: "Category",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_SubscriptionCategory_SubscriptionCategoryID",
                table: "Category",
                column: "SubscriptionCategoryID",
                principalTable: "SubscriptionCategory",
                principalColumn: "SubscriptionCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Product_ProductID",
                table: "Country",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Order_OrderID",
                table: "Customer",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_SubscriptionPlan_SubscriptionPlanID",
                table: "Customer",
                column: "SubscriptionPlanID",
                principalTable: "SubscriptionPlan",
                principalColumn: "SubscriptionPlanID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_SubscriptionPlan_SubscriptionPlanID",
                table: "Staff",
                column: "SubscriptionPlanID",
                principalTable: "SubscriptionPlan",
                principalColumn: "SubscriptionPlanID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionCategory_SubscriptionPlan_SubscriptionPlanID",
                table: "SubscriptionCategory",
                column: "SubscriptionPlanID",
                principalTable: "SubscriptionPlan",
                principalColumn: "SubscriptionPlanID");
        }
    }
}
