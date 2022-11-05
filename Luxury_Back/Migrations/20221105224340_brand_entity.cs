using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class brand_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "iBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "iBookings",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    name_ar = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    name_en = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    logo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_brands_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_iBookings_BrandId",
                table: "iBookings",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_brands_CategoryId",
                table: "brands",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_brands_name_ar",
                table: "brands",
                column: "name_ar",
                unique: true,
                filter: "[name_ar] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_brands_name_en",
                table: "brands",
                column: "name_en",
                unique: true,
                filter: "[name_en] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_iBookings_brands_BrandId",
                table: "iBookings",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_iBookings_brands_BrandId",
                table: "iBookings");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropIndex(
                name: "IX_iBookings_BrandId",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "iBookings");
        }
    }
}
