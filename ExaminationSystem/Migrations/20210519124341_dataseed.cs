using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaminationSystem.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "sAddress", "sBloodGroup", "sDOB", "sEmailId", "sFatherName", "sGender", "sId", "sMobileNumber", "sMotherName", "sName", "sRollNumber" },
                values: new object[] { 1, "Shankar Nagar", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "amangn12@gmail.com", "Avinash Gupta", 0, 1, 7289868901L, "Manisha Gupta", "Aman", 1900L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
