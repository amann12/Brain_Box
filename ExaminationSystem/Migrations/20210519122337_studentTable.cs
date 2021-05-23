using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaminationSystem.Migrations
{
    public partial class studentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sId = table.Column<int>(nullable: false),
                    sName = table.Column<string>(nullable: true),
                    sEmailId = table.Column<string>(nullable: true),
                    sDOB = table.Column<DateTime>(nullable: false),
                    sFatherName = table.Column<string>(nullable: true),
                    sMotherName = table.Column<string>(nullable: true),
                    sBloodGroup = table.Column<int>(nullable: true),
                    sGender = table.Column<int>(nullable: true),
                    sMobileNumber = table.Column<long>(nullable: false),
                    sAddress = table.Column<string>(nullable: true),
                    sRollNumber = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
