using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class prod2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 18, 0, 56, 290, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 18, 0, 56, 290, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 18, 0, 56, 290, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 18, 0, 56, 461, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 18, 0, 56, 461, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 18, 0, 56, 461, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 18, 0, 56, 173, DateTimeKind.Local).AddTicks(1814), "AQAAAAIAAYagAAAAEInRzsMD7EoRcRj+BLtlWnKPVhA+5qTqAdvSrYCKfz/sguZAtJiGIHxsyPTeIUWPkA==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 18, 0, 56, 228, DateTimeKind.Local).AddTicks(618), "AQAAAAIAAYagAAAAEC4ZCwVIkgscc4oCZoff/IjUIErd9ocdCZ3Q7zJIpU/bpqjDko9gsd1wDOu/WG1uNQ==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 3,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 18, 0, 56, 290, DateTimeKind.Local).AddTicks(7415), "AQAAAAIAAYagAAAAEDEFtJWgpL2DssY2IlIFLoA4M6vvt5g2I8WyWP0JLyBUXNXI6zjTv2Gt+vCCtiYWiA==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 18, 0, 56, 461, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 18, 0, 56, 461, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "StockNo",
                value: 178);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "StockNo",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "StockNo",
                value: 5000);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "StockNo",
                value: 103);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "StockNo",
                value: 101);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "StockNo",
                value: 303);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "StockNo",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15,
                column: "StockNo",
                value: 255);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16,
                column: "StockNo",
                value: 278);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJhlS5RxhQt7UYMVeUQckpb/NE4fDcfgqny4ijPoA2WxWLoVjlzVNpN/E+eSuWyjoA==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKqUul/zYX19q8aYS9Yuw1p55SfaU4MSngXmH/BjYjobjspIBFURxG9YxbCF4J6IAw==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECf51IW5H3qj558ufhz3OCONfeef4zQaZilGLNyzSCez2T7p14BbBVsSpcDp9GtoDQ==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 2, 4, 18, 0, 56, 461, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 4, 18, 0, 56, 461, DateTimeKind.Local).AddTicks(7512));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 44, 54, 892, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 44, 54, 892, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 44, 54, 892, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 44, 55, 87, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 44, 55, 87, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 44, 55, 87, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 44, 54, 777, DateTimeKind.Local).AddTicks(1236), "AQAAAAIAAYagAAAAECNKmZ+WcUa5KuB+VOl2JErZEg4hv+99Ko8fRrSnEEe5R4DzYxlbxqnfd/kLX+5wlA==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 44, 54, 833, DateTimeKind.Local).AddTicks(7390), "AQAAAAIAAYagAAAAELrl07Z2XkZeMrztk0ipQlflT5MAQ9Uxvja9FCysG8n9bEyIsKXbplZqCk6K2Xz9JQ==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 3,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 44, 54, 892, DateTimeKind.Local).AddTicks(2058), "AQAAAAIAAYagAAAAEGGolBdONmvf2HXZkgzHztZwZ5SJPgRADcNCneG7glLdRXe9/bdi+5+syxKaj5AzWg==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 17, 44, 55, 87, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 17, 44, 55, 87, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "StockNo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "StockNo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "StockNo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "StockNo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "StockNo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "StockNo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "StockNo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15,
                column: "StockNo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16,
                column: "StockNo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELpx3jbhRwvjxCHt/+6JCWZ+rwCpE5eom0ANMZMOWw4gW1lV0erZ0Qvxq4TL7zpyfQ==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO6jlTZHRvX3FJyDEj7NDeEm79GaUUQZmyRcoPrxe9eTAO8pY9Z2x6/etvkwrbrGxw==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB9Ffj+eBaE2sljNXZhQKixGdpmLU9FfTX2VIgEHLFf4rwTMYYE9sUrIP71eLEW62g==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 2, 4, 17, 44, 55, 87, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 4, 17, 44, 55, 87, DateTimeKind.Local).AddTicks(3872));
        }
    }
}
