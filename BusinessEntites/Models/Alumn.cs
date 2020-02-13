using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Alumn : User
    {
        public string Email { get; set; }
        public List<Activity> BookedActivites { get; set; }
        public List<FinishedEducation> FinishedEducations { get; set; }
        public List<OtherEducation> OtherEducations { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public Alumn(string username, string password)
        {
            Email = username;
            UserName = username;
            Password = password;
        }
    }
}
