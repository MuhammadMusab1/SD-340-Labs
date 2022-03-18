using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAnnotationLab.Migrations
{
    public partial class AddMultipleOneToOneRelationshipBetweenClientAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentClientId",
                table: "Room",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentRoomId",
                table: "Room",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviousClientId",
                table: "Room",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviousRoomId",
                table: "Room",
                type: "int",
                nullable: true);

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
                name: "IX_Room_CurrentRoomId",
                table: "Room",
                column: "CurrentRoomId",
                unique: true,
                filter: "[CurrentRoomId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Room_PreviousRoomId",
                table: "Room",
                column: "PreviousRoomId",
                unique: true,
                filter: "[PreviousRoomId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Client_CurrentRoomId",
                table: "Room",
                column: "CurrentRoomId",
                principalTable: "Client",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Client_PreviousRoomId",
                table: "Room",
                column: "PreviousRoomId",
                principalTable: "Client",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Client_CurrentRoomId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Client_PreviousRoomId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Room_CurrentRoomId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Room_PreviousRoomId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "CurrentClientId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "CurrentRoomId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "PreviousClientId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "PreviousRoomId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "CurrentRoomId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "PreviousRoomId",
                table: "Client");
        }
    }
}
