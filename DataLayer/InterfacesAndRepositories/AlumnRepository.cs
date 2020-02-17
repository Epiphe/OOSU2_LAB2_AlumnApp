using BusinessEntites;
using BusinessEntites.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AlumnRepository : Repository<Alumn>, IAlumnRepository
    {
        public AlumnRepository(AlumnProgramContext context) : base(context)
        {
        }

        //public IEnumerable<Alumn> GetAllSystemvetare()
        //{
        //    return Context.Alumns.Where(x => x.FinishedEducations);
        //}
    }
}
