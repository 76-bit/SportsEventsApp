using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The id of the category"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The name of the category, exemple: LightWeight, MiddleWeight...."),
                    MinWeight = table.Column<double>(type: "float", nullable: false, comment: "The minimum required weight needed to clasify as this weight, in pounds."),
                    MaxWeight = table.Column<double>(type: "float", nullable: false, comment: "The minimum required weight needed to clasify as this weight, in pounds.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Unique identifier of the fight"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "The name of the title, has a minimum and maximum characher limit"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "A brief decription of the fight details, also has a minimum and maximum characher limit"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "url of the image"),
                    DateOfTheFight = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date of the fight, not the date of its adding"),
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "The id of the admin that added the fight, note that users and guests cannot add or delete fights")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fights_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fighters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The unique identifier of the fighter"),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "First name of the fighter"),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Last name of the fighter"),
                    NickName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Nickname of the fighter"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false, comment: "The height of the fighter in cm"),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The weight class (category) of the fighter")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fighters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fighters_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersFights",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FightId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersFights", x => new { x.UserId, x.FightId });
                    table.ForeignKey(
                        name: "FK_UsersFights_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersFights_Fights_FightId",
                        column: x => x.FightId,
                        principalTable: "Fights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FightersFights",
                columns: table => new
                {
                    FighterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FightId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FightersFights", x => new { x.FighterId, x.FightId });
                    table.ForeignKey(
                        name: "FK_FightersFights_Fighters_FighterId",
                        column: x => x.FighterId,
                        principalTable: "Fighters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FightersFights_Fights_FightId",
                        column: x => x.FightId,
                        principalTable: "Fights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("2dcedebe-e294-49fa-8002-e7ba2cdece92"), 115.0, 106.0, "Strawweight" },
                    { new Guid("4bbfcd06-c89f-4749-8b06-ab9c592c226f"), 185.0, 170.0, "Middleweight  " },
                    { new Guid("62ea6f95-fe56-4e62-abc8-305cb3b502df"), 170.0, 155.0, "Welterweight  " },
                    { new Guid("aaf2d3df-93d1-48a5-be9d-7691f4c74f86"), 125.0, 115.0, "Flyweight " },
                    { new Guid("b5c2d930-7285-49c2-97e6-04ced45c1235"), 145.0, 135.0, "Featherweight  " },
                    { new Guid("d0f549d2-b1ac-4067-b896-75d39ce1c135"), 205.0, 185.0, "Light heavyweight " },
                    { new Guid("d36f037b-0335-46f4-ae64-b95aa8050327"), 265.0, 205.0, "Middleweight  " },
                    { new Guid("d4cc6824-f785-4f37-9b55-edd0ddf1c85a"), 135.0, 125.0, "Bantamweight  " },
                    { new Guid("e2dd7dab-5044-4e6d-8445-638f012645bd"), 155.0, 145.0, "Lightweight " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fighters_CategoryId",
                table: "Fighters",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FightersFights_FightId",
                table: "FightersFights",
                column: "FightId");

            migrationBuilder.CreateIndex(
                name: "IX_Fights_PublisherId",
                table: "Fights",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersFights_FightId",
                table: "UsersFights",
                column: "FightId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FightersFights");

            migrationBuilder.DropTable(
                name: "UsersFights");

            migrationBuilder.DropTable(
                name: "Fighters");

            migrationBuilder.DropTable(
                name: "Fights");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
