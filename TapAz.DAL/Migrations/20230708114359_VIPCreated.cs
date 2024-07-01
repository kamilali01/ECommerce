using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TapAz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class VIPCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_VIP_VipId",
                table: "Advert");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VIP",
                table: "VIP");

            migrationBuilder.RenameTable(
                name: "VIP",
                newName: "VIPs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VIPs",
                table: "VIPs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_VIPs_VipId",
                table: "Advert",
                column: "VipId",
                principalTable: "VIPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_VIPs_VipId",
                table: "Advert");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VIPs",
                table: "VIPs");

            migrationBuilder.RenameTable(
                name: "VIPs",
                newName: "VIP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VIP",
                table: "VIP",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_VIP_VipId",
                table: "Advert",
                column: "VipId",
                principalTable: "VIP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
