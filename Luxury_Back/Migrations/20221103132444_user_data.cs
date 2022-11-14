using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class user_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[]
                {
                    "username",
                    "Email",
                    "Phone",
                    "password",
                    "is_active",
                    "is_admin",
                    "created_at"
                },
                values: new object[,]
                {
                    {
                        "admin", "admin@asp.net", 01234567890, "123456789", true, true, DateTime.Now
                    },
                    {
                        "user", "user@asp.net", 01234567899, "123456789", true, false,DateTime.Now
                    },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
