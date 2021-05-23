using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class SqlTeacherRepo : TeacherInterface
    {
        private readonly AppDbContext context;
        public SqlTeacherRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Teacher Add(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            context.SaveChanges();
            return teacher;
        }

        public Teacher Delete(int Id)
        {
            Teacher teacher = context.Teachers.Find(Id);
            if (teacher != null)
            {
                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
            return teacher;
        }

        public Teacher fetchTeacherDetails(int Id)
        {
            return context.Teachers.Find(Id);
        }

        public IEnumerable<Teacher> TeacherDetails()
        {
            return context.Teachers;
        }

        public Teacher Update(Teacher teacherChange)
        {
            var teacher = context.Teachers.Attach(teacherChange);
            teacher.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return teacherChange;
        }
    }
}
