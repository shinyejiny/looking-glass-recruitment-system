
namespace LookingGlassRecruitmentAgency
{
    partial class ApplicationRemoveForm
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
            this.lblCandidateList = new System.Windows.Forms.Label();
            this.lstCandidates = new System.Windows.Forms.ListBox();
            this.lblApplication = new System.Windows.Forms.Label();
            this.lstApplication = new System.Windows.Forms.ListBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRmoveApplication = new System.Windows.Forms.Button();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCandidateList
            // 
            this.lblCandidateList.AutoSize = true;
            this.lblCandidateList.Location = new System.Drawing.Point(16, 9);
            this.lblCandidateList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateList.Name = "lblCandidateList";
            this.lblCandidateList.Size = new System.Drawing.Size(128, 19);
            this.lblCandidateList.TabIndex = 0;
            this.lblCandidateList.Text = "Select a candidate";
            // 
            // lstCandidates
            // 
            this.lstCandidates.FormattingEnabled = true;
            this.lstCandidates.ItemHeight = 19;
            this.lstCandidates.Location = new System.Drawing.Point(20, 31);
            this.lstCandidates.Name = "lstCandidates";
            this.lstCandidates.Size = new System.Drawing.Size(328, 137);
            this.lstCandidates.TabIndex = 1;
            this.lstCandidates.SelectedIndexChanged += new System.EventHandler(this.lstCandidates_SelectedIndexChanged);
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.Location = new System.Drawing.Point(16, 208);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(145, 19);
            this.lblApplication.TabIndex = 2;
            this.lblApplication.Text = "Select an Application";
            // 
            // lstApplication
            // 
            this.lstApplication.FormattingEnabled = true;
            this.lstApplication.ItemHeight = 19;
            this.lstApplication.Location = new System.Drawing.Point(20, 230);
            this.lstApplication.Name = "lstApplication";
            this.lstApplication.Size = new System.Drawing.Size(850, 99);
            this.lstApplication.TabIndex = 3;
            this.lstApplication.SelectedIndexChanged += new System.EventHandler(this.lstApplication_SelectedIndexChanged);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(482, 157);
            this.txtEmailAddress.MaxLength = 30;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(258, 27);
            this.txtEmailAddress.TabIndex = 30;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(481, 116);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(202, 27);
            this.txtFirstName.TabIndex = 29;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(482, 73);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(202, 27);
            this.txtLastName.TabIndex = 28;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Location = new System.Drawing.Point(481, 30);
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(59, 27);
            this.txtCandidateID.TabIndex = 27;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(375, 160);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(101, 19);
            this.lblEmailAddress.TabIndex = 26;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(396, 119);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 19);
            this.lblFirstName.TabIndex = 25;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(397, 76);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 19);
            this.lblLastName.TabIndex = 24;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.Location = new System.Drawing.Point(382, 33);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(93, 19);
            this.lblCandidateID.TabIndex = 23;
            this.lblCandidateID.Text = "Candidate ID";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(720, 354);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 44);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRmoveApplication
            // 
            this.btnRmoveApplication.Location = new System.Drawing.Point(20, 354);
            this.btnRmoveApplication.Name = "btnRmoveApplication";
            this.btnRmoveApplication.Size = new System.Drawing.Size(150, 44);
            this.btnRmoveApplication.TabIndex = 31;
            this.btnRmoveApplication.Text = "Remove Application";
            this.btnRmoveApplication.UseVisualStyleBackColor = true;
            this.btnRmoveApplication.Click += new System.EventHandler(this.btnRmoveApplication_Click);
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(382, 389);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(113, 19);
            this.lblRequiredFields.TabIndex = 48;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "*";
            // 
            // ApplicationRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRmoveApplication);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCandidateID);
            this.Controls.Add(this.lstApplication);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.lstCandidates);
            this.Controls.Add(this.lblCandidateList);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplicationRemoveForm";
            this.Text = "Remove Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCandidateList;
        private System.Windows.Forms.ListBox lstCandidates;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.ListBox lstApplication;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRmoveApplication;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}