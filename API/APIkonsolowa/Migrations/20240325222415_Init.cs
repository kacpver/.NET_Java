using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIkonsolowa.Migrations
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
                    timestamp = table.Column<int>(type: "INTEGER", nullable: false),
                    @base = table.Column<string>(name: "base", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EUR = table.Column<double>(type: "REAL", nullable: false),
                    CZK = table.Column<double>(type: "REAL", nullable: false),
                    PLN = table.Column<double>(type: "REAL", nullable: false),
                    GBP = table.Column<double>(type: "REAL", nullable: false),
                    dataId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rates_data_dataId",
                        column: x => x.dataId,
                        principalTable: "data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_rates_dataId",
                table: "rates",
                column: "dataId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rates");

            migrationBuilder.DropTable(
                name: "data");
        }
    }
}
