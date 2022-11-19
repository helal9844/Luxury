using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class Add_Img_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "img_category",
                table: "categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValues: new object[] { 2, 3, 4},
                column: "img_category",
                values:
                new object[]
                {
                    "https://m.economictimes.com/thumb/msid-89465809,width-1254,height-836,resizemode-4,imgsize-28786/indian-hotels.jpg",
                    "https://www.exceptionalvillas.com/public/upload/listing_photos_resize/w1900xh1900-Tamarindo-19.JPG",
                    "https://www.aveliving.com/AVE/media/Property_Images/Florham%20Park/hero/flor-apt-living-(2)-hero.jpg?ext=.jpg",
                }

                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img_category",
                table: "categories");
        }
    }
}
