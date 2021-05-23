using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 1,
                sId = 1,
                sName = "Aman",
                sEmailId = "amangn12@gmail.com",
                sDOB = new DateTime(01 / 02 / 2002),
                sFatherName = "Avinash Gupta",
                sMotherName = "Manisha Gupta",
                sBloodGroup = bGroup.B,
                sGender = gen.Male,
                sMobileNumber = 7289868901,
                sAddress = "Shankar Nagar",
                sRollNumber = 1900


            }
            );
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Teacher>().HasData(
            new Teacher
            {
                Id = 1,
                tId = 1,
                tName = "Dhruv",
                tGender = gen.Male,
                tBloodGroup = bGroup.a,
                tEmailId = "dhruv.cs@gmail.com",
                tMobileNumber = 987654321,
                tQualification = "PHD",
                tAddress = "Noida"

            }
            );
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Course>().HasData(
            new Course
            {
                Id = 1,
                cId = 1,
                cName = "Btech",
                cType = "Regular",
                cDuration = "4 years"
            }
            );
        }
    }
}
