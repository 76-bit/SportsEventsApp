using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFighterImageAndReach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Fighters",
                type: "nvarchar(max)",
                nullable: true,
                comment: "URL for the fighter's image");

            migrationBuilder.AddColumn<int>(
                name: "Reach",
                table: "Fighters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "The fighter's reach in centimeters");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "93a2d891-447d-4e86-a35f-ed0545fe13e8", 0, "0b3fb9ab-4cd6-4aca-87e7-1dab7a69fd32", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAEKsc1MBAfS50I6EAELOQoZeoEI63PtAxRvPl6ZnhOLnets/GmpbEzx15/UwwORYdEw==", null, false, "fecc147c-29e7-4322-b165-da2d9a051e71", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("0beb008a-477c-44e1-bb0e-9eea422f6234"), 145.0, 135.0, "Featherweight  " },
                    { new Guid("157b6b64-9276-4f92-a460-869ec1985a72"), 205.0, 185.0, "Light heavyweight " },
                    { new Guid("272abaaa-1fee-4b96-9ef1-29c951bd5df7"), 155.0, 145.0, "Lightweight " },
                    { new Guid("4af344c1-dcf2-4ba2-a2a9-0bfe76b07aea"), 170.0, 155.0, "Welterweight  " },
                    { new Guid("7eb59926-fda7-4142-bcb6-bcc22a6caf08"), 115.0, 106.0, "Strawweight" },
                    { new Guid("8a6c7bd5-1813-4565-a9b6-66bd3d44c424"), 125.0, 115.0, "Flyweight " },
                    { new Guid("9e406232-4fe0-4acd-afa5-0f16c213cb09"), 135.0, 125.0, "Bantamweight  " },
                    { new Guid("a9c5d524-dd66-417c-8971-6cdee181860c"), 185.0, 170.0, "Middleweight  " },
                    { new Guid("e4608da9-bae7-41dd-8ead-50fa72561d7e"), 265.0, 205.0, "Middleweight  " }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title" },
                values: new object[,]
                {
                    { new Guid("284917e7-8e31-44be-bfd6-116507d1bcaa"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "93a2d891-447d-4e86-a35f-ed0545fe13e8", "Israel Adesanya vs Alex Pereira" },
                    { new Guid("99a36ce7-1fee-4c6b-a8e1-34277ee1c9a1"), new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "A historic fight in women's MMA.", "https://mmajunkie.usatoday.com/wp-content/uploads/sites/91/2018/11/cris-cyborg-amanda-nunes-ufc-230-press-conference-1.jpg?w=1000", false, "93a2d891-447d-4e86-a35f-ed0545fe13e8", "Amanda Nunes vs Cris Cyborg" },
                    { new Guid("a5aac695-ebbd-45a8-bdd7-a65b3c315b80"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "93a2d891-447d-4e86-a35f-ed0545fe13e8", "Conor McGregor vs Khabib Nurmagomedov" },
                    { new Guid("be58cebf-849a-4ad6-bc18-756e6f210b5c"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "93a2d891-447d-4e86-a35f-ed0545fe13e8", "Anderson Silva vs Chael Sonnen" },
                    { new Guid("f555304d-d67a-40e4-8d7e-5dba746c0292"), new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "A heavyweight clash for the championship title.", "https://i.pinimg.com/736x/5e/69/ee/5e69ee1c4c9f20167f124387b2116c3a.jpg", false, "93a2d891-447d-4e86-a35f-ed0545fe13e8", "Francis Ngannou vs Stipe Miocic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0beb008a-477c-44e1-bb0e-9eea422f6234"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("157b6b64-9276-4f92-a460-869ec1985a72"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("272abaaa-1fee-4b96-9ef1-29c951bd5df7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4af344c1-dcf2-4ba2-a2a9-0bfe76b07aea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7eb59926-fda7-4142-bcb6-bcc22a6caf08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a6c7bd5-1813-4565-a9b6-66bd3d44c424"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e406232-4fe0-4acd-afa5-0f16c213cb09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9c5d524-dd66-417c-8971-6cdee181860c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4608da9-bae7-41dd-8ead-50fa72561d7e"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("284917e7-8e31-44be-bfd6-116507d1bcaa"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("99a36ce7-1fee-4c6b-a8e1-34277ee1c9a1"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("a5aac695-ebbd-45a8-bdd7-a65b3c315b80"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("be58cebf-849a-4ad6-bc18-756e6f210b5c"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("f555304d-d67a-40e4-8d7e-5dba746c0292"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a2d891-447d-4e86-a35f-ed0545fe13e8");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Fighters");

            migrationBuilder.DropColumn(
                name: "Reach",
                table: "Fighters");

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
    }
}
