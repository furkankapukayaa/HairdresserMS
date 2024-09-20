using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HairdresserManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class chairenum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChairStatusType",
                table: "Chairs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChairStatusType",
                table: "Chairs");
        }
    }
}