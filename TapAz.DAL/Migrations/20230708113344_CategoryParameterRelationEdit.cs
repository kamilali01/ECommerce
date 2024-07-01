using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TapAz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CategoryParameterRelationEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CategoryParameter",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ParametersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryParameter", x => new { x.CategoriesId, x.ParametersId });
                    table.ForeignKey(
                        name: "FK_CategoryParameter_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryParameter_Parameters_ParametersId",
                        column: x => x.ParametersId,
                        principalTable: "Parameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryParameter_ParametersId",
                table: "CategoryParameter",
                column: "ParametersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryParameter");

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
    }
}
