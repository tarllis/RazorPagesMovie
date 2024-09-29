using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesMovie.Migrations
{
    /// <inheritdoc />
    public partial class Rating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movie",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Movie",
                newName: "Data");

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movie",
                type: "nvchar(50)",
                nullable: false,
                defaultValue: "");
        }
             protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Movie",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Movie",
                newName: "Date");
        }
    }
}
