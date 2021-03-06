﻿using BusinessEntites;
using BusinessEntites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        public AdminRepository(AlumnProgramContext context) : base(context)
        {
        }
        public string GetFullName(int id)
        {
            string fullName = Get(id).FirstName+" "+Get(id).LastName;
            return fullName;
        }
    }
}
