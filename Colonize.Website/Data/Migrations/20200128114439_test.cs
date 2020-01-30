using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voyages_Destination_DestinationId",
                table: "Voyages");

            migrationBuilder.DropForeignKey(
                name: "FK_Voyages_Ship_ShipId",
                table: "Voyages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voyages",
                table: "Voyages");

            migrationBuilder.RenameTable(
                name: "Voyages",
                newName: "Voyage");

            migrationBuilder.RenameIndex(
                name: "IX_Voyages_ShipId",
                table: "Voyage",
                newName: "IX_Voyage_ShipId");

            migrationBuilder.RenameIndex(
                name: "IX_Voyages_DestinationId",
                table: "Voyage",
                newName: "IX_Voyage_DestinationId");

            migrationBuilder.AlterColumn<int>(
                name: "ShipId",
                table: "Voyage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "Voyage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voyage",
                table: "Voyage",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Voyage",
                columns: new[] { "Id", "ArrivalAt", "DepartureAt", "DestinationId", "ShipId" },
                values: new object[] { 1, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "Voyage",
                columns: new[] { "Id", "ArrivalAt", "DepartureAt", "DestinationId", "ShipId" },
                values: new object[] { 2, new DateTime(2029, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage",
                column: "ShipId",
                principalTable: "Ship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage");

            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voyage",
                table: "Voyage");

            migrationBuilder.DeleteData(
                table: "Voyage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voyage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Voyage",
                newName: "Voyages");

            migrationBuilder.RenameIndex(
                name: "IX_Voyage_ShipId",
                table: "Voyages",
                newName: "IX_Voyages_ShipId");

            migrationBuilder.RenameIndex(
                name: "IX_Voyage_DestinationId",
                table: "Voyages",
                newName: "IX_Voyages_DestinationId");

            migrationBuilder.AlterColumn<int>(
                name: "ShipId",
                table: "Voyages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "Voyages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voyages",
                table: "Voyages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Voyages_Destination_DestinationId",
                table: "Voyages",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Voyages_Ship_ShipId",
                table: "Voyages",
                column: "ShipId",
                principalTable: "Ship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
