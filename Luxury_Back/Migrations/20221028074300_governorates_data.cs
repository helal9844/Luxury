using Microsoft.EntityFrameworkCore.Migrations;
using static System.Net.WebRequestMethods;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class governorates_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.Sql(
                "INSERT INTO governorates" +
                " (name_ar, name_en) " +
                "VALUES ('القاهرة', 'Cairo')," +
                "('الجيزة', 'Giza')," +
                "('الأسكندرية', 'Alexandria')," +
                "('الدقهلية', 'Dakahlia')," +
                "('البحر الأحمر', 'Red Sea')," +//الغردقة 5
                "('البحيرة', 'Beheira')," +
                "('الفيوم', 'Fayoum')," +
                "('الغربية', 'Gharbiya')," +
                "('الإسماعلية', 'Ismailia')," +
                "('المنوفية', 'Menofia')," +
                "('المنيا', 'Minya')," +
                "('القليوبية', 'Qaliubiya')," +
                "('الوادي الجديد', 'New Valley')," +
                "('السويس', 'Suez')," +
                "('اسوان', 'Aswan')," +
                "('اسيوط', 'Assiut')," +
                "('بني سويف', 'Beni Suef')," +
                "('بورسعيد', 'Port Said')," +
                "('دمياط', 'Damietta')," +
                "('الشرقية', 'Sharkia')," +
                "('جنوب سيناء', 'South Sinai')," +//شرم الشيخ 21
                "('كفر الشيخ', 'Kafr Al sheikh')," +
                "('مطروح', 'Matrouh')," +
                "('الأقصر', 'Luxor')," +
                "('قنا', 'Qena')," +
                "('شمال سيناء', 'North Sinai')," +
                "('سوهاج', 'Sohag');"
                );*/

            migrationBuilder.InsertData(table: "governorates",
                columns: new[]
                {
                    "name_ar",
                    "name_en",
                   // "img_governorate"
                },
            values: new object[,]
                {
                    { "القاهرة", "Cairo"},
                    { "الجيزة", "Giza" },
                    { "الأسكندرية", "Alexandria"},
                    { "البحر الاحمر", "Red Sea" },
                    {"جنوب سيناء", "South Sinai" },

                }); 

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Truncate Table governorates");
        }
    }
}
