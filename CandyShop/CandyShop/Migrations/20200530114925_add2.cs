using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class add2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Orders",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Orders",
                type: "int",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5);
        }
    }
}
