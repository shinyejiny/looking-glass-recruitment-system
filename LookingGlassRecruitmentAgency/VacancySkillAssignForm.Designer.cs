
namespace LookingGlassRecruitmentAgency
{
    partial class VacancySkillAssignForm
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
            this.components = new System.ComponentModel.Container();
            this.lblRequired = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAssignSkill = new System.Windows.Forms.Button();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSelectSkill = new System.Windows.Forms.Label();
            this.dgvSkills = new System.Windows.Forms.DataGridView();
            this.SkillID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lGRAgencyDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lGRAgencyDBDataSet = new LookingGlassRecruitmentAgency.LGRAgencyDBDataSet();
            this.lblSelectAssignedSkill = new System.Windows.Forms.Label();
            this.txtAssignedSkill = new System.Windows.Forms.TextBox();
            this.lblAssignedSkills = new System.Windows.Forms.Label();
            this.lblSelectVacancy = new System.Windows.Forms.Label();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtVacancyDescription = new System.Windows.Forms.TextBox();
            this.txtVacancyID = new System.Windows.Forms.TextBox();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.lblVacancyDescription = new System.Windows.Forms.Label();
            this.lblVacancyID = new System.Windows.Forms.Label();
            this.dgvVacancySkills = new System.Windows.Forms.DataGridView();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacancyID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVacancies = new System.Windows.Forms.DataGridView();
            this.VacancyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacancyDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacancyStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacancyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(346, 588);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(117, 19);
            this.lblRequired.TabIndex = 41;
            this.lblRequired.Text = "* Required fields";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(107, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "*";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(684, 552);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(166, 44);
            this.btnReturn.TabIndex = 38;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAssignSkill
            // 
            this.btnAssignSkill.Location = new System.Drawing.Point(23, 552);
            this.btnAssignSkill.Name = "btnAssignSkill";
            this.btnAssignSkill.Size = new System.Drawing.Size(166, 44);
            this.btnAssignSkill.TabIndex = 37;
            this.btnAssignSkill.Text = "Assign Skill to Vacancy";
            this.btnAssignSkill.UseVisualStyleBackColor = true;
            this.btnAssignSkill.Click += new System.EventHandler(this.btnAssignSkill_Click);
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(729, 437);
            this.nudLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(120, 27);
            this.nudLevel.TabIndex = 36;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(739, 400);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(78, 19);
            this.lblLevel.TabIndex = 35;
            this.lblLevel.Text = "Enter level";
            // 
            // lblSelectSkill
            // 
            this.lblSelectSkill.AutoSize = true;
            this.lblSelectSkill.Location = new System.Drawing.Point(18, 400);
            this.lblSelectSkill.Name = "lblSelectSkill";
            this.lblSelectSkill.Size = new System.Drawing.Size(90, 19);
            this.lblSelectSkill.TabIndex = 34;
            this.lblSelectSkill.Text = "Select a skill";
            // 
            // dgvSkills
            // 
            this.dgvSkills.AutoGenerateColumns = false;
            this.dgvSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillID2,
            this.SkillDescription,
            this.SkillType});
            this.dgvSkills.DataMember = "SKILL";
            this.dgvSkills.DataSource = this.lGRAgencyDBDataSetBindingSource;
            this.dgvSkills.Location = new System.Drawing.Point(130, 400);
            this.dgvSkills.Name = "dgvSkills";
            this.dgvSkills.ReadOnly = true;
            this.dgvSkills.RowHeadersWidth = 51;
            this.dgvSkills.Size = new System.Drawing.Size(573, 126);
            this.dgvSkills.TabIndex = 33;
            // 
            // SkillID2
            // 
            this.SkillID2.DataPropertyName = "SkillID";
            this.SkillID2.HeaderText = "Skill ID";
            this.SkillID2.MinimumWidth = 6;
            this.SkillID2.Name = "SkillID2";
            this.SkillID2.ReadOnly = true;
            this.SkillID2.Width = 80;
            // 
            // SkillDescription
            // 
            this.SkillDescription.DataPropertyName = "SkillDescription";
            this.SkillDescription.HeaderText = "Skill Description";
            this.SkillDescription.MinimumWidth = 6;
            this.SkillDescription.Name = "SkillDescription";
            this.SkillDescription.ReadOnly = true;
            this.SkillDescription.Width = 450;
            // 
            // SkillType
            // 
            this.SkillType.DataPropertyName = "SkillType";
            this.SkillType.HeaderText = "SkillType";
            this.SkillType.MinimumWidth = 6;
            this.SkillType.Name = "SkillType";
            this.SkillType.ReadOnly = true;
            this.SkillType.Visible = false;
            this.SkillType.Width = 125;
            // 
            // lGRAgencyDBDataSetBindingSource
            // 
            this.lGRAgencyDBDataSetBindingSource.DataSource = this.lGRAgencyDBDataSet;
            this.lGRAgencyDBDataSetBindingSource.Position = 0;
            // 
            // lGRAgencyDBDataSet
            // 
            this.lGRAgencyDBDataSet.DataSetName = "LGRAgencyDBDataSet";
            this.lGRAgencyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSelectAssignedSkill
            // 
            this.lblSelectAssignedSkill.AutoSize = true;
            this.lblSelectAssignedSkill.Location = new System.Drawing.Point(384, 329);
            this.lblSelectAssignedSkill.Name = "lblSelectAssignedSkill";
            this.lblSelectAssignedSkill.Size = new System.Drawing.Size(292, 19);
            this.lblSelectAssignedSkill.TabIndex = 32;
            this.lblSelectAssignedSkill.Text = "Select a skill from the table to view the skill";
            // 
            // txtAssignedSkill
            // 
            this.txtAssignedSkill.Location = new System.Drawing.Point(388, 351);
            this.txtAssignedSkill.MaxLength = 50;
            this.txtAssignedSkill.Name = "txtAssignedSkill";
            this.txtAssignedSkill.ReadOnly = true;
            this.txtAssignedSkill.Size = new System.Drawing.Size(462, 27);
            this.txtAssignedSkill.TabIndex = 31;
            // 
            // lblAssignedSkills
            // 
            this.lblAssignedSkills.AutoSize = true;
            this.lblAssignedSkills.Location = new System.Drawing.Point(85, 269);
            this.lblAssignedSkills.Name = "lblAssignedSkills";
            this.lblAssignedSkills.Size = new System.Drawing.Size(104, 19);
            this.lblAssignedSkills.TabIndex = 30;
            this.lblAssignedSkills.Text = "Skills assigned";
            // 
            // lblSelectVacancy
            // 
            this.lblSelectVacancy.AutoSize = true;
            this.lblSelectVacancy.Location = new System.Drawing.Point(48, 26);
            this.lblSelectVacancy.Name = "lblSelectVacancy";
            this.lblSelectVacancy.Size = new System.Drawing.Size(116, 19);
            this.lblSelectVacancy.TabIndex = 29;
            this.lblSelectVacancy.Text = "Select a vacancy";
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(194, 227);
            this.txtEmployerName.MaxLength = 50;
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.ReadOnly = true;
            this.txtEmployerName.Size = new System.Drawing.Size(500, 27);
            this.txtEmployerName.TabIndex = 28;
            // 
            // txtVacancyDescription
            // 
            this.txtVacancyDescription.Location = new System.Drawing.Point(194, 194);
            this.txtVacancyDescription.MaxLength = 50;
            this.txtVacancyDescription.Name = "txtVacancyDescription";
            this.txtVacancyDescription.ReadOnly = true;
            this.txtVacancyDescription.Size = new System.Drawing.Size(500, 27);
            this.txtVacancyDescription.TabIndex = 27;
            // 
            // txtVacancyID
            // 
            this.txtVacancyID.Location = new System.Drawing.Point(195, 161);
            this.txtVacancyID.MaxLength = 8;
            this.txtVacancyID.Name = "txtVacancyID";
            this.txtVacancyID.ReadOnly = true;
            this.txtVacancyID.Size = new System.Drawing.Size(80, 27);
            this.txtVacancyID.TabIndex = 26;
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Location = new System.Drawing.Point(78, 230);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(111, 19);
            this.lblEmployerName.TabIndex = 25;
            this.lblEmployerName.Text = "Employer Name";
            // 
            // lblVacancyDescription
            // 
            this.lblVacancyDescription.AutoSize = true;
            this.lblVacancyDescription.Location = new System.Drawing.Point(49, 197);
            this.lblVacancyDescription.Name = "lblVacancyDescription";
            this.lblVacancyDescription.Size = new System.Drawing.Size(140, 19);
            this.lblVacancyDescription.TabIndex = 24;
            this.lblVacancyDescription.Text = "Vacancy Description";
            // 
            // lblVacancyID
            // 
            this.lblVacancyID.AutoSize = true;
            this.lblVacancyID.Location = new System.Drawing.Point(109, 164);
            this.lblVacancyID.Name = "lblVacancyID";
            this.lblVacancyID.Size = new System.Drawing.Size(80, 19);
            this.lblVacancyID.TabIndex = 23;
            this.lblVacancyID.Text = "Vacancy ID";
            // 
            // dgvVacancySkills
            // 
            this.dgvVacancySkills.AutoGenerateColumns = false;
            this.dgvVacancySkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancySkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Level,
            this.VacancyID2,
            this.SkillID});
            this.dgvVacancySkills.DataMember = "VACANCYSKILL";
            this.dgvVacancySkills.DataSource = this.lGRAgencyDBDataSetBindingSource;
            this.dgvVacancySkills.Location = new System.Drawing.Point(194, 260);
            this.dgvVacancySkills.Name = "dgvVacancySkills";
            this.dgvVacancySkills.ReadOnly = true;
            this.dgvVacancySkills.RowHeadersWidth = 51;
            this.dgvVacancySkills.Size = new System.Drawing.Size(173, 118);
            this.dgvVacancySkills.TabIndex = 22;
            this.dgvVacancySkills.Click += new System.EventHandler(this.dgvVacancySkills_Click);
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 6;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 50;
            // 
            // VacancyID2
            // 
            this.VacancyID2.DataPropertyName = "VacancyID";
            this.VacancyID2.HeaderText = "Vacancy ID";
            this.VacancyID2.MinimumWidth = 6;
            this.VacancyID2.Name = "VacancyID2";
            this.VacancyID2.ReadOnly = true;
            this.VacancyID2.Visible = false;
            this.VacancyID2.Width = 70;
            // 
            // SkillID
            // 
            this.SkillID.DataPropertyName = "SkillID";
            this.SkillID.HeaderText = "Skill ID";
            this.SkillID.MinimumWidth = 6;
            this.SkillID.Name = "SkillID";
            this.SkillID.ReadOnly = true;
            this.SkillID.Width = 80;
            // 
            // dgvVacancies
            // 
            this.dgvVacancies.AutoGenerateColumns = false;
            this.dgvVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VacancyID,
            this.VacancyDescription,
            this.VacancyStatus,
            this.VacancyType,
            this.salaryData,
            this.employerID});
            this.dgvVacancies.DataMember = "VACANCY";
            this.dgvVacancies.DataSource = this.lGRAgencyDBDataSetBindingSource;
            this.dgvVacancies.Location = new System.Drawing.Point(195, 26);
            this.dgvVacancies.Name = "dgvVacancies";
            this.dgvVacancies.ReadOnly = true;
            this.dgvVacancies.RowHeadersWidth = 51;
            this.dgvVacancies.Size = new System.Drawing.Size(655, 122);
            this.dgvVacancies.TabIndex = 21;
            this.dgvVacancies.Click += new System.EventHandler(this.dgvVacancies_Click);
            // 
            // VacancyID
            // 
            this.VacancyID.DataPropertyName = "VacancyID";
            this.VacancyID.HeaderText = "Vacancy ID";
            this.VacancyID.MinimumWidth = 6;
            this.VacancyID.Name = "VacancyID";
            this.VacancyID.ReadOnly = true;
            this.VacancyID.Width = 120;
            // 
            // VacancyDescription
            // 
            this.VacancyDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VacancyDescription.DataPropertyName = "VacancyDescription";
            this.VacancyDescription.HeaderText = "Vacancy Description";
            this.VacancyDescription.MinimumWidth = 6;
            this.VacancyDescription.Name = "VacancyDescription";
            this.VacancyDescription.ReadOnly = true;
            // 
            // VacancyStatus
            // 
            this.VacancyStatus.DataPropertyName = "VacancyStatus";
            this.VacancyStatus.HeaderText = "Vacancy Status";
            this.VacancyStatus.MinimumWidth = 6;
            this.VacancyStatus.Name = "VacancyStatus";
            this.VacancyStatus.ReadOnly = true;
            this.VacancyStatus.Visible = false;
            this.VacancyStatus.Width = 125;
            // 
            // VacancyType
            // 
            this.VacancyType.DataPropertyName = "VacancyType";
            this.VacancyType.HeaderText = "Vacancy Type";
            this.VacancyType.MinimumWidth = 6;
            this.VacancyType.Name = "VacancyType";
            this.VacancyType.ReadOnly = true;
            this.VacancyType.Visible = false;
            this.VacancyType.Width = 125;
            // 
            // salaryData
            // 
            this.salaryData.DataPropertyName = "Salary";
            this.salaryData.HeaderText = "Salary";
            this.salaryData.MinimumWidth = 6;
            this.salaryData.Name = "salaryData";
            this.salaryData.ReadOnly = true;
            this.salaryData.Visible = false;
            this.salaryData.Width = 125;
            // 
            // employerID
            // 
            this.employerID.DataPropertyName = "EmployerID";
            this.employerID.HeaderText = "EmployerID";
            this.employerID.MinimumWidth = 6;
            this.employerID.Name = "employerID";
            this.employerID.ReadOnly = true;
            this.employerID.Visible = false;
            this.employerID.Width = 125;
            // 
            // VacancySkillAssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 625);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAssignSkill);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblSelectSkill);
            this.Controls.Add(this.dgvSkills);
            this.Controls.Add(this.lblSelectAssignedSkill);
            this.Controls.Add(this.txtAssignedSkill);
            this.Controls.Add(this.lblAssignedSkills);
            this.Controls.Add(this.lblSelectVacancy);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtVacancyDescription);
            this.Controls.Add(this.txtVacancyID);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.lblVacancyDescription);
            this.Controls.Add(this.lblVacancyID);
            this.Controls.Add(this.dgvVacancySkills);
            this.Controls.Add(this.dgvVacancies);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VacancySkillAssignForm";
            this.Text = "Assign Vacancy Skill";
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAssignSkill;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSelectSkill;
        private System.Windows.Forms.DataGridView dgvSkills;
        private System.Windows.Forms.BindingSource lGRAgencyDBDataSetBindingSource;
        private LGRAgencyDBDataSet lGRAgencyDBDataSet;
        private System.Windows.Forms.Label lblSelectAssignedSkill;
        private System.Windows.Forms.TextBox txtAssignedSkill;
        private System.Windows.Forms.Label lblAssignedSkills;
        private System.Windows.Forms.Label lblSelectVacancy;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtVacancyDescription;
        private System.Windows.Forms.TextBox txtVacancyID;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.Label lblVacancyDescription;
        private System.Windows.Forms.Label lblVacancyID;
        private System.Windows.Forms.DataGridView dgvVacancySkills;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacancyID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillID;
        private System.Windows.Forms.DataGridView dgvVacancies;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacancyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacancyDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacancyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacancyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillType;
    }
}