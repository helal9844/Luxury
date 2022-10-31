using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class category_parent_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_categories_ParentId",
                table: "categories");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "categories",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_categories_ParentId",
                table: "categories",
                newName: "IX_categories_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_categories_CategoryId",
                table: "categories",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_categories_CategoryId",
                table: "categories");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "categories",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_categories_CategoryId",
                table: "categories",
                newName: "IX_categories_ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_categories_ParentId",
                table: "categories",
                column: "ParentId",
                principalTable: "categories",
                principalColumn: "Id");
        }
    }
}
