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
                comboBoxPersonInCharge.Items.Add(ad.ToString());
                comboBoxContactPerson.Items.Add(ad.ToString());
            }

            
        }

        private void tabControlMainAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateActivity_Click(object sender, EventArgs e)
        {
            Admin chosenInCharge = BM.GetAdmin(comboBoxPersonInCharge.SelectedIndex);
            Admin chosenContact = BM.GetAdmin(comboBoxContactPerson.SelectedIndex);

            BM.CreateActivity(textBoxActivityTitel.Text,chosenInCharge,chosenContact,textBoxLocation.Text,dateTimePickerStart.Value,dateTimePickerStartTime.Value,dateTimePickerEndtime.Value,richTextBoxActivityDescription.Text);
        }

        private void dateTimePickerEndtime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

                
        }
    }
}
