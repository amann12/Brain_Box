using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public interface StudentInterface
    {
        // Interface to Implement all Add, Update, Delete to the Server/Database.
        Student fetchStudentDetails(int Id);

        // To get all List from Database.
        IEnumerable<Student> StudentDetails();

        // Add a Student to the Database.
        Student Add(Student student);

        // Delete a Student from the Database.
        Student Delete(int Id);

        // Update Some Details to the Database (Edit Process).
        Student Update(Student studentChange);
    }
}
