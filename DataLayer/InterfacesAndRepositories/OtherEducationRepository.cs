using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using BusinessEntites.Contexts;

namespace DataLayer
{
    class OtherEducationRepository : Repository<OtherEducation>, IOtherEducationRepository
    {
        public OtherEducationRepository(AlumnProgramContext context) : base(context)
        {
        }
    }
}
