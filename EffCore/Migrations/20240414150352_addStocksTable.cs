using Microsoft.EntityFrameworkCore.Migrations;

namespace EffCore.Migrations
{
    public partial class addStocksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Symbol = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Sector = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Industry = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Balance = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
