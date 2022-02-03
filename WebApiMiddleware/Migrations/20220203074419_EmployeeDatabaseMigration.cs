using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiMiddleware.Migrations
{
    public partial class EmployeeDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desg_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CMP_Branch_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
