
namespace LookingGlassRecruitmentAgency
{
    partial class CandidateDeleteForm
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lstCandidates = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteCandidate = new System.Windows.Forms.Button();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(504, 242);
            this.txtStatus.MaxLength = 20;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(129, 27);
            this.txtStatus.TabIndex = 46;
            // 
            // lstCandidates
            // 
            this.lstCandidates.FormattingEnabled = true;
            this.lstCandidates.ItemHeight = 19;
            this.lstCandidates.Location = new System.Drawing.Point(30, 27);
            this.lstCandidates.Name = "lstCandidates";
            this.lstCandidates.Size = new System.Drawing.Size(349, 346);
            this.lstCandidates.TabIndex = 45;
            this.lstCandidates.SelectedIndexChanged += new System.EventHandler(this.lstCandidates_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(626, 329);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 44;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteCandidate
            // 
            this.btnDeleteCandidate.Location = new System.Drawing.Point(393, 329);
            this.btnDeleteCandidate.Name = "btnDeleteCandidate";
            this.btnDeleteCandidate.Size = new System.Drawing.Size(132, 44);
            this.btnDeleteCandidate.TabIndex = 43;
            this.btnDeleteCandidate.Text = "Delete Candidate";
            this.btnDeleteCandidate.UseVisualStyleBackColor = true;
            this.btnDeleteCandidate.Click += new System.EventHandler(this.btnDeleteCandidate_Click);
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(504, 207);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(129, 27);
            this.txtSuburb.TabIndex = 42;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(445, 210);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(53, 19);
            this.lblSuburb.TabIndex = 41;
            this.lblSuburb.Text = "Suburb";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(504, 172);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(129, 27);
            this.txtCity.TabIndex = 40;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(504, 137);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(245, 27);
            this.txtStreetAddress.TabIndex = 39;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(504, 102);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(188, 27);
            this.txtFirstName.TabIndex = 38;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(504, 67);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(188, 27);
            this.txtLastName.TabIndex = 37;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Location = new System.Drawing.Point(504, 32);
            this.txtCandidateID.MaxLength = 6;
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(49, 27);
            this.txtCandidateID.TabIndex = 36;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(449, 245);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "Status";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(464, 175);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 19);
            this.lblCity.TabIndex = 34;
            this.lblCity.Text = "City";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(395, 140);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(103, 19);
            this.lblStreetAddress.TabIndex = 33;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(419, 105);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 19);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(420, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 19);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.Location = new System.Drawing.Point(405, 35);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(93, 19);
            this.lblCandidateID.TabIndex = 30;
            this.lblCandidateID.Text = "Candidate ID";
            // 
            // CandidateDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 407);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lstCandidates);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCandidate);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCandidateID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CandidateDeleteForm";
            this.Text = "Delete Candidate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ListBox lstCandidates;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteCandidate;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCandidateID;
    }
}