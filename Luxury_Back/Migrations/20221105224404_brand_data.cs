using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class brand_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "brands",
                columns: new[]
                {
                    "CategoryId",
                    "name_ar",
                    "name_en",
                    "logo"
                    /*"created_at"*/
                },
                values: new object[,]
                {
                    //1
                    { 2,
                        "فوندق فيرمونت",
                        "Fairmont Hotel",
                        "https://www.fairmont.com/assets/0/104/2361/2366/4691/4699/d50a13da-a0a5-4927-b359-3630080bce94.jpg"
                        /*DateTime.Now,*/
                    },
                    //2
                    { 2,
                        "فندق فورسيزونز ",
                        "Four Seasons Hotel",
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/94190040.jpg?k=ef1c7c9927dbc4c9bb8ade64114c12302c1490a01530fec267460efffb8fdf47&o=&hp=1"
                        /*DateTime.Now,*/
                    },
                    //3
                    { 2,
                        "فندق تريومف ليكشري",
                        "Triumph Luxury Hotel",
                        "https://triumphhotel.com/wp-content/uploads/2022/08/luxury-1.jpg"
                        /*DateTime.Now,*/
                    },
                    //4
                    { 4,
                        "Blue House",
                        "Blue House",
                        null
                        /*DateTime.Now,*/
                    },
                    //5
                    { 3,
                        "ماونتين فيو هايد بارك",
                        "Mountain View Hyde Park",
                        "https://www.propertyfinder.eg/property/80a34d1d5637cdd54c51edef71604a77/668/452/MODE/55a48c/3437226-e9e0eo.jpg"
                        /*DateTime.Now,*/
                    },
                    //6
                    { 3,
                        "كمبوند ميفيدا",
                        "Mivida",
                        "https://i0.wp.com/elbadrelakarya.org/wp-content/uploads/2019/12/BOULEVARD-BROCHURE_page27_image28.jpg"
                       /* DateTime.Now,*/
                    },
                    //7
                    { 4,
                        "الفندقية",
                        "El-Fondoaaia",
                        null
                        /*DateTime.Now,*/
                    },
                    //8
                    { 3,
                        "بالم هيلز القطامية",
                        "Palm Hills Katameya",
                        "https://diarnaegypt.com/wp-content/uploads/WPL/3819/img_Anzzgb8iOleILzzpHGkNPbrijb1to2BoV48NEgjz.jpg"
                       /* DateTime.Now,*/
                    },
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
