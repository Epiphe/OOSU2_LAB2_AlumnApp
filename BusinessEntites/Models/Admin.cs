using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntites
{
    public class Admin : User
    {
        public List<Activity> activitiesContact;
        public List<Activity> activitiesInCharge;

        public Admin() { }
        public Admin(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public override string ToString()
        {
            return FirstName+" "+LastName;
        }
    }
}
