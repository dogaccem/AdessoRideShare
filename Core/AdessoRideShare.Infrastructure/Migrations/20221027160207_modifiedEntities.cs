using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdessoRideShare.Infrastructure.Migrations
{
    public partial class modifiedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Routes",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Routes",
                newName: "isActive");
        }
    }
}
