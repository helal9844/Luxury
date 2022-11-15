
using Microsoft.EntityFrameworkCore.Migrations;

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
                    "created_at"
                },
                values: new object[,]
                {
                    //1
                    { 4, null,
                        "Alex Luxury sea view apartment",
                        "Alex Luxury sea view apartment",
                        DateTime.Now,
                    },
                    //2
                    { 2,1,
                        "غرفة فيرمونت جولد سيجنتشر مزدوجة - لغير المدخنين",
                        "Fairmont Gold Signature Double Room - Non-Smokingm",
                        DateTime.Now,
                    },
                    //3
                    { 2,3,
                        "Helnan Palace Hotel - Adults Only",
                        "Helnan Palace Hotel - Adults Only",
                        DateTime.Now,
                    },
                    //4
                    { 4,7,
                        "شقق ستير مياستو الفندقية",
                        "Aparthotel Stare Miasto",
                        DateTime.Now,
                    },
                    //5
                    { 4,7,
                        "Golden Queen Apartments Old Town",
                        "Golden Queen Apartments Old Town",
                        DateTime.Now,
                    },
                    //6
                    { 2,2,
                        "Chez Haytham At Four Seasons Nile Plaza Residential Suite",
                        "Chez Haytham At Four Seasons Nile Plaza Residential Suite",
                        DateTime.Now,
                    },
                    //7
                    { 3,5,
                        "Sheraton ocean 401",
                        "Sheraton ocean 401",
                        DateTime.Now,
                    }
                }
            );

            /* ATTRIBUTES */
            migrationBuilder.InsertData
            (
                table: "iBookingAttributes",
                columns: new[]
                {
                    "cost",
                    "capacity",
                    "space",
                    "city_view",
                    "kitchen",
                    "pool",
                    "bath",
                    "p_bath",
                    "balcony",
                    "conditioning",
                    "washing_m",
                    "wi_fi",
                    "parking",
                    "room_service",
                    "transfer_service",
                },
                values: new object[,]
                {
                    {
                        2000, 4, 120, true, false, true, true, true, true, false, true, true, true, false, false,
                    },
                    {
                        8000, 2, 90, true, true, true, true, true, true, true,true, true, true, true, false
                    },
                    {
                        5000, 3, 180, true, true, false, true, true, true, true,true, true, true, true, false
                    },
                    {
                        3000, 4, 150, true, false, true, true, true, true, false, true, true, true, false, false,
                    },
                    {
                        4000, 4, 180, true, false, true, true, true, true, false, true, true, true, false, false,
                    },
                    {
                        7900, 2, 90, true, true, true, true, true, true, true,true, true, true, true, false
                    },
                    {
                        1500, 8, 500, true, true, true, true, true, true, true,true, true, true, true, false
                    },
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
                    }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
