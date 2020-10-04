using Microsoft.EntityFrameworkCore.Migrations;

namespace blazormysql2.Server.Migrations
{
    public partial class user_documento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // ALTER TABLE Users ADD COLUMN Documento VARCHAR(255) NULL;
            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Users");
        }
    }
}
