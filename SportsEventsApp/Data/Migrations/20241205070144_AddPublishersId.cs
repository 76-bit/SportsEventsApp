using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPublishersId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14773a41-5dc5-498a-9ec0-fd885cac29bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f7896e9-90af-414a-a318-cc4e708a425e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49216179-fdbf-429c-94b8-eb1dcd25f3fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8953ca48-4d30-4b9b-a2d4-a7a084602025"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad3d79d3-b12d-4f6e-9610-f89865aba29d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b9087796-9eaa-4ae8-8e34-5946a1cebec0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ceeeab9c-d033-48e3-acf4-7bbd337b41b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2a58820-6e1b-4e54-889f-889ab6fe7200"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f37ec1fe-44b6-4fe6-9137-6edd79ea5c8e"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("517f5d2d-d9f5-4014-bf57-f6dd5b8b453f"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("591abf3b-2e2f-447b-b3dd-99b75e23204b"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("c5e7ced4-ccd7-4703-95ed-602287743b18"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("c9e7b8f1-dd60-4edb-b1f0-7a35f7687084"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("e6e31a44-9fce-4f65-ae70-605f64684ceb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d849988-b786-4819-81b1-6d538355c4ac");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "46c9689f-1401-4559-bffa-b2109d985a94", 0, "a56ebacd-4a25-4e4a-ab0b-6bbaadfeb224", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAECjfsrru3JSUSeBPtAK0Ga7WeT9hMLVlek52WnbIFznLBzYbM5LXx9BWH/AZ0/XVQg==", null, false, "3a26f25c-2b3d-4e64-b3b1-ed1fcebc0b07", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("058c5ae5-7ecf-46a9-9c3b-60899832b7bd"), 205.0, 185.0, "Light heavyweight " },
                    { new Guid("0a78de3e-321c-43ba-aa40-8aabaf4ff464"), 155.0, 145.0, "Lightweight " },
                    { new Guid("32047af9-1e8d-44a1-87c1-b3bcc1b14387"), 135.0, 125.0, "Bantamweight  " },
                    { new Guid("39e8c3da-1e45-47a3-ac2d-c95ba0ba6eff"), 170.0, 155.0, "Welterweight  " },
                    { new Guid("927e4844-5080-4aa9-aec1-900149f89f9d"), 125.0, 115.0, "Flyweight " },
                    { new Guid("a480e317-5d4e-4359-b6df-2d3d4f4b7582"), 115.0, 106.0, "Strawweight" },
                    { new Guid("dc5ccf83-db8c-4c60-ab0b-e4517a3e36f6"), 145.0, 135.0, "Featherweight  " },
                    { new Guid("df272062-5f02-4cf9-90f1-770531a4ecd5"), 185.0, 170.0, "Middleweight  " },
                    { new Guid("ee1175c4-4c0c-4122-ac27-8b7eaade12f5"), 265.0, 205.0, "Middleweight  " }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title" },
                values: new object[,]
                {
                    { new Guid("1383b861-7000-44e0-8629-f45b4a6bfb26"), new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "A heavyweight clash for the championship title.", "https://i.pinimg.com/736x/5e/69/ee/5e69ee1c4c9f20167f124387b2116c3a.jpg", false, "46c9689f-1401-4559-bffa-b2109d985a94", "Francis Ngannou vs Stipe Miocic" },
                    { new Guid("46d1435b-d4c8-4afd-957d-c5ab37669ae6"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "46c9689f-1401-4559-bffa-b2109d985a94", "Anderson Silva vs Chael Sonnen" },
                    { new Guid("508cba32-b162-49bf-ab51-43c27c50cd0f"), new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "A historic fight in women's MMA.", "https://mmajunkie.usatoday.com/wp-content/uploads/sites/91/2018/11/cris-cyborg-amanda-nunes-ufc-230-press-conference-1.jpg?w=1000", false, "46c9689f-1401-4559-bffa-b2109d985a94", "Amanda Nunes vs Cris Cyborg" },
                    { new Guid("b75cab64-ca2a-43bd-b690-087bf725b3e3"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "46c9689f-1401-4559-bffa-b2109d985a94", "Conor McGregor vs Khabib Nurmagomedov" },
                    { new Guid("dcd1c124-27ef-47cf-a90c-0faf8c17d37f"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "46c9689f-1401-4559-bffa-b2109d985a94", "Israel Adesanya vs Alex Pereira" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("058c5ae5-7ecf-46a9-9c3b-60899832b7bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a78de3e-321c-43ba-aa40-8aabaf4ff464"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32047af9-1e8d-44a1-87c1-b3bcc1b14387"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39e8c3da-1e45-47a3-ac2d-c95ba0ba6eff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("927e4844-5080-4aa9-aec1-900149f89f9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a480e317-5d4e-4359-b6df-2d3d4f4b7582"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc5ccf83-db8c-4c60-ab0b-e4517a3e36f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df272062-5f02-4cf9-90f1-770531a4ecd5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee1175c4-4c0c-4122-ac27-8b7eaade12f5"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("1383b861-7000-44e0-8629-f45b4a6bfb26"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("46d1435b-d4c8-4afd-957d-c5ab37669ae6"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("508cba32-b162-49bf-ab51-43c27c50cd0f"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("b75cab64-ca2a-43bd-b690-087bf725b3e3"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("dcd1c124-27ef-47cf-a90c-0faf8c17d37f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46c9689f-1401-4559-bffa-b2109d985a94");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7d849988-b786-4819-81b1-6d538355c4ac", 0, "4392ec9b-c0f8-4285-8147-beb7c6ce993b", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAEJAKQ7wrWJdU+lGNfZRMFlFWAFS+64jsLxsda56Jo5H7/2dJ8rgZZkzjUI24o0LXLw==", null, false, "1a2256e4-5053-4ba4-bf35-2fbc0e75633b", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("14773a41-5dc5-498a-9ec0-fd885cac29bd"), 135.0, 125.0, "Bantamweight  " },
                    { new Guid("3f7896e9-90af-414a-a318-cc4e708a425e"), 170.0, 155.0, "Welterweight  " },
                    { new Guid("49216179-fdbf-429c-94b8-eb1dcd25f3fe"), 265.0, 205.0, "Middleweight  " },
                    { new Guid("8953ca48-4d30-4b9b-a2d4-a7a084602025"), 185.0, 170.0, "Middleweight  " },
                    { new Guid("ad3d79d3-b12d-4f6e-9610-f89865aba29d"), 145.0, 135.0, "Featherweight  " },
                    { new Guid("b9087796-9eaa-4ae8-8e34-5946a1cebec0"), 115.0, 106.0, "Strawweight" },
                    { new Guid("ceeeab9c-d033-48e3-acf4-7bbd337b41b3"), 125.0, 115.0, "Flyweight " },
                    { new Guid("f2a58820-6e1b-4e54-889f-889ab6fe7200"), 155.0, 145.0, "Lightweight " },
                    { new Guid("f37ec1fe-44b6-4fe6-9137-6edd79ea5c8e"), 205.0, 185.0, "Light heavyweight " }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title" },
                values: new object[,]
                {
                    { new Guid("517f5d2d-d9f5-4014-bf57-f6dd5b8b453f"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "7d849988-b786-4819-81b1-6d538355c4ac", "Anderson Silva vs Chael Sonnen" },
                    { new Guid("591abf3b-2e2f-447b-b3dd-99b75e23204b"), new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "A historic fight in women's MMA.", "https://mmajunkie.usatoday.com/wp-content/uploads/sites/91/2018/11/cris-cyborg-amanda-nunes-ufc-230-press-conference-1.jpg?w=1000", false, "7d849988-b786-4819-81b1-6d538355c4ac", "Amanda Nunes vs Cris Cyborg" },
                    { new Guid("c5e7ced4-ccd7-4703-95ed-602287743b18"), new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "A heavyweight clash for the championship title.", "https://i.pinimg.com/736x/5e/69/ee/5e69ee1c4c9f20167f124387b2116c3a.jpg", false, "7d849988-b786-4819-81b1-6d538355c4ac", "Francis Ngannou vs Stipe Miocic" },
                    { new Guid("c9e7b8f1-dd60-4edb-b1f0-7a35f7687084"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "7d849988-b786-4819-81b1-6d538355c4ac", "Israel Adesanya vs Alex Pereira" },
                    { new Guid("e6e31a44-9fce-4f65-ae70-605f64684ceb"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "7d849988-b786-4819-81b1-6d538355c4ac", "Conor McGregor vs Khabib Nurmagomedov" }
                });
        }
    }
}
