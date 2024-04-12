using Microsoft.EntityFrameworkCore.Migrations;

namespace EffCore.Migrations
{
    public partial class EditPostProperty_and_BlogProperty_Title_Content_Url : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Posts",
                newName: "Post Title");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Blogs",
                newName: "Post Url");

            migrationBuilder.AlterColumn<string>(
                name: "Post Content",
                table: "Posts",
                type: "nvarchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Post Title",
                table: "Posts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Post Url",
                table: "Blogs",
                newName: "Url");

            migrationBuilder.AlterColumn<string>(
                name: "Post Content",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)");
        }
    }
}
