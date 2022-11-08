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
                    {
                        "السعر",
                        "price",
                        true
                    },
                    {
                        "السعه",
                        "capacity",
                        true
                    },
                    {
                        "المساحة",
                        "space",
                        true
                    },
                    {
                        "اطلالة المدينة"
                        ,"city view"
                        ,true
                    },
                    {
                        "المطبخ"
                        ,"kitchen"
                        ,true
                    },
                    {
                        "حوض استحمام"
                        ,"bath"
                        ,true
                    },
                    {
                        "حمام خاص"
                        ,"priavte bath"
                        ,true
                    },
                    {
                        "حمام سباحة"
                        ,"pool"
                        ,true
                    },
                    {
                        "التكييف"
                        ,"conditioning"
                        ,true
                    },
                    {
                        "واي فاي"
                        ,"WiFi"
                        ,true
                    },
                    {
                        "شرفة"
                        ,"balcony"
                        ,true
                    },
                    {
                        "غسالة ملابس"
                        ,"washing machine"
                        ,true
                    },
                    {
                        "خدمة الغرف"
                        ,"room service"
                        ,true
                    },
                    {
                        "موقف سيارات"
                        ,"parking"
                        ,true
                    },
                    {
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
