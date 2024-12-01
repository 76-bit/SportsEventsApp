using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsEventsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeletedToFight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03a1b0e5-6ae4-4221-903c-5a5c78e9fda0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14596b08-529f-4fd3-9986-fa045dbfdf20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f958e3d-8f9f-4b51-9d1a-5563d29673e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81541acb-1364-4330-a8b6-2eb3c9809415"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b6a5393-17a4-4248-9768-36cbae23220e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b20956e2-86ee-4b5d-a722-4afb5112fae6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bef25e3c-b93e-41ee-a62c-7f1099edd03a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d34e565c-9c89-4488-b43e-4ef167dd7ef7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efd66861-4354-464e-b320-53bc5aade8d0"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Fights",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "this is a bool that keeps track of the status of the fight- deleted or not (soft delete)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxWeight", "MinWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("1961c34e-6a64-460d-bdd0-8dda9ca105f5"), 265.0, 205.0, "Middleweight  " },
                    { new Guid("355c87ba-0a00-41de-939f-c17ed2eafabe"), 155.0, 145.0, "Lightweight " },
                    { new Guid("45bf043e-cb7b-4d49-8d92-a8d42fdf0297"), 125.0, 115.0, "Flyweight " },
                    { new Guid("4b8d553a-bec9-4533-91bf-443e42d9cd3f"), 185.0, 170.0, "Middleweight  " },
                    { new Guid("7588bbd8-1e48-444a-b880-984501316a07"), 145.0, 135.0, "Featherweight  " },
                    { new Guid("8136c412-a48c-48af-abf7-5507f51623ee"), 115.0, 106.0, "Strawweight" },
                    { new Guid("a94fec6b-f774-46e8-a06c-3932f5e5bafc"), 135.0, 125.0, "Bantamweight  " },
                    { new Guid("c68dd645-29f0-4704-82f3-9f963e6273d8"), 205.0, 185.0, "Light heavyweight " },
                    { new Guid("f128172c-aa37-41b2-8a0c-2ae1a22f8d57"), 170.0, 155.0, "Welterweight  " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1961c34e-6a64-460d-bdd0-8dda9ca105f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("355c87ba-0a00-41de-939f-c17ed2eafabe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45bf043e-cb7b-4d49-8d92-a8d42fdf0297"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b8d553a-bec9-4533-91bf-443e42d9cd3f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7588bbd8-1e48-444a-b880-984501316a07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8136c412-a48c-48af-abf7-5507f51623ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a94fec6b-f774-46e8-a06c-3932f5e5bafc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c68dd645-29f0-4704-82f3-9f963e6273d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f128172c-aa37-41b2-8a0c-2ae1a22f8d57"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Fights");

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
        }
    }
}
