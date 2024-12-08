using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedFullFighterNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "768eac92-3bf1-4fbe-bb4f-cdd028daff93", 0, "16c4e954-8e6c-4157-8566-aede5ac4e214", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAEGnKmln5CWa7dISrPIGQo8J0hyen4lwZMMyxr2qxtMOganJWrkaWVz3txgmoESqTpw==", null, false, "e0c4d36d-73a2-4394-a794-a87dcd84a8e9", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("36255963-a867-4602-86b3-8faf785cd3ff"), 205.0, 185.0, "Light Heavyweight" },
                    { new Guid("3aff3d1f-82c8-4739-aafd-5fe199c6b530"), 185.0, 170.0, "Middleweight" },
                    { new Guid("57b39e13-b12f-4d06-842e-029b65b206ec"), 115.0, 106.0, "Strawweight" },
                    { new Guid("611faa20-6348-4232-840d-159cae996863"), 145.0, 135.0, "Featherweight" },
                    { new Guid("93c90451-bcc6-4f11-98f1-10094e87ceb3"), 135.0, 125.0, "Bantamweight" },
                    { new Guid("b707fc23-4f84-43f2-ab19-c785e26db3a9"), 155.0, 145.0, "Lightweight" },
                    { new Guid("b8222d1f-2253-4e1f-94c3-dcea83a706bc"), 125.0, 115.0, "Flyweight" },
                    { new Guid("ba58d0b5-a05c-4b21-8917-7534e9b3d9ef"), 170.0, 155.0, "Welterweight" },
                    { new Guid("db87b6e1-9bce-41c7-9d9c-08922961f40a"), 265.0, 205.0, "Heavyweight" }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "CategoryId", "Country", "DateOfBirth", "FirstName", "Height", "ImageUrl", "LastName", "NickName", "Reach" },
                values: new object[,]
                {
                    { new Guid("1d871af6-cfcd-4d58-9f06-8ca66b2ddbd3"), new Guid("b707fc23-4f84-43f2-ab19-c785e26db3a9"), "Ireland", new DateTime(1988, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conor", 5.7999999999999998, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20220325093124_Conor_McGregor_ff.JPG", "McGregor", "The Notorious", 74 },
                    { new Guid("2b01d857-6d3f-4389-b7bc-99d01be4f416"), new Guid("b707fc23-4f84-43f2-ab19-c785e26db3a9"), "Russia", new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", 5.0999999999999996, "https://www.datocms-assets.com/99008/1696277875-untitled-design-5.png", "Nurmagomedov", "The Eagle", 70 },
                    { new Guid("678e1c6d-668a-4b2e-b211-d9275175112d"), new Guid("3aff3d1f-82c8-4739-aafd-5fe199c6b530"), "Brazil", new DateTime(1987, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", 6.4000000000000004, "https://dmxg5wxfqgb4u.cloudfront.net/styles/card_advance_small_280x356/s3/2024-10/100324-Alex-Pereira-UFC-307-Press-Conference-THUMB-GettyImages-2176549340.jpg?itok=5C_djKwj", "Pereira", "Poatan", 79 },
                    { new Guid("9227c063-6c2f-4a32-bff9-827de97b7496"), new Guid("3aff3d1f-82c8-4739-aafd-5fe199c6b530"), "U.S.", new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chael", 6.0999999999999996, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20131219125416_chael_sonnen.JPG", "Sonnen", "The American Gangster", 73 },
                    { new Guid("c76317ce-92be-4b00-83db-fbb16c89917e"), new Guid("3aff3d1f-82c8-4739-aafd-5fe199c6b530"), "Nigeria", new DateTime(1989, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israel", 6.4000000000000004, "https://glory.pinkyellow.network/assets/fighters/israel-the-last-style-bender-adesanya/thumbnail.jpg", "Adesanya", "The Last Stylebender", 80 },
                    { new Guid("d4b673ce-0732-4d93-a424-80676687ee52"), new Guid("3aff3d1f-82c8-4739-aafd-5fe199c6b530"), "Brazil", new DateTime(1975, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 6.2000000000000002, "https://www.denverpost.com/wp-content/uploads/2016/04/20140801_084436_anderson-silva.jpg?w=640", "Silva", "The Spider", 77 }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title", "YouTubeUrl" },
                values: new object[,]
                {
                    { new Guid("0198e85d-8055-42a7-bd9e-0dae48e25fe6"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "768eac92-3bf1-4fbe-bb4f-cdd028daff93", "Israel Adesanya vs Alex Pereira", "https://www.youtube.com/watch?v=yKdi_7cscd0" },
                    { new Guid("0b6e061b-104b-439c-90a3-f5d63ac4643a"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "768eac92-3bf1-4fbe-bb4f-cdd028daff93", "Conor McGregor vs Khabib Nurmagomedov", "https://www.youtube.com/watch?v=JuBBIJ7adjM" },
                    { new Guid("60618752-fba4-4253-a730-49f3e3b93923"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "768eac92-3bf1-4fbe-bb4f-cdd028daff93", "Anderson Silva vs Chael Sonnen", "https://www.youtube.com/watch?v=DpLaqnwFQEY" }
                });

            migrationBuilder.InsertData(
                table: "FightersFights",
                columns: new[] { "FightId", "FighterId" },
                values: new object[,]
                {
                    { new Guid("0b6e061b-104b-439c-90a3-f5d63ac4643a"), new Guid("1d871af6-cfcd-4d58-9f06-8ca66b2ddbd3") },
                    { new Guid("0b6e061b-104b-439c-90a3-f5d63ac4643a"), new Guid("2b01d857-6d3f-4389-b7bc-99d01be4f416") },
                    { new Guid("0198e85d-8055-42a7-bd9e-0dae48e25fe6"), new Guid("678e1c6d-668a-4b2e-b211-d9275175112d") },
                    { new Guid("60618752-fba4-4253-a730-49f3e3b93923"), new Guid("9227c063-6c2f-4a32-bff9-827de97b7496") },
                    { new Guid("0198e85d-8055-42a7-bd9e-0dae48e25fe6"), new Guid("c76317ce-92be-4b00-83db-fbb16c89917e") },
                    { new Guid("60618752-fba4-4253-a730-49f3e3b93923"), new Guid("d4b673ce-0732-4d93-a424-80676687ee52") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36255963-a867-4602-86b3-8faf785cd3ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57b39e13-b12f-4d06-842e-029b65b206ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("611faa20-6348-4232-840d-159cae996863"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("93c90451-bcc6-4f11-98f1-10094e87ceb3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8222d1f-2253-4e1f-94c3-dcea83a706bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba58d0b5-a05c-4b21-8917-7534e9b3d9ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db87b6e1-9bce-41c7-9d9c-08922961f40a"));

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("0b6e061b-104b-439c-90a3-f5d63ac4643a"), new Guid("1d871af6-cfcd-4d58-9f06-8ca66b2ddbd3") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("0b6e061b-104b-439c-90a3-f5d63ac4643a"), new Guid("2b01d857-6d3f-4389-b7bc-99d01be4f416") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("0198e85d-8055-42a7-bd9e-0dae48e25fe6"), new Guid("678e1c6d-668a-4b2e-b211-d9275175112d") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("60618752-fba4-4253-a730-49f3e3b93923"), new Guid("9227c063-6c2f-4a32-bff9-827de97b7496") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("0198e85d-8055-42a7-bd9e-0dae48e25fe6"), new Guid("c76317ce-92be-4b00-83db-fbb16c89917e") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("60618752-fba4-4253-a730-49f3e3b93923"), new Guid("d4b673ce-0732-4d93-a424-80676687ee52") });

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("1d871af6-cfcd-4d58-9f06-8ca66b2ddbd3"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("2b01d857-6d3f-4389-b7bc-99d01be4f416"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("678e1c6d-668a-4b2e-b211-d9275175112d"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("9227c063-6c2f-4a32-bff9-827de97b7496"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("c76317ce-92be-4b00-83db-fbb16c89917e"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("d4b673ce-0732-4d93-a424-80676687ee52"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("0198e85d-8055-42a7-bd9e-0dae48e25fe6"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("0b6e061b-104b-439c-90a3-f5d63ac4643a"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("60618752-fba4-4253-a730-49f3e3b93923"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "768eac92-3bf1-4fbe-bb4f-cdd028daff93");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3aff3d1f-82c8-4739-aafd-5fe199c6b530"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b707fc23-4f84-43f2-ab19-c785e26db3a9"));

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
    }
}
