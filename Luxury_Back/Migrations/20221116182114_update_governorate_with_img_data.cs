using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class update_governorate_with_img_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "governorates",
                keyColumn: "Id",
                keyValues: new object [] {1,2,3,4,5 },
                column: "img_governorate",
                values:
                new object []
                {
                    "https://content.r9cdn.net/rimg/dimg/85/e5/d763bad9-city-9087-164429be177.jpg?crop=true&width=1366&height=768&xhint=2760&yhint=1285",
                    "https://blog.wego.com/wp-content/uploads/shutterstock_1443302708_fi7flo.jpg",
                    "https://jakadatoursegypt.com/wp-content/uploads/2020/12/Alexandria-Egypt.jpg",
                    "https://static.wixstatic.com/media/5eff48_85d852fc46aa40288ca187a57aab19ef~mv2.jpg/v1/fill/w_640,h_334,al_c,q_80,usm_0.66_1.00_0.01,enc_auto/5eff48_85d852fc46aa40288ca187a57aab19ef~mv2.jpg",
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/241890691.jpg?k=f30a16d1e61d7253ef29e45343f4ed294694b6a191219eb4293f23e0a83772cb&o=&hp=1",
                }

                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
