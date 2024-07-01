using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TapAz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class PremiumCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Premium_PremiumId",
                table: "Advert");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Premium",
                table: "Premium");

            migrationBuilder.RenameTable(
                name: "Premium",
                newName: "Premiums");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Premiums",
                table: "Premiums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Premiums_PremiumId",
                table: "Advert",
                column: "PremiumId",
                principalTable: "Premiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Premiums_PremiumId",
                table: "Advert");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Premiums",
                table: "Premiums");

            migrationBuilder.RenameTable(
                name: "Premiums",
                newName: "Premium");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Premium",
                table: "Premium",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Premium_PremiumId",
                table: "Advert",
                column: "PremiumId",
                principalTable: "Premium",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
