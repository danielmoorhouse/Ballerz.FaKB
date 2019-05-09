using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Football.Migrations
{
    public partial class _30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountriesId",
                table: "Competitions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_CompTypeId",
                table: "Competitions",
                column: "CompTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_CountriesId",
                table: "Competitions",
                column: "CountriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_CompType_CompTypeId",
                table: "Competitions",
                column: "CompTypeId",
                principalTable: "CompType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_Countries_CountriesId",
                table: "Competitions",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_CompType_CompTypeId",
                table: "Competitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_Countries_CountriesId",
                table: "Competitions");

            migrationBuilder.DropIndex(
                name: "IX_Competitions_CompTypeId",
                table: "Competitions");

            migrationBuilder.DropIndex(
                name: "IX_Competitions_CountriesId",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "CountriesId",
                table: "Competitions");
        }
    }
}
