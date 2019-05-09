using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Football.Migrations
{
    public partial class _33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountriesId",
                table: "Profile",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_ClubId",
                table: "Profile",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_CountriesId",
                table: "Profile",
                column: "CountriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Clubs_ClubId",
                table: "Profile",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Countries_CountriesId",
                table: "Profile",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Clubs_ClubId",
                table: "Profile");

            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Countries_CountriesId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_ClubId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_CountriesId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "CountriesId",
                table: "Profile");
        }
    }
}
