﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixDeletedSubPlanEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubscriptionPlan",
                columns: table => new
                {
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersCustID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionCategoryID = table.Column<int>(type: "int", nullable: true),
                    CustID = table.Column<int>(type: "int", nullable: true),
                    SubscribedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlan", x => x.SubscriptionPlanID);
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_Customer_CustomersCustID",
                        column: x => x.CustomersCustID,
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
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: false),
                    MonthOfYear = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
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
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.InsertData(
                table: "SubscriptionPlan",
                columns: new[] { "SubscriptionPlanID", "CustID", "CustomersCustID", "StaffID", "SubscribedDateTime", "SubscriptionCategoryID" },
                values: new object[,]
                {
                    { 1, 1, null, null, new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(6965), 12 },
                    { 2, 2, null, null, new DateTime(2023, 10, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(6966), 5 }
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
        }
    }
}
