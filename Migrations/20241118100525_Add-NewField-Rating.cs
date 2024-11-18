using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApp.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFieldRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rating",
                value: "R");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rating",
                value: "R");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");
        }
    }
}
