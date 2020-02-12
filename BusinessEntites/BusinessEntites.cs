using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class BusinessEntites
    {
        public abstract class User
        {
            public int UserID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        public class Admin : User
        {
            public Admin (string username, string password)
            {
                UserName = username;
                Password = password;
            }
        }

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
        public class FinishedEducation
        {
            public int FinEduID { get; set; }
            public string Education { get; set; }
            public DateTime EducationEndDate { get; set; }
        }
        public class OtherEducation
        {
            public int OtrEduID { get; set; }
            public string EducationsAndCertificates { get; set; }
        }
        public class WorkExperience
        {
            public int WorkExpID { get; set; }
            public string AlumnWorkExperience { get; set; }
        }
        public class ProgrammingLanguage
        {
            public int ProgLangID { get; set; }
            public string ProgrammingLang { get; set; }
            public int YearsExperience { get; set; }
        }

        public class Activity
        {
            public int ActivityID { get; set; }
            public string Titel { get; set; }
            public Admin PersonInCharge { get; set; }
            public Admin ContactPerson { get; set; }
            public string Place { get; set; }
            public DateTime StartDateAndTime { get; set; }
            public DateTime StopDateAndTime { get; set; }
            public string Description { get; set; }
        }

        public class ListExport
        {
            public int ListExportID { get; set; }
            public DateTime SentDate { get; set; }
            public List<Alumn> ListedAlumns { get; set; }
        }



    }
}
