using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TapAz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AdvertPremiumExceptionFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Premiums_PremiumId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_VIPs_VipId",
                table: "Adverts");

            migrationBuilder.AlterColumn<int>(
                name: "VipId",
                table: "Adverts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PremiumId",
                table: "Adverts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Premiums_PremiumId",
                table: "Adverts",
                column: "PremiumId",
                principalTable: "Premiums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_VIPs_VipId",
                table: "Adverts",
                column: "VipId",
                principalTable: "VIPs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Premiums_PremiumId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_VIPs_VipId",
                table: "Adverts");

            migrationBuilder.AlterColumn<int>(
                name: "VipId",
                table: "Adverts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PremiumId",
                table: "Adverts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Premiums_PremiumId",
                table: "Adverts",
                column: "PremiumId",
                principalTable: "Premiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_VIPs_VipId",
                table: "Adverts",
                column: "VipId",
                principalTable: "VIPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
