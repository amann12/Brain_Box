using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int cId { get; set; }
        public string cName { get; set; }
        public string cType { get; set; }
        public string cDuration { get; set; }
    }
}
