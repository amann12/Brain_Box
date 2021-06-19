using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.ViewModel
{
    public class StudentCourseViewModel
    {
        //Student Details
        public int Id { get; set; }
        public string sName { get; set; }
        public string sEmailId { get; set; }
        public string sFatherName { get; set; }
        public string sMotherName { get; set; }
        public long sMobileNumber { get; set; }

        //Course Details
        public string cName { get; set; }
        public string cType { get; set; }
        public string cDuration { get; set; }

    }
}
