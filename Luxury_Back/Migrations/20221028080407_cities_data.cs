using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class cities_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData
            (
                table: "cities",
                columns: new[]
                {
                    "gov_id",
                    "name_ar",
                    "name_en"

                },
                values: new object[,]
                {
                    {
                      1,
                      "15 مايو",
                      "15 May"
                    }, {
                      1,
                      "الازبكية",
                      "Al Azbakeyah"
                    }, {
                      1,
                      "البساتين",
                      "Al Basatin"
                    }, {
                      1,
                      "التبين",
                      "Tebin"
                    }, {
                      1,
                      "الخليفة",
                      "El-Khalifa"
                    }, {
                      1,
                      "الدراسة",
                      "El darrasa"
                    }, {
                      1,
                      "الدرب الاحمر",
                      "Aldarb Alahmar"
                    }, {
                      1,
                      "الزاوية الحمراء",
                      "Zawya al-Hamra"
                    }, {
                      1,
                      "الزيتون",
                      "El-Zaytoun"
                    }, {
                      1,
                      "الساحل",
                      "Sahel"
                    }, {
                      1,
                      "السلام",
                      "El Salam"
                    }, {
                      1,
                      "السيدة زينب",
                      "Sayeda Zeinab"
                    }, {
                      1,
                      "الشرابية",
                      "El Sharabeya"
                    }, {
                      1,
                      "مدينة الشروق",
                      "Shorouk"
                    }, {
                      1,
                      "الظاهر",
                      "El Daher"
                    }, {
                      1,
                      "العتبة",
                      "Ataba"
                    }, {
                      1,
                      "القاهرة الجديدة",
                      "New Cairo"
                    }, {
                      1,
                      "المرج",
                      "El Marg"
                    }, {
                      1,
                      "عزبة النخل",
                      "Ezbet el Nakhl"
                    }, {
                      1,
                      "المطرية",
                      "Matareya"
                    }, {
                      1,
                      "المعادى",
                      "Maadi"
                    }, {
                      1,
                      "المعصرة",
                      "Maasara"
                    }, {
                      1,
                      "المقطم",
                      "Mokattam"
                    }, {
                      1,
                      "المنيل",
                      "Manyal"
                    }, {
                      1,
                      "الموسكى",
                      "Mosky"
                    }, {
                      1,
                      "النزهة",
                      "Nozha"
                    }, {
                      1,
                      "الوايلى",
                      "Waily"
                    }, {
                      1,
                      "باب الشعرية",
                      "Bab al-Shereia"
                    }, {
                      1,
                      "بولاق",
                      "Bolaq"
                    }, {
                      1,
                      "جاردن سيتى",
                      "Garden City"
                    }, {
                      1,
                      "حدائق القبة",
                      "Hadayek El-Kobba"
                    }, {
                      1,
                      "حلوان",
                      "Helwan"
                    }, {
                      1,
                      "دار السلام",
                      "Dar Al Salam"
                    }, {
                      1,
                      "شبرا",
                      "Shubra"
                    }, {
                      1,
                      "طره",
                      "Tura"
                    }, {
                      1,
                      "عابدين",
                      "Abdeen"
                    }, {
                      1,
                      "عباسية",
                      "Abaseya"
                    }, {
                      1,
                      "عين شمس",
                      "Ain Shams"
                    }, {
                      1,
                      "مدينة نصر",
                      "Nasr City"
                    }, {
                      1,
                      "مصر الجديدة",
                      "New Heliopolis"
                    }, {
                      1,
                      "مصر القديمة",
                      "Masr Al Qadima"
                    }, {
                      1,
                      "منشية ناصر",
                      "Mansheya Nasir"
                    }, {
                      1,
                      "مدينة بدر",
                      "Badr City"
                    }, {
                      1,
                      "مدينة العبور",
                      "Obour City"
                    }, {
                      1,
                      "وسط البلد",
                      "Cairo Downtown"
                    }, {
                      1,
                      "الزمالك",
                      "Zamalek"
                    }, {
                      1,
                      "قصر النيل",
                      "Kasr El Nile"
                    }, {
                      1,
                      "الرحاب",
                      "Rehab"
                    }, {
                      1,
                      "القطامية",
                      "Katameya"
                    }, {
                      1,
                      "مدينتي",
                      "Madinty"
                    }, {
                      1,
                      "روض الفرج",
                      "Rod Alfarag"
                    }, {
                      1,
                      "شيراتون",
                      "Sheraton"
                    }, {
                      1,
                      "الجمالية",
                      "El-Gamaleya"
                    }, {
                      1,
                      "العاشر من رمضان",
                      "10th of Ramadan City"
                    }, {
                      1,
                      "الحلمية",
                      "Helmeyat Alzaytoun"
                    }, {
                      1,
                      "النزهة الجديدة",
                      "New Nozha"
                    }, {
                      1,
                      "العاصمة الإدارية",
                      "Capital New"
                    }, {
                      2,
                      "الجيزة",
                      "Giza"
                    }, {
                      2,
                      "السادس من أكتوبر",
                      "Sixth of October"
                    }, {
                      2,
                      "الشيخ زايد",
                      "Cheikh Zayed"
                    }, {
                      2,
                      "الحوامدية",
                      "Hawamdiyah"
                    }, {
                      2,
                      "البدرشين",
                      "Al Badrasheen"
                    }, {
                      2,
                      "الصف",
                      "Saf"
                    }, {
                      2,
                      "أطفيح",
                      "Atfih"
                    }, {
                      2,
                      "العياط",
                      "Al Ayat"
                    }, {
                      2,
                      "الباويطي",
                      "Al-Bawaiti"
                    }, {
                      2,
                      "منشأة القناطر",
                      "ManshiyetAl Qanater"
                    }, {
                      2,
                      "أوسيم",
                      "Oaseem"
                    }, {
                      2,
                      "كرداسة",
                      "Kerdasa"
                    }, {
                      2,
                      "أبو النمرس",
                      "Abu Nomros"
                    }, {
                      2,
                      "كفر غطاطي",
                      "Kafr Ghati"
                    }, {
                      2,
                      "منشأة البكاري",
                      "Manshiyet Al Bakari"
                    }, {
                      2,
                      "الدقى",
                      "Dokki"
                    }, {
                      2,
                      "العجوزة",
                      "Agouza"
                    }, {
                      2,
                      "الهرم",
                      "Haram"
                    }, {
                      2,
                      "الوراق",
                      "Warraq"
                    }, {
                      2,
                      "امبابة",
                      "Imbaba"
                    }, {
                      2,
                      "بولاق الدكرور",
                      "Boulaq Dakrour"
                    }, {
                      2,
                      "الواحات البحرية",
                      "Al Wahat Al Baharia"
                    }, {
                      2,
                      "العمرانية",
                      "Omraneya"
                    }, {
                      2,
                      "المنيب",
                      "Moneeb"
                    }, {
                      2,
                      "بين السرايات",
                      "Bin Alsarayat"
                    }, {
                      2,
                      "الكيت كات",
                      "Kit Kat"
                    }, {
                      2,
                      "المهندسين",
                      "Mohandessin"
                    }, {
                      2,
                      "فيصل",
                      "Faisal"
                    }, {
                      2,
                      "أبو رواش",
                      "Abu Rawash"
                    }, {
                      2,
                      "حدائق الأهرام",
                      "Hadayek Alahram"
                    }, {
                      2,
                      "الحرانية",
                      "Haraneya"
                    }, {
                      2,
                      "حدائق اكتوبر",
                      "Hadayek October"
                    }, {
                      2,
                      "صفط اللبن",
                      "Saft Allaban"
                    }, {
                      2,
                      "القرية الذكية",
                      "Smart Village"
                    }, {
                      2,
                      "ارض اللواء",
                      "Ard Ellwaa"
                    }, {
                      3,
                      "ابو قير",
                      "Abu Qir"
                    }, {
                      3,
                      "الابراهيمية",
                      "Al Ibrahimeyah"
                    }, {
                      3,
                      "الأزاريطة",
                      "Azarita"
                    }, {
                      3,
                      "الانفوشى",
                      "Anfoushi"
                    }, {
                      3,
                      "الدخيلة",
                      "Dekheila"
                    }, {
                      3,
                      "السيوف",
                      "El Soyof"
                    }, {
                      3,
                      "العامرية",
                      "Ameria"
                    }, {
                      3,
                      "اللبان",
                      "El Labban"
                    }, {
                      3,
                      "المفروزة",
                      "Al Mafrouza"
                    }, {
                      3,
                      "المنتزه",
                      "El Montaza"
                    }, {
                      3,
                      "المنشية",
                      "Mansheya"
                    }, {
                      3,
                      "الناصرية",
                      "Naseria"
                    }, {
                      3,
                      "امبروزو",
                      "Ambrozo"
                    }, {
                      3,
                      "باب شرق",
                      "Bab Sharq"
                    }, {
                      3,
                      "برج العرب",
                      "Bourj Alarab"
                    }, {
                      3,
                      "ستانلى",
                      "Stanley"
                    }, {
                      3,
                      "سموحة",
                      "Smouha"
                    }, {
                      3,
                      "سيدى بشر",
                      "Sidi Bishr"
                    }, {
                      3,
                      "شدس",
                      "Shads"
                    }, {
                      3,
                      "غيط العنب",
                      "Gheet Alenab"
                    }, {
                      3,
                      "فلمينج",
                      "Fleming"
                    }, {
                      3,
                      "فيكتوريا",
                      "Victoria"
                    }, {
                      3,
                      "كامب شيزار",
                      "Camp Shizar"
                    }, {
                      3,
                      "كرموز",
                      "Karmooz"
                    }, {
                      3,
                      "محطة الرمل",
                      "Mahta Alraml"
                    }, {
                      3,
                      "مينا البصل",
                      "Mina El-Basal"
                    }, {
                      3,
                      "العصافرة",
                      "Asafra"
                    }, {
                      3,
                      "العجمي",
                      "Agamy"
                    }, {
                      3,
                      "بكوس",
                      "Bakos"
                    }, {
                      3,
                      "بولكلي",
                      "Boulkly"
                    }, {
                      3,
                      "كليوباترا",
                      "Cleopatra"
                    }, {
                      3,
                      "جليم",
                      "Glim"
                    }, {
                      3,
                      "المعمورة",
                      "Al Mamurah"
                    }, {
                      3,
                      "المندرة",
                      "Al Mandara"
                    }, {
                      3,
                      "محرم بك",
                      "Moharam Bek"
                    }, {
                      3,
                      "الشاطبي",
                      "Elshatby"
                    }, {
                      3,
                      "سيدي جابر",
                      "Sidi Gaber"
                    }, {
                      3,
                      "الساحل الشمالي",
                      "North Coast sahel"
                    }, {
                      3,
                      "الحضرة",
                      "Alhadra"
                    }, {
                      3,
                      "العطارين",
                      "Alattarin"
                    }, {
                      3,
                      "سيدي كرير",
                      "Sidi Kerir"
                    }, {
                      3,
                      "الجمرك",
                      "Elgomrok"
                    }, {
                      3,
                      "المكس",
                      "Al Max"
                    }, {
                      3,
                      "مارينا",
                      "Marina"
                    },
                     {
                      4,
                      "الغردقة",
                      "Hurguda"
                    },
                      {
                      5,
                      "شرم الشيخ",
                      "Sharm Sheikh"
                    },
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
