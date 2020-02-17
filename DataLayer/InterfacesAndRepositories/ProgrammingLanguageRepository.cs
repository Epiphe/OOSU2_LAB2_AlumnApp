using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using BusinessEntites.Contexts;

namespace DataLayer.InterfacesAndRepositories
{
    class ProgrammingLanguageRepository : Repository<ProgrammingLanguage>, IProgrammingLanguageRepository
    {
        public ProgrammingLanguageRepository(AlumnProgramContext context) : base(context)
        {
        }
    }
}
