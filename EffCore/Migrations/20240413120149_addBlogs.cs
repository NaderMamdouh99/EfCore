using Microsoft.EntityFrameworkCore.Migrations;

namespace EffCore.Migrations
{
    public partial class addBlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Post Url" },
                values: new object[] { 1, "Www.google.com" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Post Url" },
                values: new object[] { 2, "Www.facebook.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
