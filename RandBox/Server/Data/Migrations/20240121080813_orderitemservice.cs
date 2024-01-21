using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class orderitemservice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 8, 13, 75, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 8, 13, 75, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 8, 13, 75, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 8, 13, 196, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 8, 13, 196, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 8, 13, 196, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 21, 16, 8, 12, 996, DateTimeKind.Local).AddTicks(5115), "AQAAAAIAAYagAAAAEKeNxhFjGZIgo9HEKf9s7A/Xm2cK4I/7McBKTU0gDzMGNOmQgdQE1kfobPYI9pzRAg==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 21, 16, 8, 13, 74, DateTimeKind.Local).AddTicks(9487), "AQAAAAIAAYagAAAAEF21vu/ScoIWYtPMPMaszVP1aW5iQrJWgvgtlLFUYAPlFA1Kmjr29jPqJ5jySowtVg==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 21, 16, 8, 13, 196, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 21, 16, 8, 13, 196, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEG+riMCw74hfpCix4hwCS02paWf4OqJwNh3fRR3PmPFwedffVG4mj1rCxdg1SI/VIw==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBUmyKnbXlaBUt98kTrVYqi7QJf3JABRbiiTp8sDaUlaXNjlc7NV84iVX6cX4MvM9w==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 21, 16, 8, 13, 196, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 21, 16, 8, 13, 196, DateTimeKind.Local).AddTicks(6971));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(2289), "" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(2302), "" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 20, 16, 23, 44, 466, DateTimeKind.Local).AddTicks(3688));
        }
    }
}
