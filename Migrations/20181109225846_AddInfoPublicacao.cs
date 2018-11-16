using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class AddInfoPublicacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataPublicacao",
                table: "posts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Publicado",
                table: "posts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPublicacao",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "Publicado",
                table: "posts");
        }
    }
}
