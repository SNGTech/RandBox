using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class orderitemservice1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 24, 10, 262, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 24, 10, 262, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 24, 10, 262, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 24, 10, 379, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 24, 10, 379, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 21, 16, 24, 10, 379, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 21, 16, 24, 10, 200, DateTimeKind.Local).AddTicks(8221), "AQAAAAIAAYagAAAAEMxybmv/LVF0KWkFsMLK/wa/rbZzAzn1pQyqAne0MtoehwUCunxbtFnr0vJZd4o+3A==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 21, 16, 24, 10, 262, DateTimeKind.Local).AddTicks(2330), "AQAAAAIAAYagAAAAELMOUgtP64rLpGe4MeoSRO6M2BKS6R0eKNB8cCCcS1UpiulubiwhsQKIQHGY6WV2Fg==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 21, 16, 24, 10, 379, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 21, 16, 24, 10, 379, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP+pjnhY9IkptjQBbW1rWXYdsYfLJB1xXyzAkVkwe5q+0qRXojL5tEYBu64k8rC2SQ==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN2mCPFbNLILY9p3DyxhThrzNxZxV0D052385oQH1knPMqjH6GszUuDxR0qcNPm1GA==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 21, 16, 24, 10, 379, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 21, 16, 24, 10, 379, DateTimeKind.Local).AddTicks(8702));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
