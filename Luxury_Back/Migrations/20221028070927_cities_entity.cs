using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class cities_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_governorates_gov_id",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "cities");

            migrationBuilder.RenameIndex(
                name: "IX_City_gov_id",
                table: "cities",
                newName: "IX_cities_gov_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cities",
                table: "cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cities_governorates_gov_id",
                table: "cities",
                column: "gov_id",
                principalTable: "governorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cities_governorates_gov_id",
                table: "cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cities",
                table: "cities");

            migrationBuilder.RenameTable(
                name: "cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_cities_gov_id",
                table: "City",
                newName: "IX_City_gov_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_City_governorates_gov_id",
                table: "City",
                column: "gov_id",
                principalTable: "governorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
