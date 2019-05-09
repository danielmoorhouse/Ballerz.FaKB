using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Football.Migrations
{
    public partial class _32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Profile",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_ApplicationUserId",
                table: "Profile",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_AspNetUsers_ApplicationUserId",
                table: "Profile",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_AspNetUsers_ApplicationUserId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_ApplicationUserId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Profile");
        }
    }
}
