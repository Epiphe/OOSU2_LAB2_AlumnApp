using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BusinessEntites.Contexts.Junction;

namespace BusinessEntites
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        public string Titel { get; set; }
        public Admin PersonInCharge { get; set; }
        public Admin ContactPerson { get; set; }
        public string Place { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public ICollection<AlumnActivity> AlumnActivities { get; set; }
    }
}
