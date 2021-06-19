using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
   
    public class SqlStudentRepo : StudentInterface
    {
        private readonly AppDbContext context;
        public SqlStudentRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Student Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public Student Delete(int Id)
        {
            Student student = context.Students.Find(Id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
            return student;
        }

        public Student fetchStudentDetails(int Id)
        {
            return context.Students.Find(Id);
        }

        public Student GetDetailByEmail(string email)
        {
            return context.Students.SingleOrDefault(student => student.sEmailId == email);
        }

        public IEnumerable<Student> StudentDetails()
        {
            return context.Students;
        }

        public Student Update(Student studentChange)
        {
            var student = context.Students.Attach(studentChange);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return studentChange;
        }
    }
}
