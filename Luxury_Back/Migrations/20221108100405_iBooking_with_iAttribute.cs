using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class iBooking_with_iAttribute : Migration
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
                    IBookingId = table.Column<int>(type: "int", nullable: false),
                    IAttributeId = table.Column<int>(type: "int", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iBookingAttributes", x => new { x.IBookingId, x.IAttributeId });
                    table.ForeignKey(
                        name: "FK_iBookingAttributes_iAttributes_IAttributeId",
                        column: x => x.IAttributeId,
                        principalTable: "iAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_iBookingAttributes_iBookings_IBookingId",
                        column: x => x.IBookingId,
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
                name: "IX_iBookingAttributes_IAttributeId",
                table: "iBookingAttributes",
                column: "IAttributeId");
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
