
namespace LookingGlassRecruitmentAgency
{
    partial class CandidateSkillAssignForm
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
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.dgvSkills = new System.Windows.Forms.DataGridView();
            this.lGRAgencyDBDataSet = new LookingGlassRecruitmentAgency.LGRAgencyDBDataSet();
            this.lGRAgencyDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.nudYears = new System.Windows.Forms.NumericUpDown();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.SkillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suburbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.AutoGenerateColumns = false;
            this.dgvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateID,
            this.CandidateLastName,
            this.CandidateFirstName,
            this.streetAddressDataGridViewTextBoxColumn,
            this.suburbDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.workTypeDataGridViewTextBoxColumn,
            this.Status});
            this.dgvCandidates.DataMember = "CANDIDATE";
            this.dgvCandidates.DataSource = this.lGRAgencyDBDataSetBindingSource;
            this.dgvCandidates.Location = new System.Drawing.Point(24, 38);
            this.dgvCandidates.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.RowTemplate.Height = 23;
            this.dgvCandidates.Size = new System.Drawing.Size(480, 149);
            this.dgvCandidates.TabIndex = 1;
            this.dgvCandidates.Click += new System.EventHandler(this.dgvCandidates_Click);
            // 
            // dgvSkills
            // 
            this.dgvSkills.AutoGenerateColumns = false;
            this.dgvSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillID,
            this.SkillDescription,
            this.skillTypeDataGridViewTextBoxColumn});
            this.dgvSkills.DataMember = "SKILL";
            this.dgvSkills.DataSource = this.lGRAgencyDBDataSetBindingSource;
            this.dgvSkills.Location = new System.Drawing.Point(24, 232);
            this.dgvSkills.Name = "dgvSkills";
            this.dgvSkills.ReadOnly = true;
            this.dgvSkills.RowTemplate.Height = 23;
            this.dgvSkills.Size = new System.Drawing.Size(394, 150);
            this.dgvSkills.TabIndex = 25;
            // 
            // lGRAgencyDBDataSet
            // 
            this.lGRAgencyDBDataSet.DataSetName = "LGRAgencyDBDataSet";
            this.lGRAgencyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lGRAgencyDBDataSetBindingSource
            // 
            this.lGRAgencyDBDataSetBindingSource.DataSource = this.lGRAgencyDBDataSet;
            this.lGRAgencyDBDataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Select Candidate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Select Skill";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(601, 416);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 44);
            this.btnReturn.TabIndex = 37;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(24, 416);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(164, 44);
            this.btnAssign.TabIndex = 36;
            this.btnAssign.Text = "Assign Candidate Skill";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(570, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "*";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(453, 257);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(136, 19);
            this.lblYears.TabIndex = 39;
            this.lblYears.Text = "Years of Experience";
            // 
            // nudYears
            // 
            this.nudYears.Location = new System.Drawing.Point(595, 255);
            this.nudYears.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYears.Name = "nudYears";
            this.nudYears.Size = new System.Drawing.Size(120, 27);
            this.nudYears.TabIndex = 38;
            this.nudYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(627, 151);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(106, 27);
            this.txtStatus.TabIndex = 48;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(627, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(138, 27);
            this.txtFirstName.TabIndex = 47;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(627, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(138, 27);
            this.txtLastName.TabIndex = 46;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Location = new System.Drawing.Point(627, 38);
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(67, 27);
            this.txtCandidateID.TabIndex = 45;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(572, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "Status";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(542, 115);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 19);
            this.lblFirstName.TabIndex = 43;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(544, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 19);
            this.lblLastName.TabIndex = 42;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.Location = new System.Drawing.Point(528, 41);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(93, 19);
            this.lblCandidateID.TabIndex = 41;
            this.lblCandidateID.Text = "Candidate ID";
            // 
            // SkillID
            // 
            this.SkillID.DataPropertyName = "SkillID";
            this.SkillID.HeaderText = "Skill ID";
            this.SkillID.Name = "SkillID";
            this.SkillID.ReadOnly = true;
            // 
            // SkillDescription
            // 
            this.SkillDescription.DataPropertyName = "SkillDescription";
            this.SkillDescription.HeaderText = "Skill Description";
            this.SkillDescription.Name = "SkillDescription";
            this.SkillDescription.ReadOnly = true;
            this.SkillDescription.Width = 250;
            // 
            // skillTypeDataGridViewTextBoxColumn
            // 
            this.skillTypeDataGridViewTextBoxColumn.DataPropertyName = "SkillType";
            this.skillTypeDataGridViewTextBoxColumn.HeaderText = "SkillType";
            this.skillTypeDataGridViewTextBoxColumn.Name = "skillTypeDataGridViewTextBoxColumn";
            this.skillTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.skillTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // CandidateID
            // 
            this.CandidateID.DataPropertyName = "CandidateID";
            this.CandidateID.HeaderText = "Candidate ID";
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.ReadOnly = true;
            this.CandidateID.Width = 120;
            // 
            // CandidateLastName
            // 
            this.CandidateLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateLastName.DataPropertyName = "CandidateLastName";
            this.CandidateLastName.HeaderText = "Last Name";
            this.CandidateLastName.Name = "CandidateLastName";
            this.CandidateLastName.ReadOnly = true;
            // 
            // CandidateFirstName
            // 
            this.CandidateFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateFirstName.DataPropertyName = "CandidateFirstName";
            this.CandidateFirstName.HeaderText = "First Name";
            this.CandidateFirstName.Name = "CandidateFirstName";
            this.CandidateFirstName.ReadOnly = true;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // suburbDataGridViewTextBoxColumn
            // 
            this.suburbDataGridViewTextBoxColumn.DataPropertyName = "Suburb";
            this.suburbDataGridViewTextBoxColumn.HeaderText = "Suburb";
            this.suburbDataGridViewTextBoxColumn.Name = "suburbDataGridViewTextBoxColumn";
            this.suburbDataGridViewTextBoxColumn.ReadOnly = true;
            this.suburbDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // workTypeDataGridViewTextBoxColumn
            // 
            this.workTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.HeaderText = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.Name = "workTypeDataGridViewTextBoxColumn";
            this.workTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.workTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // CandidateSkillAssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 501);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCandidateID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.nudYears);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSkills);
            this.Controls.Add(this.dgvCandidates);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CandidateSkillAssignForm";
            this.Text = "Assign Candidate Skill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.BindingSource lGRAgencyDBDataSetBindingSource;
        private LGRAgencyDBDataSet lGRAgencyDBDataSet;
        private System.Windows.Forms.DataGridView dgvSkills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.NumericUpDown nudYears;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suburbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}