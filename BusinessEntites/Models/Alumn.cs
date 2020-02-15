using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BusinessEntites.Contexts.Junction;

namespace BusinessEntites
{
    public class Alumn : User
    {

        public List<Activity> BookedActivites { get; set; }
        public List<FinishedEducation> FinishedEducations { get; set; }
        public List<OtherEducation> OtherEducations { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public ICollection<AlumnActivity> AlumnActivities { get; set; }

        public Alumn() { }
        public Alumn(string fName, string lName, string username, string password)
        {
            FirstName = fName;
            LastName = lName;
            Email = username;
            UserName = username;
            Password = password;
        }
    }
}
