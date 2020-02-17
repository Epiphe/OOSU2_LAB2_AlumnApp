using BusinessEntites;
using BusinessEntites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterfacesAndRepositories
{
    class FinishedEducationRepository : Repository<FinishedEducation>, IFinishedEducationRepository
    {
        public FinishedEducationRepository(AlumnProgramContext context) : base(context)
        {
        }
    }
}
