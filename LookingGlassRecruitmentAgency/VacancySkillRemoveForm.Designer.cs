
namespace LookingGlassRecruitmentAgency
{
    partial class VacancySkillRemoveForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.lblVacancyDescription = new System.Windows.Forms.Label();
            this.lblVacancyID = new System.Windows.Forms.Label();
            this.lblSelectSkill = new System.Windows.Forms.Label();
            this.lblSelectVacancy = new System.Windows.Forms.Label();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.lstAssignedSkills = new System.Windows.Forms.ListBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtVacancyDescription = new System.Windows.Forms.TextBox();
            this.txtVacancyID = new System.Windows.Forms.TextBox();
            this.lstVacancies = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(361, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "* Required fields";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(189, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(221, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "*";
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Location = new System.Drawing.Point(117, 211);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(111, 19);
            this.lblEmployerName.TabIndex = 26;
            this.lblEmployerName.Text = "Employer Name";
            // 
            // lblVacancyDescription
            // 
            this.lblVacancyDescription.AutoSize = true;
            this.lblVacancyDescription.Location = new System.Drawing.Point(88, 167);
            this.lblVacancyDescription.Name = "lblVacancyDescription";
            this.lblVacancyDescription.Size = new System.Drawing.Size(140, 19);
            this.lblVacancyDescription.TabIndex = 25;
            this.lblVacancyDescription.Text = "Vacancy Description";
            // 
            // lblVacancyID
            // 
            this.lblVacancyID.AutoSize = true;
            this.lblVacancyID.Location = new System.Drawing.Point(148, 124);
            this.lblVacancyID.Name = "lblVacancyID";
            this.lblVacancyID.Size = new System.Drawing.Size(80, 19);
            this.lblVacancyID.TabIndex = 24;
            this.lblVacancyID.Text = "Vacancy ID";
            // 
            // lblSelectSkill
            // 
            this.lblSelectSkill.AutoSize = true;
            this.lblSelectSkill.Location = new System.Drawing.Point(32, 262);
            this.lblSelectSkill.Name = "lblSelectSkill";
            this.lblSelectSkill.Size = new System.Drawing.Size(160, 19);
            this.lblSelectSkill.TabIndex = 23;
            this.lblSelectSkill.Text = "Select an assigned skill";
            // 
            // lblSelectVacancy
            // 
            this.lblSelectVacancy.AutoSize = true;
            this.lblSelectVacancy.Location = new System.Drawing.Point(99, 24);
            this.lblSelectVacancy.Name = "lblSelectVacancy";
            this.lblSelectVacancy.Size = new System.Drawing.Size(116, 19);
            this.lblSelectVacancy.TabIndex = 22;
            this.lblSelectVacancy.Text = "Select a vacancy";
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.Location = new System.Drawing.Point(22, 374);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(195, 44);
            this.btnRemoveSkill.TabIndex = 21;
            this.btnRemoveSkill.Text = "Remove Vacancy Skill ";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // lstAssignedSkills
            // 
            this.lstAssignedSkills.FormattingEnabled = true;
            this.lstAssignedSkills.ItemHeight = 19;
            this.lstAssignedSkills.Location = new System.Drawing.Point(212, 262);
            this.lstAssignedSkills.Name = "lstAssignedSkills";
            this.lstAssignedSkills.Size = new System.Drawing.Size(600, 80);
            this.lstAssignedSkills.TabIndex = 20;
            this.lstAssignedSkills.SelectedIndexChanged += new System.EventHandler(this.lstAssignedSkills_SelectedIndexChanged);
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(244, 208);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.ReadOnly = true;
            this.txtEmployerName.Size = new System.Drawing.Size(500, 27);
            this.txtEmployerName.TabIndex = 19;
            // 
            // txtVacancyDescription
            // 
            this.txtVacancyDescription.Location = new System.Drawing.Point(244, 164);
            this.txtVacancyDescription.Name = "txtVacancyDescription";
            this.txtVacancyDescription.ReadOnly = true;
            this.txtVacancyDescription.Size = new System.Drawing.Size(500, 27);
            this.txtVacancyDescription.TabIndex = 18;
            // 
            // txtVacancyID
            // 
            this.txtVacancyID.Location = new System.Drawing.Point(244, 121);
            this.txtVacancyID.Name = "txtVacancyID";
            this.txtVacancyID.ReadOnly = true;
            this.txtVacancyID.Size = new System.Drawing.Size(80, 27);
            this.txtVacancyID.TabIndex = 17;
            // 
            // lstVacancies
            // 
            this.lstVacancies.FormattingEnabled = true;
            this.lstVacancies.ItemHeight = 19;
            this.lstVacancies.Location = new System.Drawing.Point(244, 24);
            this.lstVacancies.Name = "lstVacancies";
            this.lstVacancies.Size = new System.Drawing.Size(554, 80);
            this.lstVacancies.TabIndex = 16;
            this.lstVacancies.SelectedIndexChanged += new System.EventHandler(this.lstVacancies_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(617, 374);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(195, 44);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // VacancySkillRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.lblVacancyDescription);
            this.Controls.Add(this.lblVacancyID);
            this.Controls.Add(this.lblSelectSkill);
            this.Controls.Add(this.lblSelectVacancy);
            this.Controls.Add(this.btnRemoveSkill);
            this.Controls.Add(this.lstAssignedSkills);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtVacancyDescription);
            this.Controls.Add(this.txtVacancyID);
            this.Controls.Add(this.lstVacancies);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VacancySkillRemoveForm";
            this.Text = "Remove Vacancy Skill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.Label lblVacancyDescription;
        private System.Windows.Forms.Label lblVacancyID;
        private System.Windows.Forms.Label lblSelectSkill;
        private System.Windows.Forms.Label lblSelectVacancy;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.ListBox lstAssignedSkills;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtVacancyDescription;
        private System.Windows.Forms.TextBox txtVacancyID;
        private System.Windows.Forms.ListBox lstVacancies;
        private System.Windows.Forms.Button btnReturn;
    }
}