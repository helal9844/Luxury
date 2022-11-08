using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class iAttribute_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "iAttributes",
                columns: new[]
                {
                    "name_ar",
                    "name_en",
                    "IsActive"
                },
                values: new object[,]
                {

                    {//1
                        "السعر",
                        "price",
                        true
                    },
                    {//2
                        "السعه",
                        "capacity",
                        true
                    },
                    {//3
                        "المساحة",
                        "space",
                        true
                    },
                    {//4
                        "اطلالة المدينة"
                        ,"city view"
                        ,true
                    },
                    {//5
                        "المطبخ"
                        ,"kitchen"
                        ,true
                    },
                    {//6
                        "حوض استحمام"
                        ,"bath"
                        ,true
                    },
                    {//7
                        "حمام خاص"
                        ,"priavte bath"
                        ,true
                    },
                    {//8
                        "حمام سباحة"
                        ,"pool"
                        ,true
                    },
                    {//9
                        "التكييف"
                        ,"conditioning"
                        ,true
                    },
                    {//10
                        "واي فاي"
                        ,"WiFi"
                        ,true
                    },
                    {//11
                        "شرفة"
                        ,"balcony"
                        ,true
                    },
                    {//12
                        "غسالة ملابس"
                        ,"washing machine"
                        ,true
                    },
                    {//13
                        "خدمة الغرف"
                        ,"room service"
                        ,true
                    },
                    {//14
                        "موقف سيارات"
                        ,"parking"
                        ,true
                    },
                    {//15
                        "خدمة التنقل",
                        "transfer service",
                        true,
                    }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable("iAttributes");
        }
    }
}
