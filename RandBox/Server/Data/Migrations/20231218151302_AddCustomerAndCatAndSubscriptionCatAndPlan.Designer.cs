﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RandBox.Server.Data;

#nullable disable

namespace RandBox.Server.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231218151302_AddCustomerAndCatAndSubscriptionCatAndPlan")]
    partial class AddCustomerAndCatAndSubscriptionCatAndPlan
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("bit");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RandBox.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UnitNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("RandBox.Shared.Domain.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("BadgeColour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubscriptionCategoryID")
                        .HasColumnType("int");

                    b.HasKey("CategoryID");

                    b.HasIndex("SubscriptionCategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            BadgeColour = "#78A54E",
                            DateTimeCreated = new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(7285),
                            Description = "Experience local snacks and treats, all while helping to support local family owned businesses!",
                            Name = "Snacks"
                        },
                        new
                        {
                            CategoryID = 2,
                            BadgeColour = "#D48250",
                            DateTimeCreated = new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(7292),
                            Description = "Dress up as people from all over the globe! From Kimonos to Hanboks, get a fresh look every month!",
                            Name = "Clothing"
                        },
                        new
                        {
                            CategoryID = 3,
                            BadgeColour = "#D45A50",
                            DateTimeCreated = new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(7296),
                            Description = "Unleash your artistic creativity with arts and crafts from all over the world!",
                            Name = "Arts and Crafts"
                        });
                });

            modelBuilder.Entity("RandBox.Shared.Domain.Customer", b =>
                {
                    b.Property<int>("CustID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubscriptionPlanID")
                        .HasColumnType("int");

                    b.Property<string>("UnitNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustID");

                    b.HasIndex("SubscriptionPlanID");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustID = 1,
                            Address = "Lane Road 2",
                            DateOfBirth = new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTimeCreated = new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(5863),
                            Email = "cout.sngtech@gmail.com",
                            FirstName = "Titus",
                            LastName = "Lim",
                            PasswordHash = "",
                            PostalCode = "342352",
                            UnitNo = "04-06"
                        },
                        new
                        {
                            CustID = 2,
                            Address = "Hoppa Avenue 8",
                            DateOfBirth = new DateTime(2005, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTimeCreated = new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(5900),
                            Email = "patrick_wu@gmail.com",
                            FirstName = "Patrick",
                            LastName = "Wu",
                            PasswordHash = "",
                            PostalCode = "442532",
                            UnitNo = "23-45"
                        });
                });

            modelBuilder.Entity("RandBox.Shared.Domain.Staff", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffID"));

                    b.Property<int?>("SubscriptionPlanID")
                        .HasColumnType("int");

                    b.HasKey("StaffID");

                    b.HasIndex("SubscriptionPlanID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("RandBox.Shared.Domain.SubscriptionCategory", b =>
                {
                    b.Property<int>("SubscriptionCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionCategoryID"));

                    b.Property<decimal>("BaseMonthlyPrice")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<decimal>("NewMonthlyPrice")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("SubscriptionPlanID")
                        .HasColumnType("int");

                    b.HasKey("SubscriptionCategoryID");

                    b.HasIndex("SubscriptionPlanID");

                    b.ToTable("SubscriptionCategory");

                    b.HasData(
                        new
                        {
                            SubscriptionCategoryID = 1,
                            BaseMonthlyPrice = 45.50m,
                            CategoryID = 1,
                            Description = "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.",
                            Duration = 1,
                            NewMonthlyPrice = 45.50m
                        },
                        new
                        {
                            SubscriptionCategoryID = 2,
                            BaseMonthlyPrice = 45.50m,
                            CategoryID = 2,
                            Description = "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.",
                            Duration = 1,
                            NewMonthlyPrice = 46.50m
                        },
                        new
                        {
                            SubscriptionCategoryID = 3,
                            BaseMonthlyPrice = 45.50m,
                            CategoryID = 3,
                            Description = "randBox's starter plan. This is the perfect plan for those who want to test our ingenious Mysery Boxes. Go on, we won't judge.",
                            Duration = 1,
                            NewMonthlyPrice = 46.90m
                        },
                        new
                        {
                            SubscriptionCategoryID = 4,
                            BaseMonthlyPrice = 44.00m,
                            CategoryID = 1,
                            Description = "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.",
                            Duration = 3,
                            NewMonthlyPrice = 44.00m
                        },
                        new
                        {
                            SubscriptionCategoryID = 5,
                            BaseMonthlyPrice = 45.00m,
                            CategoryID = 2,
                            Description = "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.",
                            Duration = 3,
                            NewMonthlyPrice = 45.00m
                        },
                        new
                        {
                            SubscriptionCategoryID = 6,
                            BaseMonthlyPrice = 46.40m,
                            CategoryID = 3,
                            Description = "randBox's intermediate plan. This is the perfect plan for those who want more of our ingenious Mysery Boxes. Go on, we won't judge.",
                            Duration = 3,
                            NewMonthlyPrice = 46.40m
                        },
                        new
                        {
                            SubscriptionCategoryID = 7,
                            BaseMonthlyPrice = 43.50m,
                            CategoryID = 1,
                            Description = "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.",
                            Duration = 6,
                            NewMonthlyPrice = 43.50m
                        },
                        new
                        {
                            SubscriptionCategoryID = 8,
                            BaseMonthlyPrice = 44.50m,
                            CategoryID = 2,
                            Description = "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.",
                            Duration = 6,
                            NewMonthlyPrice = 44.50m
                        },
                        new
                        {
                            SubscriptionCategoryID = 9,
                            BaseMonthlyPrice = 44.90m,
                            CategoryID = 3,
                            Description = "randBox's half-year plan. This is the perfect plan for those who live on our Mystery Boxes. Go on, we won't judge.",
                            Duration = 6,
                            NewMonthlyPrice = 44.90m
                        },
                        new
                        {
                            SubscriptionCategoryID = 10,
                            BaseMonthlyPrice = 41.35m,
                            CategoryID = 1,
                            Description = "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.",
                            Duration = 12,
                            NewMonthlyPrice = 41.35m
                        },
                        new
                        {
                            SubscriptionCategoryID = 11,
                            BaseMonthlyPrice = 42.35m,
                            CategoryID = 2,
                            Description = "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.",
                            Duration = 12,
                            NewMonthlyPrice = 42.35m
                        },
                        new
                        {
                            SubscriptionCategoryID = 12,
                            BaseMonthlyPrice = 42.75m,
                            CategoryID = 3,
                            Description = "randBox's most popular plan. This is the perfect plan for those who just can't get enough of our unique Mystery Boxes. Go on, we won't judge.",
                            Duration = 12,
                            NewMonthlyPrice = 42.75m
                        });
                });

            modelBuilder.Entity("RandBox.Shared.Domain.SubscriptionPlan", b =>
                {
                    b.Property<int>("SubscriptionPlanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionPlanID"));

                    b.Property<int?>("CustID")
                        .HasColumnType("int");

                    b.Property<int?>("StaffID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubscribedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SubscriptionCategoryID")
                        .HasColumnType("int");

                    b.HasKey("SubscriptionPlanID");

                    b.ToTable("SubscriptionPlan");

                    b.HasData(
                        new
                        {
                            SubscriptionPlanID = 1,
                            CustID = 1,
                            SubscribedDateTime = new DateTime(2023, 12, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(9004),
                            SubscriptionCategoryID = 12
                        },
                        new
                        {
                            SubscriptionPlanID = 2,
                            CustID = 2,
                            SubscribedDateTime = new DateTime(2023, 10, 18, 23, 13, 2, 470, DateTimeKind.Local).AddTicks(9018),
                            SubscriptionCategoryID = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RandBox.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RandBox.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RandBox.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RandBox.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RandBox.Shared.Domain.Category", b =>
                {
                    b.HasOne("RandBox.Shared.Domain.SubscriptionCategory", null)
                        .WithMany("Categories")
                        .HasForeignKey("SubscriptionCategoryID");
                });

            modelBuilder.Entity("RandBox.Shared.Domain.Customer", b =>
                {
                    b.HasOne("RandBox.Shared.Domain.SubscriptionPlan", null)
                        .WithMany("Customers")
                        .HasForeignKey("SubscriptionPlanID");
                });

            modelBuilder.Entity("RandBox.Shared.Domain.Staff", b =>
                {
                    b.HasOne("RandBox.Shared.Domain.SubscriptionPlan", null)
                        .WithMany("Staff")
                        .HasForeignKey("SubscriptionPlanID");
                });

            modelBuilder.Entity("RandBox.Shared.Domain.SubscriptionCategory", b =>
                {
                    b.HasOne("RandBox.Shared.Domain.SubscriptionPlan", null)
                        .WithMany("SubscriptionCategories")
                        .HasForeignKey("SubscriptionPlanID");
                });

            modelBuilder.Entity("RandBox.Shared.Domain.SubscriptionCategory", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("RandBox.Shared.Domain.SubscriptionPlan", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Staff");

                    b.Navigation("SubscriptionCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
