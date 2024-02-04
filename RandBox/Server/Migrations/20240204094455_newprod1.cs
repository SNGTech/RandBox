using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RandBox.Server.Migrations
{
    /// <inheritdoc />
    public partial class newprod1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "ThumbnailURL",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxYZ4FwhPbhOZzqANX0VnWAYw0GDegKKHdH15dGdSKBJCVcwgtU2CTserQX8NTg5Re9cA&usqp=CAU");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "ThumbnailURL",
                value: "data:image/jpeg;base64,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");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 40, 18, 344, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 40, 18, 344, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 40, 18, 344, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 40, 18, 522, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 40, 18, 522, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "DateTimeCreated",
                value: new DateTime(2024, 2, 4, 17, 40, 18, 522, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 40, 18, 228, DateTimeKind.Local).AddTicks(8933), "AQAAAAIAAYagAAAAEALNGncqMoYMfMb0GIDmIlB6/sPJeT45Yp3I/NBuvASkYWNtjoiODPxDQIDWENwxjg==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 40, 18, 284, DateTimeKind.Local).AddTicks(1651), "AQAAAAIAAYagAAAAEH0hYxKJisCj/3dK6sxz/Sa8xt0DQsizWwCQjbywgtEm7ogzdaQgc7aoAeQc5lb+wg==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustID",
                keyValue: 3,
                columns: new[] { "DateTimeCreated", "PasswordHash" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 40, 18, 344, DateTimeKind.Local).AddTicks(3100), "AQAAAAIAAYagAAAAEEGR+uSn2mLTSpVkcT5T2os3/+b35Vg7JbhGdCbAXo7S3DK98D9CQVN5n7AdqxuInA==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 17, 40, 18, 521, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "DateTimeCheckout",
                value: new DateTime(2024, 2, 4, 17, 40, 18, 521, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "ThumbnailURL",
                value: "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "ThumbnailURL",
                value: "BwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIAJQAzgMBIgACEQEDEQH/xAAbAAACAgMBAAAAAAAAAAAAAAADBAIFAAEGB//EAD0QAAIBAwIDBgQEBAUDBQAAAAECAwAEERIhBTFBBhMiUWFxFDKBkSNCobEzwdHhBxVi8PEkUrIlJnJzkv/EABoBAAMBAQEBAAAAAAAAAAAAAAABAgMEBQb/xAAkEQACAgICAQUBAQEAAAAAAAAAAQIRITEDEkEEEyIyUWGRQv/aAAwDAQACEQMRAD8A8s4m6uIpEUox8SqcbCjW0YuLYRo6KzHWSzacYGcZ+lIiVZ3hV1GEBBPoTRbcorNHqOlhmPPl5VgGhi5dJIoZAukogU7c+gOKFbRN3xWLGSMnLDbFFeVLdROF15OkDHTzodvJrJaVVBIxypGaE7hO7nbHInb0piIBo21eIjBFZdRhhqz0x71vhkyx3AEmNBUhs9aDZZGouH3F6GYQuIY1Y5Vfl2Jxn2FQlgj8DxyAsY1LZ2OfLHX3oAMsMzEsVK9AemNqe4xw2Sy/yuWYj/q7YSqFO+M439asyEJkZLhWXTqK8iaOv8DS2znmaBdqpxjO42I/nWQ/w8E9eoqWC2DnkLLmNwF5kZ3JpZCEUurZ9+lHcsWYGNcLy2qIXO+AD5YqkwMicxBjhHd1xpO+M9ffambW4ntLoSwOUcfKwbB2pQuwhWMKq+ZHNsdTTcTx3SN3UOh1YHOfCBimxrZdLLw/tA2m/ZbW/YYFwgwsh6Bx/PnXOz8Ouob14Ht8NGdLYPhz55NMLbKkomLFyOo2ApiZ5Sga6kY4GANWc+VT2rRTVi8NpDENcrBm6L0rc92zJgAZJ+woUko57ADktRKa4w+d339qmm2NUsIEqlicncfl86lIoHh9KloywwcHOKHJ/EODtzFUNGlZU8JIwfM1qWRc6Y8aKkhVgBpZnHQ8sVOa3ib+D4AoyxY01Rk3kUEgLAncg8iKKoDEl8KKDGupwAOZpqBdd1GhH5sYNNooC6+JgreHNEEYCKVOPMUR4tV1KC2nDHA+tT+ITkAfqNqT0SNXFha90yWpLMrtpc/m8WKJHEJuFsYU0mI6SSOtSsSc6XZdAlbHvRXAgWeFydJYMq46nb+dS7NBMmWWHvOigKV8qwQrEF8WX578qk40XMTKvgc7gHIJFaunWQNo6HHtUkfw1LiSHGACv6mjR2cQjSXUFO+Cc4z9PKlTJp1dSOpNWPDJ1MkUssfeqMlkYDHrQ8ZZcAXFLSZ9MttH3hxhu73wQOdCuZw0kau7MqII1BJbSPIZ5V0F3cW91w+e1ikSCXUxHgUeEDbIxknAwPeuZvhBJMDamQx+EHvMZJ89thRGXYUkDlOhgMtuNh0rcT76XO5HLGwrbArFFnw+/Stu4MihVzgZ1edURojOVR8hm09RjnS9xODjG2Oe1MugYDwtnPLG+TT/AAzgcl24a4jCxqcuWPL3/pTVFJWVdlaSXkgAU4zjVjn7Va3y29narb24UlM9446t6efKm7i7iggMdoBHFyJx4n/35Vz93cmZtII0jkKNsukjTzs5GAfpTFtZ3l6AbeGR88sDn9aFZiN5VDqxC+JgPKul4fa8a4tCZuEWp+GVtCuTpG3QHrimoryCTejlby3eFmSaMxypzVtqLAAyJnoo3ro+0/CL6yhgg40YzNJ47eZd9O26fz+lc/GhWNVyNY54p48Cpp5IMuxbqDkUnI+ZcjlnYU9KQIztuKRgTvbgL9aENvBZWdkGj72WVI0IywXdse1Zc2sJh8PdjA+Yc9qG8eBrOCB0O2KF3pUOudn2INQZNC9uP+oLdF3prhiGW+jGQPEWocaAd4zDrgDPOi8Nyks0gGCIm0jyNUWhaVwxaTOdRJI+tQRyVGdRraQtpGnnTEJaJMaUbO/iHKnaFTJmOSEIGYZ16lI671bcaQyP+ESo28R2zSlwrs+gkaWGx6of6Vb8TZBwG1aTaUAal5nNQy0ikHfR2qnQD3TZJJ3xy+tYTEyDun1nnkURJnmbUfBGAQuoCpfCRnhfxKkGfvCuoNgED0oZCWRUruSW3zy86KJyqA6mRGbBwMY5fzAqGNMasTGWzvjnQmBcyLq25gYpNJoadEl703jSKS5dixJPzHfem50RVGYz48EaRypKJ1CqwyGWrK0mSZO5nQnnsvMjnt60FONihGEwTnAzjyqUKJKXCyJGFXPiz4j5Cnha8MU6lmuZ9R+RAM/tRuJz2dnZ20NjFouNWpzzIzyG/XH2osXRrYCIR2uAwJPItIME+grL6/Ij0KxWLGRGNhn1qtku5HLauZPXnSzTYPjGrPLJ5U0r0FkpneUHnjlzpYowJBFF1ZJOOYzzrSFcHr7mrSEPdnbNb3i0Fi83crPmPWMbHBI5+ZAH1r2q24ZcWMVlBb8RisrCKELIAAMN55Pr+9eFwRSzSmOGPMjYC4PWvZ5rt17P2pnlnjBt4z+EC2SQM5wc7VlzWkdPp8uii7eWF0ezaXXEb1LuW1mLI2MeEgqBn1JH2rzOO8ZRhgGGOfKuz/xHnmkl4fFcySNGYmlVm2zk7E+uK4d0Cqdx6VXHiJnzO5k5JcxE7+LnWrMMvjU48yegqEv8NQeQG9ERl0jAJ2qzJjcgaZQSwHUjoaTYKpO3XzqasVI8OFHrRkZANTMwqQ62KqY9RJZh7Gnbdyqt3O7EbMRWviIx1LfQVBrpcn8tAKIcjK5kwj+/OglowdyT7nagNPq5Zb6ZqPdzyKDgAeXWihsviUugu6hwMjPM/wDFTfKR91NEx22Ix0qlEj6ubEj6U7F+JbanLAAldYPP+9TrY7oYvrGO2SKUThgwzoAyVPkfT1o1rbpJwJmU4UzMpI6bCmrKOCa2R7jToTYgbkinzY2n+Xi0sJlwZTIoc889Pf3o8BXk4/WUXSCCCeZHShTSkNheg6VLiGUudLFlwSCp2IPrQJAx0aQSQvnVomg8GmeTSCAZAMFtsGjsJLaaMOwDow3U7c/Oh28QkgcSEq6kFBjJYnOd+gGK0cd2xYb4x9ah4ZRaPxK3hR3s4tFy4wW6DJ3I8qrQHyHkJd2PhXrQbImSaMS7qvMego0kp+Jyi8m8PoKP4JysNbxgRsSAWJOomq149JwdyCcAdavBbF0JfJ5kBTVXIQHYaN81SdCyK5YblSNsVedm+zV1xsiVHS1tASDNKM5I5hVHP9KrFhuLu6it4VPezMEjHQkmvRUiHC0hsY2LR2jREEjGdQYE/em2VGNkoeztjwy0mgsmMk00f8d/m6EDyG+KW7K3kz3I4XdzhIJSQnebiN/L0B/enrK5e5uJkH5csCefPH8qpOLIlvxOVMEB8SL6Z5j75pQziRo7jmIxxm4biFzK86iSITKqxHkUU6ce/M586HxzsARHNJwacSdyMm2lPix5q3X2P3qNsVE8Azs0ij65rqOKXElrc2V0kjgCVIpUPyurHG4899jRyYeBRV5Z41eHxYAwBUFYhMgj61d9seGmz49PGgzHI5dSByzuQfvn61UW8et9/kWqWjNrNE7eNrg6CwAz0G9MfDQ62UBjp571uEKsp0gA+9EtyMtnHr61N2GhS4iSOQgJgetFTuwnyqxHpQrli8zMc4J2ArWFUY1E9fahi8hxgbJ4CeWDWZeH52D58hQI5HXOeR9am9xk5RfoaWRUw7oWkAyML51Y8MOm2lBxpjlVz5EHY0J1MSONj13O9McPiaW3vR4ygh1aiMY3FRLRolkdbh8bW8vwjMsiyFWTmpB5bdKQU3ljOEmgKkjYP+YUzaXhtL21nfeK4QCRR+/3qPaJp3uUYyMQgGB0FGhtEpUt+JqiXC6LhRgSY3x0FU13bNZyFXX2I5GnreVZiFZismNvWm0kiuI+5u4wyZ5nYj1FWmJZKa3lEMgZgGycb9K2UBaWM7kg7imn4etu+l2MiMfC4HL3pdnEd6qjkVAzUt5F5I2kapbFgRqI3oDyFMIqb43PU0zGqpE2c88fXNFa2FwyCTBjAwBnHOnYmhi0uY1EaybNjSx8zSd9GFl1qMr19/WjXrB7iIRqO7RgQaTlvS92zxIVyMYxsaY7Om7FWZadr5xnu20Qj/V1I9ht9a6TtCGDd6dztqbHzDUGB/8AIUt2YiC8ItSECaxqIHmSSae7QBpLOQDdtBx74qXs1SxZVcMlH+bXCrn+CDgdPEf7Ul2jH/qcZB0/ggjPnkihdmbgXN/dXikgsAieWMZ/nRu03e99C9uQX7o7MM5386uH2E/qLQsxubXcE9+ny7/mFdT2gx8CM7ATRncc8OtcVYSyt3UsowA2t888g8h9a7Xjsj/BTKpXTgFs+SkH9hT5VTCErRSdsLYXl9xERDVIlqlwgA3JBYMB9AK88jZwgkXzx6V6U8v/ALrhUj57RgR5+I1w/HOGPZ8Tnso1yokMiHoVPL+n0pReMkzXkrjO4O2B7CtKdbbkj60QWsn5njG+OdF+FCMyySeIf9tVaIIZRcVtizKVSInP+k0WOONDqAVx5k0/BLgp3iR6DkYIzjPWs260LsirW2uSoCQyZPLw86z4e5x/DfnjfarT4l0jZ9Z16vCuxHvU0fQMT9wM77rmp7v8Ff6E8OrJlYg+ZFPcMjzaX6KQW7oDHPrSC2EtvJ+PkPp1HAyMedWNo0dnaO6SsjyjBI5DBqXJNYNHLqyuuwUgtw66dJZDjbrmraPTxCzjlceNCEkzz9D9RikZ76a5cMNLMuAsnUYGM/oKY4XcLbXuJAyw3A0ENjw53FAoS7Mrr2weG4CKuCm4YDfHnUHucJq2LDYt51e8VVmUFhpdfCfUVV9yoAVljRdORj83n9ad0NprQGy4y6hllAdQCFBxsP8AfSqhpu9vQ7YA1UzJDiXUgOmXlmk3Bik3wd8gketWhW6yWLRszFBuC+RgVqbTBO/eM0m/gjU/vVhw9hNKk4RSC+MYwPtS3GykXEJVAVX2Onodh0oQ6wKGMsveEqE6KNhUEkIJAjjc4wcGjS+NEKxeBxqCA/KetZFGVToiMMnqaYHoXZVX/wAtsVK6VVBt5c6e4jgKc7YWuAveLSy2lnZcNe6juI8apEfQremOu9XnCDxi84R3rn4uQsyaCBqBHrSeMs1jnCE+yK9y0qAY/FceX+9sU32kkKS27YJwrDGM+VV3ZcyaoS2fE7MxYcs5qw7Qu6pCBgk6gcCmvuS/qUfeTMrFZe78YPd93ksCRtXb8WcSWzIhDKysrgrjmp/nXDWm19bRnGp5lAX2Oa7i4RzDIjkkgHScY2quUUDn2m19o0kBA0W5A/8A0aL22te84bBxBfCY8KW5DB/viuevry6tXa+iXwv+GrkZAO5/c1VtczyyrcX00khxtrJP28qlRtJg34ZkizBcZ1DAw1bkOR8x1MB0rI5Sc6CADyweVbcurHCjJ5HzoM9EUDlfGmW881PvGVgCW9jtUFklV8AjLfpWTSZbDYYjnjfNBDGGmlaMMCDg+EjYihlZmOpl+5rSKqMM4A556k+tZLIM+Er6kbA0D0dVa21mt20LEXBGyyK+Ax9yOQostzDc2waOMBkfZceDln7dKlccPktBre2t0kny470FQMHkAOWcioiVou+kv5MLoymkaQx9Ou1camnoUk3sprmF+770xYSRtKqhwQfby6U4l4qoIUEJUKELFcHy+/rWX/BbxrRbjXCkRh70R6zqKjmxJH996pUcPESG+bAwOlaLrJWgSlA7AEX3DI7g6S+NL49KpZEiVw8hVU5hyMkU72XkWOC5hOSp0sFO5z1/SlbhDJFKi42f8PbOd8/tV9lo3T7IRuJBJKyQKe7H5judvLyoN5ZZjiY7ahzPpRVilUNIwMfj0N3m2k9asby1WODuTIspjJxIjZDD/eKfZKkJVoX4eqRuqKwwNwc0XtHZxfFpK+5khUjbOceX3pK1CI4JyfrV12gSKfh1nNnSFbQT7/8AFU8FeCgWJniAtokAxkd4c4rS2ZSXNw3evjkpyPtRpWn16LdkCgYLf81j9zHHrMytK3ygbbUWSLARxzJcJnWrZwfLyJrv+wE8a3/E7dYy0IcNEc8yCQxH3WuEmkxghM42yRgV0fYm8KcVluHJ7mO2II67kb/p+lEspl8Uvmhm+s34b2hkhKd3FLN3sJ6Mp5/Y5/Sg9ogotIi5G02NRPoate0/EY7ua1Dl4mt5AATvnURgYHLOCPeq7tCqNw7cFh3q4yPU0QeUXyRpsorCDVxi1OSfxCQNzjCmuqmmKxSjOT3LMAfY/wBK5zgeluNQ6jgJG7c8en866K7KrDcDEjoIt1BGojr6VfJ9jOCEO0PCG4b/AIe2qzMkk0k8ZZhzRjvj7Vw6l0H4i5B8xmuw7acUQcAi4fArMZLjv5M4yn/by9Nq4yG4ZtKsGIalFOg5X8qIhkaUaSM59qKkYYsVJO+NzQ2jGrORn2qHdkHKuAPemZ0xlFAl2ZyV86BrKsQMe4rNZZgFwGHrWJaSyyqkSgtIcL70V+itmxNIcq6+IczyrDhhnxD61cHs2xfSt5EXUhSMNjzP2FbXgDuxyxjUcieTeoPUUnJIzbOz4aby4mlMzyy3BBASaL5gATyPLl0pS+4Vc3GL+9iMfjYJGsXhCqcMcDfz9Nq9OuLq1MbXLxvKsaLL3oT5gDsBtv7VS8JuzcLPdcQvY4xocxrI2nShJA1AEa+W29eDx+rT+UY0dL435ZwPElhlvJfhotUMcegO02zDck46b9OVB4bbta3ZiuLaGfTjEcZDBTjqatrKVI76NmjWWzgUo5C4EykdPI8vrQ7yK1sSicLuJJIsEu0sWgoQTz3Oa9GPy+DM1HtKxqyt47G6klhAMrhtOR8gYn+tK3q2lq7yuD376WDatRBB2IHnVNe8Tn3SJ8Kd2bO7UjFfFZAZVaTfc1r7cVpGtrSHHuO7inymfiWGp9ALjG5OfWpIBHDGzK6h3I1MPnyOf6UWe4hlgD2oaKUch5iq69umuB3zLgJhBg5xg/3qoqngzaakjEXQ5J2wfPNXYaB+Fs06NJHGQ7JGcMwHkapIm7xwR+YZq+4G0QcxMNm2OauStGi2UKRj4gM0ICM+oxkHYdB79M05xGKK5b4i3EcccTkRw7AgHn7jan7y0khLxLFO4XYOBz8j61XPbzSRgvZyoFyMAElhWTWmZXNKqAX0sl5paVI4wuB4Nl0//HpTnBbq0tYbxpp1jL6AqnnsW/rS7d73SwrbOuk5AUFioPnUo7Z0t8vA4Bzk92RjeriqxQKUrGzLa3Mo7y6jGgjdgfQ7exAP3onHr20+Ckjhu45ZdSFUHPAYGqWEbMT50nKrNMW0H3ro9tI0lNvY/wAH4hDY3yz3KzMrRaAYsHTuCc/ar+TjHD5BJBqkCOCMvEQMeeaobFVKgMAcDampB0xt1pzinkSbSKBrhxO3eSEs3iy3Nvf3qFxbfilkOEKgrjyxV1oDKCFQv5kb4ravGMowUqBgADn/AGrmfK14Mm35KIppARk5Abk0OXCaAQDnkPOrsKmPYbk8iKw29soGpAG0/lo93+CtlMgQgSKAPVhTVldm2cvGN9JxU7oxxqNUaqrfK+ME0k5XV4GCleXrVp9g2Fe8kIAVymeZBxmnLXiF0wWLLSKi7Dcnnz2+lVwfvCQ2FfHLFXvZqS9tllktTGkcvzO5UZI6An9qmbUYh0vB7FeX1vcSzWkaP+GFBYnOodQPp1HKkeKXl/d8HI4bbAiU6YlEYyRncjHTHX03578jd8Su4g2kyrNP+G0Ty4BB5nHQYzXQcGma64bI1y8KwKRCjMdOB+Y/T75HlXz69NLiS5PxnX7ibpFVwaX/AC1CsnDVvpO8KZwcmQtsMjceQ+tM9quGXXwhFp2chmeaEytLHO2uE55Y1bnflv7bVl9xTh0EjWzWErCMlYpjMCW6ZBz69N/Wl27b8Qhuo7aBkeUfndAQV5nPU5Fek4c0q5IR/wBZCaWzgbq1urJ0XiFtNC7DUvfIVJHpQ+/iUbc6se2vGZeNcVW4yzRwwJECdgDuSQMnAycD2Fc0zHrvXfx3KKb2Q2i1gu2R1OcgHenWRFW7VQQZIS6YPNlGf2Bqls2LuFA3JAx51bSWt8kq3EcTtpyMc9iCDt9auguwdk2ooCTtyNXMSPHdrg896poLOaIxqYpT1YhD4fSriSRI1jdXfK7MHG5pUUix43aC5shdRIWkUANtuV/tVJHaBl0HW/eDO6jw704eKSlVS3nIUbH3ro+z/CpOKwh5CyRA89ONXtUSUkDd6ObTgct6EW2bGkYDacgffYU9P2Xk4bZXN090jlVLaQua7iW1jtYBFCowB4VFU3FoppOBX7gERIuSXPryWqim9jrFs4BRhT70F+R8X3orHFBkIKnIH2rpMxiBgjqRuMb02+C2M8+VJLswwMbU0TtnnilLQ0LR/ELKuu6l3/10NonYyAu2WB8WcmvYE7HcBmhikNlgsgI0ufKot2I4Edu4kHXaT+1c7QHkiG6t2Jil0jfOBWjNdO5PxD742ztXqx7AcE1bLOmRvhgaG/8Ah3wdh4JLj7gj9qEh2eZWVtf8Rue5tZC7DcliAB9cVK94dxOxAe7jkjQnZyqkfoK76Hg8HBbt7WIsVcA5Y7n3qwlt7e5s3hmGtGBBGNhRopLB5ZEVRGabBCDOPCST9uVHBiuYk7qPCjchH7vf+dWvGuCyW1rK0CoyJucbHHnVZwq6JtSsaINLlcMinOAN9waHxqZi+xf9o0htpLeS2t4onlaNmZR1IG+9OcNlklgWzkfMUshLbAHfHkPWt1lea1fp1Zf/AGVXG7ZbbiQCM5BlCHUehQOf1JqNvwu1uLiSV1bWqjBB8jWVld8pNenTKa+Q26Q2tnNFFbQd2VYshjGG261wN1bxhlK5GoZIBrdZRBu2EkOcIhRLnbfC53rorRmALajkHasrK3johDRYjSM/NnNUnGXIKH/VisrKSG9F12S4XZ3dzH8TAsmU1nV5/wBK72RRbwKIRoA2AFZWVm9lxF0Xv5kR2bDHBIO+Kb7Woidl75FUBViwABy3FZWVpEU9njctKTE7D1rdZW/ggcUZYiiucRsR5VlZUy0NHuViT8Ha/wD0p/4ijt8rGtVlYAaySTQ5ZGUYBrKyqRJzXE5C/Eo9QH8LypmDLKMnbyrKyoezojooeNnBdQBho2B+1cHwpQloDz1sWOfOsrK04zGez//Z\",\r\n");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDEC1+rxscnda//4gfn8PQ/fh4Nw+lx3YM4il8BwSnDxqKAj+ZKPvzgAEVVZMdoMNQ==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIiRigMqCjB583e7jOyiQXAl0d5IOXGQYVMONhsAeOtzIF5QLKLOjvhJY1ENfj6xcw==");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMbUzYL64IfQTkIwfKAGzEk3TbsmL733+5xThBtPpZy7cOcgW6ra90YzMnjM9ZJyCQ==");

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 1,
                column: "SubscribedDateTime",
                value: new DateTime(2024, 2, 4, 17, 40, 18, 522, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "SubscriptionPlan",
                keyColumn: "SubscriptionPlanID",
                keyValue: 2,
                column: "SubscribedDateTime",
                value: new DateTime(2023, 12, 4, 17, 40, 18, 522, DateTimeKind.Local).AddTicks(1336));
        }
    }
}
