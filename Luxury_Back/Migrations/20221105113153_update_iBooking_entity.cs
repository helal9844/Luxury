using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class update_iBooking_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bath",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "capacity",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "conditioning",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "cost",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "kitchen",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "parking",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "pool",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "space",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "w_m",
                table: "iBookings");

            migrationBuilder.DropColumn(
                name: "wi_fi",
                table: "iBookings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "bath",
                table: "iBookings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "capacity",
                table: "iBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "conditioning",
                table: "iBookings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cost",
                table: "iBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "kitchen",
                table: "iBookings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "parking",
                table: "iBookings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "pool",
                table: "iBookings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "space",
                table: "iBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "w_m",
                table: "iBookings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "wi_fi",
                table: "iBookings",
                type: "bit",
                nullable: true);
        }
    }
}
