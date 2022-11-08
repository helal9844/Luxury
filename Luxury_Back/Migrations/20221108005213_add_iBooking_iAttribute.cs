using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class add_iBooking_iAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "iAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_ar = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    name_en = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "iBookingAttributes",
                columns: table => new
                {
                    iAttributesId = table.Column<int>(type: "int", nullable: false),
                    iBookingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iBookingAttributes", x => new { x.iAttributesId, x.iBookingsId });
                    table.ForeignKey(
                        name: "FK_iBookingAttributes_iAttributes_iAttributesId",
                        column: x => x.iAttributesId,
                        principalTable: "iAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_iBookingAttributes_iBookings_iBookingsId",
                        column: x => x.iBookingsId,
                        principalTable: "iBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_iAttributes_name_ar",
                table: "iAttributes",
                column: "name_ar",
                unique: true,
                filter: "[name_ar] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_iAttributes_name_en",
                table: "iAttributes",
                column: "name_en",
                unique: true,
                filter: "[name_en] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_iBookingAttributes_iBookingsId",
                table: "iBookingAttributes",
                column: "iBookingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iBookingAttributes");

            migrationBuilder.DropTable(
                name: "iAttributes");
        }
    }
}
