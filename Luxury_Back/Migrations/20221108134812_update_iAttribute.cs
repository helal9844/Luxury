using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luxury_Back.Migrations
{
    public partial class update_iAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "iAttributes",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "iAttributes",
                newName: "created_at");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "iAttributes",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "inputType",
                table: "iAttributes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "inputType",
                table: "iAttributes");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "iAttributes",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "iAttributes",
                newName: "Created_at");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "iAttributes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");
        }
    }
}
