using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class refresh2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BadgeColour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
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
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustID);
                });

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
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionCategory", x => x.SubscriptionCategoryID);
                    table.ForeignKey(
                        name: "FK_SubscriptionCategory_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockNo = table.Column<int>(type: "int", nullable: true),
                    OriginalPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ManufacturedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_Product_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeCheckout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryStatus = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustID");
                    table.ForeignKey(
                        name: "FK_Order_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPlan",
                columns: table => new
                {
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscribedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionCategoryID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlan", x => x.SubscriptionPlanID);
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustID");
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID");
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_SubscriptionCategory_SubscriptionCategoryID",
                        column: x => x.SubscriptionCategoryID,
                        principalTable: "SubscriptionCategory",
                        principalColumn: "SubscriptionCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionItem",
                columns: table => new
                {
                    SubscriptionItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    MonthOfYear = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionPlanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionItem", x => x.SubscriptionItemID);
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_SubscriptionPlan_SubscriptionPlanID",
                        column: x => x.SubscriptionPlanID,
                        principalTable: "SubscriptionPlan",
                        principalColumn: "SubscriptionPlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "645bb191-486c-4a9e-8f38-2a48b60b8df6", null, "Customer", "CUSTOMER" },
                    { "71741074-bd54-43f9-b837-c0c34c71905e", null, "Staff-Guest", "STAFF-GUEST" },
                    { "910da4f5-6826-419b-b66a-eb995b68bd15", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "BadgeColour", "DateTimeCreated", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "#78A54E", new DateTime(2024, 1, 22, 14, 55, 53, 561, DateTimeKind.Local).AddTicks(4568), "Experience local snacks and treats, all while helping to support local family owned businesses!", "Snacks" },
                    { 2, "#D48250", new DateTime(2024, 1, 22, 14, 55, 53, 561, DateTimeKind.Local).AddTicks(4571), "Dress up as people from all over the globe! From Kimonos to Hanboks, get a fresh look every month!", "Clothing" },
                    { 3, "#D45A50", new DateTime(2024, 1, 22, 14, 55, 53, 561, DateTimeKind.Local).AddTicks(4572), "Unleash your artistic creativity with arts and crafts from all over the world!", "Arts and Crafts" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "BadgeColour", "DateTimeCreated", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "#78A54E", new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7028), "Bring the well-known festivities and nightlife of Germany to your own home!", "Germany" },
                    { 2, "#D45A50", new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7035), "The land of the rising sun, experience the iconic cultures and long-standing traditions of Japan! ", "Japan" },
                    { 3, "#D48250", new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7114), "With many diverse ethnic groups, experience the traditional tastes and cultures of the worlds largest island country.", "Indonesia" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustID", "Address", "DateOfBirth", "DateTimeCreated", "Email", "FirstName", "LastName", "PasswordHash", "PostalCode", "UnitNo" },
                values: new object[,]
                {
                    { 1, "Lane Road 2", new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 14, 55, 53, 504, DateTimeKind.Local).AddTicks(7564), "cout.sngtech@gmail.com", "Titus", "Lim", "AQAAAAIAAYagAAAAEFidAIQje/bMOH3preHS4nmzxWx+BV+DaVHPXmI26KSrxWe9BFA099SnM24W0WtGIw==", "342352", "04-06" },
                    { 2, "Hoppa Avenue 8", new DateTime(2005, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 14, 55, 53, 561, DateTimeKind.Local).AddTicks(3422), "patrick_wu@gmail.com", "Patrick", "Wu", "AQAAAAIAAYagAAAAEObFig4GYlYoCv0R/DCEZU/5+UajJdJZRKHEXuH68gd7qeqUF3MK+bWNXaVpcoxCPA==", "442532", "23-45" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffID", "ContactNumber", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { 1, "81004821", new DateTime(2005, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shan2209@gmail.com", "Shan", "Lim", "AQAAAAIAAYagAAAAEPBTZypMMlY0Ge0iAypfaqfeWQEcL+eeswA2h9VtHH+O2SHdMrnrxIjHBloQksXcAQ==" },
                    { 2, "91028765", new DateTime(2005, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AtuTriyoso@gmail.com", "Atu", "Triyoso", "AQAAAAIAAYagAAAAEB/mgil3P/bvOBIIG9JI69Qw4JH+PtI5PS4wsYvWbxBwBWuq6y4Uo086odaCRoqT9g==" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CustomerID", "DateTimeCheckout", "DeliveryStatus", "StaffID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(5145), true, 1 },
                    { 2, 2, new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(5179), false, 2 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "CountryID", "Description", "DiscountedPrice", "ExpiryDate", "ManufacturedDate", "Name", "OriginalPrice", "StockNo", "ThumbnailURL" },
                values: new object[,]
                {
                    { 1, 1, 3, "Traditional Steamed Cupcake", 12.29m, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kue Mangkok", 17.89m, 501, "images/products/kue_mangkok.png" },
                    { 2, 1, 1, "Traditional Onion Cake", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zwiebelkuchen", 10.21m, 278, "images/products/zwiebelkuchen.png" },
                    { 3, 1, 2, "Special Chocolate Bar", 5.89m, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby-cocoa KitKat", 5.89m, 1001, "images/products/ruby_cocoa_kitkat.png" },
                    { 4, 1, 2, "Local favourite chips by Lorenz", 6.80m, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramune Soda Candy", 7.21m, 456, "images/products/ramune_soda_candy.png" },
                    { 5, 1, 2, "Unique Red Bean Pancake", 11.79m, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dorayaki", 12.21m, 123, "images/products/dorayaki.png" },
                    { 6, 1, 1, "Local favourite chips by Lorenz", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunchips Paprika", 10.21m, 278, "https://m.media-amazon.com/images/I/71Lnoe-JAkL.__AC_SX300_SY300_QL70_ML2_.jpg" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionCategory",
                columns: new[] { "SubscriptionCategoryID", "BaseMonthlyPrice", "CategoryID", "Description", "Duration", "NewMonthlyPrice" },
                values: new object[,]
                {
                    { 1, 45.50m, 1, "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.", 1, 45.50m },
                    { 2, 45.50m, 2, "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.", 1, 46.50m },
                    { 3, 45.50m, 3, "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.", 1, 46.90m },
                    { 4, 44.00m, 1, "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.", 3, 44.00m },
                    { 5, 45.00m, 2, "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.", 3, 45.00m },
                    { 6, 46.40m, 3, "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.", 3, 46.40m },
                    { 7, 43.50m, 1, "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.", 6, 43.50m },
                    { 8, 44.50m, 2, "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.", 6, 44.50m },
                    { 9, 44.90m, 3, "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.", 6, 44.90m },
                    { 10, 41.35m, 1, "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.", 12, 41.35m },
                    { 11, 42.35m, 2, "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.", 12, 42.35m },
                    { 12, 42.75m, 3, "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.", 12, 42.75m }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "OrderItemID", "OrderID", "ProductID", "Qty" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 2, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPlan",
                columns: new[] { "SubscriptionPlanID", "CustomerID", "StaffID", "SubscribedDateTime", "SubscriptionCategoryID" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2024, 1, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7908), 12 },
                    { 2, 2, null, new DateTime(2023, 11, 22, 14, 55, 53, 683, DateTimeKind.Local).AddTicks(7917), 5 }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionItem",
                columns: new[] { "SubscriptionItemID", "MonthOfYear", "ProductID", "Qty", "SubscriptionPlanID" },
                values: new object[,]
                {
                    { 1, 12, 4, 1, 1 },
                    { 2, 12, 2, 1, 1 },
                    { 3, 11, 3, 1, 2 },
                    { 4, 1, 2, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StaffID",
                table: "Order",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

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
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CountryID",
                table: "Product",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionCategory_CategoryID",
                table: "SubscriptionCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_ProductID",
                table: "SubscriptionItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_SubscriptionPlanID",
                table: "SubscriptionItem",
                column: "SubscriptionPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_CustomerID",
                table: "SubscriptionPlan",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_StaffID",
                table: "SubscriptionPlan",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_SubscriptionCategoryID",
                table: "SubscriptionPlan",
                column: "SubscriptionCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "SubscriptionItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SubscriptionPlan");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "SubscriptionCategory");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
