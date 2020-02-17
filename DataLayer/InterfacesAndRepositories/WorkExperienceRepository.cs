using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using BusinessEntites.Contexts;

namespace DataLayer
{
    class WorkExperienceRepository : Repository<WorkExperience>, IWorkExperienceRepository
    {
        public WorkExperienceRepository(AlumnProgramContext context) : base(context)
        {
        }
    }
}
