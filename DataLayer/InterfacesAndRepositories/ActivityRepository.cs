using BusinessEntites;
using BusinessEntites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterfacesAndRepositories
{
    public class ActivityRepository : Repository<Activity>, IActivityRepository
    {
        public ActivityRepository(AlumnProgramContext context) : base(context)
        {
        }
    }
}
