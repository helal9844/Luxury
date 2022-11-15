using Microsoft.EntityFrameworkCore.Migrations;

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
                "('البحر الأحمر', 'Red Sea')," +
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
                "('جنوب سيناء', 'South Sinai')," +
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
                    "name_en"
                },
                values: new object[,]
                {
                    { "القاهرة", "Cairo" },
                    { "الجيزة", "Giza" },
                    { "الأسكندرية", "Alexandria" },
                }); 

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Truncate Table governorates");
        }
    }
}
