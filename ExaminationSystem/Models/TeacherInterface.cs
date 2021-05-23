using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public interface TeacherInterface
    {

        // Interface to Implement all Add, Update, Delete to the Server/Database.
        Teacher fetchTeacherDetails(int Id);

        // To get all List from Database.
        IEnumerable<Teacher> TeacherDetails();

         //Add a Teacher to the Database.
        Teacher Add(Teacher teacher);

        // Delete a Teacher from the Database.
        Teacher Delete(int Id);

        // Update Some Details to the Database (Edit Process).
        Teacher Update(Teacher teacherChange);
    }
}
