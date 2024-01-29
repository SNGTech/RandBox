using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 2, 0, 24, 516, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 2, 0, 24, 516, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 2, 0, 24, 516, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 2, 0, 24, 650, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 2, 0, 24, 650, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 2, 0, 24, 650, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 30, 2, 0, 24, 454, DateTimeKind.Local).AddTicks(6283), "AQAAAAIAAYagAAAAEC1zwxdX85WZ9JDf7Z/X9XOWpoiZ0Cvi0K6nHfhkXUweP8yjUuEphiP5bGYSDyogIw==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 30, 2, 0, 24, 516, DateTimeKind.Local).AddTicks(5595), "AQAAAAIAAYagAAAAEL/uSmq1gur5FcMHpEeejPaWzu4FpI12f22/wM/IlbUTLtvJbhP5AiiIo1gTp0L9EQ==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 30, 2, 0, 24, 650, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 30, 2, 0, 24, 650, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFRb8tKVh6YnyZHJVMPMzlquoIowccwn+hI/S6N07FRDZM0Grcse/9M8GFo+0Ju+Tw==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEENkZcDe0el7l8sWfoaeQ/M/l6n0j2gllWsO8Wf4qGO7jZS0P3YSYc3MJP5vevI0EA==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 30, 2, 0, 24, 650, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 30, 2, 0, 24, 650, DateTimeKind.Local).AddTicks(3528));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
