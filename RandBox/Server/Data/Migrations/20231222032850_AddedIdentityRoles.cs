using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedIdentityRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "645bb191-486c-4a9e-8f38-2a48b60b8df6", null, "Customer", "CUSTOMER" },
                    { "71741074-bd54-43f9-b837-c0c34c71905e", null, "Staff-Guest", "STAFF-GUEST" },
                    { "910da4f5-6826-419b-b66a-eb995b68bd15", null, "Staff", "STAFF" }
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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "CountryID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 10, 22, 11, 28, 50, 830, DateTimeKind.Local).AddTicks(6966));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "645bb191-486c-4a9e-8f38-2a48b60b8df6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71741074-bd54-43f9-b837-c0c34c71905e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "910da4f5-6826-419b-b66a-eb995b68bd15");

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
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "CountryID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 21, 11, 30, 44, 915, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 10, 21, 11, 30, 44, 915, DateTimeKind.Local).AddTicks(9895));
        }
    }
}
