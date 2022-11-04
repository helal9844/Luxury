using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class iBooking_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "iBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    cost = table.Column<int>(type: "int", nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: true),
                    space = table.Column<int>(type: "int", nullable: true),
                    kitchen = table.Column<bool>(type: "bit", nullable: true),
                    pool = table.Column<bool>(type: "bit", nullable: true),
                    bath = table.Column<bool>(type: "bit", nullable: true),
                    conditioning = table.Column<bool>(type: "bit", nullable: true),
                    w_m = table.Column<bool>(type: "bit", nullable: true),
                    wi_fi = table.Column<bool>(type: "bit", nullable: true),
                    parking = table.Column<bool>(type: "bit", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iBookings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iBookings");
        }
    }
}
