using BusinessEntites.Contexts;
using BusinessEntites.Contexts.Junction;
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
            Alumn alumn1 = new Alumn()
            {
                FirstName = "Jenny",
                LastName = "Barnes",
                UserName = "jenny@arkham.com",
                Email = "jenny@arkham.com",
                Password = "qwerty"
            };
            alumnContext.Alumns.Add(alumn1);

            Alumn alumn2 = new Alumn()
            {
                FirstName = "Dexter",
                LastName = "Drake",
                UserName = "dexter@arkham.com",
                Email = "dexter@arkham.com",
                Password = "qwerty"
            };
            alumnContext.Alumns.Add(alumn2);


            Admin admin1 = new Admin()
            {
                FirstName = "Börje",
                LastName = "Hansson",
                UserName = "T100",
                Email = "borje.Hansson@hb.se",
                Password = "qwerty"
            };
            alumnContext.Admins.Add(admin1);

            Activity activity1 = new Activity()
            {
                Titel = "Elon Musk föreläser om innovation.",
                Description = "Kom och se en rafflande föreläsning av ingenmindre än Elon Musk."
            };
            alumnContext.Activities.Add(activity1);

            AlumnActivity alumnActivity1 = new AlumnActivity()
            {
                Alumn = alumn1,
                Activity = activity1
            };
            alumnContext.AlumnActivities.Add(alumnActivity1);
            AlumnActivity alumnActivity2 = new AlumnActivity()
            {
                Alumn = alumn2,
                Activity = activity1
            };
            alumnContext.AlumnActivities.Add(alumnActivity2);

            alumnContext.SaveChanges();


        }
    }
}
