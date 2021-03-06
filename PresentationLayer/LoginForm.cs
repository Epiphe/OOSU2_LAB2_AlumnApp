﻿using System;
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
    public partial class LoginForm : Form
    {
        public BusinessManager BM = new BusinessManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vårt syfte med alumnappen är att erbjuda alumner från högskolan i Borås aktiviteter som till exempel gästföreläsningar eller aktiviteter för att träffa personer som gått samma utbildning samt ge oss en möjlighet att kontakta alumner ifall vi behöver till exempel gästföreläsare från arbetslivet. \nVid registreringen av kontot behöver du uppge epostadress och namn som kontaktuppgifter. Sedan kan du frivilligt registrera fler uppgifter om examina, certifikat etc. \nVill du ändra på personuppgifter eller ta bord ditt konto finns den möjligheten i appen. \n\nGodkänner du villkoren?", "Villkor enligt GDPR för AlumnAppen", MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                CreateUserForm createUserForm = new CreateUserForm();
                createUserForm.ShowDialog();
            }
            else
            {
                Close();
            }
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //string inputUserName = textBoxUserName.Text;
            //string inputPassword = textBoxPassword.Text;
            // (textBoxUserName.Text, textBoxPassword.Text)

            if (BM.ControlLogin(textBoxUserName.Text.ToLower(), textBoxPassword.Text.ToLower()))
            {
                if (textBoxUserName.Text.Contains("@"))
                {
                    MainAlumnForm mainAlumnForm = new MainAlumnForm();
                    mainAlumnForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MainAdminForm mainAdminForm = new MainAdminForm();
                    mainAdminForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Du har inte angett rätt användarnamn eller löseord. \nSaknar du ett konto kan du skapa ett nytt genom att klicka på skapa konto länken under logga in.");
            }
        }
    }
}
