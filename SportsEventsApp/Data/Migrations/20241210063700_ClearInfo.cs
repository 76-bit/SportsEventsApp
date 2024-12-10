using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ClearInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersFights_AspNetUsers_UserId",
                table: "UsersFights");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFights_Fights_FightId",
                table: "UsersFights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersFights",
                table: "UsersFights");

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

            migrationBuilder.AddColumn<string>(
                name: "ListType",
                table: "UsersFights",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Indicates whether the fight is in the user's Watchlist or Favorites");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersFights",
                table: "UsersFights",
                columns: new[] { "UserId", "FightId", "ListType" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "40897789-0c7c-4c6e-ba51-9bef53f3857a", 0, "f2d08bdf-5a0a-481a-9f78-f61c7de1603b", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAEEnCM+EI5/ZnasFKomCRurtWKToMb+OaRg30CaNp7q/8VknQRa3p7J/QBJTPf6otrg==", null, false, "7c1a6dee-e7ea-4be9-98ff-a3a434aba917", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("1d8e06f1-8a66-42a5-9ed1-c22068a602f1"), 170.0, 155.0, "Welterweight" },
                    { new Guid("1de95a26-05ea-4b66-82f1-c0c912ac1780"), 185.0, 170.0, "Middleweight" },
                    { new Guid("1f80fdd2-e931-4e70-8432-8f25cb3569c1"), 145.0, 135.0, "Featherweight" },
                    { new Guid("282b2512-55ad-46ff-b251-464ebbd8bf79"), 125.0, 115.0, "Flyweight" },
                    { new Guid("39cd5933-0c36-4049-9122-d40c88524b23"), 115.0, 106.0, "Strawweight" },
                    { new Guid("4af1cb43-9d27-4f7a-8d81-e0af441ee1ec"), 155.0, 145.0, "Lightweight" },
                    { new Guid("7bfdc7d9-8eab-43e1-b162-726127c9f755"), 135.0, 125.0, "Bantamweight" },
                    { new Guid("bce83443-00cf-4522-84f7-0ab4062141cf"), 205.0, 185.0, "Light Heavyweight" },
                    { new Guid("fb4c64cd-67f0-45b7-acf3-759ed5f3307f"), 265.0, 205.0, "Heavyweight" }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "CategoryId", "Country", "DateOfBirth", "FirstName", "Height", "ImageUrl", "IsDeleted", "LastName", "NickName", "Reach" },
                values: new object[,]
                {
                    { new Guid("4c415431-534f-45da-b04f-5af0130c0593"), new Guid("4af1cb43-9d27-4f7a-8d81-e0af441ee1ec"), "Ireland", new DateTime(1988, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conor", 5.7999999999999998, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20220325093124_Conor_McGregor_ff.JPG", false, "McGregor", "The Notorious", 74 },
                    { new Guid("a593799f-c4b5-43f7-a19d-f2f0b4d388e2"), new Guid("1de95a26-05ea-4b66-82f1-c0c912ac1780"), "Brazil", new DateTime(1987, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", 6.4000000000000004, "https://dmxg5wxfqgb4u.cloudfront.net/styles/card_advance_small_280x356/s3/2024-10/100324-Alex-Pereira-UFC-307-Press-Conference-THUMB-GettyImages-2176549340.jpg?itok=5C_djKwj", false, "Pereira", "Poatan", 79 },
                    { new Guid("c58ca473-6b7d-457b-b221-155b1cf97a2a"), new Guid("1de95a26-05ea-4b66-82f1-c0c912ac1780"), "Brazil", new DateTime(1975, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 6.2000000000000002, "https://www.denverpost.com/wp-content/uploads/2016/04/20140801_084436_anderson-silva.jpg?w=640", false, "Silva", "The Spider", 77 },
                    { new Guid("ccfae67c-d409-4084-a27a-eb1042b917bf"), new Guid("1de95a26-05ea-4b66-82f1-c0c912ac1780"), "Nigeria", new DateTime(1989, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israel", 6.4000000000000004, "https://glory.pinkyellow.network/assets/fighters/israel-the-last-style-bender-adesanya/thumbnail.jpg", false, "Adesanya", "The Last Stylebender", 80 },
                    { new Guid("ec004262-6905-4b60-b996-80bf229c8b0d"), new Guid("1de95a26-05ea-4b66-82f1-c0c912ac1780"), "U.S.", new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chael", 6.0999999999999996, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20131219125416_chael_sonnen.JPG", false, "Sonnen", "The American Gangster", 73 },
                    { new Guid("ee4aea7a-f7cc-4727-b233-d78685283a86"), new Guid("4af1cb43-9d27-4f7a-8d81-e0af441ee1ec"), "Russia", new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", 5.0999999999999996, "https://www.datocms-assets.com/99008/1696277875-untitled-design-5.png", false, "Nurmagomedov", "The Eagle", 70 }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title", "YouTubeUrl" },
                values: new object[,]
                {
                    { new Guid("1ab04830-9655-4064-a4a9-907a4454185b"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "40897789-0c7c-4c6e-ba51-9bef53f3857a", "Conor McGregor vs Khabib Nurmagomedov", "https://www.youtube.com/watch?v=JuBBIJ7adjM" },
                    { new Guid("3c367b70-fb1e-48cc-a40e-847e07a3a8d3"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "40897789-0c7c-4c6e-ba51-9bef53f3857a", "Israel Adesanya vs Alex Pereira", "https://www.youtube.com/watch?v=yKdi_7cscd0" },
                    { new Guid("a19b3d06-a213-4ac3-837c-f5ae4f87c133"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "40897789-0c7c-4c6e-ba51-9bef53f3857a", "Anderson Silva vs Chael Sonnen", "https://www.youtube.com/watch?v=DpLaqnwFQEY" }
                });

            migrationBuilder.InsertData(
                table: "FightersFights",
                columns: new[] { "FightId", "FighterId" },
                values: new object[,]
                {
                    { new Guid("1ab04830-9655-4064-a4a9-907a4454185b"), new Guid("4c415431-534f-45da-b04f-5af0130c0593") },
                    { new Guid("3c367b70-fb1e-48cc-a40e-847e07a3a8d3"), new Guid("a593799f-c4b5-43f7-a19d-f2f0b4d388e2") },
                    { new Guid("a19b3d06-a213-4ac3-837c-f5ae4f87c133"), new Guid("c58ca473-6b7d-457b-b221-155b1cf97a2a") },
                    { new Guid("3c367b70-fb1e-48cc-a40e-847e07a3a8d3"), new Guid("ccfae67c-d409-4084-a27a-eb1042b917bf") },
                    { new Guid("a19b3d06-a213-4ac3-837c-f5ae4f87c133"), new Guid("ec004262-6905-4b60-b996-80bf229c8b0d") },
                    { new Guid("1ab04830-9655-4064-a4a9-907a4454185b"), new Guid("ee4aea7a-f7cc-4727-b233-d78685283a86") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFights_AspNetUsers_UserId",
                table: "UsersFights",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFights_Fights_FightId",
                table: "UsersFights",
                column: "FightId",
                principalTable: "Fights",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersFights_AspNetUsers_UserId",
                table: "UsersFights");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFights_Fights_FightId",
                table: "UsersFights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersFights",
                table: "UsersFights");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d8e06f1-8a66-42a5-9ed1-c22068a602f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f80fdd2-e931-4e70-8432-8f25cb3569c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("282b2512-55ad-46ff-b251-464ebbd8bf79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39cd5933-0c36-4049-9122-d40c88524b23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bfdc7d9-8eab-43e1-b162-726127c9f755"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bce83443-00cf-4522-84f7-0ab4062141cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb4c64cd-67f0-45b7-acf3-759ed5f3307f"));

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("1ab04830-9655-4064-a4a9-907a4454185b"), new Guid("4c415431-534f-45da-b04f-5af0130c0593") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("3c367b70-fb1e-48cc-a40e-847e07a3a8d3"), new Guid("a593799f-c4b5-43f7-a19d-f2f0b4d388e2") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("a19b3d06-a213-4ac3-837c-f5ae4f87c133"), new Guid("c58ca473-6b7d-457b-b221-155b1cf97a2a") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("3c367b70-fb1e-48cc-a40e-847e07a3a8d3"), new Guid("ccfae67c-d409-4084-a27a-eb1042b917bf") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("a19b3d06-a213-4ac3-837c-f5ae4f87c133"), new Guid("ec004262-6905-4b60-b996-80bf229c8b0d") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("1ab04830-9655-4064-a4a9-907a4454185b"), new Guid("ee4aea7a-f7cc-4727-b233-d78685283a86") });

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("4c415431-534f-45da-b04f-5af0130c0593"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("a593799f-c4b5-43f7-a19d-f2f0b4d388e2"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("c58ca473-6b7d-457b-b221-155b1cf97a2a"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("ccfae67c-d409-4084-a27a-eb1042b917bf"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("ec004262-6905-4b60-b996-80bf229c8b0d"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("ee4aea7a-f7cc-4727-b233-d78685283a86"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("1ab04830-9655-4064-a4a9-907a4454185b"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("3c367b70-fb1e-48cc-a40e-847e07a3a8d3"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("a19b3d06-a213-4ac3-837c-f5ae4f87c133"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40897789-0c7c-4c6e-ba51-9bef53f3857a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1de95a26-05ea-4b66-82f1-c0c912ac1780"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4af1cb43-9d27-4f7a-8d81-e0af441ee1ec"));

            migrationBuilder.DropColumn(
                name: "ListType",
                table: "UsersFights");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersFights",
                table: "UsersFights",
                columns: new[] { "UserId", "FightId" });

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
                name: "FK_UsersFights_AspNetUsers_UserId",
                table: "UsersFights",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFights_Fights_FightId",
                table: "UsersFights",
                column: "FightId",
                principalTable: "Fights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
