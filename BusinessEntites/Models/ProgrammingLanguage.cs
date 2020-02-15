using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntites
{
    public class ProgrammingLanguage
    {
        [Key]
        public int ProgLangID { get; set; }
        public string ProgrammingLang { get; set; }
        public int YearsExperience { get; set; }
        public Alumn Alumn;
    }
}
