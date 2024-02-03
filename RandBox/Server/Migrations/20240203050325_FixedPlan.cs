using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixedPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "OrderItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 15, 14, 18, 91, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 15, 14, 18, 91, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 15, 14, 18, 91, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 15, 14, 18, 262, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 15, 14, 18, 262, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 1, 30, 15, 14, 18, 262, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 14, 18, 5, DateTimeKind.Local).AddTicks(6729), "AQAAAAIAAYagAAAAEOiEeaPa+O5adbqybGsCC+yGVZenatTUhhfJsfUMWbjw3/qnTENSoL1suPtinIKibw==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 14, 18, 90, DateTimeKind.Local).AddTicks(9179), "AQAAAAIAAYagAAAAEOyg74psV7JZzORYD/w7XL3fBauKOGDBpTWL3EW/l0g3qR/MMMxoahPiBClN9UJ+Ng==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 30, 15, 14, 18, 261, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 1, 30, 15, 14, 18, 261, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMsA/F1hclGhKulEqq4u3YzEYUrVrj6IOohgOcmq5VFr9kQ1SmghC7BxEAqu3EKmcw==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEI5H2bEmtpTyip6DshDQLVvmc+Wf1YQRK2uAwanRe4E1PlEEbBTjXaTqTEzVW4bfVA==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 1, 30, 15, 14, 18, 262, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 11, 30, 15, 14, 18, 262, DateTimeKind.Local).AddTicks(956));
        }
    }
}
