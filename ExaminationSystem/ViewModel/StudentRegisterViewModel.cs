using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.ViewModel
{
    public class StudentRegisterViewModel
    {
        public int Id { get; set; }
        public int sId { get; set; }
        public string sName { get; set; }
        public string sEmailId { get; set; }
        [DataType(DataType.Date)]
        public DateTime sDOB { get; set; }
        public string sFatherName { get; set; }
        public string sMotherName { get; set; }
        public bGroup? sBloodGroup { get; set; }
        public gen? sGender { get; set; }
        public long sMobileNumber { get; set; }
        public string sAddress { get; set; }
        public long sRollNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
