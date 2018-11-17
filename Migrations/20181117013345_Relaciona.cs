using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class Relaciona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_posts_AutorId",
                table: "posts",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_usuarios_AutorId",
                table: "posts",
                column: "AutorId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_usuarios_AutorId",
                table: "posts");

            migrationBuilder.DropIndex(
                name: "IX_posts_AutorId",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "posts");
        }
    }
}
