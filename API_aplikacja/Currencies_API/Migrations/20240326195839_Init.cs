using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Currencies_API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    timestamp = table.Column<int>(type: "INTEGER", nullable: true),
                    @base = table.Column<string>(name: "base", type: "TEXT", nullable: true),
                    date_cur = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    EUR = table.Column<double>(type: "REAL", nullable: false),
                    GBP = table.Column<double>(type: "REAL", nullable: false),
                    PLN = table.Column<double>(type: "REAL", nullable: false),
                    CZK = table.Column<double>(type: "REAL", nullable: false),
                    CHF = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rates_data_Id",
                        column: x => x.Id,
                        principalTable: "data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "data");
        }
    }
}
