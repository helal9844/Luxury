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
                    "https://media.cntraveler.com/photos/56291e1bc4dab9d4414263bc/16:9/w_1280,c_limit/cairo-egypt-night-cr-courtesy.jpg?mbid=social_retweet",
                    "https://cf.bstatic.com/xdata/images/city/540x270/644363.webp?k=d7dfbc64880d52cf00797f6a0e34568e4d25fc913a719a721a06832b5c5a9308&o=",
                    "https://cf.bstatic.com/xdata/images/city/square250/644356.webp?k=d6ce4466d6df2568018de1e5de202e1bffed10b6104eebf0681b716fcddc167f&o=",
                    "https://cf.bstatic.com/xdata/images/city/square250/644338.webp?k=51ec9b834df182428a266d5084a944dca58573a3aad1a2b5993989d3438539fe&o=",
                    "https://cf.bstatic.com/xdata/images/city/square250/644630.webp?k=700ac1d32a3bab480b14db2cba3050abe5b5bce062911dc4f5b3fdc15d81f007&o=",
                }

                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
