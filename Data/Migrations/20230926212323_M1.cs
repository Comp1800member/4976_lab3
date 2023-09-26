using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommunityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CityName",
                value: "Prince George");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CityName",
                value: "Victora");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CityName",
                value: "Calgary");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CityName",
                value: "Edmonton");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CityName",
                value: "Medhat");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CityName",
                value: "Thunder Bay");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CityName",
                value: "Toronto");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CityName",
                value: "Guelph");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CityName",
                value: "Vancouver");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CityName",
                value: "Vancouver");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CityName",
                value: "Vancouver");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CityName",
                value: "Vancouver");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CityName",
                value: "Vancouver");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CityName",
                value: "Vancouver");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CityName",
                value: "Vancouver");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CityName",
                value: "Vancouver");
        }
    }
}
