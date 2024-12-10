using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedWatchlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1c50963f-4914-44ec-ba0d-e4e516b30299", 0, "96e488b7-fe6d-422c-a434-1fe4d18fdcba", "admin@mma.com", true, false, null, "ADMIN@MMA.COM", "ADMIN@MMA.COM", "AQAAAAIAAYagAAAAECeYp0wcugCVuNWadGcY/IGLJVjSAx2ofpbGnoVLsHsK7eQUjHkzfSsbVIw8K3+aUg==", null, false, "74752dc6-3e4f-4ca5-8bcf-2cde0dd41212", false, "admin@mma.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("024d95c3-2920-401b-9543-1d3fc3cb1a91"), 185.0, 170.0, "Middleweight" },
                    { new Guid("2ba90245-5a30-42ca-9bf9-91b7032001ed"), 265.0, 205.0, "Heavyweight" },
                    { new Guid("34d8343e-e01d-44f7-93bf-f90511d5dd13"), 155.0, 145.0, "Lightweight" },
                    { new Guid("5d42f5f5-233b-45cc-93e6-73eee3c350dc"), 135.0, 125.0, "Bantamweight" },
                    { new Guid("683713ff-dd6e-4886-bd88-ea9f2c4f2ab5"), 170.0, 155.0, "Welterweight" },
                    { new Guid("a872b12f-ccee-42c6-90d5-0ba36aef3c47"), 125.0, 115.0, "Flyweight" },
                    { new Guid("b90b8326-0448-44ca-8fb4-5f7904d15fec"), 205.0, 185.0, "Light Heavyweight" },
                    { new Guid("b940ca34-e345-426d-8ee7-ae5aa0bbcfe9"), 115.0, 106.0, "Strawweight" },
                    { new Guid("db9a1e0c-02c4-4fea-85d2-641d0c7158c7"), 145.0, 135.0, "Featherweight" }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "CategoryId", "Country", "DateOfBirth", "FirstName", "Height", "ImageUrl", "IsDeleted", "LastName", "NickName", "Reach" },
                values: new object[,]
                {
                    { new Guid("43f2fe04-fcdf-40a3-9e78-d5f9f0007cf1"), new Guid("34d8343e-e01d-44f7-93bf-f90511d5dd13"), "Ireland", new DateTime(1988, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conor", 5.7999999999999998, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20220325093124_Conor_McGregor_ff.JPG", false, "McGregor", "The Notorious", 74 },
                    { new Guid("62269b9c-1c18-4c5a-8077-a24d8b7d5ff1"), new Guid("024d95c3-2920-401b-9543-1d3fc3cb1a91"), "Nigeria", new DateTime(1989, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israel", 6.4000000000000004, "https://glory.pinkyellow.network/assets/fighters/israel-the-last-style-bender-adesanya/thumbnail.jpg", false, "Adesanya", "The Last Stylebender", 80 },
                    { new Guid("69b7f934-2428-4ca6-96af-ce2c65850e4c"), new Guid("024d95c3-2920-401b-9543-1d3fc3cb1a91"), "Brazil", new DateTime(1975, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 6.2000000000000002, "https://www.denverpost.com/wp-content/uploads/2016/04/20140801_084436_anderson-silva.jpg?w=640", false, "Silva", "The Spider", 77 },
                    { new Guid("7cef6602-d0f3-4ec2-b11a-faeed4b26297"), new Guid("024d95c3-2920-401b-9543-1d3fc3cb1a91"), "Brazil", new DateTime(1987, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", 6.4000000000000004, "https://dmxg5wxfqgb4u.cloudfront.net/styles/card_advance_small_280x356/s3/2024-10/100324-Alex-Pereira-UFC-307-Press-Conference-THUMB-GettyImages-2176549340.jpg?itok=5C_djKwj", false, "Pereira", "Poatan", 79 },
                    { new Guid("d89307f5-7c46-4af9-a16e-6c31e01bb949"), new Guid("024d95c3-2920-401b-9543-1d3fc3cb1a91"), "U.S.", new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chael", 6.0999999999999996, "https://www.sherdog.com/image_crop/200/300/_images/fighter/20131219125416_chael_sonnen.JPG", false, "Sonnen", "The American Gangster", 73 },
                    { new Guid("f48d1740-1e35-4464-a4c5-2e129961a0d9"), new Guid("34d8343e-e01d-44f7-93bf-f90511d5dd13"), "Russia", new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", 5.0999999999999996, "https://www.datocms-assets.com/99008/1696277875-untitled-design-5.png", false, "Nurmagomedov", "The Eagle", 70 }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "Id", "DateOfTheFight", "Description", "ImageUrl", "IsDeleted", "PublisherId", "Title", "YouTubeUrl" },
                values: new object[,]
                {
                    { new Guid("2fe0a744-d1b0-4d8c-a6d3-61433656c80f"), new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic middleweight bout filled with drama.", "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg", false, "1c50963f-4914-44ec-ba0d-e4e516b30299", "Anderson Silva vs Chael Sonnen", "https://www.youtube.com/watch?v=DpLaqnwFQEY" },
                    { new Guid("9256519a-75f2-4b25-b1c4-36f593043f56"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thrilling bout between two fierce rivals.", "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg", false, "1c50963f-4914-44ec-ba0d-e4e516b30299", "Israel Adesanya vs Alex Pereira", "https://www.youtube.com/watch?v=yKdi_7cscd0" },
                    { new Guid("a87099fd-d283-4988-9514-cc8ca3e97311"), new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary UFC fight between two icons of the sport.", "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg", false, "1c50963f-4914-44ec-ba0d-e4e516b30299", "Conor McGregor vs Khabib Nurmagomedov", "https://www.youtube.com/watch?v=JuBBIJ7adjM" }
                });

            migrationBuilder.InsertData(
                table: "FightersFights",
                columns: new[] { "FightId", "FighterId" },
                values: new object[,]
                {
                    { new Guid("a87099fd-d283-4988-9514-cc8ca3e97311"), new Guid("43f2fe04-fcdf-40a3-9e78-d5f9f0007cf1") },
                    { new Guid("9256519a-75f2-4b25-b1c4-36f593043f56"), new Guid("62269b9c-1c18-4c5a-8077-a24d8b7d5ff1") },
                    { new Guid("2fe0a744-d1b0-4d8c-a6d3-61433656c80f"), new Guid("69b7f934-2428-4ca6-96af-ce2c65850e4c") },
                    { new Guid("9256519a-75f2-4b25-b1c4-36f593043f56"), new Guid("7cef6602-d0f3-4ec2-b11a-faeed4b26297") },
                    { new Guid("2fe0a744-d1b0-4d8c-a6d3-61433656c80f"), new Guid("d89307f5-7c46-4af9-a16e-6c31e01bb949") },
                    { new Guid("a87099fd-d283-4988-9514-cc8ca3e97311"), new Guid("f48d1740-1e35-4464-a4c5-2e129961a0d9") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ba90245-5a30-42ca-9bf9-91b7032001ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d42f5f5-233b-45cc-93e6-73eee3c350dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("683713ff-dd6e-4886-bd88-ea9f2c4f2ab5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a872b12f-ccee-42c6-90d5-0ba36aef3c47"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b90b8326-0448-44ca-8fb4-5f7904d15fec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b940ca34-e345-426d-8ee7-ae5aa0bbcfe9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db9a1e0c-02c4-4fea-85d2-641d0c7158c7"));

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("a87099fd-d283-4988-9514-cc8ca3e97311"), new Guid("43f2fe04-fcdf-40a3-9e78-d5f9f0007cf1") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("9256519a-75f2-4b25-b1c4-36f593043f56"), new Guid("62269b9c-1c18-4c5a-8077-a24d8b7d5ff1") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("2fe0a744-d1b0-4d8c-a6d3-61433656c80f"), new Guid("69b7f934-2428-4ca6-96af-ce2c65850e4c") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("9256519a-75f2-4b25-b1c4-36f593043f56"), new Guid("7cef6602-d0f3-4ec2-b11a-faeed4b26297") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("2fe0a744-d1b0-4d8c-a6d3-61433656c80f"), new Guid("d89307f5-7c46-4af9-a16e-6c31e01bb949") });

            migrationBuilder.DeleteData(
                table: "FightersFights",
                keyColumns: new[] { "FightId", "FighterId" },
                keyValues: new object[] { new Guid("a87099fd-d283-4988-9514-cc8ca3e97311"), new Guid("f48d1740-1e35-4464-a4c5-2e129961a0d9") });

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("43f2fe04-fcdf-40a3-9e78-d5f9f0007cf1"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("62269b9c-1c18-4c5a-8077-a24d8b7d5ff1"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("69b7f934-2428-4ca6-96af-ce2c65850e4c"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("7cef6602-d0f3-4ec2-b11a-faeed4b26297"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("d89307f5-7c46-4af9-a16e-6c31e01bb949"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("f48d1740-1e35-4464-a4c5-2e129961a0d9"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("2fe0a744-d1b0-4d8c-a6d3-61433656c80f"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("9256519a-75f2-4b25-b1c4-36f593043f56"));

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: new Guid("a87099fd-d283-4988-9514-cc8ca3e97311"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c50963f-4914-44ec-ba0d-e4e516b30299");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("024d95c3-2920-401b-9543-1d3fc3cb1a91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34d8343e-e01d-44f7-93bf-f90511d5dd13"));

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
        }
    }
}
