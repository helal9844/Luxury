using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class remove_iBooking_attribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iBookingAttributes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "iBookingAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IBookingId = table.Column<int>(type: "int", nullable: true),
                    balcony = table.Column<bool>(type: "bit", nullable: true),
                    bath = table.Column<bool>(type: "bit", nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: true),
                    city_view = table.Column<bool>(type: "bit", nullable: true),
                    conditioning = table.Column<bool>(type: "bit", nullable: true),
                    cost = table.Column<int>(type: "int", nullable: true),
                    kitchen = table.Column<bool>(type: "bit", nullable: true),
                    p_bath = table.Column<bool>(type: "bit", nullable: true),
                    parking = table.Column<bool>(type: "bit", nullable: true),
                    pool = table.Column<bool>(type: "bit", nullable: true),
                    room_service = table.Column<bool>(type: "bit", nullable: true),
                    space = table.Column<int>(type: "int", nullable: true),
                    transfer_service = table.Column<bool>(type: "bit", nullable: true),
                    washing_m = table.Column<bool>(type: "bit", nullable: true),
                    wi_fi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iBookingAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_iBookingAttributes_iBookings_IBookingId",
                        column: x => x.IBookingId,
                        principalTable: "iBookings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_iBookingAttributes_IBookingId",
                table: "iBookingAttributes",
                column: "IBookingId",
                unique: true,
                filter: "[IBookingId] IS NOT NULL");
        }
    }
}
