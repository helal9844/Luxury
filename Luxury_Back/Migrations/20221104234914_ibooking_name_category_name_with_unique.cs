using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class ibooking_name_category_name_with_unique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<string>(
                name: "name_ar",
                table: "iBookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name_en",
                table: "iBookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
               name: "description_ar",
               table: "iBookings",
               type: "nvarchar(max)",
               nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description_en",
                table: "iBookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name_en",
                table: "categories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "name_ar",
                table: "categories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_iBookings_name_ar",
                table: "iBookings",
                column: "name_ar",
                unique: true,
                filter: "[name_ar] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_iBookings_name_en",
                table: "iBookings",
                column: "name_en",
                unique: true,
                filter: "[name_en] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_categories_name_ar",
                table: "categories",
                column: "name_ar",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_name_en",
                table: "categories",
                column: "name_en",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_iBookings_name_ar",
                table: "iBookings");

            migrationBuilder.DropIndex(
                name: "IX_iBookings_name_en",
                table: "iBookings");

            migrationBuilder.DropIndex(
                name: "IX_categories_name_ar",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_name_en",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "description_ar",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "description_en",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "name_ar",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "name_en",
                table: "iBookings");

            migrationBuilder.AlterColumn<string>(
                name: "name_en",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "name_ar",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
