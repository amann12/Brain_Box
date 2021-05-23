using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.ViewModelTeacher
{
    public class CreateTeacherViewModel
    {
        public int Id { get; set; }
        public int tId { get; set; }
        public string tName { get; set; }
        public gen? tGender { get; set; }
        public bGroup? tBloodGroup { get; set; }
        public string tEmailId { get; set; }
        public long tMobileNumber { get; set; }
        public string tQualification { get; set; }
        public string tAddress { get; set; }
    }
}
