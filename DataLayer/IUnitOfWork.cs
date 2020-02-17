using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IAlumnRepository AlumnRepositorys { get; set; }
        IAdminRepository AdminRepositorys { get; set; }
        IActivityRepository ActivityRepositorys { get; set; }
        IFinishedEducationRepository FinishedEducationRepositorys { get; set; }
        IListExportRepository ListExportRepositorys { get; set; }
        IOtherEducationRepository OtherEducationRepositorys { get; set; }
        IProgrammingLanguageRepository ProgrammingLanguageRepositorys { get; set; }
        int Complete();
    }
}
