using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public interface CourseInterface
    {
        // Interface to Implement all Add, Update, Delete to the Server/Database.
        Course fetchCourseDetails(int Id);

        // To get all List from Database.
        IEnumerable<Course> CourseDetails();

        // Add a Teacher to the Database.
        Course Add(Course course);

        // Delete a Teacher from the Database.
        Course Delete(int Id);

        // Update Some Details to the Database (Edit Process).
        Course Update(Course CourseChange);
    }
}
