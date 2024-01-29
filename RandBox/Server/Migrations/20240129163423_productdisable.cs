using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class productdisable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDisabled",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 0, 34, 23, 278, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 0, 34, 23, 278, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 0, 34, 23, 278, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 0, 34, 23, 403, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 0, 34, 23, 403, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 0, 34, 23, 403, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 34, 23, 222, DateTimeKind.Local).AddTicks(6640), "AQAAAAIAAYagAAAAEOMQ5+SlUmq8Joo1TU+F6WnkSF5HFkIW9OSAtFWj4wWquYt2x0nsocWeW+pJVRAWmw==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 34, 23, 278, DateTimeKind.Local).AddTicks(7306), "AQAAAAIAAYagAAAAECcfA82FbpBUCsZfBikxmj3whGlPWO2p7CXjzhFUxjpVgJww9im+rfQ/qF+y6pwlTw==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 30, 0, 34, 23, 403, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 30, 0, 34, 23, 403, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "IsDisabled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "IsDisabled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "IsDisabled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "IsDisabled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "IsDisabled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "IsDisabled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEG9xL0sYx38jjvXBmV/eymbZS0Wtg/WeOiMEYGb+9KMpvTzeYxQtceGYYoR3+t7POQ==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJxPUS246wKK3KDk/SVfXb2ZNI4Cl5Bwyyox8sDj4CbgmoWHm2skQzJx3hKWQ74T/A==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 30, 0, 34, 23, 403, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 30, 0, 34, 23, 403, DateTimeKind.Local).AddTicks(4453));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisabled",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 22, 14, 55, 53, 561, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 22, 14, 55, 53, 561, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 22, 14, 55, 53, 561, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 22, 14, 55, 53, 504, DateTimeKind.Local).AddTicks(7564), "AQAAAAIAAYagAAAAEFidAIQje/bMOH3preHS4nmzxWx+BV+DaVHPXmI26KSrxWe9BFA099SnM24W0WtGIw==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 22, 14, 55, 53, 561, DateTimeKind.Local).AddTicks(3422), "AQAAAAIAAYagAAAAEObFig4GYlYoCv0R/DCEZU/5+UajJdJZRKHEXuH68gd7qeqUF3MK+bWNXaVpcoxCPA==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPBTZypMMlY0Ge0iAypfaqfeWQEcL+eeswA2h9VtHH+O2SHdMrnrxIjHBloQksXcAQ==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB/mgil3P/bvOBIIG9JI69Qw4JH+PtI5PS4wsYvWbxBwBWuq6y4Uo086odaCRoqT9g==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7917));
        }
    }
}
