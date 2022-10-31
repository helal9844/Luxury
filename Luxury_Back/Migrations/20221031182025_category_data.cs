using Luxury_Back.Models;
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
                        ,"IsActive"
                        ,"Created_at"
                    },
                values: new object[,]
                {
                    {
                        null, true, DateTime.Now, 
                    },
                    {
                        1, true, DateTime.Now,
                    },
                    {
                        1, true, DateTime.Now,
                    }
                }
            );
            migrationBuilder.InsertData(
                table: "categoriesTranslation",
                columns: new[]{
                        "CategoryId"
                        ,"Name"
                        ,"locale"
                    },
                values: new object[,]
                {
                    {
                        1,"residence", "en",
                    },
                    {
                        1,"اماكن الاقامة", "ar",
                    },
                    {
                        2,"Hotels", "en",
                    },
                    {
                        2,"فنادق", "ar",
                    },
                    {
                        3,"Villas", "en",
                    },
                    {
                        3,"فيلات", "ar",
                    },
                }
            );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
