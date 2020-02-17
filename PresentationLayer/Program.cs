using BusinessEntites.Contexts;
using BusinessEntites.Models.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var message = MessageBox.Show("Vill du återställa databasen?", "Meddelande", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                AlumnProgramContext alumnContext = new AlumnProgramContext();

                alumnContext.Database.EnsureDeleted();
                alumnContext.Database.EnsureCreated();

                AlumnSeed.Populate(alumnContext);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
