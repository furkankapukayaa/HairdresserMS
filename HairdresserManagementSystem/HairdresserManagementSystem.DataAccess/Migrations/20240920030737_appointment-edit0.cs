using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HairdresserManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class appointmentedit0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentStatusType",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentStatusType",
                table: "Appointments");
        }
    }
}