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
                    "IsActive",
                    "inputType"
                },
                values: new object[,]
                {

                    {//1
                        "السعر",
                        "price",
                        true,
                        "text",
                    },
                    {//2
                        "السعه",
                        "capacity",
                        true,
                        "text",
                    },
                    {//3
                        "المساحة",
                        "space",
                        true,
                        "text",
                    },
                    {//4
                        "اطلالة المدينة"
                        ,"city view"
                        ,true,
                        "checkbox"
                    },
                    {//5
                        "المطبخ"
                        ,"kitchen"
                        ,true,
                        "checkbox"
                    },
                    {//6
                        "حوض استحمام"
                        ,"bath"
                        ,true
                        ,"checkbox"
                    },
                    {//7
                        "حمام خاص"
                        ,"priavte bath"
                        ,true
                        ,"checkbox"
                    },
                    {//8
                        "حمام سباحة"
                        ,"pool"
                        ,true
                        ,"checkbox"
                    },
                    {//9
                        "التكييف"
                        ,"conditioning"
                        ,true
                        ,"checkbox"
                    },
                    {//10
                        "واي فاي"
                        ,"WiFi"
                        ,true
                        ,"checkbox"
                    },
                    {//11
                        "شرفة"
                        ,"balcony"
                        ,true
                        ,"checkbox"
                    },
                    {//12
                        "غسالة ملابس"
                        ,"washing machine"
                        ,true
                        ,"checkbox"
                    },
                    {//13
                        "خدمة الغرف"
                        ,"room service"
                        ,true
                        ,"checkbox"
                    },
                    {//14
                        "موقف سيارات"
                        ,"parking"
                        ,true
                        ,"checkbox"
                    },
                    {//15
                        "خدمة التنقل",
                        "transfer service",
                        true
                        ,"checkbox"
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
