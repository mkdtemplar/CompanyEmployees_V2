using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployees_V2.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyID", "Address", "Country", "Name" },
                values: new object[] { 1, "583 Wall Dr. Gwynn Oak, MD 21207", "USA", "IT_Solutions Ltd" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyID", "Address", "Country", "Name" },
                values: new object[] { 2, "312 Forest Avenue, BF 923", "USA", "Admin_Solutions Ltd" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyID", "Name", "Position" },
                values: new object[] { 1, 26, 1, "Sam Raiden", "Software developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyID", "Name", "Position" },
                values: new object[] { 2, 30, 2, "Jana McLeaf", "Software developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyID", "Name", "Position" },
                values: new object[] { 3, 35, 2, "Kane Miller", "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2);
        }
    }
}
