using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class BlogVeWriter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterId",
                table: "blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_WriterId",
                table: "blogs",
                column: "WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_writers_WriterId",
                table: "blogs",
                column: "WriterId",
                principalTable: "writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_writers_WriterId",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_WriterId",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "WriterId",
                table: "blogs");
        }
    }
}
