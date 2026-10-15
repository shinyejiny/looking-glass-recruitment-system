
namespace LookingGlassRecruitmentAgency
{
    partial class CandidateSkillRemoveForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSkills = new System.Windows.Forms.ListBox();
            this.lstCandidates = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Skill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Candidate";
            // 
            // lstSkills
            // 
            this.lstSkills.FormattingEnabled = true;
            this.lstSkills.ItemHeight = 19;
            this.lstSkills.Location = new System.Drawing.Point(30, 222);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(492, 118);
            this.lstSkills.TabIndex = 34;
            this.lstSkills.SelectedIndexChanged += new System.EventHandler(this.lstSkills_SelectedIndexChanged);
            // 
            // lstCandidates
            // 
            this.lstCandidates.FormattingEnabled = true;
            this.lstCandidates.ItemHeight = 19;
            this.lstCandidates.Location = new System.Drawing.Point(30, 43);
            this.lstCandidates.Name = "lstCandidates";
            this.lstCandidates.Size = new System.Drawing.Size(492, 137);
            this.lstCandidates.TabIndex = 33;
            this.lstCandidates.SelectedIndexChanged += new System.EventHandler(this.lstCandidates_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(673, 368);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(170, 44);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(30, 368);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(170, 44);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.Text = "Remove Candidate Skill";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(669, 239);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(142, 27);
            this.txtStatus.TabIndex = 30;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(669, 206);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(174, 27);
            this.txtFirstName.TabIndex = 29;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(669, 173);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(174, 27);
            this.txtLastName.TabIndex = 28;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Location = new System.Drawing.Point(669, 136);
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(37, 27);
            this.txtCandidateID.TabIndex = 27;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(615, 237);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(585, 203);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 19);
            this.lblFirstName.TabIndex = 25;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(585, 169);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 19);
            this.lblLastName.TabIndex = 24;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.Location = new System.Drawing.Point(570, 136);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(93, 19);
            this.lblCandidateID.TabIndex = 23;
            this.lblCandidateID.Text = "Candidate ID";
            // 
            // CandidateSkillRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSkills);
            this.Controls.Add(this.lstCandidates);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCandidateID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CandidateSkillRemoveForm";
            this.Text = "CandidateSkillRemoveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSkills;
        private System.Windows.Forms.ListBox lstCandidates;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCandidateID;
    }
}