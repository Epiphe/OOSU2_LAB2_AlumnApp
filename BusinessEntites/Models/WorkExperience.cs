using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntites
{

        public class WorkExperience
        {
            [Key]
            public int WorkExpID { get; set; }
            public string AlumnWorkExperience { get; set; }
            public Alumn Alumn;
        }

}
