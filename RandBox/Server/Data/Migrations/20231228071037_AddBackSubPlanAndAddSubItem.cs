using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBackSubPlanAndAddSubItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubscriptionPlan",
                columns: table => new
                {
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscribedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionCategoryID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlan", x => x.SubscriptionPlanID);
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustID");
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID");
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_SubscriptionCategory_SubscriptionCategoryID",
                        column: x => x.SubscriptionCategoryID,
                        principalTable: "SubscriptionCategory",
                        principalColumn: "SubscriptionCategoryID");
                });

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

            migrationBuilder.InsertData(
                table: "SubscriptionPlan",
                columns: new[] { "SubscriptionPlanID", "CustomerID", "StaffID", "SubscribedDateTime", "SubscriptionCategoryID" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2023, 12, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(1747), 12 },
                    { 2, 2, null, new DateTime(2023, 10, 28, 15, 10, 37, 796, DateTimeKind.Local).AddTicks(1749), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_ProductID",
                table: "SubscriptionItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_SubscriptionPlanID",
                table: "SubscriptionItem",
                column: "SubscriptionPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_CustomerID",
                table: "SubscriptionPlan",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_StaffID",
                table: "SubscriptionPlan",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_SubscriptionCategoryID",
                table: "SubscriptionPlan",
                column: "SubscriptionCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubscriptionItem");

            migrationBuilder.DropTable(
                name: "SubscriptionPlan");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 96, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 96, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 96, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 96, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 96, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 96, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 95, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 95, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 96, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 28, 15, 6, 33, 96, DateTimeKind.Local).AddTicks(695));
        }
    }
}
