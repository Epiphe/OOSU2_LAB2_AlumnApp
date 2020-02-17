using BusinessEntites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AlumnProgramContext _context;

        public UnitOfWork(AlumnProgramContext alumnProgramContext)
        {
            _context = alumnProgramContext;
            AlumnRepositorys = new AlumnRepository(_context);
            AdminRepositorys = new AdminRepository(_context);
            ActivityRepositorys = new ActivityRepository(_context);
            FinishedEducationRepositorys = new FinishedEducationRepository(_context);
            ListExportRepositorys = new ListExportRepository(_context);
            OtherEducationRepositorys = new OtherEducationRepository(_context);
            ProgrammingLanguageRepositorys = new ProgrammingLanguageRepository(_context);
        }

        public IAlumnRepository AlumnRepositorys { get; set; }
        public IAdminRepository AdminRepositorys { get; set; }
        public IActivityRepository ActivityRepositorys { get; set; }
        public IFinishedEducationRepository FinishedEducationRepositorys { get; set; }
        public IListExportRepository ListExportRepositorys { get; set; }
        public IOtherEducationRepository OtherEducationRepositorys { get; set; }
        public IProgrammingLanguageRepository ProgrammingLanguageRepositorys { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
