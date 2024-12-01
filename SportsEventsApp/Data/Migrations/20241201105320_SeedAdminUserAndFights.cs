using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUserAndFights : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1961c34e-6a64-460d-bdd0-8dda9ca105f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("355c87ba-0a00-41de-939f-c17ed2eafabe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45bf043e-cb7b-4d49-8d92-a8d42fdf0297"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b8d553a-bec9-4533-91bf-443e42d9cd3f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7588bbd8-1e48-444a-b880-984501316a07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8136c412-a48c-48af-abf7-5507f51623ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a94fec6b-f774-46e8-a06c-3932f5e5bafc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c68dd645-29f0-4704-82f3-9f963e6273d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f128172c-aa37-41b2-8a0c-2ae1a22f8d57"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("1961c34e-6a64-460d-bdd0-8dda9ca105f5"), 265.0, 205.0, "Middleweight  " },
                    { new Guid("355c87ba-0a00-41de-939f-c17ed2eafabe"), 155.0, 145.0, "Lightweight " },
                    { new Guid("45bf043e-cb7b-4d49-8d92-a8d42fdf0297"), 125.0, 115.0, "Flyweight " },
                    { new Guid("4b8d553a-bec9-4533-91bf-443e42d9cd3f"), 185.0, 170.0, "Middleweight  " },
                    { new Guid("7588bbd8-1e48-444a-b880-984501316a07"), 145.0, 135.0, "Featherweight  " },
                    { new Guid("8136c412-a48c-48af-abf7-5507f51623ee"), 115.0, 106.0, "Strawweight" },
                    { new Guid("a94fec6b-f774-46e8-a06c-3932f5e5bafc"), 135.0, 125.0, "Bantamweight  " },
                    { new Guid("c68dd645-29f0-4704-82f3-9f963e6273d8"), 205.0, 185.0, "Light heavyweight " },
                    { new Guid("f128172c-aa37-41b2-8a0c-2ae1a22f8d57"), 170.0, 155.0, "Welterweight  " }
                });
        }
    }
}
