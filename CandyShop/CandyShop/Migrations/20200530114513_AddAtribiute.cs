using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class AddAtribiute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Orders",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 25);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "Orders",
                type: "int",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "City",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Address",
                table: "Orders",
                type: "int",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);
        }
    }
}
