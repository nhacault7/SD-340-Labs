using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAnnotations.Migrations
{
    public partial class FixClientIdPropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Client",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Client",
                newName: "id");
        }
    }
}
