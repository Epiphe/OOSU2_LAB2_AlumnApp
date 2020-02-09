namespace PresentationLayer
{
    partial class MainAlumnForm
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
            this.tabControlAlumn = new System.Windows.Forms.TabControl();
            this.tabPageUpcommingActivities = new System.Windows.Forms.TabPage();
            this.tabPageBookedActivities = new System.Windows.Forms.TabPage();
            this.tabPageAlumnFacts = new System.Windows.Forms.TabPage();
            this.tabPageUserData = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxUpcomminActivites = new System.Windows.Forms.ListBox();
            this.listBoxUpcommingActivityInfo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBookActivity = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxBookedActivity = new System.Windows.Forms.ListBox();
            this.listBoxBookedActivityInfo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelBookedActivity = new System.Windows.Forms.Button();
            this.tabControlAlumn.SuspendLayout();
            this.tabPageUpcommingActivities.SuspendLayout();
            this.tabPageBookedActivities.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAlumn
            // 
            this.tabControlAlumn.Controls.Add(this.tabPageUpcommingActivities);
            this.tabControlAlumn.Controls.Add(this.tabPageBookedActivities);
            this.tabControlAlumn.Controls.Add(this.tabPageAlumnFacts);
            this.tabControlAlumn.Controls.Add(this.tabPageUserData);
            this.tabControlAlumn.Location = new System.Drawing.Point(12, 12);
            this.tabControlAlumn.Name = "tabControlAlumn";
            this.tabControlAlumn.SelectedIndex = 0;
            this.tabControlAlumn.Size = new System.Drawing.Size(579, 394);
            this.tabControlAlumn.TabIndex = 0;
            // 
            // tabPageUpcommingActivities
            // 
            this.tabPageUpcommingActivities.Controls.Add(this.btnBookActivity);
            this.tabPageUpcommingActivities.Controls.Add(this.label2);
            this.tabPageUpcommingActivities.Controls.Add(this.listBoxUpcommingActivityInfo);
            this.tabPageUpcommingActivities.Controls.Add(this.listBoxUpcomminActivites);
            this.tabPageUpcommingActivities.Controls.Add(this.label1);
            this.tabPageUpcommingActivities.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpcommingActivities.Name = "tabPageUpcommingActivities";
            this.tabPageUpcommingActivities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpcommingActivities.Size = new System.Drawing.Size(571, 368);
            this.tabPageUpcommingActivities.TabIndex = 0;
            this.tabPageUpcommingActivities.Text = "Aktuella händelser";
            this.tabPageUpcommingActivities.UseVisualStyleBackColor = true;
            // 
            // tabPageBookedActivities
            // 
            this.tabPageBookedActivities.Controls.Add(this.btnCancelBookedActivity);
            this.tabPageBookedActivities.Controls.Add(this.label4);
            this.tabPageBookedActivities.Controls.Add(this.listBoxBookedActivityInfo);
            this.tabPageBookedActivities.Controls.Add(this.listBoxBookedActivity);
            this.tabPageBookedActivities.Controls.Add(this.label3);
            this.tabPageBookedActivities.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookedActivities.Name = "tabPageBookedActivities";
            this.tabPageBookedActivities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookedActivities.Size = new System.Drawing.Size(571, 368);
            this.tabPageBookedActivities.TabIndex = 1;
            this.tabPageBookedActivities.Text = "Bokade aktiviteter";
            this.tabPageBookedActivities.UseVisualStyleBackColor = true;
            // 
            // tabPageAlumnFacts
            // 
            this.tabPageAlumnFacts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlumnFacts.Name = "tabPageAlumnFacts";
            this.tabPageAlumnFacts.Size = new System.Drawing.Size(744, 400);
            this.tabPageAlumnFacts.TabIndex = 2;
            this.tabPageAlumnFacts.Text = "Alumnuppgifter";
            this.tabPageAlumnFacts.UseVisualStyleBackColor = true;
            // 
            // tabPageUserData
            // 
            this.tabPageUserData.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserData.Name = "tabPageUserData";
            this.tabPageUserData.Size = new System.Drawing.Size(744, 400);
            this.tabPageUserData.TabIndex = 3;
            this.tabPageUserData.Text = "Användaruppgifter";
            this.tabPageUserData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kommande aktiviteter";
            // 
            // listBoxUpcomminActivites
            // 
            this.listBoxUpcomminActivites.FormattingEnabled = true;
            this.listBoxUpcomminActivites.Location = new System.Drawing.Point(10, 24);
            this.listBoxUpcomminActivites.Name = "listBoxUpcomminActivites";
            this.listBoxUpcomminActivites.Size = new System.Drawing.Size(251, 290);
            this.listBoxUpcomminActivites.TabIndex = 1;
            // 
            // listBoxUpcommingActivityInfo
            // 
            this.listBoxUpcommingActivityInfo.FormattingEnabled = true;
            this.listBoxUpcommingActivityInfo.Location = new System.Drawing.Point(297, 24);
            this.listBoxUpcommingActivityInfo.Name = "listBoxUpcommingActivityInfo";
            this.listBoxUpcommingActivityInfo.Size = new System.Drawing.Size(251, 290);
            this.listBoxUpcommingActivityInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aktivitets information";
            // 
            // btnBookActivity
            // 
            this.btnBookActivity.Location = new System.Drawing.Point(416, 321);
            this.btnBookActivity.Name = "btnBookActivity";
            this.btnBookActivity.Size = new System.Drawing.Size(131, 23);
            this.btnBookActivity.TabIndex = 4;
            this.btnBookActivity.Text = "Boka vald aktivitet";
            this.btnBookActivity.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bokade aktiviteter";
            // 
            // listBoxBookedActivity
            // 
            this.listBoxBookedActivity.FormattingEnabled = true;
            this.listBoxBookedActivity.Location = new System.Drawing.Point(10, 24);
            this.listBoxBookedActivity.Name = "listBoxBookedActivity";
            this.listBoxBookedActivity.Size = new System.Drawing.Size(257, 290);
            this.listBoxBookedActivity.TabIndex = 1;
            // 
            // listBoxBookedActivityInfo
            // 
            this.listBoxBookedActivityInfo.FormattingEnabled = true;
            this.listBoxBookedActivityInfo.Location = new System.Drawing.Point(283, 24);
            this.listBoxBookedActivityInfo.Name = "listBoxBookedActivityInfo";
            this.listBoxBookedActivityInfo.Size = new System.Drawing.Size(266, 290);
            this.listBoxBookedActivityInfo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aktivitets information";
            // 
            // btnCancelBookedActivity
            // 
            this.btnCancelBookedActivity.Location = new System.Drawing.Point(410, 320);
            this.btnCancelBookedActivity.Name = "btnCancelBookedActivity";
            this.btnCancelBookedActivity.Size = new System.Drawing.Size(139, 23);
            this.btnCancelBookedActivity.TabIndex = 4;
            this.btnCancelBookedActivity.Text = "Avboka vald aktivitet";
            this.btnCancelBookedActivity.UseVisualStyleBackColor = true;
            // 
            // MainAlumnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 426);
            this.Controls.Add(this.tabControlAlumn);
            this.Name = "MainAlumnForm";
            this.Text = "MainAlumnForm";
            this.tabControlAlumn.ResumeLayout(false);
            this.tabPageUpcommingActivities.ResumeLayout(false);
            this.tabPageUpcommingActivities.PerformLayout();
            this.tabPageBookedActivities.ResumeLayout(false);
            this.tabPageBookedActivities.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAlumn;
        private System.Windows.Forms.TabPage tabPageUpcommingActivities;
        private System.Windows.Forms.TabPage tabPageBookedActivities;
        private System.Windows.Forms.Button btnBookActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxUpcommingActivityInfo;
        private System.Windows.Forms.ListBox listBoxUpcomminActivites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelBookedActivity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxBookedActivityInfo;
        private System.Windows.Forms.ListBox listBoxBookedActivity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageAlumnFacts;
        private System.Windows.Forms.TabPage tabPageUserData;
    }
}