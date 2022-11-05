using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class category_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[]{
                        "CategoryId"
                        ,"name_en"
                        ,"name_ar"
                        ,"IsActive"
                        ,"Created_at"
                    },
                values: new object[,]
                {
                    {
                        null,"residence","اماكن الاقامة", true, DateTime.Now,
                    },
                    {
                        1,"Hotels","فنادق", true, DateTime.Now,
                    },
                    {
                        1,"Villas","فيلات", true, DateTime.Now,
                    },
                    {
                        1,"Apartments","شقق", true, DateTime.Now,
                    }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
