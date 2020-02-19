using BusinessEntites;
using BusinessEntites.Contexts;

namespace DataLayer
{
    class FinishedEducationRepository : Repository<FinishedEducation>, IFinishedEducationRepository
    {
        public FinishedEducationRepository(AlumnProgramContext context) : base(context)
        {
        }
    }
}
