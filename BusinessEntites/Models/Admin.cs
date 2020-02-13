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

        public Admin() { }
        public Admin(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
