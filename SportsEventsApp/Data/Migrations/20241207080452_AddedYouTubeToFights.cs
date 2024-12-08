using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedYouTubeToFights : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "YouTubeUrl",
                table: "Fights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The link to the youtube video of the fight");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Fighters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The nationality of the fighter");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8144e996-a8f3-4235-b0d4-82a6e9b9bbda", 0, "3c5c02a7-5955-480f-8198-16f4149f5828", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAEL/X3FQZ7fVI2yodvM+AX8+KOplaNC/RfY/bELWXaaL9kcfZ2MqI0Q+JAtrni0w72Q==", null, false, "c9f68d84-b460-4816-9a88-1c44147a1341", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("187ef30b-d99f-4ad5-b9ba-5cd607150be5"), 115.0, 106.0, "Strawweight" },
                    { new Guid("376c73f0-2399-412b-8259-4410930fb19f"), 170.0, 155.0, "Welterweight" },
                    { new Guid("3e824996-9440-4d6b-8591-b429d0211506"), 185.0, 170.0, "Middleweight" },
                    { new Guid("84e5851c-c7b0-4c67-b1f3-7c842e09b10e"), 125.0, 115.0, "Flyweight" },
                    { new Guid("90d86c9b-26dd-4d01-9c6f-cdc5361f2e4f"), 265.0, 205.0, "Heavyweight" },
                    { new Guid("9c918936-c07b-44ea-baa2-7f6ab56d1a9a"), 205.0, 185.0, "Light Heavyweight" },
                    { new Guid("ddb8628a-e3fd-4110-9bb6-e6051d77fe91"), 155.0, 145.0, "Lightweight" },
                    { new Guid("e95e16bd-8376-4d2e-8b5a-c4c565ed2454"), 145.0, 135.0, "Featherweight" },
                    { new Guid("f8211693-1bcc-4775-ac9c-264168eb8502"), 135.0, 125.0, "Bantamweight" }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "CategoryId", "Country", "DateOfBirth", "FirstName", "Height", "ImageUrl", "LastName", "NickName", "Reach" },
                values: new object[,]
                {
                    { new Guid("403046cc-9ee0-4516-ae15-01c6f923e57e"), new Guid("3e824996-9440-4d6b-8591-b429d0211506"), "Nigeria", new DateTime(1989, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israel", 6.4000000000000004, "https://glory.pinkyellow.network/assets/fighters/israel-the-last-style-bender-adesanya/thumbnail.jpg", "Adesanya", "The Last Stylebender", 80 },
                    { new Guid("70483d62-1771-48f2-9c1b-065894373cba"), new Guid("3e824996-9440-4d6b-8591-b429d0211506"), "Brazil", new DateTime(1987, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", 6.4000000000000004, "https://dmxg5wxfqgb4u.cloudfront.net/styles/card_advance_small_280x356/s3/2024-10/100324-Alex-Pereira-UFC-307-Press-Conference-THUMB-GettyImages-2176549340.jpg?itok=5C_djKwj", "Pereira", "Poatan", 79 },
                    { new Guid("9d8a21c7-7cb6-47cb-8d6b-69c2ebeb2108"), new Guid("3e824996-9440-4d6b-8591-b429d0211506"), "Brazil", new DateTime(1975, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 6.2000000000000002, "https://www.denverpost.com/wp-content/uploads/2016/04/20140801_084436_anderson-silva.jpg?w=640", "Silva", "The Spider", 77 },
                    { new Guid("b4c9996e-fd22-45ce-9657-bfe26e3505dd"), new Guid("3e824996-9440-4d6b-8591-b429d0211506"), "U.S.", new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chael", 6.0999999999999996, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20131219125416_chael_sonnen.JPG", "Sonnen", "The American Gangster", 73 },
                    { new Guid("e80733ba-f7dd-4606-bb35-a8963f64a203"), new Guid("ddb8628a-e3fd-4110-9bb6-e6051d77fe91"), "Ireland", new DateTime(1988, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conor", 5.7999999999999998, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20220325093124_Conor_McGregor_ff.JPG", "McGregor", "The Notorious", 74 },
                    { new Guid("f83610a7-261e-4322-80a7-2f5a111ce50f"), new Guid("ddb8628a-e3fd-4110-9bb6-e6051d77fe91"), "Russia", new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", 5.0999999999999996, "https://www.datocms-assets.com/99008/1696277875-untitled-design-5.png", "Nurmagomedov", "The Eagle", 70 }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title", "YouTubeUrl" },
                values: new object[,]
                {
                    { new Guid("71c20fb5-cfb9-4e1c-b48d-773b6a491f4d"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "8144e996-a8f3-4235-b0d4-82a6e9b9bbda", "Conor McGregor vs Khabib Nurmagomedov", "https://www.youtube.com/watch?v=JuBBIJ7adjM" },
                    { new Guid("bfec4b7f-d3b2-4863-a9cc-4250911340bf"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "8144e996-a8f3-4235-b0d4-82a6e9b9bbda", "Anderson Silva vs Chael Sonnen", "https://www.youtube.com/watch?v=DpLaqnwFQEY" },
                    { new Guid("c6c9cb75-e69a-46a1-bce5-dc531657ca4c"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "8144e996-a8f3-4235-b0d4-82a6e9b9bbda", "Israel Adesanya vs Alex Pereira", "https://www.youtube.com/watch?v=yKdi_7cscd0" }
                });

            migrationBuilder.InsertData(
                table: "FightersFights",
                columns: new[] { "FightId", "FighterId" },
                values: new object[,]
                {
                    { new Guid("c6c9cb75-e69a-46a1-bce5-dc531657ca4c"), new Guid("403046cc-9ee0-4516-ae15-01c6f923e57e") },
                    { new Guid("c6c9cb75-e69a-46a1-bce5-dc531657ca4c"), new Guid("70483d62-1771-48f2-9c1b-065894373cba") },
                    { new Guid("bfec4b7f-d3b2-4863-a9cc-4250911340bf"), new Guid("9d8a21c7-7cb6-47cb-8d6b-69c2ebeb2108") },
                    { new Guid("bfec4b7f-d3b2-4863-a9cc-4250911340bf"), new Guid("b4c9996e-fd22-45ce-9657-bfe26e3505dd") },
                    { new Guid("71c20fb5-cfb9-4e1c-b48d-773b6a491f4d"), new Guid("e80733ba-f7dd-4606-bb35-a8963f64a203") },
                    { new Guid("71c20fb5-cfb9-4e1c-b48d-773b6a491f4d"), new Guid("f83610a7-261e-4322-80a7-2f5a111ce50f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("187ef30b-d99f-4ad5-b9ba-5cd607150be5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("376c73f0-2399-412b-8259-4410930fb19f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84e5851c-c7b0-4c67-b1f3-7c842e09b10e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90d86c9b-26dd-4d01-9c6f-cdc5361f2e4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c918936-c07b-44ea-baa2-7f6ab56d1a9a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e95e16bd-8376-4d2e-8b5a-c4c565ed2454"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8211693-1bcc-4775-ac9c-264168eb8502"));

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("c6c9cb75-e69a-46a1-bce5-dc531657ca4c"), new Guid("403046cc-9ee0-4516-ae15-01c6f923e57e") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("c6c9cb75-e69a-46a1-bce5-dc531657ca4c"), new Guid("70483d62-1771-48f2-9c1b-065894373cba") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("bfec4b7f-d3b2-4863-a9cc-4250911340bf"), new Guid("9d8a21c7-7cb6-47cb-8d6b-69c2ebeb2108") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("bfec4b7f-d3b2-4863-a9cc-4250911340bf"), new Guid("b4c9996e-fd22-45ce-9657-bfe26e3505dd") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("71c20fb5-cfb9-4e1c-b48d-773b6a491f4d"), new Guid("e80733ba-f7dd-4606-bb35-a8963f64a203") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("71c20fb5-cfb9-4e1c-b48d-773b6a491f4d"), new Guid("f83610a7-261e-4322-80a7-2f5a111ce50f") });

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("403046cc-9ee0-4516-ae15-01c6f923e57e"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("70483d62-1771-48f2-9c1b-065894373cba"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("9d8a21c7-7cb6-47cb-8d6b-69c2ebeb2108"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("b4c9996e-fd22-45ce-9657-bfe26e3505dd"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("e80733ba-f7dd-4606-bb35-a8963f64a203"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("f83610a7-261e-4322-80a7-2f5a111ce50f"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("71c20fb5-cfb9-4e1c-b48d-773b6a491f4d"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("bfec4b7f-d3b2-4863-a9cc-4250911340bf"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("c6c9cb75-e69a-46a1-bce5-dc531657ca4c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8144e996-a8f3-4235-b0d4-82a6e9b9bbda");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e824996-9440-4d6b-8591-b429d0211506"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ddb8628a-e3fd-4110-9bb6-e6051d77fe91"));

            migrationBuilder.DropColumn(
                name: "YouTubeUrl",
                table: "Fights");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Fighters");

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
    }
}
