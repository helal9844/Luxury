using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class language_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "languages",
                columns: new[]
                {
                    "name",
                    "locale",
                },
                values: new object[,]
                {
                    {"Arabic", "ar"},{"English", "en"},
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
