using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class iBooking_category_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_iBookings_Category_Id",
                table: "iBookings",
                column: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_iBookings_categories_Category_Id",
                table: "iBookings",
                column: "Category_Id",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_iBookings_categories_Category_Id",
                table: "iBookings");

            migrationBuilder.DropIndex(
                name: "IX_iBookings_Category_Id",
                table: "iBookings");
        }
    }
}
