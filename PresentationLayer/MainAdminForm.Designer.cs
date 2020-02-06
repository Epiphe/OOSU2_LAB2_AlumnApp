namespace PresentationLayer
{
    partial class MainAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMainAdmin = new System.Windows.Forms.TabControl();
            this.tabPageCreateActivity = new System.Windows.Forms.TabPage();
            this.tabPageCreateOffer = new System.Windows.Forms.TabPage();
            this.tabPageEditActivity = new System.Windows.Forms.TabPage();
            this.tabPageEditOffer = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxActivityTitel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPersonInCharge = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxContactPerson = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerSlut = new System.Windows.Forms.DateTimePicker();
            this.listBoxCreateActivity = new System.Windows.Forms.ListBox();
            this.btnCreateActivity = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbContactPerson = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.listBoxCreateOffer = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonCreateOffer = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControlMainAdmin.SuspendLayout();
            this.tabPageCreateActivity.SuspendLayout();
            this.tabPageCreateOffer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainAdmin
            // 
            this.tabControlMainAdmin.Controls.Add(this.tabPageCreateActivity);
            this.tabControlMainAdmin.Controls.Add(this.tabPageCreateOffer);
            this.tabControlMainAdmin.Controls.Add(this.tabPageEditActivity);
            this.tabControlMainAdmin.Controls.Add(this.tabPageEditOffer);
            this.tabControlMainAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabControlMainAdmin.Name = "tabControlMainAdmin";
            this.tabControlMainAdmin.SelectedIndex = 0;
            this.tabControlMainAdmin.Size = new System.Drawing.Size(519, 295);
            this.tabControlMainAdmin.TabIndex = 0;
            // 
            // tabPageCreateActivity
            // 
            this.tabPageCreateActivity.Controls.Add(this.btnCreateActivity);
            this.tabPageCreateActivity.Controls.Add(this.listBoxCreateActivity);
            this.tabPageCreateActivity.Controls.Add(this.dateTimePickerSlut);
            this.tabPageCreateActivity.Controls.Add(this.label7);
            this.tabPageCreateActivity.Controls.Add(this.dateTimePickerStart);
            this.tabPageCreateActivity.Controls.Add(this.label6);
            this.tabPageCreateActivity.Controls.Add(this.textBox1);
            this.tabPageCreateActivity.Controls.Add(this.label5);
            this.tabPageCreateActivity.Controls.Add(this.comboBoxContactPerson);
            this.tabPageCreateActivity.Controls.Add(this.label4);
            this.tabPageCreateActivity.Controls.Add(this.comboBoxPersonInCharge);
            this.tabPageCreateActivity.Controls.Add(this.label3);
            this.tabPageCreateActivity.Controls.Add(this.textBoxActivityTitel);
            this.tabPageCreateActivity.Controls.Add(this.label2);
            this.tabPageCreateActivity.Controls.Add(this.label1);
            this.tabPageCreateActivity.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateActivity.Name = "tabPageCreateActivity";
            this.tabPageCreateActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateActivity.Size = new System.Drawing.Size(511, 269);
            this.tabPageCreateActivity.TabIndex = 0;
            this.tabPageCreateActivity.Text = "Skapa aktivitet";
            this.tabPageCreateActivity.UseVisualStyleBackColor = true;
            // 
            // tabPageCreateOffer
            // 
            this.tabPageCreateOffer.Controls.Add(this.buttonCreateOffer);
            this.tabPageCreateOffer.Controls.Add(this.label12);
            this.tabPageCreateOffer.Controls.Add(this.listBoxCreateOffer);
            this.tabPageCreateOffer.Controls.Add(this.dateTimePickerEndDate);
            this.tabPageCreateOffer.Controls.Add(this.label11);
            this.tabPageCreateOffer.Controls.Add(this.dateTimePickerStartDate);
            this.tabPageCreateOffer.Controls.Add(this.label10);
            this.tabPageCreateOffer.Controls.Add(this.cbContactPerson);
            this.tabPageCreateOffer.Controls.Add(this.label9);
            this.tabPageCreateOffer.Controls.Add(this.textBoxTitel);
            this.tabPageCreateOffer.Controls.Add(this.label8);
            this.tabPageCreateOffer.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateOffer.Name = "tabPageCreateOffer";
            this.tabPageCreateOffer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateOffer.Size = new System.Drawing.Size(511, 269);
            this.tabPageCreateOffer.TabIndex = 1;
            this.tabPageCreateOffer.Text = "Skapa erbjudande";
            this.tabPageCreateOffer.UseVisualStyleBackColor = true;
            // 
            // tabPageEditActivity
            // 
            this.tabPageEditActivity.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditActivity.Name = "tabPageEditActivity";
            this.tabPageEditActivity.Size = new System.Drawing.Size(768, 400);
            this.tabPageEditActivity.TabIndex = 2;
            this.tabPageEditActivity.Text = "Redigera aktivitet";
            this.tabPageEditActivity.UseVisualStyleBackColor = true;
            // 
            // tabPageEditOffer
            // 
            this.tabPageEditOffer.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditOffer.Name = "tabPageEditOffer";
            this.tabPageEditOffer.Size = new System.Drawing.Size(768, 400);
            this.tabPageEditOffer.TabIndex = 3;
            this.tabPageEditOffer.Text = "Redigera erbjudande";
            this.tabPageEditOffer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beskrivning";
            // 
            // textBoxActivityTitel
            // 
            this.textBoxActivityTitel.Location = new System.Drawing.Point(10, 24);
            this.textBoxActivityTitel.Name = "textBoxActivityTitel";
            this.textBoxActivityTitel.Size = new System.Drawing.Size(208, 20);
            this.textBoxActivityTitel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ansvarig person";
            // 
            // comboBoxPersonInCharge
            // 
            this.comboBoxPersonInCharge.FormattingEnabled = true;
            this.comboBoxPersonInCharge.Location = new System.Drawing.Point(10, 64);
            this.comboBoxPersonInCharge.Name = "comboBoxPersonInCharge";
            this.comboBoxPersonInCharge.Size = new System.Drawing.Size(208, 21);
            this.comboBoxPersonInCharge.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kontakt person";
            // 
            // comboBoxContactPerson
            // 
            this.comboBoxContactPerson.FormattingEnabled = true;
            this.comboBoxContactPerson.Location = new System.Drawing.Point(10, 104);
            this.comboBoxContactPerson.Name = "comboBoxContactPerson";
            this.comboBoxContactPerson.Size = new System.Drawing.Size(208, 21);
            this.comboBoxContactPerson.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Plats";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Datum och starttid";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(10, 184);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerStart.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Datum och sluttid";
            // 
            // dateTimePickerSlut
            // 
            this.dateTimePickerSlut.Location = new System.Drawing.Point(10, 223);
            this.dateTimePickerSlut.Name = "dateTimePickerSlut";
            this.dateTimePickerSlut.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerSlut.TabIndex = 12;
            // 
            // listBoxCreateActivity
            // 
            this.listBoxCreateActivity.FormattingEnabled = true;
            this.listBoxCreateActivity.Location = new System.Drawing.Point(250, 24);
            this.listBoxCreateActivity.Name = "listBoxCreateActivity";
            this.listBoxCreateActivity.Size = new System.Drawing.Size(238, 186);
            this.listBoxCreateActivity.TabIndex = 13;
            // 
            // btnCreateActivity
            // 
            this.btnCreateActivity.Location = new System.Drawing.Point(250, 223);
            this.btnCreateActivity.Name = "btnCreateActivity";
            this.btnCreateActivity.Size = new System.Drawing.Size(238, 23);
            this.btnCreateActivity.TabIndex = 14;
            this.btnCreateActivity.Text = "Skapa aktivitet";
            this.btnCreateActivity.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Titel:";
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(10, 24);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(210, 20);
            this.textBoxTitel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kontaktperson:";
            // 
            // cbContactPerson
            // 
            this.cbContactPerson.FormattingEnabled = true;
            this.cbContactPerson.Location = new System.Drawing.Point(10, 68);
            this.cbContactPerson.Name = "cbContactPerson";
            this.cbContactPerson.Size = new System.Drawing.Size(210, 21);
            this.cbContactPerson.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Datum och starttid:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(11, 118);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerStartDate.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Datum och sluttid:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(11, 166);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerEndDate.TabIndex = 7;
            // 
            // listBoxCreateOffer
            // 
            this.listBoxCreateOffer.FormattingEnabled = true;
            this.listBoxCreateOffer.Location = new System.Drawing.Point(241, 24);
            this.listBoxCreateOffer.Name = "listBoxCreateOffer";
            this.listBoxCreateOffer.Size = new System.Drawing.Size(245, 199);
            this.listBoxCreateOffer.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Beskrivning:";
            // 
            // buttonCreateOffer
            // 
            this.buttonCreateOffer.Location = new System.Drawing.Point(241, 230);
            this.buttonCreateOffer.Name = "buttonCreateOffer";
            this.buttonCreateOffer.Size = new System.Drawing.Size(245, 23);
            this.buttonCreateOffer.TabIndex = 10;
            this.buttonCreateOffer.Text = "Skapa erbjudande";
            this.buttonCreateOffer.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(452, 315);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Logga ut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 350);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tabControlMainAdmin);
            this.Name = "MainAdminForm";
            this.Text = "MainAdminForm";
            this.tabControlMainAdmin.ResumeLayout(false);
            this.tabPageCreateActivity.ResumeLayout(false);
            this.tabPageCreateActivity.PerformLayout();
            this.tabPageCreateOffer.ResumeLayout(false);
            this.tabPageCreateOffer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainAdmin;
        private System.Windows.Forms.TabPage tabPageCreateActivity;
        private System.Windows.Forms.TabPage tabPageCreateOffer;
        private System.Windows.Forms.TabPage tabPageEditActivity;
        private System.Windows.Forms.TabPage tabPageEditOffer;
        private System.Windows.Forms.Button btnCreateActivity;
        private System.Windows.Forms.ListBox listBoxCreateActivity;
        private System.Windows.Forms.DateTimePicker dateTimePickerSlut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxContactPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPersonInCharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxActivityTitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateOffer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxCreateOffer;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbContactPerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLogOut;
    }
}