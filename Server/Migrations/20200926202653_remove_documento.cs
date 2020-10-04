using Microsoft.EntityFrameworkCore.Migrations;

namespace blazormysql2.Server.Migrations
{
    public partial class remove_documento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
