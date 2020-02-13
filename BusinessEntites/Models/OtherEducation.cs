using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntites
{
    public class OtherEducation
    {
        [Key]
        public int OtrEduID { get; set; }
        public string EducationsAndCertificates { get; set; }
    }
}
