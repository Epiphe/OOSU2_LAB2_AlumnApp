using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntites;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class MainAdminForm : Form
    {
        public BusinessManager BM = new BusinessManager();
        

        public MainAdminForm()
        {
            InitializeComponent();
            List<Admin> admins = BM.GetAdmins();
            foreach (Admin ad in admins)
            {
                comboBoxPersonInCharge.Items.Add(ad.FirstName+" "+ad.LastName);
                comboBoxContactPerson.Items.Add(ad.FirstName + " " + ad.LastName);
            }

            
        }

        private void tabControlMainAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateActivity_Click(object sender, EventArgs e)
        {

        }
    }
}
