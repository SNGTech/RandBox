using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class reset1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 56, 38, 660, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 56, 38, 660, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 56, 38, 660, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 56, 38, 800, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 56, 38, 800, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 56, 38, 800, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 56, 38, 597, DateTimeKind.Local).AddTicks(5100), "AQAAAAIAAYagAAAAEEePhSMTahwJqwivIjJpUi1bmwP8lTpEhY8FdhOGiYZdT5CHwugF8yO1b99UOp5dIA==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 56, 38, 660, DateTimeKind.Local).AddTicks(3521), "AQAAAAIAAYagAAAAELSDyR5N/OWS+TGX8/oBOyAhWKg9SJTE77euTf54lGFZfXmcJasFXQpO9hN29r7Mog==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 12, 56, 38, 800, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 12, 56, 38, 800, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKuvBmp1d8Utzy8+8/wE0/7YKl+FB9ylxZE3QEm41xM9clqffRrSxo5BvGl5xoqciA==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIp5KtTQUOGhmLolz3ZRJCrba6h5MIv4t9NpKXe0qmz+PPMyOWzRczvarKby5fEDbg==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 2, 4, 12, 56, 38, 800, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 4, 12, 56, 38, 800, DateTimeKind.Local).AddTicks(2151));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 36, 24, 77, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 36, 24, 77, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 36, 24, 77, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 36, 24, 190, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 36, 24, 190, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 12, 36, 24, 190, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 36, 24, 21, DateTimeKind.Local).AddTicks(7582), "AQAAAAIAAYagAAAAENtmFhOg0oyzLdflk/8FW+F+jYZ599bVj2qd9SjrnpfcRXzXf9c0mpzur9hVJoTlfw==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 12, 36, 24, 77, DateTimeKind.Local).AddTicks(5433), "AQAAAAIAAYagAAAAEEHTIGcwZ47CfymN53XPflO5jgB7igmjfmmZOY6h4qZueHi4zIegNCUjnKuMBsFv+w==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 12, 36, 24, 190, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 12, 36, 24, 190, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENcePSRnFSktxQnZqdEtTOds3ZL8CnI7uA/3zElxU32T0Tl844v917lJ7Cr0Whqd9Q==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDgG9JshE4np+ETOt86ys3/bpDD563OZNzYmr8jxSYxKqsFn3tIRWO7DZrqLRY/wAA==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 2, 4, 12, 36, 24, 190, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 4, 12, 36, 24, 190, DateTimeKind.Local).AddTicks(1707));
        }
    }
}
