using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TapAz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Categories_CategoryId",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Cities_CityId",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Premiums_PremiumId",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Stores_StoreId",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Users_UserId",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_Advert_VIPs_VipId",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertQuestion_Advert_AdvertId",
                table: "AdvertQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertQuestion",
                table: "AdvertQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advert",
                table: "Advert");

            migrationBuilder.RenameTable(
                name: "AdvertQuestion",
                newName: "AdvertQuestions");

            migrationBuilder.RenameTable(
                name: "Advert",
                newName: "Adverts");

            migrationBuilder.RenameIndex(
                name: "IX_AdvertQuestion_AdvertId",
                table: "AdvertQuestions",
                newName: "IX_AdvertQuestions_AdvertId");

            migrationBuilder.RenameIndex(
                name: "IX_Advert_VipId",
                table: "Adverts",
                newName: "IX_Adverts_VipId");

            migrationBuilder.RenameIndex(
                name: "IX_Advert_UserId",
                table: "Adverts",
                newName: "IX_Adverts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Advert_StoreId",
                table: "Adverts",
                newName: "IX_Adverts_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Advert_PremiumId",
                table: "Adverts",
                newName: "IX_Adverts_PremiumId");

            migrationBuilder.RenameIndex(
                name: "IX_Advert_CityId",
                table: "Adverts",
                newName: "IX_Adverts_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Advert_CategoryId",
                table: "Adverts",
                newName: "IX_Adverts_CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Users",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertQuestions",
                table: "AdvertQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adverts",
                table: "Adverts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertQuestions_Adverts_AdvertId",
                table: "AdvertQuestions",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Categories_CategoryId",
                table: "Adverts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Cities_CityId",
                table: "Adverts",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Premiums_PremiumId",
                table: "Adverts",
                column: "PremiumId",
                principalTable: "Premiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Stores_StoreId",
                table: "Adverts",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Users_UserId",
                table: "Adverts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_VIPs_VipId",
                table: "Adverts",
                column: "VipId",
                principalTable: "VIPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertQuestions_Adverts_AdvertId",
                table: "AdvertQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Categories_CategoryId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Cities_CityId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Premiums_PremiumId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Stores_StoreId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Users_UserId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_VIPs_VipId",
                table: "Adverts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adverts",
                table: "Adverts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertQuestions",
                table: "AdvertQuestions");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Adverts",
                newName: "Advert");

            migrationBuilder.RenameTable(
                name: "AdvertQuestions",
                newName: "AdvertQuestion");

            migrationBuilder.RenameIndex(
                name: "IX_Adverts_VipId",
                table: "Advert",
                newName: "IX_Advert_VipId");

            migrationBuilder.RenameIndex(
                name: "IX_Adverts_UserId",
                table: "Advert",
                newName: "IX_Advert_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Adverts_StoreId",
                table: "Advert",
                newName: "IX_Advert_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Adverts_PremiumId",
                table: "Advert",
                newName: "IX_Advert_PremiumId");

            migrationBuilder.RenameIndex(
                name: "IX_Adverts_CityId",
                table: "Advert",
                newName: "IX_Advert_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Adverts_CategoryId",
                table: "Advert",
                newName: "IX_Advert_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvertQuestions_AdvertId",
                table: "AdvertQuestion",
                newName: "IX_AdvertQuestion_AdvertId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advert",
                table: "Advert",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertQuestion",
                table: "AdvertQuestion",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Categories_CategoryId",
                table: "Advert",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Cities_CityId",
                table: "Advert",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Premiums_PremiumId",
                table: "Advert",
                column: "PremiumId",
                principalTable: "Premiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Stores_StoreId",
                table: "Advert",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Users_UserId",
                table: "Advert",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_VIPs_VipId",
                table: "Advert",
                column: "VipId",
                principalTable: "VIPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertQuestion_Advert_AdvertId",
                table: "AdvertQuestion",
                column: "AdvertId",
                principalTable: "Advert",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
