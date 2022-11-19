
using Luxury_Back.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using static System.Net.WebRequestMethods;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class iBooking_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* hotels:2, villas:3, Apartments:4  */

            /* Fairmont:1, villas:3, Four Seasons:2, Triumph:3, 
             * Blue:4, Mountain:5, Mivida:6, El-Fondoaaia:7 */

            /* IBOOKING */
            migrationBuilder.InsertData(
                table: "iBookings",
                columns: new[]
                {
                    "Category_Id",
                    "BrandId",
                    "name_ar",
                    "name_en",
                    "description_ar",
                    "description_en",
                    "created_at"
                },
                values: new object[,]
                {
                    //1
                    { 4, null,
                        // NAME
                        "شقة مطلة علي البحر بالاسكندرية",
                        "Alex Luxury sea view apartment",
                        //DESCRIPTION
                        "<h3 style=\"text-align: right;\"><b><u>شرح تفصيلي لأهم مميزات الشقة</u></b></h3><p style=\"text-align: right;\">شرفة بهية وماكينة صراف الي. تقع هذه الشقق في الاسكندرية علي بعد 600 متر من شاطئ كيلوباترا وعلي بعد 1.4 كيلو من شاطئ ستانلي&nbsp;</p><p style=\"text-align: right; \">هذه الملكيات المطلة علي البحر توفر لك شرفات تظهر جمال البحر واماكن خاصة مجانية لركن السيارات&nbsp;</p><p style=\"text-align: right; \">هذه الشقق المكيفة يوجد بها ثلاث آسره وشاشة تلفاز بها رسيفر متصل بالقمر الصناعي ومطبخ وغسالة اطباق وفرن كهربائي ومنشفات ومفارش آسره متوفرة&nbsp;</p><p style=\"text-align: right; \">يمكن للضيوف المقيمن بهذه الشقق ان يحصلوا علي حمامات ساخنة تزيل عنهم هموم وعناء السفر&nbsp;</p>",
                        "<h5 style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\"><h3 style=\"margin-block-start: 0px; font-size: 14px;\"><b><u>Feature Description</u></b></h3><p style=\"margin-block-start: 0px; font-size: 14px;\"><b>Boasting </b>a terrace and an ATM, Alex apartment is conveniently located in Alexandria, 600 m from Cleopatra Beach and 1.4 km from Stanley Beach. This beachfront property offers access to a balcony and free private parking.</p><p style=\"font-size: 14px;\"><b>This </b>air-conditioned apartment is fitted with 3 bedrooms, a satellite flat-screen TV, a dining area, and a kitchen with a dishwasher and a microwave. Towels and bed linen are offered.</p><p style=\"font-size: 14px;\">At the apartment guests are welcome to take advantage of a hot tub.</p></h5>",

                        DateTime.Now,
                    },
                    //2
                    { 2,1,
                        "غرفة فيرمونت جولد سيجنتشر مزدوجة - لغير المدخنين",
                        "Fairmont Gold Signature Double Room - Non-Smokingm",

                        "<h3 style=\"text-align: right; \"><b style=\"font-size: 1.51rem;\"><u>شرح تفصيلي للمميزات</u></b><br></h3><h4 style=\"text-align: right; \"><br></h4><p style=\"text-align: right;\">مثل المدينة نفسها فندق فيرمونت يقدم لك العديد من الاشياء المبهجة ويجمع بين التقدم التكنولوجي والتصميم الحديث مع نكهات المحلية&nbsp;</p><p style=\"text-align: right;\">مع مشهد بانورامي لنهر النيل والاهرامات علي بعد كبير , جمال القاهرة وتاريخها دائما امام ناظريك من شرفة فندقك الراقي ,اثناء اقامتك في وسط البلد تستيطع الحصول علي افضل الاطعمة من افضل المطاعم الموجودة في القاهرة والاستمتاع بالهواء الطلق من علي قمة سطح فندقنا المجاور له حمام سباحة</p><p style=\"text-align: right;\">&nbsp;يقع الفندق في موقع استراتيجي في قلب العاصمة ويقام بيه العديد من الاحداث الاقتصادية ويتكون من 845 متر مربع اضافة الي 450 متر مربع من المساحة الخارجية المفتوحة مخصصة للتجماعات وتتكون من 10 غرف للاجتماعات ومنظر رائع لنهر النيل</p>",
                        "<div style=\"margin: 0px; padding: 0px; color: rgb(57, 57, 57); font-family: ITCFranklinGothicStd; letter-spacing: 0.5px;\"><h3 style=\"margin-right: 0px; margin-bottom: 10px; margin-left: 0px; padding: 0px; font-family: ITCFranklinGothicStd, sans-serif; font-size: 16px; letter-spacing: normal;\"><b><u>Feature Description&nbsp;</u></b></h3><h3 style=\"margin-right: 0px; margin-bottom: 10px; margin-left: 0px; padding: 0px; font-family: ITCFranklinGothicStd, sans-serif; font-size: 16px; letter-spacing: normal;\"><b><u><br></u></b></h3><p style=\"margin-right: 0px; margin-bottom: 10px; margin-left: 0px; padding: 0px; font-family: ITCFranklinGothicStd, sans-serif; font-size: 16px; letter-spacing: normal;\">Like the city itself, Fairmont Nile City offers a delightful series of contrasts, combining advanced technology and modern design with local flavors and flair.</p><p style=\"margin-right: 0px; margin-bottom: 10px; margin-left: 0px; padding: 0px; font-family: ITCFranklinGothicStd, sans-serif; font-size: 16px; letter-spacing: normal;\">With sweeping panoramas of the river Nile and the Pyramids in the distance, Cairo’s beauty and history are always in sight from your luxury hotel accommodation. During your stay downtown, embark on culinary adventures at the city’s finest restaurants, enjoy the fresh air at our rooftop poolside restaurant and pamper yourself at Willow Stream Spa.</p><p style=\"margin-right: 0px; margin-bottom: 10px; margin-left: 0px; padding: 0px; font-family: ITCFranklinGothicStd, sans-serif; font-size: 16px; letter-spacing: normal;\">Conveniently located as part of the prestigious Nile City complex, this luxury city hotel is the ideal location for business events, consisting of 845 square meters (9,100 square feet) in addition to 450 square meters (4,800 square feet) of outdoor space dedicated to meetings and conventions. The space comprises of 10 meeting rooms including a ballroom and offers spectacular river Nile views.</p></div>",

                        DateTime.Now,
                    },
                    //3
                    { 2,3,
                        "فندق قصر هلنان - بالغين فقط",
                        "Helnan Palace Hotel - Adults Only",

                        "<h3 style=\"text-align: right; \"><b style=\"font-size: 1.51rem;\"><u>شرح تفصيلي للمميزات</u></b><br></h3><h4 style=\"text-align: right; \"><span style=\"color: rgb(0, 0, 0); font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 1rem;\"><br></span></h4><p style=\"text-align: right; font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يقع فندق هلنان فلسطين‏ وسط حدائق مورقة تبلغ مساحتها 1.42 كم مربع تطل على خليج البحر الأبيض المتوسط، ويتميز بمسبح خارجي وتراس خاص للتشمس مواجه للبحر، كما توفر جميع الغرف إمكانية استخدام الإنترنت مجاناً وشرفات مع إطلالات على البحر.</p><p style=\"text-align: right; font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تتميز جميع غرف هلنان فلسطين بأنها فسيحة وتوفر مفروشات فاخرة، كما تحتوي على سجاد شرقي ومرافق للمشروبات الساخنة وتلفزيون مع قنوات فضائية، بينما توفر بعضها إطلالة على قصر المنتزه التاريخي.</p><p style=\"text-align: right; font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن للضيوف الاستمتاع بقضاء فترة بعد الظهر بالاسترخاء، ويقدم المسبح المرطبات في الأيام الحارة.</p><h4 style=\"text-align: right; \">يقدم البار والمطاعم الموجودة في فندق فلسطين مجموعة كبيرة من المأكولات والمشروبات في كل من المناطق الداخلية والخارجية، وتوفر حانة Budega الترفيه الليلي في أجواء أنيقة.<span style=\"color: rgb(0, 0, 0); font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 1rem;\">&nbsp;</span><br></h4>",
                        "<div style=\"margin: 0px; padding: 0px; color: rgb(57, 57, 57); font-family: ITCFranklinGothicStd; letter-spacing: 0.5px;\"><h3 style=\"margin-right: 0px; margin-bottom: 10px; margin-left: 0px; padding: 0px; font-family: ITCFranklinGothicStd, sans-serif; font-size: 16px; letter-spacing: normal;\"><b><u>Feature Description&nbsp;</u></b></h3><h3 style=\"margin-right: 0px; margin-bottom: 10px; margin-left: 0px; padding: 0px; font-family: ITCFranklinGothicStd, sans-serif; font-size: 16px; letter-spacing: normal;\"><b><u><br></u></b></h3><h4 style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; letter-spacing: normal;\">Set on 350 acres of lush gardens overlooking a Mediterranean cove, Helnan Royal Hotel - Palestine features an outdoor pool and private seafront sun terrace. All rooms have free internet access and balconies with sea views.</h4><h4 style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; letter-spacing: normal;\"><br>All the rooms of the Helnan Palestine are spacious and offer luxurious furnishings. They feature oriental carpeting, hot drink facility and a satellite TV. Some rooms look out on the historic Montaza Palace.</h4><h4 style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; letter-spacing: normal;\"><br>Guests can simply enjoy a lazy afternoon. The swimming pool provides refreshment on hot days.<br>Palestine Hotel’s restaurants and bar offer a wide range of food and beverages, both indoors and outdoors. The Bodega Pub provides night-time entertainment in a stylish setting.</h4></div>",

                        DateTime.Now,
                    },
                    //4
                    { 4,7,
                        "شقق ستير مياستو الفندقية",
                        "Aparthotel Stare Miasto",

                        "<h3 style=\"text-align: right; \"><b style=\"font-size: 1.51rem;\"><u>شرح تفصيلي للمميزات</u></b><br></h3><h4 style=\"text-align: right; \"><span style=\"color: rgb(0, 0, 0); font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 1rem;\"><br></span></h4><h4 style=\"text-align: right; \"><span style=\"color: rgb(0, 0, 0); font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 1rem;\">فندق ستاير مياستو يقع في شارع خالد بن الوليد علي بعد 120 متر من سوق وسط المدينة . يوجد شقق بها حديثة ولديها نت هوائي مجاني&nbsp;</span></h4><h4 style=\"text-align: right; \"><span style=\"color: rgb(0, 0, 0); font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 1rem;\">تقع الشقق في مبني تاريخي يطل علي شوارع الاسكندرية , شقق ستاير مياستو لديها تصميم فريد من نوعه للتصميم الداخلي للشقق وبها الوان دافئة وتتكون من احجار ذات طابع خشبي&nbsp;</span></h4><h4 style=\"text-align: right; \"><span style=\"color: rgb(0, 0, 0); font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 1rem;\">جميع الشقق في ستاير مياستو مكيفة , وبها شاشات تلفاز سمارت وبها مطابخ صغيرة جاهزة للاستخدام وتتضمن ثلاجة وسخان كهربائي وخدمة عملاء تعمل 24 ساعة تحت خدمتك</span></h4><h4 style=\"text-align: right; \"><span style=\"color: rgb(0, 0, 0); font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 1rem;\">الشقق الفندقية ستاير مياستو تقع علي بعد 900 متر من محطة الرمل , وهناك العديد من المطاعم والكافيهات المحيطة بالمنطقة ومحطة القطارات ومنطقة التسوق علي بعد 1.6 كيلو متر مربع&nbsp;</span></h4><h4 style=\"text-align: right; \"><span style=\"color: rgb(0, 0, 0); font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 1rem;\"><br></span><br></h4>",
                        "<h3><u><b>Feature description&nbsp;</b></u></h3><h3><br></h3><h3><div id=\"summary\" class=\"\" data-et-view=\"\" style=\"font-size: 14px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\"><div id=\"property_description_content\"><p><b>Aparthotel Stare Miasto</b> is situated in the very centre of Kraków’s Old Town, just 120 m from the Main Market Square. It features spacious modern apartments with free WiFi.</p><p>Located in a historic building, Aparthotel Stare Miasto features a unique interior design in the warm colour of bricks with wooden elements.</p><p>All apartments at Aparthotel Stare Miasto are air-conditioned, fitted with an LCD TV and a fully-equipped kitchenette, including a refrigerator and an electric kettle. The 24-hour front desk offers ticket and tour services.</p><p style=\"margin-block-end: 0px;\"><b>Aparthotel Stare Miasto </b>is located 900 m from the Wawel Castle. There is a variety of restaurants and cafés in the surrounding area. Kraków Główny Railway Station and Galeria Krakowska Shopping Centre are just 1.6 km away.</p><p style=\"margin-block-end: 0px;\"><br></p></div></div><p class=\"geo_information\" style=\"font-size: 14px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">This is our guests' favourite part of Kraków, according to independent reviews.</p></h3>",

                        DateTime.Now,
                    },
                    //5
                    { 4,7,
                        "شقق جولدين كوين في المدينة القديمة",
                        "Golden Queen Apartments Old Town",

                        "<h3 style=\"text-align: right;\"><b><u>شرح تفصيلي للمزيات</u></b></h3><p style=\"text-align: right;\"><br></p><p style=\"text-align: right; \" &quot;geeza=\"\" pro&quot;,=\"\" tahoma,=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;=\"\" color:=\"\" rgb(38,=\"\" 38,=\"\" 38);\\\"=\"\">تحتوي جميع الوحدات على مطبخ مع غسالة صحون وميكروويف وتلفزيون بشاشة مسطحة مع قنوات فضائية ومرافق كي الملابس وخزانة ملابس ومنطقة جلوس مع أريكة، ويتوفر حمام خاص مع دش في جميع الوحدات بالإضافة إلى مجفف شعر ولوازم استحمام مجانية،</p><p style=\"text-align: right; \" &quot;geeza=\"\" pro&quot;,=\"\" tahoma,=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;=\"\" color:=\"\" rgb(38,=\"\" 38,=\"\" 38);\\\"=\"\">تقدم الشقة وجبة إفطار كونتيننتال أو بوفيه إفطار.</p><p style=\"text-align: right; \" &quot;geeza=\"\" pro&quot;,=\"\" tahoma,=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;=\"\" color:=\"\" rgb(38,=\"\" 38,=\"\" 38);\\\"=\"\">يتوفر تراس للضيوف في Golden Queen Apartments Old Town للاستخدام.</p>",
                        "<h3><b><u>Feature Description</u></b><br class=\"Apple-interchange-newline\"></h3><p><br></p><p style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\">All units come with a living room, a seating area, a flat-screen TV with satellite channels, a fully equipped kitchen and a private bathroom with shower. Some units feature a dining area and/or a balcony.</p><p style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\">The apartment offers a continental or buffet breakfast.</p><p style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\">A terrace is available for guests at Golden Queen Apartments Old Town to use.</p>",

                        DateTime.Now,
                    },
                    //6
                    { 2,2,
                        "جناح تيشز هيثم  فندق الفور سيزون نايل بلازا",
                        "Chez Haytham At Four Seasons Nile Plaza Residential Suite",


                        "<h3 style=\"text-align: right; \"><u>شرح تفصيلي للمزيات</u></h3><p style=\"text-align: right;\"><br></p><p style=\"text-align: right;\"><span style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" &quot;geeza=\"\" pro&quot;,=\"\" tahoma,=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\">تقع الشقة الفندقية Chez Haytham At Four Seasons Nile Plaza Residential Suite في مدينة القاهرة، وهي مكان إقامة يوفر إطلالات على البحيرة ومطعماً ومركزاً للياقة البدنية وبار وصالة مشتركة وحديقة، كما تتوفر خدمة الواي فاي مجاناً في جميع أنحاء مكان الإقامة، بالإضافة إلى مواقف خاصة للسيارات في الموقع.</span><br></p>",
                        "<h3><u style=\"\"><b>Feature Description</b></u></h3><p><b><br></b></p><p><span style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\">Providing lake views, Chez Haytham At Four Seasons Nile Plaza Residential Suite in Cairo provides accommodations, a restaurant, a fitness center, a bar, a shared lounge and a garden. Complimentary WiFi is provided throughout the property and private parking is available on site.</span><b><br></b></p>",

                        DateTime.Now,
                    },
                    //7
                    { 3,5,
                        "شيراتون اوشين 401",
                        "Sheraton ocean 401",

                        "<h3 style=\"text-align: right; \"><b style=\"font-size: 1.51rem;\"><u>شرح تفصيلي للمزيات</u></b></h3><h3 style=\"text-align: right; \"><b style=\"font-size: 1.51rem;\"><u><br></u></b><br></h3><p style=\"text-align: right;\">يقع Sheraton ocean 401 على بعد 6.1 كم من Citystars Heliopolis ، ويوفر أماكن إقامة مع حديقة وتراس ومكتب استقبال يعمل على مدار 24 ساعة لراحتك. متوفر على الموقع موقف خاص للسيارات. </p><p style=\"text-align: right;\">تم تأثيث الوحدات المكيفة بأرضيات خشبية وتحتوي على حمام خاص وتلفزيون بشاشة مسطحة وخدمة الواي فاي المجانية ومكتب وغرفة معيشة ومطبخ مجهز وفناء وإطلالات على المدينة. </p><p style=\"text-align: right;\">توجد منطقة جلوس و / أو منطقة لتناول الطعام في بعض الوحدات.<br></p><p style=\"text-align: right;\"><br></p>",
                        "<h3 style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\"><b><u>Feature Description</u></b></h3><p style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\"><b><br></b></p><p style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\">Located 6.1 km from Citystars Heliopolis, Sheraton ocean 401 has accommodations with a garden, a terrace and a 24-hour front desk for your convenience. Private parking is available on site.</p><p style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\">The air-conditioned units are furnished with hardwood floors and feature a private bathroom, a flat-screen TV, free WiFi, desk, a living room, an equipped kitchen, patio and views over the city. </p><p style=\"\\&quot;color:\" rgb(38,=\"\" 38,=\"\" 38);=\"\" font-family:=\"\" blinkmacsystemfont,=\"\" -apple-system,=\"\" &quot;segoe=\"\" ui&quot;,=\"\" roboto,=\"\" helvetica,=\"\" arial,=\"\" sans-serif;\\\"=\"\">There's a seating and/or dining area in some units.</p>",


                        DateTime.Now,
                    },

                #region Hotels In Cairo 1-6
                     //8 hotel
                     { 2,1,
                        "فيرمونت نايل سيتي",
                        "FairMont Nile City",

                        "<h3 class=\"top_pick_heading\" style=\"margin: 15px 0px; font-size: 18px; font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; line-height: var(--DO_NOT_USE_bui_large_font_strong_1_line-height); margin-block-end: 0.67em; color: rgb(38, 38, 38);\"><b>اشعر وكأنك نجم واستمتع بالمعاملة والخدمات الراقية في فيرمونت نايل سيتي</b></h3><div data-component=\"content-agency/property-desc-tracker/property-desc-tracker\" style=\"color: rgb(38, 38, 38); font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\"></div><div id=\"property_description_content\" style=\"color: rgb(38, 38, 38); font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\"><p style=\"margin-block-start: 0px;\">يقع هذا الفندق الـ 5 نجوم في أبراج نايل سيتي بجانب نهر النيل، ويضم سطح مسبح على السطح مع إطلالة مذهلة عبر مدينة القاهرة إلى الأهرامات. ويوفر 7 أماكن لتناول الطعام والمشروبات.</p><p>تتميز جميع الغرف العازلة للصوت في فيرمونت نايل سيتي بديكور مع مفروشات على طراز فن آرت ديكو. وهي مجهزة بمكتب عمل وتلفزيون IPTV تفاعلي. كما تحتوي الحمامات على دش مطري مع مصاريع منزلقة. وتوفر بعض الغرف إطلالات بانورامية على المدينة أو نهر النيل.</p><p>يوفر فيرمونت نايل سيتي معدات حديثة في مركز اللياقة البدنية الفسيح. كما يتوفر مركز أعمال مُجهّز جيداً في الموقع.</p><p>يمكن للضيوف الاستمتاع بتناول الطعام الذواقة في مطعم وصالة آسيان فيوجن سايغون وكذلك المأكولات الإيطالية في لوليفيتو. ويمكنهم أيضاً الاستمتاع بتناول الطعام في الخارج على التراس البانورامي الموجود على السطح. كما يقدم باب النيل أنشطة ترفيهية وقت الليل ومأكولات شرق الأوسطية.</p><p style=\"margin-block-end: 0px;\">يقع فيرمونت نايل سيتي على بعد 23.5 كم فقط من مطار القاهرة الدولي ويقع متحف القاهرة على بعد 10 دقائق بالسيارة. كما يبعد مول نايل تاورز مسافة خطوات من الفندق.</p></div>",
                        "<h3 class=\"top_pick_heading\" style=\"margin: 15px 0px; font-size: 18px; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; line-height: var(--DO_NOT_USE_bui_large_font_strong_1_line-height); margin-block-end: 0.67em; color: rgb(38, 38, 38);\"><b>Get the celebrity treatment with world-class service at Fairmont Nile City</b></h3><h3 class=\"top_pick_heading\" style=\"margin: 15px 0px; font-size: 18px; font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; line-height: var(--DO_NOT_USE_bui_large_font_strong_1_line-height); margin-block-end: 0.67em; color: rgb(38, 38, 38);\"><div data-component=\"content-agency/property-desc-tracker/property-desc-tracker\" style=\"font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; font-size: 14px;\"></div><div id=\"property_description_content\" style=\"font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; font-size: 14px;\"><p style=\"margin-block-start: 0px;\">Located in the Nile City Towers by the River Nile, this 5-star hotel features a rooftop pool deck with spectacular views across Cairo to the Pyramids. It offers 7 food and beverage venues.</p><p>All of the Fairmont Nile City rooms are soundproof and decorated with elegant Art Deco furnishings. They come equipped with a work desk and interactive IPTV. The bathrooms have rain showers with sliding shutters. Some rooms offer a panoramic Nile view or city view.</p><p>Fairmont Nile City provides modern equipment at its spacious fitness center. There is also a well equipped business center on site.</p><p>Guests can enjoy gourmet dining at the Asian Fusion Saigon Restaurant and Lounge as well as Italian favorites at L’Uliveto. Guests can also enjoy Al fresco dining on the panoramic rooftop terrace. Bab El Nil offers nighttime entertainment and Middle Eastern cuisine.</p><p style=\"margin-block-end: 0px;\">Fairmont Nile City is located just 15 mi from Cairo Int’l Airport and Cairo Museum is within 10 minutes drive away. Nile Towers Mall is footsteps away from the hotel.</p></div></h3>",

                        DateTime.Now,
                    },
                   
                     //9
                     { 2,2,
                        "Victory Of Downtown Hotel",
                        "Victory Of Downtown Hotel",

                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع Victory Of Downtown Hotel في مدينة القاهرة، وعلى بُعد 1.6 كم من ميدان التحرير، كما يوفر بار وتراس وإطلالات على المدينة، وتشمل المرافق المتوفرة في مكان الإقامة هذا مطعماً ومكتباً للاستقبال يعمل على مدار الساعة ومطبخاً مشتركاً، بالإضافة إلى خدمة الواي فاي مجاناً في جميع أنحائه، ويتميز مكان الإقامة بخدمة الغرف وصالة مشتركة وخدمة تحويل العملات للضيوف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي الغرف في الفندق على مكيّف ومنطقة جلوس وجهاز تلفزيون بشاشة مسطحة مع قنوات فضائية وصندوق ودائع آمن وحمّام خاص مع دش ونعال ومجفف للشعر، كما توفر الغرف مكتباً وغلاية للضيوف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تتوفر وجبة إفطار كونتيننتال كل صباح في Victory Of Downtown Hotel.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تتوفر مرافق للاجتماعات والحفلات ومركز للأعمال وجهاز صراف آلي لراحة المسافرين بغرض الأعمال.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يقع مكان الإقامة على بعد 1.9 كم من جامع الأزهر و2.1 كم من مسجد الإمام الحسين، ويعتبر مطار القاهرة الدولي المطار الأقرب لـ Victory Of Downtown Hotel، حيث يبعد مسافة 18 كم، كما يوفر مكان الإقامة خدمة نقل المطار مقابل تكلفة إضافية.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Boasting a bar, terrace and views of city, Victory Of Downtown Hotel is situated in Cairo, 1.6 km from Tahrir Square. Among the facilities of this property are a restaurant, a 24-hour front desk and a shared kitchen, along with free WiFi throughout the property. The accommodation features room service, a shared lounge and currency exchange for guests.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">At the hotel rooms come with air conditioning, a seating area, a flat-screen TV with satellite channels, a safety deposit box and a private bathroom with a shower, slippers and a hairdryer. The rooms will provide guests with a desk and a kettle.</p>",
                        DateTime.Now,
                    },
                     //10 villa
                     { 3,5,
                         "The Resort Studio - New Cairo",
                         "The Resort Studio - New Cairo",

                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">تقع فيلا \"The Resort Studio - New Cairo\" في القاهرة، وتضم مسبحاً خاصاً خارجياً مُدفأً، كما يقع مكان الإقامة هذا على بعد 15 دقيقة سيراً على الأقدام من داون تاون مول و5 دقائق بالسيارة من كايرو فيستيفال سيتي مول.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">توفر هذه الفيلا للضيوف حديقة خاصة ومنطقة خارجية للجلوس، وتضم مطبخاً صغيراً كاملاً مجهزاً بميكروويف وثلاجة وآلة إسبريسو لصنع القهوة، كما يشمل الحمّام الديلوكس غرفة دش ساخن.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">توفر فيلا \"The Resort Studio - New Cairo\" مرافق للشواء، كما تتوفر مواقف للسيارات مجاناً بالقرب من مكان الإقامة هذا، فيما يبعد مطار القاهرة الدولي مسافة 20 دقيقة بسيارة الأجرة الخاصة بالمطار من فيلا \"The Resort Villa - New Cairo\".</p>",
                        "Located in Cairo, The Resort Studio - New Cairo offers an outdoor Private heated pool. The property is a 15 minute walk from Downtown Mall. Cairo Festival City Mall is a 5-minute drive away.\r\n\r\nThe villa will provide you with a private garden, and outdoor seating area. There is a full kitchenette with a microwave , refrigerator and Espresso Machine. The deluxe bathroom included a hot shower room.\r\n\r\nAt The Resort Studio - New Cairo you will find barbecue facilities. Free parking is available at a location nearby. From Cairo Airport you can reach to The Resort Villa - New Cairo by airport taxi in 20 minutes.",
                        DateTime.Now,
                    },
                     //11
                     { 3,6,
                        "Villa by the Pyramids",
                        "Villa by the Pyramids",

                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">تقع فيلا Villa by the Pyramids على بعد حوالي 2.8 كم من تمثال أبو الهول، وهي مكان إقامة يوفر إطلالات على المسبح ومسبحاً خارجياً ومنطقة استراحة مشتركة وتراساً، كما تضم هذه الفيلا مسبحاً خاصاً وحديقة ومواقف خاصة للسيارات مجاناً.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي هذه الفيلا على 4 غرف نوم وتلفزيون بشاشة مسطحة ومطبخ مجهز بثلاجة وفرن وغسالة ملابس، بالإضافة إلى 3 حمّامات مزودة ببيديت.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن لضيوف هذه الفيلا الاستمتاع بتناول وجبة إفطار كونتيننتال.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">توفر فيلا Villa by the Pyramids خدمة استئجار السيارات، كما يمكن الاستمتاع برياضة المشي لمسافات طويلة بالقرب من مكان الإقامة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يبعد مكان الإقامة مسافة 3.4 كم من أهرامات الجيزة و13 كم من برج القاهرة، ويعتبر مطار القاهرة الدولي المطار الأقرب لشقة Villa by the Pyramids، حيث يقع على بعد 30 كم، كما يوفر مكان الإقامة خدمة نقل المطار مقابل تكلفة.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Featuring pool views, Villa by the Pyramids provides accommodation with an outdoor swimming pool, a shared lounge and a terrace, around 4.3 km from Great Sphinx. This villa has a private pool, a garden and free private parking.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The villa features 4 bedrooms, a flat-screen TV, an equipped kitchen with a fridge and an oven, a washing machine, and 3 bathrooms with a bidet.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests at the villa can enjoy a continental breakfast.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">A car rental service is available at Villa by the Pyramids, while hiking can be enjoyed nearby.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Giza Pyramids is 7.6 km from the accommodation, while Cairo Tower is 17 km away. The nearest airport is Cairo International, 35 km from Villa by the Pyramids, and the property offers a paid airport shuttle service.</p>",
                        DateTime.Now,
                    },
                     //12 apartment
                     { 4,4,
                        "City Stars Apartment",
                        "City Stars Apartment",

                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">تقع شقة Apartment near City Stars في القاهرة وعلى بعد 300 متر سيرًا على الأقدام من سيتي ستارز (أحد أكبر مراكز التسوق في القاهرة) و7 كم من القاهرة فيستيفال مول (أحد أكبر مراكز التسوق في القاهرة)، كما تبعد مسافة 2.7 كم من قصر البارون إمبان، ويتميز مكان الإقامة هذا بإطلالات على المدينة من الطابق الثامن ويضم مصعدين، فيما تتوفر خدمة الواي فاي مجانًا.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي الشقة الديلوكس على غرفتي نوم وغرفة معيشة مع تلفزيون بشاشة مسطحة، وتتميز الشقة المكيفة بغسالة ملابس ومنطقة لتناول الطعام ومطبخ مع ميكروويف وثلاجة وغلاية مياه، كما يحتوي الحمامين الخاصين على دش.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يقع مكان الإقامة على بعد 3.1 كم من مستشفى كليوباترا و3.4 كم من كنيسة مصر الجديدة، كما يعتبر مطار القاهرة الدولي المطار الأقرب لمكان الإقامة حيث يقع على بعد 7 كم، فيما يتوفر موقف مجاني للسيارات في الموقع.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Apartment near City Stars is an apartment situated in Cairo. 300 m walking distance from City Stars (one of Cairo's biggest malls) and 7 km from Cairo Festival mall (one of Cairo's biggest malls) and 2.7 km from palace of Baron Emban. The property features views of the city from Eighths floor with 2 elevators. Free WiFi is provided.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The deluxe apartment includes 2 bed rooms and a living room with a flat-screen TV. The apartment is air-conditioned and features a washing machine, a dining area and a kitchen fitted with a microwave,fridge and a water kettle. The 2 private bathrooms are fitted with a shower.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Cleopatra hospital is 3.1 km and Heliopolis Basilika is 3.4 km. The nearest airport is Cairo international airport 7 km from the property. Free parking is available on-site.</p>",
                        DateTime.Now,
                    },
                     //13
                     { 4,null,
                        "Arabella Residence",
                        "Arabella Residence",

                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">تقع هذه الشقق الفندقية بالخدمة الذاتية والأجنحة على بعد 10 دقائق من مول كايرو فستيفال سيتي وعلى بعد 250 م من البقالة وتوفر خدمة الواي فاي مجاناً، يقع مكان الإقامة على بعد 1.3 كم (دقيقتين) من الجامعة الألمانية في القاهرة، وعلى بعد 9 كم (10 دقائق) من الجامعة الأمريكية في القاهرة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي جميع الغرف في الفندق الاقتصادي على منطقة جلوس ومنطقة لتناول الطعام وحمام مع حوض استحمام ساخن. وتحتوي جميع الغرف على تكييف، كما تضم بعض الغرف تراسًا.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يقع سوبر ماركت كارفور وKFC وMcdonalds وHardees على بعد 1.8 كم (5 دقائق) من Arabella. ويقع مركز المنارة الدولي للمؤتمرات ومركز مصر الدولي للمعارض (EIEC) على بعد 10 دقائق.<br>ويعتبر مطار القاهرة الدولي المطار الأقرب لمكان الإقامة حيث يقع على بعد 14 كم منه.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Set 10 minutes from Cairo Festival City Mall, 250 m from Grocery, this Aparthotel and Suites offers free WiFi. The property is located 1.3 km (2 min) from German University in Cairo, 9 km (10 min)from American University in Cairo.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">At the economy hotel every room comes with a seating area, a dining area and a bathroom with a hot tub. Every room includes air conditioning, and selected rooms also offer a terrace.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Carrefour Supermarket,KFC, Mcdonalds, Hardees is 1.8 km (5 min)from Arabella. Al Manara International Conference Center and Egypt International Exhibition Center (EIEC) is 10 minutes away.<br>The nearest airport is Cairo International, 14 km from the accommodation.</p>",
                        DateTime.Now,
                    },
                    
                     #endregion


                #region Giza 1-6
                     //14 Hotel
                      { 2,2,
                        "Turquoise Pyramids view Hotel",
                        "Turquoise Pyramids view Hotel",
                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع فندق Turquoise Pyramids view Hotel في مدينة القاهرة، وضمن مسافة 600 متر من أهرامات الجيزة و2.3 كم من تمثال أبو الهول، وهو مكان إقامة يضم تراس ومواقف خاصة للسيارات مجاناً للضيوف القادمين بسياراتهم، كما يوفر هذا الفندق المصنف 4 نجوم ماكينة صراف آلي وخدمات الكونسيرج، فيما يشمل مكان الإقامة هذا مكتباً للاستقبال يعمل على مدار الساعة وخدمات نقل المطار وخدمة الغرف، بالإضافة إلى خدمة الواي فاي مجاناً في جميع أنحائه.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تتميز الغرف في هذا الفندق بأنها مكيّفة، وتوفر للضيوف مكتباً وغلاية وثلاجة وميني بار وصندوق ودائع آمن وتلفزيوناً بشاشة مسطحة وحمّاماً خاصاً مع حوض استحمام ساخن.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن للضيوف في فندق Turquoise Pyramids view Hotel الاستمتاع بوجبة إفطار كونتيننتال أو بوفيه إفطار.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يبعد مكان الإقامة مسافة 14 كم من برج القاهرة ومسجد ابن طولون، ويعتبر مطار القاهرة الدولي المطار الأقرب لفندق Turquoise Pyramids view Hotel، حيث يقع على بعد 33 كم.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Located in Cairo, within a 7-minute walk of Giza Pyramids and 2.3 km of Great Sphinx, Turquoise Pyramids view Hotel provides accommodations with a terrace as well as free private parking for guests who drive. This 4-star hotel offers an ATM and a concierge service. The property has a 24-hour front desk, airport transportation, room service and free WiFi throughout the property.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The hotel will provide guests with air-conditioned rooms with a desk, an electric tea pot, a fridge, a minibar, a safety deposit box, a flat-screen TV and a private bathroom with a hot tub.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests at Turquoise Pyramids view Hotel can enjoy a continental or a buffet breakfast.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Cairo Tower is 13.8 km from the accommodation, while Mosque of Ibn Tulun is 14.5 km from the property. The nearest airport is Cairo International Airport, 33.8 km from Turquoise Pyramids view Hotel.</p>",
                        DateTime.Now,
                    },
                     //15
                      { 2,3,
                        "Comfort Giza Inn",
                        "Comfort Giza Inn",
                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع فندق Comfort Giza Inn في مدينة القاهرة، وعلى بُعد 1.6 كم من أهرامات الجيزة، ويوفر غرفاً مكيفة وبار، كما يتميز مكان الإقامة هذا أيضاً بمكتب استقبال يعمل على مدار الساعة ويوفر مطعماً وتراس للضيوف، فيما يتميز الفندق بحوض استحمام ساخن وخدمة الغرف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تم تجهيز جميع الوحدات في الفندق بتلفزيون بشاشة مسطحة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يقع فندق Comfort Giza Inn على بُعد 3.3 كم من تمثال أبو الهول و13 كم من برج القاهرة، كما يعتبر مطار القاهرة الدولي المطار الأقرب لمكان الإقامة، حيث يبعد مسافة 32 كم، ويوفر مكان الإقامة خدمة نقل المطار مقابل تكلفة إضافية.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Comfort Giza Inn features a restaurant, bar, a shared lounge and casino in Cairo. Featuring family rooms, this property also provides guests with a terrace. The accommodation provides a 24-hour front desk, room service and currency exchange for guests.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests at the hotel can enjoy a continental or a à la carte breakfast.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Comfort Giza Inn offers 3-star accommodation with a hot tub.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests can sing karaoke, plan their trips at the tour desk, or make use of the business centre and meeting and banquet facilities.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Giza Pyramids is 1.6 km from the accommodation, while Great Sphinx is 3.3 km away. The nearest airport is Cairo International, 32 km from Comfort Giza Inn, and the property offers a paid airport shuttle service.</p>",
                        DateTime.Now,
                    },
                      //16 Villa
                      { 3,5,
                        "Villa 14 Suites",
                        "Villa 14 Suites",

                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع فندق Villa 14 Suites في مدينة السادس من أكتوبر، ويحتوي على مطعم وبار وصالة مشتركة وحديقة، كما يضم مكان الإقامة هذا أيضاً غرفاً عائلية وتراساً للضيوف، ويشمل مكان الإقامة هذا مكتباً للاستقبال يعمل على مدار الساعة وخدمة الغرف وخدمة تحويل العملات للضيوف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي جميع الغرف على مكيّف وتلفزيون بشاشة مسطحة مع قنوات فضائية وميني بار وغلاية ودش وأردية حمّام ومكتب، كما توفر بعض الغرف في الفندق شرفة مع إطلالة على الحديقة، وتشمل الغرف حمّاماً خاصاً وخزانة ملابس، فيما تضم كل غرفة في Villa 14 Suites بياضات أسرّة ومناشف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن لضيوف مكان الإقامة الاستمتاع بوجبة إفطار كونتيننتال أو إفطار من قائمة مأكولات.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يبعد فندق Villa 14 Suites مسافة 18 كم من أهرامات الجيزة و20 كم من تمثال أبو الهول، كما يعتبر مطار سفنكس الدولي المطار الأقرب لهذا الفندق، حيث يقع على بُعد 29 كم، ويوفر مكان الإقامة خدمة نقل المطار مقابل تكلفة إضافية.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Villa 14 Suites has a restaurant, bar, a shared lounge and garden in 6th Of October. Boasting family rooms, this property also provides guests with a terrace. The accommodation features a 24-hour front desk, room service and currency exchange for guests.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">All rooms are fitted with air conditioning, a flat-screen TV with satellite channels, a minibar, a kettle, a shower, bathrobes and a desk. The hotel offers some rooms that have a balcony and garden view, and the rooms include a private bathroom and a wardrobe. At Villa 14 Suites every room has bed linen and towels.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests at the accommodation can enjoy a continental or a à la carte breakfast.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Giza Pyramids is 18 km from Villa 14 Suites, while Great Sphinx is 20 km from the property. The nearest airport is Sphinx International, 29 km from the hotel, and the property offers a paid airport shuttle service.</p>",
                        DateTime.Now,
                    },
                      //17
                      { 3,6,
                        "Villa 55",
                        "Villa 55",

                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع Villa 55 في السادس من أكتوبر، وعلى بعد 6 كم من ماست أوبرا هاوس، فيما يوفر غرفاً مكيّفة وحديقة، كما يشمل مكان الإقامة هذا غرفاً عائلية وتراساً للتشمس للضيوف، ويوفر مكان الإقامة مكتباً للاستقبال يعمل على مدار الساعة وخدمة نقل وخدمة الغرف وخدمة الواي فاي مجاناً.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي الوحدات في هذا الفندق على تلفزيون بشاشة مسطحة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن لضيوف Villa 55 الاستمتاع بإفطار من مأكولات حلال.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يقع مكان الإقامة على بعد 100 متر من مول العرب و14 كم من دريم بارك، ويعتبر مطار سفنكس الدولي المطار الأقرب لـ Villa 55، حيث يبعد مسافة 16 كم.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Set in 6th Of October, 6 km from MUST Opera House, Villa 55 provides air-conditioned rooms and a garden. Featuring family rooms, this property also provides guests with a sun terrace. The accommodation offers a 24-hour front desk, a shuttle service, room service and free WiFi.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The units in the hotel are equipped with a flat-screen TV.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests at Villa 55 can enjoy a halal breakfast.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Mall of Arabia is 100 m from the accommodation, while Dream Park is 14 km away. The nearest airport is Sphinx International Airport, 16 km from Villa 55.</p>",
                        DateTime.Now,
                    },
                      //18 apartment
                      { 4,4,
                        "Spacious 3 bedroom apartment",
                        "Spacious 3 bedroom apartment",

                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">تقع شقة Spacious 3 bedroom apartment في مدينة السادس من أكتوبر، وهي مكان إقامة مكيّف يضم شرفة، كما يبعد مكان الإقامة هذا مسافة 14 كم من منتزه دريم بارك الترفيهي و2.9 كم من جامعة السادس من أكتوبر.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي هذه الشقة على 3 غرف نوم وتلفزيون بشاشة مسطحة ومطبخ مجهز بميكروويف وثلاجة وغسالة ملابس وحمّامين مع حوض استحمام ساخن، كما تتوفر المناشف وبياضات الأسرّة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">تقع هذه الشقة على بعد 5 كم من ماست أوبرا هاوس و6 كم من مول العرب، ويعتبر مطار سفنكس الدولي المطار الأقرب لشقة Spacious 3 bedroom apartment، حيث يقع على بعد 15 كم.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Boasting air-conditioned accommodation with a balcony, Spacious 3 bedroom apartment - FAMILIES ONLY is situated in 6th Of October. The property is 38 km from Tahrir Square and 38 km from The Egyptian Museum.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The apartment has 3 bedrooms, a flat-screen TV, an equipped kitchen with a microwave and a fridge, a washing machine, and 2 bathrooms with a hot tub. Towels and bed linen are available.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Giza Pyramids is 32 km from the apartment, while Great Sphinx is 33 km from the property. The nearest airport is Sphinx International Airport, 28 km from Spacious 3 bedroom apartment - FAMILIES ONLY.</p>",
                        DateTime.Now,
                      },
                      //19
                      { 4,null,
                        "The Home dreamland",
                        "The Home dreamland",

                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع ذا هوم دريم لاند في 6 أكتوبر على بعد 31 كم من القاهرة، ويوفر مسبحاً خارجياً موسمياً وخدمة الواي فاي المجانية.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي جميع الوحدات على مطبخ مع ميكروويف وثلاجة وتلفزيون بشاشة مسطحة مع قنوات فضائية ومرافق كي الملابس ومكتب ومنطقة جلوس مع أريكة، يتوفر فناء مع إطلالات على الحديقة في كل وحدة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يوفر مكان الإقامة تراس.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">كما يمكن للضيوف الاسترخاء في الحديقة أو في منطقة الصالة المشتركة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">ويعتبر مطار أبو الهول الدولي المطار الأقرب لـ The Home dreamland حيث يقع على بعد 26 كم منه.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Set in 6th of October, 31 km from Cairo, The Home dreamland offers a seasonal outdoor swimming pool and free WiFi.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Featuring a kitchen with a microwave and a fridge, each unit also comes with a satellite flat-screen TV, ironing facilities, desk and a seating area with a sofa. A patio with garden views is offered in each unit.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The homestay offers a terrace.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests can also relax in the garden or in the shared lounge area.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The nearest airport is Sphinx International Airport, 26 km from The Home dreamland.</p>",
                        DateTime.Now,
                      },
                   #endregion

                #region Alex Hotel1-6
                    //20 hotel
                    { 2,null,
                    " Alexander The Great Hotel",
                    " Alexander The Great Hotel",
 
                    "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع فندق الاسكندر الاكبر في وسط مدينة الاسكندرية ويوفر غرف مكيفة مع شرفات وخدمة الواي فاي مجاناً، ويوفر الفندق إطلالة على كنيسة الاسقفية ويتميز بمكتب للجولات السياحية ومكتب استقبال يعمل على مدار 24 ساعة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يضم هذا الفندق غرف واسعة تحتوي على تلفزيون مع قنوات فضائية وهاتف ويبعد مسافة 15 دقيقة فقط بالسيارة من مكتبة الاسكندرية، كما تحتوي جميع الغرف على ميني بار وحمام خاص مزود بدش.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن للضيوف بدء يومهم بتناول بوفيه الإفطار في منطقة تناول الطعام أو في غرفهم الخاصة، ويقدم مطعم الفندق الذي يشمل على قائمة مأكولات الأطباق المحلية كما تتوفر أيضاً مجموعة متنوعة من المطاعم في المنطقة المجاورة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يقع فندق الاسكندر الاكبر على بعد 5 دقائق من ممشى الكورنيش ذو الواجهة البحرية في الاسكندرية، ويبعد مطار الاسكندرية الدولي مسافة 5 كم كما تتوفر أيضًا خدمة استئجار السيارات.</p>",
                    "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Located in Alexandria city center, Alexander The Great Hotel offers air-conditioned rooms with balconies and free WiFi. The hotel overlooks the Episcopal Church and features a 24-hour front desk and a tour desk service.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Just a 15-minute drive away from the Library of Alexandria, this hotel has spacious rooms with a satellite TV and a telephone. Each room has a minibar and a private bathroom with a shower.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests can start their day with a breakfast buffet in the dining area or in the privacy of their room. The hotel’s à la carte restaurant serves local dishes, while you will also find a variety of restaurant in the surrounding area.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Alexander The Great Hotel is 5 minutes away from the waterfront promenade corniche in Alexandria. Alexandria International Airport is 5 km away, and a car rental service is also provided.</p>",
                    DateTime.Now,
                    },
                    //21
                    { 2,3,
                     "فندق توليب الإسكندرية",
                     "Tolip Hotel Alexandria",

                     "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع هذا الفندق ذو الـ 5 نجوم في مدينة الإسكندرية، ويضم مسبحاً في الهواء الطلق وسبا وجيم. كما يوفر أماكن إقامة عصرية مُطلة على البحر أو المدينة. وتتوفر خدمة الواي فاي المجانية في المناطق العامة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تم تجهيز الغرف المكيفة بميني بار وتلفزيون بشاشة مسطحة مع قنوات فضائية، وتحتوي جميع الأجنحة على غرفة معيشة وطاولة لتناول الطعام. كما تشتمل الحمامات الخاصة على حوض استحمام ودش، ويتم تزويدها بلوازم استحمام مجانية. كما تحتوي جميع الغرف على شرفة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن للضيوف اختيار تناول الطعام في أي من منافذ تناول الطعام الـ 9 الخاصة بالفندق، والتي تقدم مجموعة من المأكولات التي تتنوع بين المأكولات المحلية والعالمية. كما تُعتبر بارات المسبح مكاناً مثالياً للاسترخاء.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يقع الفندق على بعد 400 متر من مسرح السلام وجسر ستانلي وعلى بعد 1.5 كم من محطة سيدي جابر للسكك الحديدية. ويبعد مطار برج العرب الدولي مسافة 42 كم. كما يوفر مكان الإقامة مواقف للسيارات مقابل تكلفة إضافية.</p>",
                     "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">This 5-star hotel in Alexandria offers an outdoor pool, a spa and a gym. It features modern accommodations with views of the sea or city. Free Wi-Fi is available in public areas.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Air-conditioned rooms are equipped with a mini-bar and flat-screen satellite TV. Each suite comes with a living room and a dining table. Featuring a bathtub and shower, private bathrooms are stocked with free toiletries. All rooms have a balcony.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests can choose to dine at any of the hotel’s 9 dining outlets, which serve a variety of cuisine ranging from local to international. The pool bars are an ideal place for relaxation.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The hotel is 400 m from Al-Salam Theater and Stanley Bridge, and is 0.9 mi from Sidi Gaber Railway Station. Borg el Arab International Airport is 26 mi away. The property offers parking at an extra cost.</p>",
                      DateTime.Now,
                    },
                    //22 villa
                    { 3,6,
                     "Blue House",
                     "Blue House",

                     "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">تقع فيلا \"Blue House\" في مدينة الإسكندرية وعلى بعد 36 كم من مقابر كوم الشقافة و41 كم من حديقة حيوان الإسكندرية و38 كم من استاد الإسكندرية وهي مكان إقامة يوفر حديقة وصالة مشتركة ومسبحاً خارجياً، كما يتميز مكان الإقامة هذا بإمكانية استخدام طاولة البلياردو وتنس الطاولة، بالإضافة إلى مواقف خاصة للسيارات مجاناً.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي هذه الفيلا على 4 غرف نوم و3 حمّامات وبياضات أسرّة ومناشف وتلفزيون بشاشة مسطحة مع قنوات فضائية ومنطقة لتناول الطعام ومطبخ مجهز بالكامل وشرفة مع إطلالات على الحديقة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تضم هذه الفيلا مرافقاً للشواء وتراساً.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">تقع شقة \"Blue House\" على بُعد 38 كم من كل من مكتبة الإسكندرية والمتحف اليوناني الروماني في الإسكندرية، ويعتبر مطار برج العرب الدولي المطار الأقرب لمكان الإقامة، حيث يبعد مسافة 13 كم.</p>",
                     "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Featuring air-conditioned accommodations with a private pool, Blue House is located in Alexandria. This property offers access to pool at the pool table, ping pong and free private parking.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The villa is fitted with 4 bedrooms, 3 bathrooms, bed linen, towels, a flat-screen TV with satellite channels, a dining area, a fully equipped kitchen, and a balcony with garden views.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The villa has a terrace. Grill facilities are provided and guests can also relax in the garden, beside the outdoor swimming pool, or in the shared lounge area.</p>",
                      DateTime.Now,
                    },
                    //23
                    { 3,6,
                     "Villa Borg ELArab",
                     "Villa Borg ELArab",

                     "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع فندق Villa 14 Suites في مدينة السادس من أكتوبر، ويحتوي على مطعم وبار وصالة مشتركة وحديقة، كما يضم مكان الإقامة هذا أيضاً غرفاً عائلية وتراساً للضيوف، ويشمل مكان الإقامة هذا مكتباً للاستقبال يعمل على مدار الساعة وخدمة الغرف وخدمة تحويل العملات للضيوف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي جميع الغرف على مكيّف وتلفزيون بشاشة مسطحة مع قنوات فضائية وميني بار وغلاية ودش وأردية حمّام ومكتب، كما توفر بعض الغرف في الفندق شرفة مع إطلالة على الحديقة، وتشمل الغرف حمّاماً خاصاً وخزانة ملابس، فيما تضم كل غرفة في Villa 14 Suites بياضات أسرّة ومناشف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن لضيوف مكان الإقامة الاستمتاع بوجبة إفطار كونتيننتال أو إفطار من قائمة مأكولات.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يبعد فندق Villa 14 Suites مسافة 18 كم من أهرامات الجيزة و20 كم من تمثال أبو الهول، كما يعتبر مطار سفنكس الدولي المطار الأقرب لهذا الفندق، حيث يقع على بُعد 29 كم، ويوفر مكان الإقامة خدمة نقل المطار مقابل تكلفة إضافية.</p>",
                     "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">Featuring garden views, Villa Borg ELArab provides accommodation with a terrace and a balcony, around 2.5 km from Burj al ‘Arab al Jadīdah. This property offers a private pool and free private parking.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">This air-conditioned villa comes with 5 bedrooms, a flat-screen TV, and a kitchen with a minibar.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">Borg El Arab is 3.2 km from the villa. The nearest airport is Borg el Arab International Airport, 20 km from Villa Borg ELArab.</p>",
                      DateTime.Now,
                    },

                    //24 apartment
                    { 4,4,
                     "Hi Alexandria",
                     "Hi Alexandria",

                     "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">Situated in Alexandria, 600 metres from Cleopatra Beach, Hi Alexandria features accommodation with a garden, free WiFi, a 24-hour front desk, and room service. Private parking is available on site.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">This apartment features 2 bedrooms, a kitchen with a microwave and a fridge, a flat-screen TV, a seating area and 1 bathroom fitted with a bidet.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">The apartment offers a terrace. A car rental service is available at Hi Alexandria.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">Popular points of interest near the accommodation include Stanley Beach, Al Ibrahimiyyah Beach and Sidi Gaber Railway Station. The nearest airport is Borg el Arab International, 53 km from Hi Alexandria, and the property offers a paid airport shuttle service.</p>",
                     "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">Situated in Alexandria, 600 metres from Cleopatra Beach, Hi Alexandria features accommodation with a garden, free WiFi, a 24-hour front desk, and room service. Private parking is available on site.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">This apartment features 2 bedrooms, a kitchen with a microwave and a fridge, a flat-screen TV, a seating area and 1 bathroom fitted with a bidet.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">The apartment offers a terrace. A car rental service is available at Hi Alexandria.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">Popular points of interest near the accommodation include Stanley Beach, Al Ibrahimiyyah Beach and Sidi Gaber Railway Station. The nearest airport is Borg el Arab International, 53 km from Hi Alexandria, and the property offers a paid airport shuttle service.</p>",
                      DateTime.Now,
                    },

                    //25
                    { 4,4,
                     "شقة فخمة فيوالبحر",
                     "Luxury Panorama Sea View",

                     "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">تقع \"شقة فخمة فيوالبحر Luxury Panorama Sea View\" على بعد حوالي 2.2 كم من حديقة حيوان الإسكندرية، وهي مكان إقامة يوفر إطلالات على البحر وبار وشرفة، فيما يبعد مكان الإقامة المكيّف هذا مسافة 2.8 كم من شاطئ ستانلي، ويمكن للضيوف الاستفادة من المواقف الخاصة للسيارات الموجودة في الموقع وخدمة الواي فاي مجاناً.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي هذه الشقة على 3 غرف نوم وتلفزيون بشاشة مسطحة مع قنوات فضائية ومطبخ مجهز بميكروويف وثلاجة وغسالة ملابس وحمّام واحد مزود بحوض استحمام ساخن.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن للضيوف استخدام حوض الاستحمام الساخن الموجود في هذه الشقة، وتتوفر خدمة تأجير السيارات في \"شقة فخمة فيوالبحر Luxury Panorama Sea View\".</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يقع مكان الإقامة على بعد 3.9 كم من مقابر كوم الشقافة و600 متر من نادي سبورتنغ الإسكندرية، ويعتبر مطار برج العرب الدولي المطار الأقرب لـ \"شقة فخمة فيوالبحر Luxury Panorama Sea View\"، حيث يبعد مسافة 40 كم، كما يوفر مكان الإقامة خدمة نقل المطار مقابل تكلفة إضافية.</p>",
                     "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Featuring sea views, شقة فخمة فيوالبحر Luxury Panorama Sea View provides accommodation with a bar and a balcony, around 1.1 km from Shatibi Beach. The air-conditioned accommodation is 300 m from Al Ibrahimiyyah Beach, and guests benefit from complimentary WiFi and private parking available on site.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The apartment features 3 bedrooms, a flat-screen TV with satellite channels, an equipped kitchen with a microwave and a fridge, a washing machine, and 1 bathroom with a hot tub.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">At the apartment guests are welcome to take advantage of a hot tub. A car rental service is available at شقة فخمة فيوالبحر Luxury Panorama Sea View.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Popular points of interest near the accommodation include Cleopatra Beach, Sidi Gaber Railway Station and Alexandria Sporting Club. The nearest airport is Borg el Arab International, 52 km from شقة فخمة فيوالبحر Luxury Panorama Sea View, and the property offers a paid airport shuttle service.</p>",
                      DateTime.Now,
                    },


	            #endregion

                #region Red Sea 1-6 الغردقة
                    //26 hotels
                     { 2,2,
                        "Palm Inn Hotel",
                        "Palm Inn Hotel",
                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع Palm Inn Hotel في مدينة الغردقة، ويضم مطعماً ومسبحاً خارجياً وصالة مشتركة وحديقة، كما يوفر مكان الإقامة هذا أيضاً غرفاً عائلية وتراساً للضيوف، كما يوفر مكان الإقامة مكتباً للاستقبال يعمل على مدار الساعة وخدمة الغرف وخدمة صرف العملات للضيوف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تم تجهيز غرف الضيوف في هذا الفندق بمنطقة للجلوس، وتتميز الغرف بحمام خاص مجهز بحوض استحمام، كما تحتوي جميع الوحدات في فندق Palm Inn على تلفزيون بشاشة مسطحة وتكييف، وتحتوي بعض الغرف على شرفة، وتم تجهيز كل غرفة في مكان الإقامة ببياضات أسرّة ومناشف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يتم تقديم إفطار كونتيننتال يومياً في فندق Palm Inn.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن للضيوف في فندق Palm Inn الاستمتاع بالأنشطة في مدينة الغردقة وما حولها، مثل ركوب الدراجات.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">تشمل المعالم السياحية الشهيرة الواقعة بالقرب من Palm Inn Hotel شاطئ إليزيه دريم بيتش وشاطئ قسم الغردقة العام وشاطئ السواقي، كما يعتبر مطار الغردقة الدولي المطار الأقرب لمكان الإقامة، حيث يقع على بعد 13 كم.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Palm Inn Hotel features a restaurant, outdoor swimming pool, a shared lounge and garden in Hurghada. Featuring family rooms, this property also provides guests with a terrace. The property provides a 24-hour front desk, room service and currency exchange for guests.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Complete with a private bathroom equipped with a bath, guest rooms at the hotel have a flat-screen TV and air conditioning, and selected rooms have a seating area. At Palm Inn Hotel every room is equipped with bed linen and towels.</p>",
                        DateTime.Now,
                    },
                     //27 
                     { 2,2,
                        "Zahabia Hotel & Beach Resort",
                        "Zahabia Hotel & Beach Resort",
                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">Zahabia Hotel &amp; Beach Resort features a restaurant, outdoor swimming pool, a bar and garden in Hurghada. Featuring family rooms, this property also provides guests with a terrace. The accommodation provides a 24-hour front desk and room service for guests.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">All units are equipped with air conditioning, a flat-screen TV with satellite channels, a minibar, a kettle, a shower, free toiletries and a wardrobe. Rooms are complete with a private bathroom equipped with a bath, while certain units at the resort also provide guests with a seating area.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">A buffet breakfast is available daily at Zahabia Hotel &amp; Beach Resort.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">Paradise Beach is 1.6 km from the accommodation, while El Sawaki Beach is 2.7 km away. The nearest airport is Hurghada International Airport, 11 km from Zahabia Hotel &amp; Beach Resort.</p>",
                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">Zahabia Hotel &amp; Beach Resort features a restaurant, outdoor swimming pool, a bar and garden in Hurghada. Featuring family rooms, this property also provides guests with a terrace. The accommodation provides a 24-hour front desk and room service for guests.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">All units are equipped with air conditioning, a flat-screen TV with satellite channels, a minibar, a kettle, a shower, free toiletries and a wardrobe. Rooms are complete with a private bathroom equipped with a bath, while certain units at the resort also provide guests with a seating area.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">A buffet breakfast is available daily at Zahabia Hotel &amp; Beach Resort.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">Paradise Beach is 1.6 km from the accommodation, while El Sawaki Beach is 2.7 km away. The nearest airport is Hurghada International Airport, 11 km from Zahabia Hotel &amp; Beach Resort.</p>",
                        DateTime.Now,
                    },
                     //28 villa
                     { 3,5,
                        "Rixos Premium Magawish Suites and Villas- Ultra All-Inclusive",
                        "Rixos Premium Magawish Suites and Villas- Ultra All-Inclusive",
                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع هذا المنتجع الفاخر الذي يوفر نظام إقامة شامل كلياً بريميوم ألترا في الغردقة، ويتميز بأجنحة وفيلات فقط مع أماكن إقامة مواجهة للشاطئ تشمل منطقة ذات مناظر طبيعية بمساحة إجمالية تبلغ 255000 متر مربع، كما يشمل شاطئ رملي خاص بطول 1 كم و30 مسبح (9 أنواع) ومطعم بوفيه رئيسي واحد و5 مطاعم ذات قائمة مأكولات و10 بارات وخدمة الواي فاي مجاناً في جميع أنحاء مكان الإقامة، ويوفر هذا الفندق المصنف 5 نجوم شاطئاً خاصاً وكابانات مسبح عند الطلب.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">توفر جميع الأجنحة والفيلات منطقة للجلوس في حديقة خلابة ومسبحاً وإطلالات على البحر، وتتميز جميعها بتلفزيون بشاشة مسطحة وخزنة وميني بار (يتم تعبئته يومياً) وآلة إسبرسو لصنع القهوة وقائمة وسائد ولوازم استحمام.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن للضيوف الاستمتاع بالمأكولات التي تقدمها المطاعم الأصيلة ذات قائمة المأكولات مثل البرازيلية في مطعم “La Churrascaria” والتركية في مطعم \"Lalezar\" ومأكولات الشرق الأوسط في مطعم \"Asian\" والمأكولات البحرية الطازجة في مطعم \"Salt\" والمأكولات العالمية في مطعم \"People\" ومطعم \"Turquoise\" الرئيسي الذي يوفر مجموعة متنوعة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يوفر Rixos Premium Magawish Suites &amp; Villas مجموعة كبيرة ومتنوعة من الأنشطة لجميع الأعمار مثل أنشطة الشاطئ والمسبح وملاعب التنس وطاولة كرة القدم ومسابح الأطفال ومركز اللياقة البدنية الحديث ومركز الغوص وركوب الخيل وغيرها، ويتوفر في \"نادي الرياضة الحصري\" مدربون خبراء لليوغا والزومبا والتمارين الرياضية المائية ودروس الرقص والبيلاتس وكروس فيت، كما يوفر \"نادي ريكسي للأطفال\" للأطفال دروس رئيسية وغرفة للحرف وديسكو صغير وسينما للأطفال وملعب وأيام ذات طابع مميز، ويقدم \"Anjana Spa\" مجموعة متنوعة من جلسات المساج للجسم بالكامل وطقوس العناية التي يوفرها معالجون خبراء، فيما يتميز بحمّام تركي وغرف مساج خاصة وغرف بخار وحوض استحمام ساخن وساونا وتقشير وكمادات وخدمات سبا متطورة ومصفف شعر وصالون تجميل.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يبعد هذا المنتجع مسافة 7 كم من مطار الغردقة الدولي و9 كم عن جزيرة الجفتون و10 كم من مركز سينزو التجاري.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">This Luxurious Premium Ultra all-inclusive resort in Hurghada offers only suites and villas with beachfront accommodations with total landscape area of 255.000 m2. It features 0.6 mi private sandy beach, 30 Swimming pools (9 types), 1 main buffet restaurant, 5 a-la-carte restaurants, 10 bars and free Wi-Fi in the entire property. This 5-star hotel offers private beach and pool cabanas upon request.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">All suites and villas are with a scenic garden sitting, pool and sea views. Each flat TV, safe box, mini bar (refilled daily), Espresso machine, pillow menu, bath amenities.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests can enjoy authentic a-la-carte restaurants’ cuisines, Brazilian at “La Churrascaria”, Turkish at “Lalezar”, Far Eastern at “Asian”, Fresh Seafood at “Salt”, International at “People’s” and “Turquoise” the main restaurant with a wide variety.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Rixos Premium Magawish Suites &amp; Villas offers a great variety of activities for all ages such as beach and pool activities, tennis courts, mini football, kids’ pools, modern fitness center, diving center, horse riding and more. At “Exclusive Sports Club” professional trainers for yoga, Zumba, aqua aerobics, dance lessons, pilates and crossfit. “Rixy Kids Club” for kids features master classes, craft room, mini disco, children’s cinema, playground and themed days. “Anjana Spa” offers a variety of full body massage and care rituals performed by professional therapists, featuring Turkish hammam, private massage rooms, steam rooms, Jacuzzi and sauna, peeling and compresses, complex spa services, hairdresser and beauty salon.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The resort is 4.3 mi away from Hurghada international airport, 5.6 mi from Giftun Island and 6.2 mi from Senzo mall.</p>",
                        DateTime.Now,
                    },
                     //29
                     { 3,5,
                        "Villa Zainab",
                        "Villa Zainab",
                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">Located in Hurghada, just 1 km from Hawaii Beach, Villa Zainab provides beachfront accommodation with a shared lounge, a garden, a private beach area and free WiFi. This villa features free private parking and a shared kitchen.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">This villa is equipped with 4 bedrooms, a kitchen with a microwave and a fridge, a flat-screen TV, a seating area and 3 bathrooms equipped with a bath. Towels and bed linen are provided.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">A barbecue can be found at the villa, along with a terrace.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">Panorama Bungalows Aqua Park Hurghada Beach is 2.3 km from Villa Zainab, while New Marina is 17 km away. The nearest airport is Hurghada International, 22 km from the accommodation, and the property offers a paid airport shuttle service.</p>",
                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">Located in Hurghada, just 1 km from Hawaii Beach, Villa Zainab provides beachfront accommodation with a shared lounge, a garden, a private beach area and free WiFi. This villa features free private parking and a shared kitchen.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">This villa is equipped with 4 bedrooms, a kitchen with a microwave and a fridge, a flat-screen TV, a seating area and 3 bathrooms equipped with a bath. Towels and bed linen are provided.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">A barbecue can be found at the villa, along with a terrace.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">Panorama Bungalows Aqua Park Hurghada Beach is 2.3 km from Villa Zainab, while New Marina is 17 km away. The nearest airport is Hurghada International, 22 km from the accommodation, and the property offers a paid airport shuttle service.</p>",
                        DateTime.Now,
                    },
                     //30 apartment
                     { 4,4,
                        "THE LOTUSE",
                        "THE LOTUSE",
                        "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">تقع شقة THE LOTUSE في الغردقة بمنطقة محافظة البحر الأحمر، وضمن مسافة 300 متر من شاطئ أورانج، وهي مكان إقامة يوفر خدمة الواي فاي مجاناً ومرافقاً للشواء وحديقة ومواقف خاصة للسيارات مجاناً.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تضم كل وحدة فناءً ومطبخاً مجهزاً بالكامل مع ثلاجة ومدفأة ومنطقة جلوس وتلفزيوناً بشاشة مسطحة وغسالة ملابس وحمّاماً خاصاً مع حوض استحمام ساخن، كما يمكن لمكان الإقامة توفير المناشف وبياضات الأسرّة مقابل تكلفة إضافية لمزيد من الراحة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تضم هذه الشقة تراساً.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">تشمل المعالم السياحية الشهيرة الواقعة بالقرب من شقة THE LOTUSE شاطئ هاروني وشاطئ ذا فيو الغردقة ونيو مارينا، ويعتبر مطار الغردقة الدولي المطار الأقرب لمكان الإقامة، حيث يبعد مسافة 5 كم، كما يوفر مكان الإقامة خدمة نقل المطار مقابل تكلفة إضافية.</p>",
                        "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Located in Hurghada in the Red Sea Governorate region and Orange Beach reachable within a 7-minute walk, THE LOTUSE provides accommodations with free WiFi, BBQ facilities, a garden and free private parking.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Each unit has a patio, a fully equipped kitchen with a fridge, a fireplace, a seating area, a flat-screen TV, a washing machine, and a private bathroom with hot tub. Some units include a dining area and/or a balcony.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The apartment has a terrace.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Popular points of interest near THE LOTUSE include Harouny Beach, The View Hurghada Beach and New Marina. The nearest airport is Hurghada International, 8 km from the accommodation, and the property offers a paid airport shuttle service.</p>",
                        DateTime.Now,
                    },


	            #endregion

                #region South Sinai sharm sheikh
                //hotels 31
                { 2,2,
                    "El Khan Sharm Hotel",
                    "El Khan Sharm Hotel ",
                    "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع فندق El Khan Sharm Hotel في مدينة شرم الشيخ، ويوفر مطعماً ومسبحاً خارجياً وبار وحديقة، كما تضم جميع الغرف تلفزيوناً بشاشة مسطحة مع قنوات فضائية وحمّاماً خاصاً، فيما يشمل مكان الإقامة هذا مكتباً للاستقبال يعمل على مدار الساعة وخدمة الغرف وخدمة تخزين الأمتعة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي كل غرفة في هذا الفندق على شرفة مع إطلالة على المسبح، كما تضم جميع الوحدات في فندق El Khan Sharm Hotel منطقة جلوس.</p>",
                    "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">El Khan Sharm Hotel features a restaurant, outdoor swimming pool, a bar and garden in Sharm El Sheikh. Each room at the 3-star hotel has mountain views, and guests can enjoy access to a terrace. The property provides a 24-hour front desk, room service and luggage storage for guests.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">At the hotel, every room comes with a balcony with a pool view. Complete with a private bathroom equipped with a shower, guest rooms at El Khan Sharm Hotel have a flat-screen TV and air conditioning, and selected rooms include a seating area.</p>",
                    DateTime.Now,
                    },
                //32
                { 2,2,
                    "Raouf Hotels International - Sun Hotel",
                    "Raouf Hotels International - Sun Hotel",
                    "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع Raouf Hotels International - Sun Hotel في مدينة شرم الشيخ، وعلى بُعد 9.2 كم من سوهو سكوير شرم الشيخ، وهو مكان إقامة يوفر مطعماً ومواقف خاصة للسيارات مجاناً ومركزاً للياقة البدنية وبار، كما تشمل المرافق المختلفة صالة مشتركة وحديقة ومنطقة شاطئية خاصة، ويتميز مكان الإقامة بمسبح داخلي وأنشطة ترفيهية مسائية ومكتب استقبال يعمل على مدار الساعة.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يمكن لضيوف هذا الفندق الاستمتاع ببوفيه إفطار.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يوفر Raouf Hotels International - Sun Hotel تراس.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">يقع مكان الإقامة على بُعد 47 كم من محمية رأس محمد الوطنية و12 كم من المركز الدولي للمؤتمرات - فنادق جولي فيل، ويعتبر مطار شرم الشيخ الدولي المطار الأقرب إلى Raouf Hotels International - Sun Hotel، حيث يقع على بُعد 11 كم.</p>",
                    "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Located in Sharm El Sheikh, 9.2 km from SOHO Square Sharm El Sheikh, Raouf Hotels International - Sun Hotel has accommodations with a restaurant, free private parking, a fitness center and a bar. Among the various facilities of this property are a shared lounge, a garden and a private beach area. The hotel has an indoor pool, evening entertainment and a 24-hour front desk.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests at the hotel can enjoy a buffet breakfast.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Raouf Hotels International - Sun Hotel has a terrace.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Ras Mohammed National Park is 46.7 km from the accommodation, while International Congress Center - Jolie Ville Hotels is 12.2 km from the property. The nearest airport is Sharm el-Sheikh International Airport, 10.9 km from Raouf Hotels International - Sun Hotel.</p>",
                    DateTime.Now,
                },
                //33 villa
                { 3,5,
                    "Villa & Chalet at Four Seasons Resort Sharm El Sheikh - Private Residence",
                    "Villa & Chalet at Four Seasons Resort Sharm El Sheikh - Private Residence",
                    "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">تقع فيلا Villa &amp; Chalet at Four Seasons Resort Sharm El Sheikh - Private Residence في مدينة شرم الشيخ، وتوفر إطلالات على الحديقة ومطعماً ومكتباً للاستقبال يعمل على مدار الساعة وبار وحديقة وملعباً للأطفال وتراس، كما يضم مكان الإقامة هذا حوض استحمام ساخن.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تضم الوحدات المكيّفة غرفة معيشة مزودة بتلفزيون بشاشة مسطحة ومطبخ مع غسالة صحون وميكروويف وغسالة ملابس وصندوق ودائع آمن وحمّام خاص مع أردية حمّام ونعال، كما تشمل جميع الوحدات منطقة لتناول الطعام والجلوس.</p>",
                    "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">With garden views, Villa &amp; Chalet at Four Seasons Resort Sharm El Sheikh - Private Residence is located in Sharm El Sheikh and has a restaurant, a 24-hour front desk, bar, garden, playground and terrace. The accommodations feature a hot tub.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The air-conditioned units feature a living room with a flat-screen TV, a kitchen with a dishwasher and a microwave, a washing machine, a safety deposit box, and a private bathroom with bathrobes and slippers. There's a seating and/or dining area in some units.</p>",
                    DateTime.Now,
                },
                //34
                { 3,5,
                    "Parrotel Lagoon Resort",
                    "Parrotel Lagoon Resort",
                    "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">يقع Parrotel Lagoon Resort في شرم الشيخ، ويوفر مركزاً للياقة البدنية وباراً وحديقة ومنطقة شاطئية خاصة، فيما يشمل مَكان الإقامة هذا أيضاً مكتب استقبال يعمل عَلى مدار الساعة ومطعم ومنتزه مائي ومسبح خارجي، كما يوفر مَكان الإقامة هذا ساونا والترفيه المسائي وخدمة الغرف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">تحتوي جميع الغرف المكيفة عَلى تلفزيون بشاشة مسطحة مع قنوات فضائية وغلاية ودش ومجفف شعر وخزانة ملابس، كما تشمل الغرف الموجودة في هذا المنتجع حمّاماً خاصاً مزوداً بلوازم استحمام مجاناً، وتتوفر خدمة الواي فاي مجاناً في المناطق العامة بجانب المسبح وفي جميع الغرف.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يقدم Parrotel Lagoon Resort بوفيه إفطار أو إفطار من مأكولات حلال كل صباح.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يوفر مكان الإقامة بحيرات شاطئية ورحلات بالتاكسي المائي ومنتزه مائي ونادٍ للأطفال.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يوفر مكان الإقامة ملعباً للأطفال، كما يوفر نادي Smurfs عروضاً ترفيهية ومنطقة للأطفال ومكتب تسجيل الوصول وديسكو صغير وسينما صغيرة وعرض صغير وملعب ومسبح صغير (مع بعض معدات الأنشطة) ومطعم خاص للأطفال.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">يُمكن للضيوف الاستمتاع بلعب تنس الطاولة أو غناء الكاريوكي أو رمي السهام أو الاستفادة من مركز الأعمال.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">تشمل المعالم السياحية الشهيرة الواقعة بالقرب من Parrotel Lagoon Resort شاطئ نوبيان وشاطئ ريحانة رويال وشاطئ خليج نبق، كما يعتبر مطار شرم الشيخ الدولي المطار الأقرب لهذا المنتجع، حيث يقع عَلى بُعد 7 كم، فيما يوفر مَكان الإقامة هذا خدمة نقل المطار مقابل تكلفة إضافية. ويتوفر للضيوف أيضاً خدمات النقل مجاناً إلى الشاطئ الخاص.</p>",
                    "<p style=\"margin-block-start: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Parrotel Lagoon Resort has a fitness center, bar, a garden and private beach area in Sharm El Sheikh. Boasting a 24-hour front desk, this property also welcomes guests with a restaurant, a water park and an outdoor pool. The property features a sauna, evening entertainment and room service.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">All rooms are fitted with air conditioning, a flat-screen TV with satellite channels, a kettle, a shower, a hairdryer and a wardrobe. At the resort the rooms are fitted with a private bathroom with free toiletries. Free WiFi is available in public areas, by the pool and in all rooms.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Buffet and halal breakfast options are available each morning at Parrotel Lagoon Resort.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The property includes a lagoon, water taxi trips, an aqua park and kids club.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">The accommodations offers a children's playground. Smurfs Club offers space and entertainment for children, check-in Desk, mini disco, mini cinema, mini show, playground , mini Pool (with some activity equipment) and special kids restaurant.</p><p style=\"color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Guests can enjoy playing table tennis, darts or sing karaoke, or take advantage of the business center.</p><p style=\"margin-block-end: 0px; color: rgb(38, 38, 38); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif;\">Popular points of interest near Parrotel Lagoon Resort include Nubian Beach, Rehana Royal Beach and Nabq Bay Beach. The nearest airport is Sharm el-Sheikh International, 4.3 mi from the resort, and the property offers a paid airport shuttle service. Guests also have access to free shuttle services to the private beach.</p>",
                    DateTime.Now,
                },
                //35 apartment
                { 4,null,

                    "Palm resort 2B",
                    "Palm resort 2B",
                    "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">&nbsp;for guests who drive. It is situated a few steps from Gardens Bay Beach and offers room service.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">This air-conditioned apartment is fitted with 1 bedroom, a flat-screen TV, and a kitchen.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">Speaking Arabic and English at the reception, staff are always at hand to help.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">The apartment offers a terrace. Guests can enjoy the indoor pool at Palm resort 2B.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">Popular points of interest near the accommodation include Naama Bay Beach, Ghibli Raceway and Sinai Grand Casino. The nearest airport is Sharm el-Sheikh International Airport, 12 km from Palm resort 2B.</p>",
                    "<p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-start: 0px; color: rgb(38, 38, 38);\">&nbsp;for guests who drive. It is situated a few steps from Gardens Bay Beach and offers room service.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">This air-conditioned apartment is fitted with 1 bedroom, a flat-screen TV, and a kitchen.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">Speaking Arabic and English at the reception, staff are always at hand to help.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; color: rgb(38, 38, 38);\">The apartment offers a terrace. Guests can enjoy the indoor pool at Palm resort 2B.</p><p style=\"font-family: &quot;Geeza Pro&quot;, Tahoma, BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Helvetica, Arial, sans-serif; margin-block-end: 0px; color: rgb(38, 38, 38);\">Popular points of interest near the accommodation include Naama Bay Beach, Ghibli Raceway and Sinai Grand Casino. The nearest airport is Sharm el-Sheikh International Airport, 12 km from Palm resort 2B.</p>",
                    DateTime.Now,
                },

        	    #endregion



                }
            );
           
            /* IMAGES */
            migrationBuilder.InsertData
            (
                table: "iBookingImg",
                columns: new[]
                {
                    "Name",
                    "IBookingId",
                },
                values: new object[,]
                {
                    //1
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/303354323.jpg?k=d7f9ca9680553c7565769ef1e4f3c3b778b137ba83c19faf015af2f24b60fb86&o=&hp=1",
                        1
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/303354384.jpg?k=b349dcd72acd5bd4eb13733594b8f4c737b636d74d0d47e44d09c90f3f2976f4&o=&hp=1",
                        1
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/303354380.jpg?k=664f866f3ec38186344b1f261b87261654a59d7d2b535b27bcc33a15f9b5f3c4&o=&hp=1",
                        1
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/303354412.jpg?k=d7fd098fec9610509b73fc4613d2b9958eee7fe868b141032c00ef755b0e7c72&o=&hp=1",
                        1
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/303354392.jpg?k=857c4136ebf22ba176e11a41f28cc4036a32d97d21fe269df927934bbbf3bd2b&o=&hp=1",
                        1
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/303354392.jpg?k=857c4136ebf22ba176e11a41f28cc4036a32d97d21fe269df927934bbbf3bd2b&o=&hp=1",
                        1
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/303354399.jpg?k=491afc58d3b21c749410b0f744d00b51ff17875ca0f2d742b7fe7139a1ec094f&o=&hp=1",
                        1
                    },

                    //2
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/326897328.jpg?k=9234630b9f66dfd25a266f5f6c01461f55e3d1a6e7bd65c2bcaab5f4eabe6f84&o=&hp=1",
                        2
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/327314150.jpg?k=f7f4ae0c2f0c7c9d6435d43822910b47ec4b739ccf32ec28ac7bd10ec0f2e02e&o=&hp=1",
                        2
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/327314146.jpg?k=e01cb76c9ca2020452046079ecb1151f7cd103012b05bc137b6ab51eaf9682a0&o=&hp=1",
                        2
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/327314153.jpg?k=fd1eac08ee68a932a284c80c91e008c766c258d1cb101120f6a70f075d2d6ba3&o=&hp=1",
                        2
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/327314160.jpg?k=665ace7a3010d01778249aa4732b61e7491913d6fbb9012e6de436139b3a891c&o=&hp=1",
                        2
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/327314144.jpg?k=59070b1a5ec2bae46d52fba81b752b6627742f2f5195667876ef67617a86f019&o=&hp=1",
                        2
                    },
                    
                    //3
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/346526561.jpg?k=a50be491e6548c519c0417a1f2c3911d4ee6d8ba6fd61516454408398c48f5d2&o=&hp=1",
                        3
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/346539371.jpg?k=b7aa3dabd4f4bfbaadea7fc7699f53da29737513e62877f912224484937fcda4&o=&hp=1",
                        3
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/346344670.jpg?k=b1dc76a07aab817be73632b77797b1ed3441c075abe65cdf4c0c718a2edd5439&o=&hp=1",
                        3
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/346254163.jpg?k=77aac22b11e8bfca45250e7b7711facf2e1369047dab47287aa4d1c580fc3c00&o=&hp=1",
                        3
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/346340688.jpg?k=95bfd5c13a623b33950b28d62abf4443822e35d986c8d167a1e6d44204572072&o=&hp=1",
                        3
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/346343338.jpg?k=37d6edd51f7a7b55af5e40519931bdf8baae98a1a33258d76364960473a227c7&o=&hp=1",
                        3
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/346525408.jpg?k=bb21fa32335c3467f9abde29da1f0c813648879692a91f6fa502b61ba8c6d6c4&o=&hp=1",
                        3
                    },

                    //4
                    {
                        "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/13125860.jpg?k=b5f4783a8a6ecf84738e080755acfebf943253d71f4458fbe2510a356cf3d8c8&o=&hp=1",
                        4
                    },
                    {
                        "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/403985858.jpg?k=9d07336797a8e03c62832e9666892de67abb124f53e10c1ceee1fc4a61083bb6&o=&hp=1",
                        4
                    },
                    {
                        "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/336588539.jpg?k=5670128c817483102c8e83e1b09f6965096cd7c2bfceee4a83dae6fa5ba8597d&o=&hp=1",
                        4
                    },
                    {
                        "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/115648832.jpg?k=ad43d01c73b4866e7ad19068c6ef61b3ecb44c59f8d0862290fb9281e8eb2703&o=&hp=1",
                        4
                    },
                    {
                        "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/403985864.jpg?k=b4548da5768a0417c19039b50eee816233f4274f9eaf198dfdbeeb18e560221e&o=&hp=1",
                        4
                    },
                    {
                        "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/403985863.jpg?k=7001eb625993305340cce8ab34731ae6e28ff1f64d9f4d5b0d1ff8ef0e98112b&o=&hp=1",
                        4
                    },
                    {
                        "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/403985868.jpg?k=13a49b7d00ca01fbf40fd5b920353c6a1473ffbe4b4a3c148dd04b2a41e3021a&o=&hp=1",
                        4
                    },

                    //5
                      {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/389416678.jpg?k=019df0a5439c8f20df8f54776a9a249ab112e47785b8cbe892f63d6509c8ec33&o=&hp=1",
                       5
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/390390001.jpg?k=ffbc1b00311814b43ded3540c3d8a7bdb84fcdd6d27c8b1b2c597ab95b171ec8&o=&hp=1",
                       5
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/389669988.jpg?k=7db56210d572185eddb92e064a854a06dee05c8d56e9d02837d784c3a8dec866&o=&hp=1",
                       5
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/389669840.jpg?k=a2f2c6202703657a1651cd61102dc91f513af13a5514a4c52e2981fdb38bff88&o=&hp=1",
                       5
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/391198276.jpg?k=b9c223cc88c62b1e204f7f411118bf856c5cfdc28b2e52d13087bda43a1e19e8&o=&hp=1",
                       5
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/390390361.jpg?k=a7967913f3cd21af5b2ac3873f18d268f3616b8fc1bd01470a4c0c4afa0c4ed8&o=&hp=1",
                       5
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/390390361.jpg?k=a7967913f3cd21af5b2ac3873f18d268f3616b8fc1bd01470a4c0c4afa0c4ed8&o=&hp=1",
                        5
                    },

                    //6
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/286279364.jpg?k=f4905912d236bb2fc8ee7cc51f79c2ed3eed1fe3f0dd45560008c37bf2d7b462&o=&hp=1",
                        6
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/286279385.jpg?k=fb26565d75008fce62e0d87eed0cfff6c99e79d95de981c3f65863030979e37a&o=&hp=1",
                        6
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/286279323.jpg?k=ee54ff5de015fbfb87001e096b9e61fd7702ef15d0516b87cb89db07f3af71e5&o=&hp=1",
                        6
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/321676796.jpg?k=7d9747bb756d265c2c16973f1778959251ba4c84b4f56b98b9c426e652834f95&o=&hp=1",
                        6
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/287241138.jpg?k=46ee7f1aad5a5c955c172c7906c93f210f067acdd1d95354600a3a59a80923c3&o=&hp=1",
                        6
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/286279390.jpg?k=6708e6ac086b869e61c937d289daa29c8e99f3aa1effb7f70cafc565168c0d84&o=&hp=1",
                        6
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max200/286279357.jpg?k=e2d06a160b2fedc32e53606d637c869536b29fd04aa2eab94b67b0d0743e30c1&o=&hp=1",
                        6
                    },

                    //7
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max200/228433193.jpg?k=5e52d7de2baeadaa2cc9c9841931c299911a2ab6a9bbb26e0bf9b9e49c97919d&o=&hp=1",
                        7
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max200/228433029.jpg?k=49e89dc5ddaf944bb2e49d9e95ce198f9e118677bbafa557e33904a01ed3e633&o=&hp=1",
                        7
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/228433491.jpg?k=dd92fcd30db0afe0f10df75173b359f14d5e063fc6b330d40a9541685c26b4fc&o=&hp=1",
                        7
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max200/221986105.jpg?k=b01661fc0f1935b0f4d663cf196c1427e286d3b8437c75b6c35f0e24efa913c0&o=&hp=1",
                        7
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max200/226785706.jpg?k=22e1bc202d0021d6e1245f526876599caeefa0572b4df2cdd5ab4f3c796d3c95&o=&hp=1",
                        7
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/228432358.jpg?k=da58451e329ab1196b82ca4cb838f49e276e34a6cdc9da03524cdb301113ecaf&o=&hp=1",
                        7
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/221986919.jpg?k=d44286a783d6c95187b85b681f9da79ee261d5ce1c72dfce610f81f5ceb3ec7c&o=&hp=1",
                        7
                    },

                    #region Images Hotels 1-6
                    //8
                    {
                        "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/326897328.jpg?k=9234630b9f66dfd25a266f5f6c01461f55e3d1a6e7bd65c2bcaab5f4eabe6f84&o=&hp=1",
                        8
                    },
                    {
                        "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/327314153.jpg?k=fd1eac08ee68a932a284c80c91e008c766c258d1cb101120f6a70f075d2d6ba3&o=&hp=1",
                        8
                    },
                    {
                       "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/327314158.jpg?k=5fb9ae20284b88cd1ccf3253da2c6b2ecc14b74b2b050f0b286d5b2eab4aa430&o=&hp=1",
                       8
                    },
                    {
                       "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/327314170.jpg?k=a8a24d012a75f9afe54df465fb91e34681b5633358216daa8a7a59284d6834b5&o=&hp=1",
                       8
                    },
                    {
                       "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/327314146.jpg?k=e01cb76c9ca2020452046079ecb1151f7cd103012b05bc137b6ab51eaf9682a0&o=&hp=1",
                       8
                    },
                    {
                       "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/327314160.jpg?k=665ace7a3010d01778249aa4732b61e7491913d6fbb9012e6de436139b3a891c&o=&hp=1",
                       8
                    },
                    {
                       "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/327314149.jpg?k=2222a7a659fab57163e89c806b75630bf7e28520894efb1d0f3b30195176ccec&o=&hp=1",
                       8
                    },
                    //9
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/298925073.jpg?k=9428c982eb164e58cde27697c0e7c2ac9e80895ed8ad0966b7d02b2c4dc5b0f4&o=&hp=1",
                      9
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/286639098.jpg?k=83c119045211e47b1eb1cf543b8e0ffb3ac7cfd7f4afa287619df743e0b3f035&o=&hp=1",
                      9
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/342201327.jpg?k=d3d3839505c65ed146abf206a0e4fbb2936a05416db4b51bb8626e002678ebab&o=&hp=1",
                      9
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/344854006.jpg?k=21c68a5181ba447ccaac00356a467a17b64233431e3d0114c0203db22465d2bb&o=&hp=1",
                      9
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/299174458.jpg?k=75d7e1b47858a002772db8553f45a04dc015d027ba56474e02380681ab93f774&o=&hp=1",
                      9
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1280x900/342210065.jpg?k=46aa2ca39da705a346c38b71d60e8b0fa56f249276697af5c1aba9f871777de7&o=&hp=1",
                      9
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/302205232.jpg?k=e2e0c914bd6f193c48bdc7972164d15305e5236e7e5f10560095811d5825d532&o=&hp=1",
                     9
                    },
                    //10
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/354965285.jpg?k=2d8f4e64c682e9350fa6e27829839ae4a9c0af1b6a725ea7c00052ccafa704ac&o=&hp=1",
                     10
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/354964937.jpg?k=b8f538ff9cc94834d49af24e74f60d4059871e40af400a96f2e2bac049965031&o=&hp=1",
                        10
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/354964912.jpg?k=b14c4087d75ce299e5c81539bdf950d38a9b30007256244a7a9349f094c7cc84&o=&hp=1",
                        10
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/354964904.jpg?k=52b65a795a23d7c09567c3ff6e4a7e9bf52900f323fa188c63b867ee8da688b0&o=&hp=1",
                        10
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/354964900.jpg?k=021b7f0cf103959e7063ffee03efd04563eb16a9650808a082f548c3938f55db&o=&hp=1",
                        10
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/354964906.jpg?k=b6b59f88a2ab844ec2b0270b2f3a6032c50e9393b61fa56b099578438af7e432&o=&hp=1",
                        10
                    },
                    {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/354965325.jpg?k=81f4ac3396a2411cb4b6e7baf6f78553b326fe7085c363adc78b5b94cb77fb2a&o=&hp=1",
                        10
                     },
                    //11
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/334709566.jpg?k=88728a2e1b1cea6197d47a071739a9514334ad583a2304887d2dc8468a65dfb8&o=&hp=1",
                    11
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/334538294.jpg?k=2983cc4b290f9add5c13348d3525b9e657c54f548bc8b01c19054bc1cefa37c6&o=&hp=1",
                    11
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/366715740.jpg?k=b947c92353251fe3fe12828a9e8c6331fe2e6c6b4b706b7d610ebc7cc516ec4b&o=&hp=1",
                    11
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/332286204.jpg?k=c345a892bdda225eefeba364a8bb18ad4e9557c20ddbf8531410c279d0b51aab&o=&hp=1",
                    11
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/332286238.jpg?k=da51905bffefb2507ab5ad1ab8f4af613b1f80f694f8cb45eb5127200b3fd80f&o=&hp=1",
                    11
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/332286213.jpg?k=ced27364a6e704c80f2e5b49a54b6dc76886c6e0074399763e6831a70d2dbddc&o=&hp=1",
                    11
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/332286244.jpg?k=4a51e36ca86f11f3b34fb56cc4ea1ef796907a75c3743423c0495fea24f130bc&o=&hp=1",
                    11
                    },
                    //12
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/292507420.jpg?k=5a0ddeae543a261d9c5195fdda2cb01411e0171c08b33e5ed9ed4dd20aea803b&o=&hp=1",
                    12
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309847295.jpg?k=9817b7a933b72a467c9570c7b0a9bebd32175b650cb1e25352d8481e2ae01f10&o=&hp=1",
                    12
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309847450.jpg?k=f0722b5ed70684b0d881c1184e9824256ca1e8b9d0f1c4b4996c57451da8ce2a&o=&hp=1",
                    12
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/208945828.jpg?k=121b6e72af9c671873467eca11dc02c99de4fd64d170770b2d6aaed6a47c4305&o=&hp=1",
                    12
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/208944327.jpg?k=33a1169a9b50d76c3fe8653004d275295f9e75eef9bf6de2d6e4a5d98fd58b57&o=&hp=1",
                    12
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/230067124.jpg?k=244b60ada617ba83082cf331b57816e9701d8f853aa4d8c89e46cec662d47552&o=&hp=1",
                    12
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/225152078.jpg?k=5046dbba0f3439499b42617ad713f1dd691c046907ac896b27953e8aeb949ef7&o=&hp=1",
                    12
                    },
                    //13
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/195403406.jpg?k=7101111b82fa5547be7b89eb19ef209e4332b82315b298a5ca711ac84d20a97b&o=&hp=1",
                    13
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/210680264.jpg?k=3038713dfde2318d39f00fcc63c2219c5b97b96a02056e964a652776c1c64b9c&o=&hp=1",
                    13
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/195403207.jpg?k=c382a5dbc981afbf2eaf6083fe7901fd7fb9c8a8eb49b9c953b95ccb8c1f4b65&o=&hp=1",
                    13
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/195403463.jpg?k=b2280edbab7070153ec06578f7bb989e328eb2d9d26b626bf3296cba2b1b106b&o=&hp=1",
                    13
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/195403412.jpg?k=c0908a4c9bc9785e8f23ed9fc081086dbe905a0cffcd02ffac22b3443dd135ed&o=&hp=1",
                    13
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/194985401.jpg?k=4488561c49c3502e979e42d865e51dcf4c0547a23da5f20a89e61df234482546&o=&hp=1",
                    13 },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/210845169.jpg?k=cb87c25931f9fce90c665e9cb65200c3e9355c6c6641a0939bfecb28ef51c0b0&o=&hp=1",
                    13
                    },
                    //14 Giza
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/377313073.jpg?k=7cd5232b6fed57609cba39f9c4a22f250b497db94e62df7c83641fd874dc397f&o=&hp=1",
                    14
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/370809552.jpg?k=cb2448f3705e9a9c9134d76af92b113ce9ad33635e7f095fcd760980794a2ebb&o=&hp=1",
                    14
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/406835065.jpg?k=3e4f8a734f6341926372a1cbcab2616f6931760e6c44a0243ca7a2264d225aef&o=&hp=1",
                    14
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/370810182.jpg?k=e757c8177051fc09d07971bde8b68bc319b359feda03df7dd0af76a6fa9cd524&o=&hp=1",
                    14
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/370809750.jpg?k=9963b45a7755a56ea64bbfddcf0d98ee655a7b555c950362d2e7335bb7a30da5&o=&hp=1",
                    14
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/370809386.jpg?k=65c37b56ca2b4065abeb53c25baf51450b400b4465fc228d337ce710c601a973&o=&hp=1",
                    14
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/377311938.jpg?k=c49e04b4c76ac538042680c76f10942694e8fc5b54a16b84f3eedb522277f21a&o=&hp=1",
                    14
                    },
                   //15
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402792712.jpg?k=f23988113f9f8ead9bdd88155929c58121e807886aa303abb0b60dfaa1001387&o=&hp=1",
                    15
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402787445.jpg?k=e83c603aafd95849eb70c94819dfca96a9d73bd51b2b8ec9237080f97cc6a2c4&o=&hp=1",
                    15
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402793862.jpg?k=62acad5220115fe867f7234665a7e62f41f13cc2e681ed8b19c1c2224da68137&o=&hp=1",
                    15
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402792531.jpg?k=4d7df716699f76919d970750049268cca803360e531f856577fd2b14ee431615&o=&hp=1",
                    15
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402787678.jpg?k=4f0d448a1393e25d5c8eb48e4fbcf906257fd931606dca49b04b53838da7bfa8&o=&hp=1",
                    15
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402790296.jpg?k=61b0acca1e81aaccbdac02b9f59e3aba0cd515aeab7e0d8c0369574b8d2a2ba0&o=&hp=1",
                    15
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402789088.jpg?k=610695a5bc9c18ef19f519cef7d5cc76e63039b7b4355cae7a0e4aae1c610870&o=&hp=1",
                    15
                    },
                    //16 villa giza
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309513038.jpg?k=48da735a8ef8da73bb94f1e0ffe078adbbd05a2c5f34a7a649b2ffe23c04ea3f&o=&hp=1",
                    16
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309513104.jpg?k=a82cf021b7ca2e72db4a1888a2176863a346ad61af1af86007255566e1ae3535&o=&hp=1",
                    16
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/173898073.jpg?k=1d0f01b3e62fb8c3e58f1767479a53594b1d37b2b8e9d64e613652be2e53cce7&o=&hp=1",
                    16
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/173901171.jpg?k=43f6b63078102fdd8e699cb3d92bdf9e18e7b3262b3c54e0f2a6e990c585177e&o=&hp=1",
                    16
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309512984.jpg?k=8475337abb682d40782c8b9fba5afce29f0b89e58a8fa784a3aecf92600df404&o=&hp=1",
                    16
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309513053.jpg?k=5c024127f268f390ca511808718819dbf91e182a4f5f6777da1018c3658c1190&o=&hp=1",
                    16
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309513182.jpg?k=c56872dc886c884261abdcef5590ebcf06c989577f198ae934ee561c2ef5a850&o=&hp=1",
                    16
                    },

                    //17
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/310815506.jpg?k=89bc3d6649f8ac6039a6cdb1955f800024cb1bbef044130ccb3f0ca54e65ac28&o=&hp=1",
                    17
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/310814875.jpg?k=90a170b68a164f03cb8f87b10e853a68f459ef1bb9811087c1f5c932cf6c30f9&o=&hp=1",
                    17
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/310820733.jpg?k=53a2c5d2db30a4fe5f4485e00c48cb7814bba069bd505ca52d189f751b8208ae&o=&hp=1",
                    17
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/310816320.jpg?k=65465e2103da3dbf42fb692919c3f36e71b9149febe057d4368ab4e8c73e3311&o=&hp=1",
                    17
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/314448909.jpg?k=f368195cdef8ed13351dc333c49d13438083424b312c65c3c51295373c9f2d81&o=&hp=1",
                    17
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/314448909.jpg?k=f368195cdef8ed13351dc333c49d13438083424b312c65c3c51295373c9f2d81&o=&hp=1",
                    17
                    },
                    {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/318554038.jpg?k=4d212b593861c040a31104c91190b95b471b08fc75b0001101b235be0f1a3cef&o=&hp=1",
                    17
                    },

                    //18 apartment giza
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/359807551.jpg?k=89b09ca44ce7c75271b25c28a12b7d6932cac6217e976e205651c92e77600048&o=&hp=1",
                    18
                   },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/359807715.jpg?k=081ceba65e0ccde2776df7da861e16a534abbcf4c14e9655f753cbf64525e335&o=&hp=1",
                    18
                   },
                   {
                    " https://cf.bstatic.com/xdata/images/hotel/max1024x768/372751257.jpg?k=bf89d37e44aa893b3c936430601c669ef2df4bac836fd3177e65d43299f0a5e9&o=&hp=1",
                    18
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/359807606.jpg?k=bff9d433e44b6c36daac17b8863a888ff45e9191c2f8ad011fb104c6af08451c&o=&hp=1",
                    18
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/359807711.jpg?k=e71615dfaeff38f20790799e9d39d375a0892cc01e585e4124ac466d3b0e5768&o=&hp=1",
                    18
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/371174207.jpg?k=d7b95ceb639c50e1065d682ac8a60701d74aa03036f8cb02264bc70546274a33&o=&hp=1",
                    18
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/361449828.jpg?k=57d87c2d338c0ba3c49a195cbe5087c93a806d8abf132dd24a0602c2e5ebb0b7&o=&hp=1",
                    18
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/371174182.jpg?k=e6c6cc75e3b4cae0502164582c7a5abb3582ca2d443a57163e680c58b44c02db&o=&hp=1",
                    18
                    },
                   
                   //19 
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/219756262.jpg?k=2f0d5c430cd2248f44d836e5c259ccb8286ee72e10f9feb43302f1bab6e49c81&o=&hp=1",
                    19
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/219756262.jpg?k=2f0d5c430cd2248f44d836e5c259ccb8286ee72e10f9feb43302f1bab6e49c81&o=&hp=1",
                    19
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/219756321.jpg?k=a54d465ad401280d3164aab823e8125f4fd8ba7aeb732beefcde7a565c0805ff&o=&hp=1",
                    19
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/384966782.jpg?k=421d872cec958247d42aec77435fff92568c48f5e65232d22a1ab804c7aaa27a&o=&hp=1",
                    19
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/219756318.jpg?k=d9e82fb45098b9c26568026129da4d6f80559de1e55b2a4cf5391c0fd58b5519&o=&hp=1",
                    19
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/219756326.jpg?k=6d8919c52d3408f3cf4ab8b94eebd064f961ae91bd13d038a33733aab8fa580a&o=&hp=1",
                    19
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/219756345.jpg?k=a684aa6cbf51802da439ad03702e6b5749c7a25f7142ba70ce3968a25408ae46&o=&hp=1",
                    19
                    },
                   //20 Hotel alex
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/6123786.jpg?k=ef864ba10a9a53ec261288cd49b7884e082304b95bd05a1e44fd82ef2cf76e09&o=&hp=1",
                    20
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/195171381.jpg?k=d6e652aebeee0aa65fe7e8a2f9bb1335b907c57354c52067e882ddac308b70dc&o=&hp=1",
                    20
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/219070653.jpg?k=529770acbd3cced36e1aa2f883f1f5c650d3fc5d21906b124074762b54b366f0&o=&hp=1",
                    20
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/62677254.jpg?k=5cd489df6157766bb7548c2cf782bc5971d1d6c557c7b995cbaa06579289baf9&o=&hp=1",
                    20
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/14048979.jpg?k=5192425af82a1402266fa370797f7fbf5d8c569c3169b97f31ff075bacafec53&o=&hp=1",
                    20
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/159830552.jpg?k=fb6caea3e93d2e0ce1fa4a678df350972cd380de16dfb1b069670baf950338ff&o=&hp=1",
                    20
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/84039067.jpg?k=f8a8b090eb7b8fdd40379e7f5af76c73b5c900158b18d2125fdcd0ce1bb500f1&o=&hp=1",
                    20
                    },

                   //21
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/288644202.jpg?k=5ba38f47744415ee4d072303af89bf69b987e9f15ab3e69dc8c442d085a675d9&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/288998939.jpg?k=fe3d937165e6af00fe2cd9fad1285195309b9d5d70c5f72df010c82d29a43d25&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/288651065.jpg?k=3e2f032e8a14677babe9847ac0d2a0492ea2cadb03fd1b6b2955b5b8f405f6c4&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/284508801.jpg?k=16ef029e0110c38461c970205d75481d10e814d339bd3b5788a3169d924abe56&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/288644689.jpg?k=4dd8e9c3b30a98d2dccb55fb9c24d9c1deb2c5dbf79a7e629fd042643f2798fd&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/284509641.jpg?k=1051a9b5fc67763e2fa73a166ee0b39762f65fac3aacb5c04f883cc09fd0f71f&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/289444696.jpg?k=83ade52cf41e328b004526fdbc95cc83c687f8a48863020578e01ab3bac918c8&o=&hp=1",
                    21
                    },

                   //22 villa alex
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/364589522.jpg?k=111b40854c0829aa5f3a6e9a22af1f612a85d935890a58d4eb17c6c15b4ef514&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/316539484.jpg?k=f9f988fe7df2216dc6406cf834f7848ffa52690cdcad9f9b11245afbe2bb6774&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/316539732.jpg?k=97f747435e9ba9f6d5af31b1012cc10dc680d2126900904c9f076ebe03f2b678&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/318207379.jpg?k=fe967f6751a1911fccdd7792c814f923cf66a5e5000b340bf1a156f9370fd81b&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/318207398.jpg?k=264ede2515b15f21d3323f83f9a42ab2d6d76cf61d0cdedb84be43cc5411e390&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/318207408.jpg?k=3e14063e0fe1194d59cb7f79541b03d8a7a592dc740f1cec42d75f1d32a38357&o=&hp=1",
                    21
                    },
                   {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/318207374.jpg?k=51aa5f992d1ed1ef14a6c0f288bd16f78b08c8ce098ce81f4e42f0d095b05e69&o=&hp=1",
                    21
                    },

                    //23
                   {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/319343001.jpg?k=8c498fec4de332728fe15e09faa7cff766b7987d37426e9350a082f7c647c383&o=&hp=1",
                        23
                    },
                   {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/319343009.jpg?k=f9530752cf5a4aaceb43cb1ebeb267ef960ca34a12193b26031e44c94020c61e&o=&hp=1",
                        23
                    },
                   {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/319343019.jpg?k=f4e5bf72e4548575f3838a8984be7c0073ff2dbf25b6157a99f1fc45ebfb4588&o=&hp=1",
                        23
                    },
                   {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/319343017.jpg?k=a2199d6d41f6c7253d176f23566f44899fd1b23e8f1a98d62ad4f81ca5c18e8b&o=&hp=1",
                        23
                    },
                   {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/319343022.jpg?k=55174d2503ea3932f2b06429ceead7c38de812345f148ef2277bce220979f228&o=&hp=1",
                        23
                    },
                   {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/319343018.jpg?k=372f10e406fd5066ab3d0393a1cde1a9196ebc385ca54d5245fc7b374cdc3058&o=&hp=1",
                        23
                    },
                   {
                        "https://cf.bstatic.com/xdata/images/hotel/max1024x768/319343014.jpg?k=0612802c01cb5e29e43962c42a58ea0fc11e37a11d852bc067d6076e8322b13c&o=&hp=1",
                        23
                    },

                  //24 apartment alex
                  {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/390640759.jpg?k=d7f35026a0982ce87b05ca1d7866870ec067001315d6a14b4ab594c3a5404eff&o=&hp=1",
                    24,
                  },
                  {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/390640777.jpg?k=3415d5ee53919509e4de7a3fd97249ba3760e051815eb9c87c3e9add7c8f951c&o=&hp=1",
                    24,
                  },
                  {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/390640786.jpg?k=30379dbad874cc1e06a8d34c84ffdb9b67db8683d8d2a503ce672a89d1994b6d&o=&hp=1",
                    24
                },
                  {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/390640794.jpg?k=dc75cff05363f36282a0f76fa2a58e64d9047b4612476c9f5f30fd323bb1613b&o=&hp=1",
                    24
                  },
                  {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/390640789.jpg?k=781889668878bcf3929c7f857b9fd3b3cb5dfde3cf9218b983f1dc3e9216264c&o=&hp=1",
                    24
                  },
                  {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/390640781.jpg?k=5da9f8682005d4caa5f9a4666092c112b5165b8e5071b99920e3ea9970de6048&o=&hp=1",
                    24
                  },
                  {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/390640784.jpg?k=29bcc0749dafa74b17b5377010c76a7ff9b33c2ead51612d4bddc21e73648110&o=&hp=1",
                    24
                  },

                //25 
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/348100914.jpg?k=91067b1292cbe7bffdb5d606764348a7fd93078951c10a614ceaa059c708d8bc&o=&hp=1",
                    25,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/348100950.jpg?k=37dd3d6d2d8cdb8cabaf26ea045001c0080f66b29c89c697ee4b8bddbb16257b&o=&hp=1",
                    25,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/348100953.jpg?k=71a743dcd5c5fb648c69dad218514d68c333c8265ab4bd0130e44d5613d25366&o=&hp=1",
                    25,
                },
                {
                  "https://cf.bstatic.com/xdata/images/hotel/max1024x768/348100959.jpg?k=a11639bf8f3d86f75e9c040e4f1163a72d26a04b7b5c494c97e5a8b675fbf948&o=&hp=1",
                  25,
                },
                {
                  "https://cf.bstatic.com/xdata/images/hotel/max1024x768/348109581.jpg?k=1f7dfbc191c330a8ee6f9c265521b4008dc482cd92cc21f039b5b043b0508a1e&o=&hp=1",
                  25,
                },
                {
                  "https://cf.bstatic.com/xdata/images/hotel/max1024x768/348100966.jpg?k=e9dc4ea441c30a63dd8163771c84767a7290a057ee8e1af474d4c57ea7ca33a3&o=&hp=1",
                  25,
                },
                {
                  "https://cf.bstatic.com/xdata/images/hotel/max1280x900/348109578.jpg?k=17bdd02cc1ea7cb9178f74a27bb670604572c0a8467d95e5e4e57b08793b809c&o=&hp=1",
                  25,
                },

                //26 hotel red sea
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/376719585.jpg?k=dc44a3e762d29fa1d96138bd4631ab3712c9ebf1d8ef7173eaa0559f53caa3b9&o=&hp=1",
                    26
                },
                {
                   "https://cf.bstatic.com/xdata/images/hotel/max1024x768/376719588.jpg?k=971cfb679d40395e80ddd52a7b70b583d92c00b6ea23d7c8e8bbe37507bc2621&o=&hp=1",
                    26
                },
                {
                   "https://cf.bstatic.com/xdata/images/hotel/max1024x768/378329504.jpg?k=27c7457ef49d4aff6903896a74b5a82c99a4a7524179b7303e1ffd440ccd381a&o=&hp=1",
                    26
                },
                {
                   "https://cf.bstatic.com/xdata/images/hotel/max1024x768/378329573.jpg?k=8b728ed776fa0903d7002e01781bee188e27d12a5fe9156bb1897d018a2d1c02&o=&hp=1",
                    26
                },
                {
                   "https://cf.bstatic.com/xdata/images/hotel/max1024x768/378329601.jpg?k=7fd313d3be9941794b5c3578009f41ff0261298af0ed95ad3c36ba8871ffe6bc&o=&hp=1",
                    26
                },
                {
                   "https://cf.bstatic.com/xdata/images/hotel/max1024x768/378329631.jpg?k=7d0f43a7fc6cd8603490363e6b2a7d40f6bae7906329e516e8a5ee5c10261a89&o=&hp=1",
                    26
                },
                {
                   "https://cf.bstatic.com/xdata/images/hotel/max1024x768/378329553.jpg?k=0571126463f9d2227990947292b8d53291ec0e955e83d7e8bc4ced957eafb59f&o=&hp=1",
                    26
                },

                //27
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402663267.jpg?k=a7f1c4905d68957b3aec16bd4bfb0bb4eba4cbe98ceb29a10406d79f64326ff6&o=&hp=1",
                    27
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402668008.jpg?k=9076742fdb4271ac0f826be7aa662464baab8851b43a171fcce549657a500d71&o=&hp=1",
                    27
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402673928.jpg?k=309b0228772361cba7045791bf5e305777fc7672ce99bc6edc0098908b0a6db9&o=&hp=1",
                    27
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402663222.jpg?k=b074b2e56a3b5afec619be80352a44b494e5715bf193302bd0aed03d7fa23901&o=&hp=1",
                    27
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402667790.jpg?k=fc44f8533482b2f5e11039faa3e6155dd7127865cdac160070125637bcd5e232&o=&hp=1",
                    27
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402439290.jpg?k=836a4c89dbf3d1dc18a44755f1d520c800c0de37b05310394bc329cb5bde7f89&o=&hp=1",
                    27
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/402438327.jpg?k=75829feebe441f0030f6e165473c5551397008edc2dd0698ec786df7e324b2d0&o=&hp=1",
                    27
                },

                //28 villa
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/294263162.jpg?k=18433aec4e03d2c5f718fe3af28bddef2c30ed7d672eee802768da994f3f2609&o=&hp=1",
                    28
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/294264006.jpg?k=d3acd3df570d9b5025c629252da7fb96a9ab632f35e11588579d98e37e12e5c4&o=&hp=1",
                    28
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/294520126.jpg?k=a61bb9fcf7e6c2ac2cbd31d0fbb972c82998a0c0f055cd6f9ea2967f774c7d68&o=&hp=1",
                    28
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/294263940.jpg?k=1790000c56798431a8b67708e462a0082c652f3c887c3b92d9220702d9dd5311&o=&hp=1",
                    28
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/294251929.jpg?k=6ddcbb7bda9641ca92530be46050e214789828151fb387180bc9588aca11d9c2&o=&hp=1",
                    28
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/294520419.jpg?k=8f9e7aa57462b8dae8adb1d348549c4c9a8d004aa0ddf77ffaa331255242545f&o=&hp=1",
                    28
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/403351745.jpg?k=c937ee94c64fcf60dc13d1caaa678de99aa911af285475c7d46a416a9713c911&o=&hp=1",
                    28
                },
                //29
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/374932913.jpg?k=74e82111d00ecc542c7d197409c5cedd7c91163784ac80e61c0876dc1f52bb79&o=&hp=1",
                    29
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/374932964.jpg?k=8476783733e509ae651bcdcaacf8b26dc0334677fd6be4844230722c15333571&o=&hp=1",
                    29
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/374932970.jpg?k=a509891ec65ba84e7b4e50a9799f6e5a09ce4295fdc38e879f6fc71f1e154731&o=&hp=1",
                    29
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/374933038.jpg?k=a46d6a9198572ed8a3d30831e8bf83e696e7a00dba21167791e8d6e4dd43c78e&o=&hp=1",
                    29
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/374933044.jpg?k=b00a223e74ff611fd248d02816d897066d0e81c6b892755a532df5704cb66fef&o=&hp=1",
                    29
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/374933082.jpg?k=9840fa2eb1374a720060015d829da626448b102e767e7d3eba400f76bb52ab30&o=&hp=1",
                    29
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/374933021.jpg?k=4ba00cedea1829036d13038be4d0ab9ecd76fe7877ed9c874a1559a278bc595a&o=&hp=1",
                    29
                },
                //30 apartment
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/296382276.jpg?k=e16341defe78bab6fdd17721cd21e3977bc6f77fb441e672201984a97ab46358&o=&hp=1",
                    30
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/295331326.jpg?k=a8c2431a40ddcf50e1be4151bf3de83932b5de53e641a9d8c857c5840efb485c&o=&hp=1",
                    30
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/296381286.jpg?k=e330385466d6f0b4f3ba9ae2a8291929e9e4ab3a9edf6ab3b61b0edb49cd7507&o=&hp=1",
                    30
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/295914161.jpg?k=bd209eecd26677f451a6d02b296ef4fddc175c740ec34a05eab5311f580317cc&o=&hp=1",
                    30
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/296381388.jpg?k=7e65d6fe273072f9c6abe777210607097973e0febe8a571ab9865504fa984699&o=&hp=1",
                    30
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/295914181.jpg?k=1f34cfb0c1947ca1ca15249a2c34c73a94b1c01ab6523c584f6b21b60025e9ea&o=&hp=1",
                    30
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/295331302.jpg?k=b734343689ee598a6bf291f269412706cf2dfb6fa119663d737f36b8f679b06a&o=&hp=1",
                    30
                },

                //31 hotel sharm
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/382670406.jpg?k=3fe523b0c6839bf73eef2d0e607e4df8cb899a9b128f222e45b5e22e9a671c63&o=&hp=1",
                    31
                },
                {
                "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405977567.jpg?k=a6dc758e8ce974856f89afc6103156ada0564abdb8245cd8d6bb31e53050a45c&o=&hp=1",
                31
                },
                {
                "https://cf.bstatic.com/xdata/images/hotel/max1024x768/345656725.jpg?k=1d990df94210ea826e7128403821c2e1f79306a619453dc314a4131be766a290&o=&hp=1",
                31
                },
                {
                "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405976909.jpg?k=681a2c6e9bed6f9d7c6e39f775e3df6de1e9aa8382c62091a7c47553e8026158&o=&hp=1",
                31
                },
                {
                "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405977701.jpg?k=119de8d3364366826a47ea7a95557bf589513d086c861dfcf92dda0117b65f45&o=&hp=1",
                31
                },
                {
                "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405977918.jpg?k=8e0edc90acee70ebf7a3caf1f637ec1744ebc290b606bd81452af8bd46a42baf&o=&hp=1",
                31
                },
                {
                "https://cf.bstatic.com/xdata/images/hotel/max1024x768/382671399.jpg?k=e34f7089626919fc9797ff0fbd98e27b27a17c606812aac94bf38445e71c9842&o=&hp=1",
                31
                },
                //32
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/362870436.jpg?k=9e1368c8744c8525e7537db3f1b72ec5b1ea32df7de05b9ad74f5a168b3dc775&o=&hp=1",
                    32
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/362863129.jpg?k=3be76e2265f2f19c3c48d904f1d948f379eaebcd9744fd9a6cb4e5c086178da0&o=&hp=1",
                    32
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/362863257.jpg?k=1ccb3555b1283b509417ed0a0201dd3e3b018af78f289452e2fcbc489be19ae9&o=&hp=1",
                    32
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/362870986.jpg?k=a5a2cb340f48fa2c6d11268e4c68f9bbedd614921c0fa3bfb6d629379e061bf5&o=&hp=1",
                    32
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/362863170.jpg?k=605ad93629dba140ff8d8e5d25ed0ec9f1c7f4d96a6c54a5cc84837962de7478&o=&hp=1",
                    32
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/367707215.jpg?k=816e3b6d3322719b445d201f751c7600ba1e6d7647f957dd5bbaf62e206f806f&o=&hp=1",
                    32
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/362863245.jpg?k=6263b878e4e53f27cfffe6821db6a054b641508ec0aa261d02ec06f4dad6e72c&o=&hp=1",
                    32
                },

                //33 villa
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/299600602.jpg?k=9ab922127ee357f9a541d63638459c903546a286985f5d95151e6b5365377e7a&o=&hp=1",
                    33,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/311735364.jpg?k=16f5d690ea181a1790580e6bfcce6fc99820988c1678c7c8753ae49bf6a79706&o=&hp=1",
                    33,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/299600487.jpg?k=56ee3e26319f681ee0f20c17534d9142a8fcad4518e15033b88bc117932266ca&o=&hp=1",
                    33,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/299600487.jpg?k=56ee3e26319f681ee0f20c17534d9142a8fcad4518e15033b88bc117932266ca&o=&hp=1",
                    33,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/299360337.jpg?k=be48c0b4af44315e5be87c5508f4dcddc2e879f1012299d8906e20cc23400046&o=&hp=1",
                    33,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/298970514.jpg?k=fb8c059f2e7061bbedd900ceb2155b2c933331df83d57f1ac58c07fc97a73693&o=&hp=1",
                    33,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/299202012.jpg?k=38b41772fccb3cb05cd5200d09e00a512c97653b4a36d14f0138e11cb804362a&o=&hp=1",
                    33,
                },

                //34 
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/267141696.jpg?k=e2c482d1080f1b157559c16277431746e77c9a8f287ca74b16403c9d39d5516d&o=&hp=1",
                    34,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405064485.jpg?k=acdfef2df9deac3441af2b4cf4f955f9d359545dfa00534d5c76e3cc328788bc&o=&hp=1",
                    34,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/240197503.jpg?k=448269ce86b89e6d7ccd400774f11797dde7e616c1a2a92127bf42fafedf36ef&o=&hp=1",
                    34,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405064266.jpg?k=c9598d29adca4c2e96dde44643c1e60c6d190d59365fbb4afa3b9bc0efc57128&o=&hp=1",
                    34,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/240198695.jpg?k=71dbb7300fec5c5a14e03427363a228b778b5baa0ffb3d855380bb4910b76cfb&o=&hp=1",
                    34,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/266101600.jpg?k=15d6af74ff37bef347dde247f94d0152adb5bb61f49133f80ec8e06276bbf9e2&o=&hp=1",
                    34,
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/266096213.jpg?k=d5bc8f8e195d7b1c610b5f6899df897b335b89ba7875960acc35e521f91af6ea&o=&hp=1",
                    34,
                },
                //35 apartment sharm 
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405083281.jpg?k=b635f0967fb550fd1977784ad75f992292ff6c1dcdda8092bbae14cdefedfb55&o=&hp=1",
                    35
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405082983.jpg?k=5758d8833f7a3e5ed1f9ea12fa81cb897de1ddaf32ca358bf8c9ada9b921b61d&o=&hp=1",
                    35
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405083151.jpg?k=8e5296d04b5fd07cd4bee434a7b6e5f41ac9732c91b04ce1343411415cdb0296&o=&hp=1",
                    35
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405089200.jpg?k=bcfce3a0c60cac812f0023164f789119075562d9c56f9ed698a4c5f1d5634e55&o=&hp=1",
                    35
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405089194.jpg?k=1e93e52c36a1200373216f09dfcf025e21d3279f399737be3a9f9ee2486bbb5e&o=&hp=1",
                    35
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405089156.jpg?k=ff72fd5332fdfe42100a8eace7dc54612650527c3f4e12520c37ff1f98a9fe8b&o=&hp=1",
                    35
                },
                {
                    "https://cf.bstatic.com/xdata/images/hotel/max1024x768/405082426.jpg?k=8f4839c0853da02d28c07f9bcd253e227726d42174d1a3353a84baf2aeb70ca9&o=&hp=1",
                    35
                },
	               #endregion
                    

                   

                }

            );

            /* Address */
            migrationBuilder.InsertData
                (
                    table: "addresses",
                    columns: new[]
                    {
                        "IBookingId",
                        "address",
                        "lat",
                        "lng",
                        "GovernorateId",
                        "CityId"
                    },
                    values: new object[,]
                    {
                        {1, "هيلتون رمسيس، Nile Corniche, Sharkas, Bulaq, Egypt", 30.0502819, 31.2320504, 1, 1 },
                        {2, "هيلتون رمسيس، Nile Corniche, Sharkas, Bulaq, Egypt", 30.0502819, 31.2320504, 1, 1 },
                        {3, "هيلتون رمسيس، Nile Corniche, Sharkas, Bulaq, Egypt", 31.2811595, 30.01148340000001, 1, 1 },
                        {4, "هيلتون رمسيس، Nile Corniche, Sharkas, Bulaq, Egypt", 30.0502819, 31.2320504, 1, 1 },
                        {5, "هيلتون رمسيس، Nile Corniche, Sharkas, Bulaq, Egypt", 30.0502819, 31.2320504, 1, 1 },
                        {6, "هيلتون رمسيس، Nile Corniche, Sharkas, Bulaq, Egypt", 30.0502819, 31.2320504, 1, 1 },
                        {7, "هيلتون رمسيس، Nile Corniche, Sharkas, Bulaq, Egypt", 30.0502819, 31.2320504, 1, 1 },
                        //hottel cairo
                        {8,"Corniche El Nile, Ramlet Beaulac, Cairo, Egypt",30.0719907,31.2278928,1,37},
                        {9,"56 Kasr Al Nile, Al Fawalah, Abdeen, Cairo Downtown, 4th Floor, 11518 Cairo, Egypt –",30.0495033,31.2461452,1,30},
                        //villa cairo
                        {10,"309 Ganoob Academia (A) District. Behind Down Town Mall, New Cairo, New Cairo",30.0602454,31.2101179,1,40},
                        {11,"Abou Al Hool Al Seiahi, 61652 Cairo, Egypt",29.9762053,31.1414724,1,46},
                        //apartment cairo
                        {12,"El Emdad and El Tamween Building, 8th Floor, Flat 81, Nasr City, 11765 Cairo",30.0699873,31.3446328,1,48},
                        {13,"201 Gamal Abdel Nasser, 5th settlement, New Cairo City, 11835 Cairo, Egypt ",29.9912319,31.4278952,1,50},
                        //Giza Hotel
                        {14,"Al Remaya 7 Al Remaya square Cairo Alxsandria road, Giza, 12511 Cairo, Egypt",29.9889441,31.1297589,2,75},
                        {15,"Al Asema 12, Giza, 21634 Cairo, Egypt ",29.9900007,31.1373851,2,84},
                        //Giza Villa
                        {16,"Villa 14 Al Khamayel Compound Alworoud - El Sheikh .Zayed City, in front of Hyper 1 market, 6th of October City, 12593 6th Of October, Egypt",30.0194418,31.0110957,2,59},
                        {17,"Gamal Abd Al Nassir Axis ڤيلا 55 السياحية الشمالية مقابل بوابة 20 مول العرب, 12573 6th Of October, Egypt ",30.008488,30.9705018,2,1},
                        //Giza apartment
                        {18,"Street 6, 6th Of October, Egypt",29.9533879,30.9281209,2,87},
                        {19,"GTA 8 Dreamland Compound, Entrance 3 After Dreamland Hospital, 12345 6th",29.9727201,31.0390644,2,89},
                        //Alex Hotel
                        {20,"5 Oskofia Street Beside the Greek Church in front of Saint Catherine's School, El Mansheya El Soghra, 99999 الإسكندرية, مصر",31.1948731,29.8958044,3,117 },
                        {21,"Moustafa Kamel, Corniche Road Roshdy, Alexandria, Egypt",31.0557568,29.7197476,3,114 },
                        //Alex Villa
                        {22,"Kilo 38 Alexandria - Matrouh Road, North Coast, Alexandria, Egypt",30.9939824,29.5957426,3,125 },
                        {23," الحي الثالث المجتمع المحلي الرابع مجاورة 2 قطعة 219, Alexandria, Egypt",30.0267048,31.4598444,3,123 },
                        //Alex apartment
                        {24,"مصطفى كامل, Alexandria, Egypt ",31.248057,30.0008903,3,123 },
                        {25,"112 شارع زكريا غنيم العاشر, 21500 Alexandria, Egypt",31.2175238,29.9265748,3,110 },
                        //Red sea hotels Hurguda
                        {26,"El Dahar, Abdel-Moneim Riad Square, 84511 Hurghada, Egypt",27.2591473,33.8129257,4,1 },
                        {27,"El Corniche Street - Hurghada, Red Sea, 19706 الغردقة, مصر",27.2561602,33.8288267,4,1 },
                        //villa
                        {28,"Safaga Road Km12 Hurghada Red Sea Egypt Egypt, 84517 Hurghada, Egypt ",27.1332614,33.8304279,4,1 },
                        {29,"29 Hurgada - Al Ismaileya, 46616 الغردقة, مصر",29.9634626,32.5551746,4,1 },
                        //apartment 1
                        {30,"Sheraton Road, 84511 Hurghada, Egypt",27.2046564,33.8488577,4,1 },
                        //sharm sheikh south sinai hotels
                        {31,"sea street ,Um El Seed Cliff El Forsya Street ; Um El Seed cliff, 44628 Sharm El Sheikh, Egypt",27.8648531,34.3126042,5,1 },
                        {32,"Sharm El-Sheikh, Qesm Sharm Ash Sheikh, Egypt, 46619 Sharm El Sheikh, Egypt",27.9654198,34.3617769,5,1 },
                        //villa
                        {33,"1 Four Seasons Resort, Boulevard, El-Salam, Sharm El Sheikh, Egypt",27.9564317,34.3916611,5,1 },
                        {34," NABQ BAY, approx. 20 km from the entertainment centre in Naama Bay; approx. 8 km from the airport in Sharm El Sheikh. NABQ BAY, 46619 Sharm El Sheikh, Egypt",28.1213151,34.4410615,5,1 },
                        {35,"Nama bay, 44264 شرم الشيخ, مصر",27.9061088,34.3271739,5,1 },








                    }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
