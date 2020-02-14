using BusinessEntites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Seed
{
    public class AlumnSeed
    {
        public static void Populate(AlumnContext alumnContext)
        {
            alumnContext.Alumns.Add(new Alumn()
            {
                FirstName = "Jenny",
                LastName = "Barnes",
                UserName = "jenny@arkham.com",
                Email = "jenny@arkham.com",
                Password = "qwerty"

            });
            alumnContext.Alumns.Add(new Alumn()
            {
                FirstName = "Dexter",
                LastName = "Drake",
                UserName = "dexter@arkham.com",
                Email = "dexter@arkham.com",
                Password = "qwerty"

            });
            alumnContext.Admins.Add(new Admin()
            {
                FirstName = "Börje",
                LastName = "Hansson",
                UserName = "T100",
                Email = "borje.Hansson@hb.se",
                Password = "qwerty"
            });
            alumnContext.Activities.Add(new Activity()
            {
                Titel = "Elon Musk föreläser om innovation.",
                Description = "Kom och se en rafflande föreläsning av ingenmindre än Elon Musk."
            });
            alumnContext.SaveChanges();
        }
    }
}
