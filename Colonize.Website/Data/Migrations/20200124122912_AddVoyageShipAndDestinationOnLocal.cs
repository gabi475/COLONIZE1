using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class AddVoyageShipAndDestinationOnLocal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor", "https://via.placeholder.com/480x360.png?text=Moon", "Moon" },
                    { 2, "Lorem ipsum dolor", "https://via.placeholder.com/480x360.png?text=Mars", "Mars" }
                });

            migrationBuilder.UpdateData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://via.placeholder.com/480x360.png?text=Moonshot");

            migrationBuilder.InsertData(
                table: "Ship",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "PassengerCapacity" },
                values: new object[] { 2, "Lorem ipsum dolor", "https://via.placeholder.com/480x360.png?text=Mars+Explorer", "Mars Explorer", 2800 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://via.placeholder.com/480x360.png?text=Moon");
        }
    }
}
