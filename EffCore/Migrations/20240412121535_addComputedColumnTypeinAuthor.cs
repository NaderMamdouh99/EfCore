using Microsoft.EntityFrameworkCore.Migrations;

namespace EffCore.Migrations
{
    public partial class addComputedColumnTypeinAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[LastName] + ', ' + [FirstName]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Authors");
        }
    }
}
