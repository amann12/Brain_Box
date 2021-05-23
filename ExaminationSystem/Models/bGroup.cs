using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public enum bGroup
    {
        [Display(Name ="A+")]
        A,
        [Display(Name ="B+")]
        B,
        [Display(Name ="AB+")]
        AB,
        [Display(Name ="O+")]
        O,
        [Display(Name ="A-")]
        a,
        [Display(Name ="B-")]
        b,
        [Display(Name ="AB-")]
        ab,
        [Display(Name ="O-")]
        o
    }
}
