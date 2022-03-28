using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAnnotations.Migrations
{
    public partial class AddClientRoomTypePropertiesToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentClientId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PreviousClientId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentRoomId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PreviousRoomId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CurrentClientId",
                table: "Rooms",
                column: "CurrentClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_PreviousClientId",
                table: "Rooms",
                column: "PreviousClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Client_CurrentClientId",
                table: "Rooms",
                column: "CurrentClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Client_PreviousClientId",
                table: "Rooms",
                column: "PreviousClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Client_CurrentClientId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Client_PreviousClientId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_CurrentClientId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_PreviousClientId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CurrentClientId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "PreviousClientId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CurrentRoomId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "PreviousRoomId",
                table: "Client");
        }
    }
}
