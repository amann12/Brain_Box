using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class SqlCourseRepo : CourseInterface
    {
        private readonly AppDbContext context;
        public SqlCourseRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Course Add(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return course;
        }

        public IEnumerable<Course> CourseDetails()
        {
            return context.Courses;
        }

        public Course Delete(int Id)
        {
            Course course = context.Courses.Find(Id);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }
            return course;
        }

        public Course fetchCourseDetails(int Id)
        {
            return context.Courses.Find(Id);
        }

        public Course Update(Course CourseChange)
        {
            var course = context.Courses.Attach(CourseChange);
            course.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return CourseChange;
        }
    }
}
