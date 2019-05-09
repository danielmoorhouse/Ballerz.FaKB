using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Football.Migrations
{
    public partial class _31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountriesId",
                table: "Stadiums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContinentsId",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountriesId",
                table: "ClubPeople",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_CountriesId",
                table: "Stadiums",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_StadiumImages_StadiumId",
                table: "StadiumImages",
                column: "StadiumId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentsId",
                table: "Countries",
                column: "ContinentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPersonImages_ClubPersonId",
                table: "ClubPersonImages",
                column: "ClubPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPersonHistory_ClubPersonId",
                table: "ClubPersonHistory",
                column: "ClubPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPeople_ClubId",
                table: "ClubPeople",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPeople_ClubRoleId",
                table: "ClubPeople",
                column: "ClubRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPeople_CountriesId",
                table: "ClubPeople",
                column: "CountriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPeople_Clubs_ClubId",
                table: "ClubPeople",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPeople_ClubRoles_ClubRoleId",
                table: "ClubPeople",
                column: "ClubRoleId",
                principalTable: "ClubRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPeople_Countries_CountriesId",
                table: "ClubPeople",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPersonHistory_ClubPeople_ClubPersonId",
                table: "ClubPersonHistory",
                column: "ClubPersonId",
                principalTable: "ClubPeople",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPersonImages_ClubPeople_ClubPersonId",
                table: "ClubPersonImages",
                column: "ClubPersonId",
                principalTable: "ClubPeople",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Continents_ContinentsId",
                table: "Countries",
                column: "ContinentsId",
                principalTable: "Continents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StadiumImages_Stadiums_StadiumId",
                table: "StadiumImages",
                column: "StadiumId",
                principalTable: "Stadiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stadiums_Countries_CountriesId",
                table: "Stadiums",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClubPeople_Clubs_ClubId",
                table: "ClubPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPeople_ClubRoles_ClubRoleId",
                table: "ClubPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPeople_Countries_CountriesId",
                table: "ClubPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPersonHistory_ClubPeople_ClubPersonId",
                table: "ClubPersonHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPersonImages_ClubPeople_ClubPersonId",
                table: "ClubPersonImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Continents_ContinentsId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_StadiumImages_Stadiums_StadiumId",
                table: "StadiumImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Stadiums_Countries_CountriesId",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Stadiums_CountriesId",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_StadiumImages_StadiumId",
                table: "StadiumImages");

            migrationBuilder.DropIndex(
                name: "IX_Countries_ContinentsId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_ClubPersonImages_ClubPersonId",
                table: "ClubPersonImages");

            migrationBuilder.DropIndex(
                name: "IX_ClubPersonHistory_ClubPersonId",
                table: "ClubPersonHistory");

            migrationBuilder.DropIndex(
                name: "IX_ClubPeople_ClubId",
                table: "ClubPeople");

            migrationBuilder.DropIndex(
                name: "IX_ClubPeople_ClubRoleId",
                table: "ClubPeople");

            migrationBuilder.DropIndex(
                name: "IX_ClubPeople_CountriesId",
                table: "ClubPeople");

            migrationBuilder.DropColumn(
                name: "CountriesId",
                table: "Stadiums");

            migrationBuilder.DropColumn(
                name: "ContinentsId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CountriesId",
                table: "ClubPeople");
        }
    }
}
