using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Leo_Effert.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "BookCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LibraryCard",
                table: "BookCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "BookCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ReturnDate",
                table: "BookCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartDate",
                table: "BookCustomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "BookCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "BookCustomers");

            migrationBuilder.DropColumn(
                name: "LibraryCard",
                table: "BookCustomers");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "BookCustomers");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "BookCustomers");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "BookCustomers");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "BookCustomers");
        }
    }
}
