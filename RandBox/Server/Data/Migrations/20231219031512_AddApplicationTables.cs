using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Staff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Staff",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeCheckout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryStatus = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true),
                    OrderItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "OrderItemId");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockNo = table.Column<int>(type: "int", nullable: true),
                    OriginalPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ManufacturedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    OrderItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "OrderItemId");
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BadgeColour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Country_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "ProductID" },
                values: new object[] { new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3694), null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "ProductID" },
                values: new object[] { new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3696), null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "DateTimeCreated", "ProductID" },
                values: new object[] { new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3697), null });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "OrderId" },
                values: new object[] { new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3417), null });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "OrderId" },
                values: new object[] { new DateTime(2023, 12, 19, 11, 15, 12, 545, DateTimeKind.Local).AddTicks(3432), null });

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

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OrderId",
                table: "Staff",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrderId",
                table: "Customer",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ProductID",
                table: "Category",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ProductID",
                table: "Country",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderItemId",
                table: "Order",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderItemId",
                table: "Product",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Product_ProductID",
                table: "Category",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Order_OrderId",
                table: "Customer",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Order_OrderId",
                table: "Staff",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Product_ProductID",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Order_OrderId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Order_OrderId",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Staff_OrderId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Customer_OrderId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Category_ProductID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 10, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(9018));
        }
    }
}
