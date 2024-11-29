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
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UsersFights_Fights_FightId",
                        column: x => x.FightId,
                        principalTable: "Fights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FightersFights_Fights_FightId",
                        column: x => x.FightId,
                        principalTable: "Fights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("03a1b0e5-6ae4-4221-903c-5a5c78e9fda0"), 185.0, 170.0, "Middleweight  " },
                    { new Guid("14596b08-529f-4fd3-9986-fa045dbfdf20"), 135.0, 125.0, "Bantamweight  " },
                    { new Guid("5f958e3d-8f9f-4b51-9d1a-5563d29673e7"), 265.0, 205.0, "Middleweight  " },
                    { new Guid("81541acb-1364-4330-a8b6-2eb3c9809415"), 125.0, 115.0, "Flyweight " },
                    { new Guid("9b6a5393-17a4-4248-9768-36cbae23220e"), 205.0, 185.0, "Light heavyweight " },
                    { new Guid("b20956e2-86ee-4b5d-a722-4afb5112fae6"), 155.0, 145.0, "Lightweight " },
                    { new Guid("bef25e3c-b93e-41ee-a62c-7f1099edd03a"), 115.0, 106.0, "Strawweight" },
                    { new Guid("d34e565c-9c89-4488-b43e-4ef167dd7ef7"), 145.0, 135.0, "Featherweight  " },
                    { new Guid("efd66861-4354-464e-b320-53bc5aade8d0"), 170.0, 155.0, "Welterweight  " }
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
