using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.ViewModelCourse
{
    public class CreateCourseViewModel
    {
        public int Id { get; set; }
        public int cId { get; set; }
        public string cName { get; set; }
        public string cType { get; set; }
        public string cDuration { get; set; }
    }
}
