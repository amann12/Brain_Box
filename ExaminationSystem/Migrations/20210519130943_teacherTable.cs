using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaminationSystem.Migrations
{
    public partial class teacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tId = table.Column<int>(nullable: false),
                    tName = table.Column<string>(nullable: true),
                    tGender = table.Column<int>(nullable: true),
                    tBloodGroup = table.Column<int>(nullable: true),
                    tEmailId = table.Column<string>(nullable: true),
                    tMobileNumber = table.Column<long>(nullable: false),
                    tQualification = table.Column<string>(nullable: true),
                    tAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "tAddress", "tBloodGroup", "tEmailId", "tGender", "tId", "tMobileNumber", "tName", "tQualification" },
                values: new object[] { 1, "Noida", 4, "dhruv.cs@gmail.com", 0, 1, 987654321L, "Dhruv", "PHD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
