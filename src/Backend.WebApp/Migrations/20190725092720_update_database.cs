using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class update_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLate",
                table: "Checkins",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLate",
                table: "Checkins");
        }
    }
}
