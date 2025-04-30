using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Management_System.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeSearch",
                table: "Employee",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "EmployeeList",
                table: "Employee",
                newName: "EmployeeID");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employee",
                newName: "EmployeeSearch");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Employee",
                newName: "EmployeeList");
        }
    }
}
