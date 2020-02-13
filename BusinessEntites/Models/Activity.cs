﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string Titel { get; set; }
        public Admin PersonInCharge { get; set; }
        public Admin ContactPerson { get; set; }
        public string Place { get; set; }
        public DateTime StartDateAndTime { get; set; }
        public DateTime StopDateAndTime { get; set; }
        public string Description { get; set; }
    }
}