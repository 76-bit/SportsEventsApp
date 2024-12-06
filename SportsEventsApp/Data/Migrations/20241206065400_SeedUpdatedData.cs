using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdatedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Reach",
                table: "Fighters",
                type: "int",
                nullable: false,
                comment: "The fighter's reach in inches",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The fighter's reach in centimeters");

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "Fighters",
                type: "float",
                nullable: false,
                comment: "The height of the fighter in feet",
                oldClrType: typeof(double),
                oldType: "float",
                oldComment: "The height of the fighter in cm");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "274f50e2-e329-4a18-b68c-9ce664576802", 0, "15afeee0-c7d4-47d4-94df-4bff9c107863", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAEByR1W5K3Eokjn4FdO0T6QFYLzCvve1R5kACJPa0YNPknqMUr9VYfjH7+sFVR7CiNA==", null, false, "edad879d-853b-42cb-9334-0150795bafd7", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("1465824f-659c-4139-9fb2-1561d3ac6385"), 265.0, 205.0, "Heavyweight" },
                    { new Guid("15a24b87-6509-4189-817c-ea65b3f1f9e3"), 205.0, 185.0, "Light Heavyweight" },
                    { new Guid("2a5315ad-b76c-44f5-a96e-1df84ee3d88e"), 155.0, 145.0, "Lightweight" },
                    { new Guid("755672e7-6a15-4056-a6bc-b3809d2df9cb"), 170.0, 155.0, "Welterweight" },
                    { new Guid("9d55b9c9-3eba-43f3-9acd-e0e12cea3960"), 125.0, 115.0, "Flyweight" },
                    { new Guid("9eaa1166-cb8f-4592-8de7-2a845e4f9c1f"), 145.0, 135.0, "Featherweight" },
                    { new Guid("ac6d2b9b-304d-4c8b-86c8-2e59ea4fa030"), 135.0, 125.0, "Bantamweight" },
                    { new Guid("b31c7d92-79d0-4c8a-9f0f-39be3df0e993"), 115.0, 106.0, "Strawweight" },
                    { new Guid("c7962691-f6ce-45f2-b76a-b58d24f816f9"), 185.0, 170.0, "Middleweight" }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "CategoryId", "DateOfBirth", "FirstName", "Height", "ImageUrl", "LastName", "NickName", "Reach" },
                values: new object[,]
                {
                    { new Guid("115fd96d-906b-4880-8bf5-32e5295c8145"), new Guid("c7962691-f6ce-45f2-b76a-b58d24f816f9"), new DateTime(1975, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 6.2000000000000002, "https://www.denverpost.com/wp-content/uploads/2016/04/20140801_084436_anderson-silva.jpg?w=640", "Silva", "The Spider", 77 },
                    { new Guid("897acab7-e5f2-4caa-921d-d47d137c0bff"), new Guid("c7962691-f6ce-45f2-b76a-b58d24f816f9"), new DateTime(1987, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", 6.4000000000000004, "https://dmxg5wxfqgb4u.cloudfront.net/styles/card_advance_small_280x356/s3/2024-10/100324-Alex-Pereira-UFC-307-Press-Conference-THUMB-GettyImages-2176549340.jpg?itok=5C_djKwj", "Pereira", "Poatan", 79 },
                    { new Guid("945c2a10-20ee-455b-9250-1e07b1652cf6"), new Guid("c7962691-f6ce-45f2-b76a-b58d24f816f9"), new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chael", 6.0999999999999996, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20131219125416_chael_sonnen.JPG", "Sonnen", "The American Gangster", 73 },
                    { new Guid("9e39741d-52d4-40f3-95f9-d476861da18b"), new Guid("c7962691-f6ce-45f2-b76a-b58d24f816f9"), new DateTime(1989, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israel", 6.4000000000000004, "https://glory.pinkyellow.network/assets/fighters/israel-the-last-style-bender-adesanya/thumbnail.jpg", "Adesanya", "The Last Stylebender", 80 },
                    { new Guid("be7039ea-6544-475d-8059-fd48c697f97a"), new Guid("2a5315ad-b76c-44f5-a96e-1df84ee3d88e"), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", 5.0999999999999996, "https://www.datocms-assets.com/99008/1696277875-untitled-design-5.png", "Nurmagomedov", "The Eagle", 70 },
                    { new Guid("d4237fc1-19ef-4b1d-a39d-be17618df31e"), new Guid("2a5315ad-b76c-44f5-a96e-1df84ee3d88e"), new DateTime(1988, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conor", 5.7999999999999998, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20220325093124_Conor_McGregor_ff.JPG", "McGregor", "The Notorious", 74 }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title" },
                values: new object[,]
                {
                    { new Guid("11c546d0-40de-4aa7-9114-9f098d40592a"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "274f50e2-e329-4a18-b68c-9ce664576802", "Anderson Silva vs Chael Sonnen" },
                    { new Guid("281325cb-ba57-4792-8cb8-335a90c50191"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "274f50e2-e329-4a18-b68c-9ce664576802", "Conor McGregor vs Khabib Nurmagomedov" },
                    { new Guid("748d39ff-6afd-4905-a09c-57c687ab8b72"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "274f50e2-e329-4a18-b68c-9ce664576802", "Israel Adesanya vs Alex Pereira" }
                });

            migrationBuilder.InsertData(
                table: "FightersFights",
                columns: new[] { "FightId", "FighterId" },
                values: new object[,]
                {
                    { new Guid("748d39ff-6afd-4905-a09c-57c687ab8b72"), new Guid("897acab7-e5f2-4caa-921d-d47d137c0bff") },
                    { new Guid("748d39ff-6afd-4905-a09c-57c687ab8b72"), new Guid("9e39741d-52d4-40f3-95f9-d476861da18b") },
                    { new Guid("281325cb-ba57-4792-8cb8-335a90c50191"), new Guid("be7039ea-6544-475d-8059-fd48c697f97a") },
                    { new Guid("281325cb-ba57-4792-8cb8-335a90c50191"), new Guid("d4237fc1-19ef-4b1d-a39d-be17618df31e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1465824f-659c-4139-9fb2-1561d3ac6385"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15a24b87-6509-4189-817c-ea65b3f1f9e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("755672e7-6a15-4056-a6bc-b3809d2df9cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d55b9c9-3eba-43f3-9acd-e0e12cea3960"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9eaa1166-cb8f-4592-8de7-2a845e4f9c1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac6d2b9b-304d-4c8b-86c8-2e59ea4fa030"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b31c7d92-79d0-4c8a-9f0f-39be3df0e993"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("115fd96d-906b-4880-8bf5-32e5295c8145"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("945c2a10-20ee-455b-9250-1e07b1652cf6"));

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("748d39ff-6afd-4905-a09c-57c687ab8b72"), new Guid("897acab7-e5f2-4caa-921d-d47d137c0bff") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("748d39ff-6afd-4905-a09c-57c687ab8b72"), new Guid("9e39741d-52d4-40f3-95f9-d476861da18b") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("281325cb-ba57-4792-8cb8-335a90c50191"), new Guid("be7039ea-6544-475d-8059-fd48c697f97a") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("281325cb-ba57-4792-8cb8-335a90c50191"), new Guid("d4237fc1-19ef-4b1d-a39d-be17618df31e") });

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("11c546d0-40de-4aa7-9114-9f098d40592a"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("897acab7-e5f2-4caa-921d-d47d137c0bff"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("9e39741d-52d4-40f3-95f9-d476861da18b"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("be7039ea-6544-475d-8059-fd48c697f97a"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("d4237fc1-19ef-4b1d-a39d-be17618df31e"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("281325cb-ba57-4792-8cb8-335a90c50191"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("748d39ff-6afd-4905-a09c-57c687ab8b72"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "274f50e2-e329-4a18-b68c-9ce664576802");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a5315ad-b76c-44f5-a96e-1df84ee3d88e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7962691-f6ce-45f2-b76a-b58d24f816f9"));

            migrationBuilder.AlterColumn<int>(
                name: "Reach",
                table: "Fighters",
                type: "int",
                nullable: false,
                comment: "The fighter's reach in centimeters",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The fighter's reach in inches");

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "Fighters",
                type: "float",
                nullable: false,
                comment: "The height of the fighter in cm",
                oldClrType: typeof(double),
                oldType: "float",
                oldComment: "The height of the fighter in feet");

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
    }
}
