using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using BusinessEntites.Contexts;
using DataLayer;




namespace BusinessLayer
{
    public class BusinessManager
    {
        public UnitOfWork UnitOfWork = new UnitOfWork(new AlumnProgramContext());

        //Loginscript returning true if the user is in the database.
        #region loginscript
        public bool ControlLogin(string uName, string uPass)
        {
            bool isAlumn = false;
            bool isAdmin = false;
            if (uName.Contains("@"))
            {
                List<Alumn> AllAlumns = UnitOfWork.AlumnRepositorys.GetAlumnList().ToList();
                foreach (Alumn A in AllAlumns)
                {
                    if (A.UserName.Equals(uName) && A.Password.Equals(uPass))
                    {
                         isAlumn = true;
                    }
                }
            }
            else
            {
                List<Admin> AllAdmin = UnitOfWork.AdminRepositorys.GetAll().ToList();
                foreach (Admin B in AllAdmin)
                {
                    if (B.UserName.Equals(uName) && B.Password.Equals(uPass))
                    {
                        isAdmin = true;
                    }

                }
            }
            if (isAdmin == true || isAlumn == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
