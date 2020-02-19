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
         
        public bool ControlLogin(string uName, string pWord)
        {
            var output = Context.Alumns.Where(alumn => alumn.Email == uName)
                .Where(alumn => alumn.Password == pWord);
            if (output== null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public IEnumerable<Alumn> GetAlumnList()
        {
            IEnumerable<Alumn> output = GetAll();
            return output;
        }

        //public IEnumerable<Alumn> GetAllSystemvetare()
        //{
        //    return Context.Alumns.Where(x => x.FinishedEducations);
        //}
    }
}
