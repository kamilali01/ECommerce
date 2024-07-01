using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TapAz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CategoryParameterRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Parameters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parameters_CategoryId",
                table: "Parameters",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parameters_Categories_CategoryId",
                table: "Parameters",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parameters_Categories_CategoryId",
                table: "Parameters");

            migrationBuilder.DropIndex(
                name: "IX_Parameters_CategoryId",
                table: "Parameters");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Parameters");
        }
    }
}
