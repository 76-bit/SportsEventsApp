using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreFights : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5426e6e2-0302-4b71-80f3-77d7f4580565"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77ef233f-e347-49ca-86f7-c1f60e0d3b86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88cabeaa-5564-4fd3-ae3f-ded8cfdbc956"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98a2d2e2-2054-4bdb-9e37-1c0d97c999db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a18511ed-040d-4e87-9597-e70c02698c18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b546b08a-4673-4531-868f-5743e419992d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c431fdbb-646a-4a09-b2fc-60eb3c5e64d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c79cb0cb-19a4-4300-8060-6ce6a559a443"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdb0155a-cd20-46d0-85b1-2e8bc525fb2b"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("5970fd33-4809-4192-9f1b-6c76c953bde9"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("9463ef91-af4d-446a-9e0b-7e5a98bcb624"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0662080b-83af-4581-8c2a-726f23b54b7d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0662080b-83af-4581-8c2a-726f23b54b7d", 0, "b8d7d001-6a64-4248-b999-ba0bf7a776f6", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAEIqI5i6BH6Fl7s2bUJ75OK+OgYVwjGdd3/AU9qYWTxf8XlKT0rqURiCdqBB3Gif/Rg==", null, false, "992d540a-cc68-4129-955e-7c1e75e5fc41", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("5426e6e2-0302-4b71-80f3-77d7f4580565"), 135.0, 125.0, "Bantamweight  " },
                    { new Guid("77ef233f-e347-49ca-86f7-c1f60e0d3b86"), 125.0, 115.0, "Flyweight " },
                    { new Guid("88cabeaa-5564-4fd3-ae3f-ded8cfdbc956"), 170.0, 155.0, "Welterweight  " },
                    { new Guid("98a2d2e2-2054-4bdb-9e37-1c0d97c999db"), 155.0, 145.0, "Lightweight " },
                    { new Guid("a18511ed-040d-4e87-9597-e70c02698c18"), 115.0, 106.0, "Strawweight" },
                    { new Guid("b546b08a-4673-4531-868f-5743e419992d"), 145.0, 135.0, "Featherweight  " },
                    { new Guid("c431fdbb-646a-4a09-b2fc-60eb3c5e64d8"), 265.0, 205.0, "Middleweight  " },
                    { new Guid("c79cb0cb-19a4-4300-8060-6ce6a559a443"), 205.0, 185.0, "Light heavyweight " },
                    { new Guid("cdb0155a-cd20-46d0-85b1-2e8bc525fb2b"), 185.0, 170.0, "Middleweight  " }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title" },
                values: new object[,]
                {
                    { new Guid("5970fd33-4809-4192-9f1b-6c76c953bde9"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "0662080b-83af-4581-8c2a-726f23b54b7d", "Conor McGregor vs Khabib Nurmagomedov" },
                    { new Guid("9463ef91-af4d-446a-9e0b-7e5a98bcb624"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://example.com/adesanya-vs-pereira.jpg", false, "0662080b-83af-4581-8c2a-726f23b54b7d", "Israel Adesanya vs Alex Pereira" }
                });
        }
    }
}
