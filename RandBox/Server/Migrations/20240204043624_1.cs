using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturedDate",
                table: "Product",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                table: "Product",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturedDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 3, 13, 3, 24, 878, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 3, 13, 3, 24, 878, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 3, 13, 3, 24, 878, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 3, 13, 3, 24, 964, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 3, 13, 3, 24, 964, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 3, 13, 3, 24, 964, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 3, 13, 3, 24, 834, DateTimeKind.Local).AddTicks(8539), "AQAAAAIAAYagAAAAEID7Q/1SnG6Rt1yYrZP13RPmr32gGKnlPMYKOAVpfoMEYv11xju7C8ww7J/JxAxwag==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 3, 13, 3, 24, 878, DateTimeKind.Local).AddTicks(7522), "AQAAAAIAAYagAAAAEB7z/noJAczqYv3zJE10y1HeZN/PQAQkOn1zO0KbJuSXAzmF1+X7rgKCg9H/d06Yug==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 3, 13, 3, 24, 964, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 3, 13, 3, 24, 964, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN33HpDd4T7ZJkX3Hy6LghWeA9/3JfLKIOvUkgNDGPvNFqZjSAg0p3wq678iQmxAYw==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEr1TEmyJGOFRDQxNSRVDLmBZAwnbMs+BbXQ/kHcj9KOqjzf2pyoSqvM1zC5Y4VMsg==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 2, 3, 13, 3, 24, 964, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 3, 13, 3, 24, 964, DateTimeKind.Local).AddTicks(9550));
        }
    }
}
