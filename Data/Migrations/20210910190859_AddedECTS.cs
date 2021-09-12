using Microsoft.EntityFrameworkCore.Migrations;

namespace final.Data.Migrations
{
    public partial class AddedECTS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ects",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ects",
                table: "Courses");
        }
    }
}
