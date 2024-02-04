using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class newcuststaff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 16, 58, 35, 509, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 16, 58, 35, 509, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 16, 58, 35, 509, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 16, 58, 35, 690, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 16, 58, 35, 690, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 16, 58, 35, 690, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 58, 35, 398, DateTimeKind.Local).AddTicks(231), "AQAAAAIAAYagAAAAELhLtAkpcLRN2A+oVadICTMPH2BsCsemNchSBGq0jXHL3QrRwQXBn7vu9HUhDbki+Q==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 58, 35, 453, DateTimeKind.Local).AddTicks(6748), "AQAAAAIAAYagAAAAEAXUJsWAxEIQRilPDgyxccnvl3aD6lJssx0zLPJD2uQaLIlTumpJgmJKXaQ3U5IQuA==" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustID", "Address", "DateOfBirth", "DateTimeCreated", "Email", "FirstName", "LastName", "PasswordHash", "PostalCode", "UnitNo" },
                values: new object[] { 3, "Hoppa Avenue 8", new DateTime(2005, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 16, 58, 35, 509, DateTimeKind.Local).AddTicks(7039), "e@gmail.com", "Kelyn", "Neo", "AQAAAAIAAYagAAAAENkm3SD2NentfA5j2AiROJx9jpVpewGmE0S24uBjVnF5wa3Qvo6qbenQ8+5tCxy5+Q==", "442532", "23-45" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 16, 58, 35, 690, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 16, 58, 35, 690, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEI4BJyIwjcVTcBWApEnpWzI1bar3TWvbRNk3q5c48QvEuSJYfOn7TkZatC3fFLzkw==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBCTtdx1J+kjJVloGB4u19itDwmK4SprNcK3iH8Up/sZGzUyT6uXyRBM9UD+c+kLCA==");

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffID", "ContactNumber", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { 3, "81004812", new DateTime(2005, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "yahoo@randbox.sg", "Wei", "Hanh", "AQAAAAIAAYagAAAAEGpwSjlbJdPSfUVfz5crudtiI7jXBgXzzaRLQqOjepvYa2/lPP2+heoIuohzqf6LLg==" });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 2, 4, 16, 58, 35, 690, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 4, 16, 58, 35, 690, DateTimeKind.Local).AddTicks(8495));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 3);

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
    }
}
