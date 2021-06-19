using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class ParentInfo
    {
        public int Id { get; set; }
        public string FatherName { get; set; }
        public string FatherOccupation { get; set; }
        public string FatherEmail { get; set; }
        public int FatherNumber { get; set; }
        public bGroup? FatherBG { get; set; }

        public string MotherName { get; set; }
        public string MotherOccupation { get; set; }
        public string MotherEmail { get; set; }
        public string MotherNumber { get; set; }
        public bGroup? MotherBG { get; set; }
    }
}
