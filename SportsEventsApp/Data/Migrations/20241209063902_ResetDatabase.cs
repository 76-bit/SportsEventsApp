using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ResetDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FightersFights_Fighters_FighterId",
                table: "FightersFights");

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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Fighters",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Indicates wether the fighter is deleted (soft delete).");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e2fa2b79-df6d-4585-a1db-6dc94c8f164a", 0, "ba6355f9-c25a-4eec-b770-85365a4d3a60", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAEIjgalsfCD1OQAtpsOv2aEs+shOsmjTTQ72VLEcZayuYHm+M5I0ISxXEJXhyAoy6vQ==", null, false, "5b6542c6-6d7d-44a6-bcad-fac041ff689f", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("07f4a5fe-871f-436d-a14d-ce4473e0ccc0"), 185.0, 170.0, "Middleweight" },
                    { new Guid("1b6d3f72-b466-407b-bb14-d041c60ecf26"), 265.0, 205.0, "Heavyweight" },
                    { new Guid("201d8d8c-63d4-4edd-8570-6432f3a4af1e"), 170.0, 155.0, "Welterweight" },
                    { new Guid("5a8a8d22-10d5-42f1-9ea6-743185b72cd2"), 205.0, 185.0, "Light Heavyweight" },
                    { new Guid("6b4e8fcc-fee7-419b-bcf4-928fa22c8701"), 125.0, 115.0, "Flyweight" },
                    { new Guid("cc2a80a7-b4b6-4e4a-a44e-794252b11168"), 115.0, 106.0, "Strawweight" },
                    { new Guid("d7fbafb1-c274-4e63-a98c-5108626a252d"), 155.0, 145.0, "Lightweight" },
                    { new Guid("dc14374a-64c4-45db-afb5-b432032f1e76"), 145.0, 135.0, "Featherweight" },
                    { new Guid("f3c97b3f-0285-4f93-8485-4683935ac0af"), 135.0, 125.0, "Bantamweight" }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "CategoryId", "Country", "DateOfBirth", "FirstName", "Height", "ImageUrl", "IsDeleted", "LastName", "NickName", "Reach" },
                values: new object[,]
                {
                    { new Guid("0a8bd239-99c4-4e6c-90dd-5d06201d04c6"), new Guid("07f4a5fe-871f-436d-a14d-ce4473e0ccc0"), "U.S.", new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chael", 6.0999999999999996, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20131219125416_chael_sonnen.JPG", false, "Sonnen", "The American Gangster", 73 },
                    { new Guid("411eaa2b-616b-4159-8486-73a0eccefb8a"), new Guid("d7fbafb1-c274-4e63-a98c-5108626a252d"), "Russia", new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", 5.0999999999999996, "https://www.datocms-assets.com/99008/1696277875-untitled-design-5.png", false, "Nurmagomedov", "The Eagle", 70 },
                    { new Guid("469de697-3a36-4dd3-a958-160f56e92794"), new Guid("07f4a5fe-871f-436d-a14d-ce4473e0ccc0"), "Brazil", new DateTime(1975, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 6.2000000000000002, "https://www.denverpost.com/wp-content/uploads/2016/04/20140801_084436_anderson-silva.jpg?w=640", false, "Silva", "The Spider", 77 },
                    { new Guid("4a325453-826d-47f6-abf4-57f804fef821"), new Guid("07f4a5fe-871f-436d-a14d-ce4473e0ccc0"), "Brazil", new DateTime(1987, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", 6.4000000000000004, "https://dmxg5wxfqgb4u.cloudfront.net/styles/card_advance_small_280x356/s3/2024-10/100324-Alex-Pereira-UFC-307-Press-Conference-THUMB-GettyImages-2176549340.jpg?itok=5C_djKwj", false, "Pereira", "Poatan", 79 },
                    { new Guid("5467e801-6681-47ce-a4fc-9dcd5bff9f4b"), new Guid("d7fbafb1-c274-4e63-a98c-5108626a252d"), "Ireland", new DateTime(1988, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conor", 5.7999999999999998, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20220325093124_Conor_McGregor_ff.JPG", false, "McGregor", "The Notorious", 74 },
                    { new Guid("88f2fe73-6031-45ea-bbff-68aed3f75d7e"), new Guid("07f4a5fe-871f-436d-a14d-ce4473e0ccc0"), "Nigeria", new DateTime(1989, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israel", 6.4000000000000004, "https://glory.pinkyellow.network/assets/fighters/israel-the-last-style-bender-adesanya/thumbnail.jpg", false, "Adesanya", "The Last Stylebender", 80 }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title", "YouTubeUrl" },
                values: new object[,]
                {
                    { new Guid("9c6d966b-e7c1-4953-b086-e856fec37d2b"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "e2fa2b79-df6d-4585-a1db-6dc94c8f164a", "Israel Adesanya vs Alex Pereira", "https://www.youtube.com/watch?v=yKdi_7cscd0" },
                    { new Guid("c2e5872c-2210-4ef2-8224-701877a59cc8"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "e2fa2b79-df6d-4585-a1db-6dc94c8f164a", "Anderson Silva vs Chael Sonnen", "https://www.youtube.com/watch?v=DpLaqnwFQEY" },
                    { new Guid("d83c413f-c267-4a03-8e75-a9b6ec241802"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "e2fa2b79-df6d-4585-a1db-6dc94c8f164a", "Conor McGregor vs Khabib Nurmagomedov", "https://www.youtube.com/watch?v=JuBBIJ7adjM" }
                });

            migrationBuilder.InsertData(
                table: "FightersFights",
                columns: new[] { "FightId", "FighterId" },
                values: new object[,]
                {
                    { new Guid("c2e5872c-2210-4ef2-8224-701877a59cc8"), new Guid("0a8bd239-99c4-4e6c-90dd-5d06201d04c6") },
                    { new Guid("d83c413f-c267-4a03-8e75-a9b6ec241802"), new Guid("411eaa2b-616b-4159-8486-73a0eccefb8a") },
                    { new Guid("c2e5872c-2210-4ef2-8224-701877a59cc8"), new Guid("469de697-3a36-4dd3-a958-160f56e92794") },
                    { new Guid("9c6d966b-e7c1-4953-b086-e856fec37d2b"), new Guid("4a325453-826d-47f6-abf4-57f804fef821") },
                    { new Guid("d83c413f-c267-4a03-8e75-a9b6ec241802"), new Guid("5467e801-6681-47ce-a4fc-9dcd5bff9f4b") },
                    { new Guid("9c6d966b-e7c1-4953-b086-e856fec37d2b"), new Guid("88f2fe73-6031-45ea-bbff-68aed3f75d7e") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FightersFights_Fighters_FighterId",
                table: "FightersFights",
                column: "FighterId",
                principalTable: "Fighters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FightersFights_Fighters_FighterId",
                table: "FightersFights");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b6d3f72-b466-407b-bb14-d041c60ecf26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("201d8d8c-63d4-4edd-8570-6432f3a4af1e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a8a8d22-10d5-42f1-9ea6-743185b72cd2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b4e8fcc-fee7-419b-bcf4-928fa22c8701"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc2a80a7-b4b6-4e4a-a44e-794252b11168"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc14374a-64c4-45db-afb5-b432032f1e76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3c97b3f-0285-4f93-8485-4683935ac0af"));

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("c2e5872c-2210-4ef2-8224-701877a59cc8"), new Guid("0a8bd239-99c4-4e6c-90dd-5d06201d04c6") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("d83c413f-c267-4a03-8e75-a9b6ec241802"), new Guid("411eaa2b-616b-4159-8486-73a0eccefb8a") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("c2e5872c-2210-4ef2-8224-701877a59cc8"), new Guid("469de697-3a36-4dd3-a958-160f56e92794") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("9c6d966b-e7c1-4953-b086-e856fec37d2b"), new Guid("4a325453-826d-47f6-abf4-57f804fef821") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("d83c413f-c267-4a03-8e75-a9b6ec241802"), new Guid("5467e801-6681-47ce-a4fc-9dcd5bff9f4b") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("9c6d966b-e7c1-4953-b086-e856fec37d2b"), new Guid("88f2fe73-6031-45ea-bbff-68aed3f75d7e") });

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("0a8bd239-99c4-4e6c-90dd-5d06201d04c6"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("411eaa2b-616b-4159-8486-73a0eccefb8a"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("469de697-3a36-4dd3-a958-160f56e92794"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("4a325453-826d-47f6-abf4-57f804fef821"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("5467e801-6681-47ce-a4fc-9dcd5bff9f4b"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("88f2fe73-6031-45ea-bbff-68aed3f75d7e"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("9c6d966b-e7c1-4953-b086-e856fec37d2b"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("c2e5872c-2210-4ef2-8224-701877a59cc8"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("d83c413f-c267-4a03-8e75-a9b6ec241802"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2fa2b79-df6d-4585-a1db-6dc94c8f164a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07f4a5fe-871f-436d-a14d-ce4473e0ccc0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7fbafb1-c274-4e63-a98c-5108626a252d"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Fighters");

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

            migrationBuilder.AddForeignKey(
                name: "FK_FightersFights_Fighters_FighterId",
                table: "FightersFights",
                column: "FighterId",
                principalTable: "Fighters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
