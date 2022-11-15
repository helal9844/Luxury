using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class iBooking_iAttribute_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* ATTRIBUTES */
            migrationBuilder.InsertData
            (
                table: "iBookingAttributes",
                columns: new[]
                {
                    "IBookingId",
                    "IAttributeId",
                    "value"
                },
                values: new object[,]
                {
                    //1
                    { 1, 1, "10000" },
                    { 1, 2, "4" },
                    { 1, 3, "500" },
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
