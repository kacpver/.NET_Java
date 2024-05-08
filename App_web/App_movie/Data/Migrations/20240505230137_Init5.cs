using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App_movie.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountRate",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "SumOfRate",
                table: "Movie",
                type: "real",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountRate",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "SumOfRate",
                table: "Movie");
        }
    }
}
