using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Contexts.Junction
{
    public class AlumnActivity
    {
        public int UserID { get; set; }
        public Alumn Alumn { get; set; }

        public int ActivityID { get; set; }
        public Activity Activity { get; set; }
    }
}
