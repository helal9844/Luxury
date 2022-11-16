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
                        "غرف",
                        "rooms",
                        true,
                        "text",
                    },
                    {//4
                        "المساحة",
                        "space",
                        true,
                        "text",
                    },
                    {//5
                        "اطلالة المدينة"
                        ,"city view"
                        ,true,
                        "checkbox"
                    },
                    {//6
                        "المطبخ"
                        ,"kitchen"
                        ,true,
                        "checkbox"
                    },
                    {//7
                        "حوض استحمام"
                        ,"bath"
                        ,true
                        ,"checkbox"
                    },
                    {//8
                        "حمام خاص"
                        ,"priavte bath"
                        ,true
                        ,"checkbox"
                    },
                    {//9
                        "حمام سباحة"
                        ,"pool"
                        ,true
                        ,"checkbox"
                    },
                    {//10
                        "التكييف"
                        ,"conditioning"
                        ,true
                        ,"checkbox"
                    },
                    {//11
                        "واي فاي"
                        ,"WiFi"
                        ,true
                        ,"checkbox"
                    },
                    {//12
                        "شرفة"
                        ,"balcony"
                        ,true
                        ,"checkbox"
                    },
                    {//13
                        "غسالة ملابس"
                        ,"washing machine"
                        ,true
                        ,"checkbox"
                    },
                    {//14
                        "خدمة الغرف"
                        ,"room service"
                        ,true
                        ,"checkbox"
                    },
                    {//15
                        "موقف سيارات"
                        ,"parking"
                        ,true
                        ,"checkbox"
                    },
                    {//16
                        "خدمة التنقل",
                        "transfer service",
                        true
                        ,"checkbox"
                    },
                    {//17
                        "خدمة التنظيف",
                        "cleaning service",
                        true,
                        "checkbox"
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
