using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdatedDataTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "51ac4bdd-94b1-4555-bb6e-382c55dd0c49", 0, "aaa700d3-3d37-410d-abef-b482d2ac1531", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAEETcCZge/JWWAGrXnhb05+JwixpbGvW6EcOFWulleh57+4eOKr4vs8HOUOuaRBsG8w==", null, false, "7c51cd58-53ed-4eba-8944-a1aed3bc9a00", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"), 185.0, 170.0, "Middleweight" },
                    { new Guid("345d657d-9f6d-489f-81ad-7c2b23dbca85"), 265.0, 205.0, "Heavyweight" },
                    { new Guid("43b57e8f-44bd-4420-911f-f15f282287e3"), 205.0, 185.0, "Light Heavyweight" },
                    { new Guid("6309f412-c5d0-4020-8a90-b7fcc678ff8f"), 135.0, 125.0, "Bantamweight" },
                    { new Guid("829e0070-5a08-4a0d-bcf0-3f2505f02009"), 155.0, 145.0, "Lightweight" },
                    { new Guid("a58ed655-4395-41b7-be26-ad8fe3ecc1e4"), 170.0, 155.0, "Welterweight" },
                    { new Guid("def79ab8-d35f-4cbc-9787-b78ee5fabd1f"), 125.0, 115.0, "Flyweight" },
                    { new Guid("ebbb6ece-1add-4e79-9c6a-ac33de3efde9"), 115.0, 106.0, "Strawweight" },
                    { new Guid("feba3733-4e9c-4309-954a-66616afded74"), 145.0, 135.0, "Featherweight" }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "CategoryId", "DateOfBirth", "FirstName", "Height", "ImageUrl", "LastName", "NickName", "Reach" },
                values: new object[,]
                {
                    { new Guid("0093a69e-632f-4934-bf45-23235ad134db"), new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"), new DateTime(1975, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 6.2000000000000002, "https://www.denverpost.com/wp-content/uploads/2016/04/20140801_084436_anderson-silva.jpg?w=640", "Silva", "The Spider", 77 },
                    { new Guid("1550013c-e044-4f0e-a337-3bfbde73f510"), new Guid("829e0070-5a08-4a0d-bcf0-3f2505f02009"), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", 5.0999999999999996, "https://www.datocms-assets.com/99008/1696277875-untitled-design-5.png", "Nurmagomedov", "The Eagle", 70 },
                    { new Guid("4bff9e8a-5832-4c7a-b9a0-c0a94b801415"), new Guid("829e0070-5a08-4a0d-bcf0-3f2505f02009"), new DateTime(1988, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conor", 5.7999999999999998, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20220325093124_Conor_McGregor_ff.JPG", "McGregor", "The Notorious", 74 },
                    { new Guid("500391a5-d4ba-4f6e-8b35-880f75398eef"), new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"), new DateTime(1989, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israel", 6.4000000000000004, "https://glory.pinkyellow.network/assets/fighters/israel-the-last-style-bender-adesanya/thumbnail.jpg", "Adesanya", "The Last Stylebender", 80 },
                    { new Guid("6301e156-7b95-4a58-b3e9-aee197bcfdf1"), new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"), new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chael", 6.0999999999999996, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20131219125416_chael_sonnen.JPG", "Sonnen", "The American Gangster", 73 },
                    { new Guid("67de9f12-8221-42f2-9474-b89953651748"), new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"), new DateTime(1987, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", 6.4000000000000004, "https://dmxg5wxfqgb4u.cloudfront.net/styles/card_advance_small_280x356/s3/2024-10/100324-Alex-Pereira-UFC-307-Press-Conference-THUMB-GettyImages-2176549340.jpg?itok=5C_djKwj", "Pereira", "Poatan", 79 }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title" },
                values: new object[,]
                {
                    { new Guid("3d2dc79b-2398-421e-b9bc-15cf1c29f4ca"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "51ac4bdd-94b1-4555-bb6e-382c55dd0c49", "Israel Adesanya vs Alex Pereira" },
                    { new Guid("79d85fe7-6bda-4390-becc-921714e46af0"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "51ac4bdd-94b1-4555-bb6e-382c55dd0c49", "Conor McGregor vs Khabib Nurmagomedov" },
                    { new Guid("ef939acd-47bb-4ac7-b915-d237ad5f8c87"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "51ac4bdd-94b1-4555-bb6e-382c55dd0c49", "Anderson Silva vs Chael Sonnen" }
                });

            migrationBuilder.InsertData(
                table: "FightersFights",
                columns: new[] { "FightId", "FighterId" },
                values: new object[,]
                {
                    { new Guid("ef939acd-47bb-4ac7-b915-d237ad5f8c87"), new Guid("0093a69e-632f-4934-bf45-23235ad134db") },
                    { new Guid("79d85fe7-6bda-4390-becc-921714e46af0"), new Guid("1550013c-e044-4f0e-a337-3bfbde73f510") },
                    { new Guid("79d85fe7-6bda-4390-becc-921714e46af0"), new Guid("4bff9e8a-5832-4c7a-b9a0-c0a94b801415") },
                    { new Guid("3d2dc79b-2398-421e-b9bc-15cf1c29f4ca"), new Guid("500391a5-d4ba-4f6e-8b35-880f75398eef") },
                    { new Guid("ef939acd-47bb-4ac7-b915-d237ad5f8c87"), new Guid("6301e156-7b95-4a58-b3e9-aee197bcfdf1") },
                    { new Guid("3d2dc79b-2398-421e-b9bc-15cf1c29f4ca"), new Guid("67de9f12-8221-42f2-9474-b89953651748") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("345d657d-9f6d-489f-81ad-7c2b23dbca85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43b57e8f-44bd-4420-911f-f15f282287e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6309f412-c5d0-4020-8a90-b7fcc678ff8f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a58ed655-4395-41b7-be26-ad8fe3ecc1e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("def79ab8-d35f-4cbc-9787-b78ee5fabd1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebbb6ece-1add-4e79-9c6a-ac33de3efde9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("feba3733-4e9c-4309-954a-66616afded74"));

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("ef939acd-47bb-4ac7-b915-d237ad5f8c87"), new Guid("0093a69e-632f-4934-bf45-23235ad134db") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("79d85fe7-6bda-4390-becc-921714e46af0"), new Guid("1550013c-e044-4f0e-a337-3bfbde73f510") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("79d85fe7-6bda-4390-becc-921714e46af0"), new Guid("4bff9e8a-5832-4c7a-b9a0-c0a94b801415") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("3d2dc79b-2398-421e-b9bc-15cf1c29f4ca"), new Guid("500391a5-d4ba-4f6e-8b35-880f75398eef") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("ef939acd-47bb-4ac7-b915-d237ad5f8c87"), new Guid("6301e156-7b95-4a58-b3e9-aee197bcfdf1") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("3d2dc79b-2398-421e-b9bc-15cf1c29f4ca"), new Guid("67de9f12-8221-42f2-9474-b89953651748") });

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("0093a69e-632f-4934-bf45-23235ad134db"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("1550013c-e044-4f0e-a337-3bfbde73f510"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("4bff9e8a-5832-4c7a-b9a0-c0a94b801415"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("500391a5-d4ba-4f6e-8b35-880f75398eef"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("6301e156-7b95-4a58-b3e9-aee197bcfdf1"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("67de9f12-8221-42f2-9474-b89953651748"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("3d2dc79b-2398-421e-b9bc-15cf1c29f4ca"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("79d85fe7-6bda-4390-becc-921714e46af0"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("ef939acd-47bb-4ac7-b915-d237ad5f8c87"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51ac4bdd-94b1-4555-bb6e-382c55dd0c49");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("829e0070-5a08-4a0d-bcf0-3f2505f02009"));

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
    }
}
