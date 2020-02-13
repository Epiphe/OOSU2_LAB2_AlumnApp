using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class ListExport
    {
        public int ListExportID { get; set; }
        public DateTime SentDate { get; set; }
        public List<Alumn> ListedAlumns { get; set; }
    }
}
