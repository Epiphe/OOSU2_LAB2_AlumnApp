using System.Collections.Generic;
using BusinessEntites;

namespace DataLayer
{
    public interface IAlumnRepository : IRepository<Alumn>
    {
        IEnumerable<Alumn> GetAlumnList();
        //IEnumerable<Alumn> GetAllSystemvetare();
    }
}