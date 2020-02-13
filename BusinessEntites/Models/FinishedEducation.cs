﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntites
{
    public class FinishedEducation
    {
        [Key]
        public int FinEduID { get; set; }
        public string Education { get; set; }
        public DateTime EducationEndDate { get; set; }
    }
}
