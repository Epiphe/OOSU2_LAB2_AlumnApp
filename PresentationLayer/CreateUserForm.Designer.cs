namespace PresentationLayer
{
    partial class CreateUserForm
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
            this.radioButtonAlumn = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonAlumn
            // 
            this.radioButtonAlumn.AutoSize = true;
            this.radioButtonAlumn.Location = new System.Drawing.Point(3, 1);
            this.radioButtonAlumn.Name = "radioButtonAlumn";
            this.radioButtonAlumn.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAlumn.TabIndex = 0;
            this.radioButtonAlumn.TabStop = true;
            this.radioButtonAlumn.Text = "Alumn";
            this.radioButtonAlumn.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(63, 1);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(85, 17);
            this.radioButtonAdmin.TabIndex = 1;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Administratör";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Användarnamn";
            // 
            // textBoxUserNameInput
            // 
            this.textBoxUserNameInput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxUserNameInput.Location = new System.Drawing.Point(3, 37);
            this.textBoxUserNameInput.Name = "textBoxUserNameInput";
            this.textBoxUserNameInput.Size = new System.Drawing.Size(210, 20);
            this.textBoxUserNameInput.TabIndex = 3;
            this.textBoxUserNameInput.Text = "Epost eller anst.nr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lösenord";
            // 
            // textBoxPasswordInput
            // 
            this.textBoxPasswordInput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPasswordInput.Location = new System.Drawing.Point(3, 76);
            this.textBoxPasswordInput.Name = "textBoxPasswordInput";
            this.textBoxPasswordInput.Size = new System.Drawing.Size(210, 20);
            this.textBoxPasswordInput.TabIndex = 5;
            this.textBoxPasswordInput.Text = "Minst 10 tecken";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(127, 244);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(99, 23);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Skapa konto";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alumner använder epost som användarnamn.\r\nAdministratörer använder sitt Anstälnni" +
    "ngsnummer.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lösenorder måste vara minst 10 tecken långt.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Förnamn";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxFirstName.Location = new System.Drawing.Point(3, 115);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(210, 20);
            this.textBoxFirstName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Efternamn";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(3, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxFirstName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radioButtonAdmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonAlumn);
            this.panel1.Controls.Add(this.textBoxUserNameInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPasswordInput);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 226);
            this.panel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Epost:";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(3, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 14;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 273);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateAccount);
            this.Name = "CreateUserForm";
            this.Text = "Skapa konto";
            this.Load += new System.EventHandler(this.CreateUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAlumn;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPasswordInput;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
    }
}