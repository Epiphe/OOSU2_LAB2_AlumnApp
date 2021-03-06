﻿using System;
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
        public AlumnProgramContext alumnContext = new AlumnProgramContext();
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
                    if (A.UserName.ToLower().Equals(uName) && A.Password.Equals(uPass))
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
                    if (B.UserName.ToLower().Equals(uName) && B.Password.Equals(uPass))
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

        public List<Admin> GetAdmins()
        {
          return UnitOfWork.AdminRepositorys.GetAll().ToList();
        }

        public Admin GetAdmin(int Id)
        {
            return UnitOfWork.AdminRepositorys.Get(Id);
        }

        //Add activityscript
        #region add activity script

        public void CreateActivity (string title, Admin adminInCharge, Admin adminContact, string place, DateTime startDate, DateTime starttime, DateTime endtime, string description)
        {
            UnitOfWork.ActivityRepositorys.Add(

            new Activity()
            {
                Titel = title,
                PersonInCharge = adminInCharge,
                ContactPerson = adminContact,
                Place = place,
                StartDate = startDate,
                StartTime = starttime,
                EndTime = endtime,
                Description = description
            });
            UnitOfWork.Complete();
        }

        #endregion
    }
}
