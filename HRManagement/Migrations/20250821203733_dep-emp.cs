using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagement.Migrations
{
    public partial class depemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "dptdepartment_id",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_employees_dptdepartment_id",
                table: "employees",
                column: "dptdepartment_id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_dptdepartment_id",
                table: "employees",
                column: "dptdepartment_id",
                principalTable: "departments",
                principalColumn: "department_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_dptdepartment_id",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_dptdepartment_id",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "dptdepartment_id",
                table: "employees");
        }
    }
}
