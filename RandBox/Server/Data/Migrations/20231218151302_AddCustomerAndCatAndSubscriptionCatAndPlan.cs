using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RandBox.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerAndCatAndSubscriptionCatAndPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPlan",
                columns: table => new
                {
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscribedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionCategoryID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlan", x => x.SubscriptionPlanID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustID);
                    table.ForeignKey(
                        name: "FK_Customer_SubscriptionPlan_SubscriptionPlanID",
                        column: x => x.SubscriptionPlanID,
                        principalTable: "SubscriptionPlan",
                        principalColumn: "SubscriptionPlanID");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staff_SubscriptionPlan_SubscriptionPlanID",
                        column: x => x.SubscriptionPlanID,
                        principalTable: "SubscriptionPlan",
                        principalColumn: "SubscriptionPlanID");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionCategory",
                columns: table => new
                {
                    SubscriptionCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    BaseMonthlyPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    NewMonthlyPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionCategory", x => x.SubscriptionCategoryID);
                    table.ForeignKey(
                        name: "FK_SubscriptionCategory_SubscriptionPlan_SubscriptionPlanID",
                        column: x => x.SubscriptionPlanID,
                        principalTable: "SubscriptionPlan",
                        principalColumn: "SubscriptionPlanID");
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BadgeColour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriptionCategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_Category_SubscriptionCategory_SubscriptionCategoryID",
                        column: x => x.SubscriptionCategoryID,
                        principalTable: "SubscriptionCategory",
                        principalColumn: "SubscriptionCategoryID");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "BadgeColour", "DateTimeCreated", "Description", "Name", "SubscriptionCategoryID" },
                values: new object[,]
                {
                    { 1, "#78A54E", new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(7285), "Experience local snacks and treats, all while helping to support local family owned businesses!", "Snacks", null },
                    { 2, "#D48250", new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(7292), "Dress up as people from all over the globe! From Kimonos to Hanboks, get a fresh look every month!", "Clothing", null },
                    { 3, "#D45A50", new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(7296), "Unleash your artistic creativity with arts and crafts from all over the world!", "Arts and Crafts", null }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustID", "Address", "DateOfBirth", "DateTimeCreated", "Email", "FirstName", "LastName", "PasswordHash", "PostalCode", "SubscriptionPlanID", "UnitNo" },
                values: new object[,]
                {
                    { 1, "Lane Road 2", new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(5863), "cout.sngtech@gmail.com", "Titus", "Lim", "", "342352", null, "04-06" },
                    { 2, "Hoppa Avenue 8", new DateTime(2005, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(5900), "patrick_wu@gmail.com", "Patrick", "Wu", "", "442532", null, "23-45" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionCategory",
                columns: new[] { "SubscriptionCategoryID", "BaseMonthlyPrice", "CategoryID", "Description", "Duration", "NewMonthlyPrice", "SubscriptionPlanID" },
                values: new object[,]
                {
                    { 1, 45.50m, 1, "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.", 1, 45.50m, null },
                    { 2, 45.50m, 2, "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.", 1, 46.50m, null },
                    { 3, 45.50m, 3, "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.", 1, 46.90m, null },
                    { 4, 44.00m, 1, "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.", 3, 44.00m, null },
                    { 5, 45.00m, 2, "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.", 3, 45.00m, null },
                    { 6, 46.40m, 3, "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.", 3, 46.40m, null },
                    { 7, 43.50m, 1, "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.", 6, 43.50m, null },
                    { 8, 44.50m, 2, "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.", 6, 44.50m, null },
                    { 9, 44.90m, 3, "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.", 6, 44.90m, null },
                    { 10, 41.35m, 1, "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.", 12, 41.35m, null },
                    { 11, 42.35m, 2, "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.", 12, 42.35m, null },
                    { 12, 42.75m, 3, "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.", 12, 42.75m, null }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPlan",
                columns: new[] { "SubscriptionPlanID", "CustID", "StaffID", "SubscribedDateTime", "SubscriptionCategoryID" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(9004), 12 },
                    { 2, 2, null, new DateTime(2023, 10, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(9018), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_SubscriptionCategoryID",
                table: "Category",
                column: "SubscriptionCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_SubscriptionPlanID",
                table: "Customer",
                column: "SubscriptionPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_SubscriptionPlanID",
                table: "Staff",
                column: "SubscriptionPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionCategory_SubscriptionPlanID",
                table: "SubscriptionCategory",
                column: "SubscriptionPlanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "SubscriptionCategory");

            migrationBuilder.DropTable(
                name: "SubscriptionPlan");
        }
    }
}
