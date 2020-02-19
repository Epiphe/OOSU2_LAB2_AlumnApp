using BusinessEntites;
using BusinessEntites.Contexts;

namespace DataLayer
{
    public class ActivityRepository : Repository<Activity>, IActivityRepository
    {
        public ActivityRepository(AlumnProgramContext context) : base(context)
        {
        }
    }
}
