using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Registiration.Migrations
{
    public partial class mig_lib_sys2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Book_publisher",
                table: "books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book_publisher",
                table: "books");
        }
    }
}
