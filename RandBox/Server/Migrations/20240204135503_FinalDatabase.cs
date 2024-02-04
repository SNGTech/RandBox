﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class FinalDatabase : Migration
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
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionCategory", x => x.SubscriptionCategoryID);
                    table.ForeignKey(
                        name: "FK_SubscriptionCategory_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
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
                    ManufacturedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    Qty = table.Column<int>(type: "int", nullable: false),
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
                    { "910da4f5-6826-419b-b66a-eb995b68bd15", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UnitNo", "UserName" },
                values: new object[,]
                {
                    { "2c435063-eee0-40bb-bfeb-41051a581450", 0, "Lane Road 2", "b66ef285-3491-49e6-806d-72efda15ac95", new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "cout.sngtech@gmail.com", false, "Titus", "Lim", false, null, "COUT.SNGTECH@GMAIL.COM", "COUT.SNGTECH@GMAIL.COM", "AQAAAAIAAYagAAAAEDk+BdFUO34w+o2DpORZN6fLG+tvuc5Jm8JNDRRA8DDSGVy7N56f9UDkbXr+3IBsJQ==", null, false, "342352", "0eb87ef5-ca52-4c22-b5e1-b01c45844029", false, "04-06", "cout.sngtech@gmail.com" },
                    { "9adbb6f1-b495-4fa3-86e2-7afb7de32fd4", 0, "Hoppa Avenue 8", "ad43514b-6bad-45b8-b43c-ff08e7e3b9b6", new DateTime(2005, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "atutriyoso@randbox.sg", false, "Atu", "Triyoso", false, null, "ATUTRIYOSO@RANDBOX.SG", "ATUTRIYOSO@RANDBOX.SG", "AQAAAAIAAYagAAAAEA70rOsxNGifjXeMuitqZ6wc0HetzY5Ia5yRIBAjMlQ22YGZgV+EUaoV1Fw8DVtMLg==", null, false, "442532", "c1f0aee6-a482-4be0-9152-4c8eee253d33", false, "23-45", "atutriyoso@randbox.sg" },
                    { "d9e7365f-8ec0-48d6-86b4-f5c95062b494", 0, "Hoppa Avenue 8", "c34d3058-d76a-4075-9aaf-00a166ff7e0b", new DateTime(2005, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "patrick_wu@gmail.com", false, "Patrick", "Wu", false, null, "PATRICK_WU@GMAIL.COM", "PATRICK_WU@GMAIL.COM", "AQAAAAIAAYagAAAAEEbnnvz7tOD3LUH5lMO99KzCfIVcEYm0HEg+SzYvLK/jQWN0nMoxQLIAAxvi54IpPg==", null, false, "442532", "53c777e6-01c9-45cf-98c0-c8bca1a0942d", false, "23-45", "patrick_wu@gmail.com" },
                    { "edc993c1-c4c7-458b-9870-e1a7af7361aa", 0, "", "37ad0272-0d56-4877-8107-e8609c533137", new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@randbox.sg", false, "Bob", "Lim", false, null, "TEST@RANDBOX.SG", "TEST@RANDBOX.SG", "AQAAAAIAAYagAAAAECiItylOQyhyCVJLwglR6w1U8dFu0CZaNH4LXGIdYVhZtB9gvAves0+Wyu2GjLI8ug==", null, false, "", "6b20b305-2a98-4dc9-af85-fd62e6d2ea55", false, "", "test@randbox.sg" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "BadgeColour", "DateTimeCreated", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "#78A54E", new DateTime(2024, 2, 4, 21, 55, 2, 740, DateTimeKind.Local).AddTicks(4340), "Experience local snacks and treats, all while helping to support local family owned businesses!", "Snacks" },
                    { 2, "#D48250", new DateTime(2024, 2, 4, 21, 55, 2, 740, DateTimeKind.Local).AddTicks(4343), "Dress up as people from all over the globe! From Kimonos to Hanboks, get a fresh look every month!", "Clothing" },
                    { 3, "#D45A50", new DateTime(2024, 2, 4, 21, 55, 2, 740, DateTimeKind.Local).AddTicks(4344), "Unleash your artistic creativity with arts and crafts from all over the world!", "Arts and Crafts" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "BadgeColour", "DateTimeCreated", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "#78A54E", new DateTime(2024, 2, 4, 21, 55, 2, 862, DateTimeKind.Local).AddTicks(5315), "Bring the well-known festivities and nightlife of Germany to your own home!", "Germany" },
                    { 2, "#D45A50", new DateTime(2024, 2, 4, 21, 55, 2, 862, DateTimeKind.Local).AddTicks(5319), "The land of the rising sun, experience the iconic cultures and long-standing traditions of Japan! ", "Japan" },
                    { 3, "#D48250", new DateTime(2024, 2, 4, 21, 55, 2, 862, DateTimeKind.Local).AddTicks(5320), "With many diverse ethnic groups, experience the traditional tastes and cultures of the worlds largest island country.", "Indonesia" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustID", "Address", "DateOfBirth", "DateTimeCreated", "Email", "FirstName", "LastName", "PasswordHash", "PostalCode", "UnitNo" },
                values: new object[,]
                {
                    { 1, "Lane Road 2", new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 21, 55, 2, 678, DateTimeKind.Local).AddTicks(6648), "cout.sngtech@gmail.com", "Titus", "Lim", "AQAAAAIAAYagAAAAEAZ7lFGu4c6KvzfUXOqHAAJYkv09xS69DRxPNOtBmUAALNZTMLwh+Ym1osnd0X4RWQ==", "342352", "04-06" },
                    { 2, "Hoppa Avenue 8", new DateTime(2005, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 21, 55, 2, 740, DateTimeKind.Local).AddTicks(3092), "patrick_wu@gmail.com", "Patrick", "Wu", "AQAAAAIAAYagAAAAEHXrM85TIBbBdtETdRQS0EGT0TRJ78NdNpCLrNgsfTKUFLb5x6FOOIegR6Av9bsxCg==", "442532", "23-45" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffID", "ContactNumber", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { 1, "81004821", new DateTime(2005, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@randbox.sg", "Bob", "Lim", "AQAAAAIAAYagAAAAECDb29WhtZBmkm7qYjuf2OH8fKNXBka5UFmtrfR4OWG/oYl6PlQwOxqhGqKeLm1EQw==" },
                    { 2, "91028765", new DateTime(2005, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "atutriyoso@randbox.sg", "Atu", "Triyoso", "AQAAAAIAAYagAAAAEGi0fveL8Z2tu/YbsWgPGMP+vQ7ycSuP9eWyr3HhPIv2D33LAOjPn4ADhHhnbhylXQ==" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "645bb191-486c-4a9e-8f38-2a48b60b8df6", "2c435063-eee0-40bb-bfeb-41051a581450" },
                    { "910da4f5-6826-419b-b66a-eb995b68bd15", "9adbb6f1-b495-4fa3-86e2-7afb7de32fd4" },
                    { "645bb191-486c-4a9e-8f38-2a48b60b8df6", "d9e7365f-8ec0-48d6-86b4-f5c95062b494" },
                    { "910da4f5-6826-419b-b66a-eb995b68bd15", "edc993c1-c4c7-458b-9870-e1a7af7361aa" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CustomerID", "DateTimeCheckout", "DeliveryStatus", "StaffID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 4, 21, 55, 2, 862, DateTimeKind.Local).AddTicks(3930), true, 1 },
                    { 2, 2, new DateTime(2024, 2, 4, 21, 55, 2, 862, DateTimeKind.Local).AddTicks(3949), false, 2 }
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
                    { 6, 1, 1, "Local favourite chips by Lorenz", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunchips Paprika", 10.21m, 278, "https://m.media-amazon.com/images/I/71Lnoe-JAkL.__AC_SX300_SY300_QL70_ML2_.jpg" },
                    { 7, 2, 2, "Traditional Japanese dress", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimono", 10.21m, 278, "data:image/jpeg;base64,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" },
                    { 8, 2, 1, "Breeches worn by farmers", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trachten", 10.21m, 178, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxYZ4FwhPbhOZzqANX0VnWAYw0GDegKKHdH15dGdSKBJCVcwgtU2CTserQX8NTg5Re9cA&usqp=CAU" },
                    { 9, 2, 3, "Dance costume used in parades", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kebaya", 10.21m, 78, "data:image/jpeg;base64,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" },
                    { 10, 2, 2, "Fashionable jacket", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haori", 10.21m, 5000, "data:image/jpeg;base64,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" },
                    { 11, 2, 3, "Headwear", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belangkon", 10.21m, 103, "data:image/jpeg;base64,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" },
                    { 12, 3, 2, "Put them together to make appealing 3D paper models", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paper Theatre", 10.21m, 101, "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcTBe4WceZjlTcY9O_vUuOUYrfy0QjRUa7M0-0iQ0NM599EZIjFrhkTsj61X7nf4vVOg3JcVORBz9LdByO5OfnV7s-t5dTDMocwRNdLJO789EBDiQDaUNFMukRdJTYW6iL_NdUYaqeCGOg&usqp=CAc" },
                    { 13, 3, 3, "Shadow puppets used in traditional indonesian story telling", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayang kulit", 10.21m, 303, "https://www.indonesia.travel/content/dam/indtravelrevamp/en/trip-ideas/7-handicraft-center-s-you-must-visit-when-visiting-indonesia/2.jpg" },
                    { 14, 3, 1, "German engraved playing cards", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playing Cards", 10.21m, 120, "https://cdn2.wanderlust.co.uk/media/1005/3.jpg?anchor=center&mode=crop&width=480&height=0&format=auto&quality=90&rnd=133018283150000000" },
                    { 15, 3, 3, "Ancient art form from Bali", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wood carved masks", 10.21m, 255, "https://www.indonesia.travel/content/dam/indtravelrevamp/en/trip-ideas/7-handicraft-center-s-you-must-visit-when-visiting-indonesia/3.jpg" },
                    { 16, 3, 2, "Hand-carved and painted", 7.79m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daruma dolls", 10.21m, 278, "data:image/jpeg;base64,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" }
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
                    { 1, 1, null, new DateTime(2024, 2, 4, 21, 55, 2, 862, DateTimeKind.Local).AddTicks(5616), 12 },
                    { 2, 2, null, new DateTime(2023, 12, 4, 21, 55, 2, 862, DateTimeKind.Local).AddTicks(5621), 5 }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionItem",
                columns: new[] { "SubscriptionItemID", "MonthOfYear", "ProductID", "Qty", "SubscriptionPlanID" },
                values: new object[,]
                {
                    { 1, 12, 16, 1, 1 },
                    { 2, 12, 12, 1, 1 },
                    { 3, 11, 7, 1, 2 },
                    { 4, 1, 10, 1, 2 }
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
