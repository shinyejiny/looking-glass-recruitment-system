
namespace LookingGlassRecruitmentAgency
{
    partial class ApplicationAddForm
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
            this.dgvCandidate = new System.Windows.Forms.DataGridView();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suburbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANDIDATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lGRAgencyDBDataSet = new LookingGlassRecruitmentAgency.LGRAgencyDBDataSet();
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.VacancyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACANCYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCandidates = new System.Windows.Forms.Label();
            this.lblVacancies = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dtpApplicationDate = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.cANDIDATETableAdapter = new LookingGlassRecruitmentAgency.LGRAgencyDBDataSetTableAdapters.CANDIDATETableAdapter();
            this.vACANCYTableAdapter = new LookingGlassRecruitmentAgency.LGRAgencyDBDataSetTableAdapters.VACANCYTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApplicationStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACANCYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidate
            // 
            this.dgvCandidate.AutoGenerateColumns = false;
            this.dgvCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateID,
            this.candidateLastNameDataGridViewTextBoxColumn,
            this.candidateFirstNameDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.suburbDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.workTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvCandidate.DataSource = this.cANDIDATEBindingSource;
            this.dgvCandidate.Location = new System.Drawing.Point(25, 48);
            this.dgvCandidate.Name = "dgvCandidate";
            this.dgvCandidate.Size = new System.Drawing.Size(816, 165);
            this.dgvCandidate.TabIndex = 0;
            this.dgvCandidate.Click += new System.EventHandler(this.dgvCandidate_Click);
            // 
            // CandidateID
            // 
            this.CandidateID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateID.DataPropertyName = "CandidateID";
            this.CandidateID.HeaderText = "Candidate ID";
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.ReadOnly = true;
            // 
            // candidateLastNameDataGridViewTextBoxColumn
            // 
            this.candidateLastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.candidateLastNameDataGridViewTextBoxColumn.DataPropertyName = "CandidateLastName";
            this.candidateLastNameDataGridViewTextBoxColumn.HeaderText = "Candidate Last Name";
            this.candidateLastNameDataGridViewTextBoxColumn.Name = "candidateLastNameDataGridViewTextBoxColumn";
            // 
            // candidateFirstNameDataGridViewTextBoxColumn
            // 
            this.candidateFirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.candidateFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CandidateFirstName";
            this.candidateFirstNameDataGridViewTextBoxColumn.HeaderText = "Candidate First Name";
            this.candidateFirstNameDataGridViewTextBoxColumn.Name = "candidateFirstNameDataGridViewTextBoxColumn";
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // suburbDataGridViewTextBoxColumn
            // 
            this.suburbDataGridViewTextBoxColumn.DataPropertyName = "Suburb";
            this.suburbDataGridViewTextBoxColumn.HeaderText = "Suburb";
            this.suburbDataGridViewTextBoxColumn.Name = "suburbDataGridViewTextBoxColumn";
            this.suburbDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // workTypeDataGridViewTextBoxColumn
            // 
            this.workTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.HeaderText = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.Name = "workTypeDataGridViewTextBoxColumn";
            this.workTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // cANDIDATEBindingSource
            // 
            this.cANDIDATEBindingSource.DataMember = "CANDIDATE";
            this.cANDIDATEBindingSource.DataSource = this.lGRAgencyDBDataSet;
            // 
            // lGRAgencyDBDataSet
            // 
            this.lGRAgencyDBDataSet.DataSetName = "LGRAgencyDBDataSet";
            this.lGRAgencyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.AutoGenerateColumns = false;
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VacancyID,
            this.vacancyDescriptionDataGridViewTextBoxColumn,
            this.vacancyStatusDataGridViewTextBoxColumn,
            this.vacancyTypeDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.employerIDDataGridViewTextBoxColumn});
            this.dgvVacancy.DataSource = this.vACANCYBindingSource;
            this.dgvVacancy.Location = new System.Drawing.Point(25, 249);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.Size = new System.Drawing.Size(408, 273);
            this.dgvVacancy.TabIndex = 2;
            // 
            // VacancyID
            // 
            this.VacancyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VacancyID.DataPropertyName = "VacancyID";
            this.VacancyID.HeaderText = "Vacancy ID";
            this.VacancyID.Name = "VacancyID";
            this.VacancyID.ReadOnly = true;
            // 
            // vacancyDescriptionDataGridViewTextBoxColumn
            // 
            this.vacancyDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vacancyDescriptionDataGridViewTextBoxColumn.DataPropertyName = "VacancyDescription";
            this.vacancyDescriptionDataGridViewTextBoxColumn.HeaderText = "VacancyDescription";
            this.vacancyDescriptionDataGridViewTextBoxColumn.Name = "vacancyDescriptionDataGridViewTextBoxColumn";
            this.vacancyDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vacancyStatusDataGridViewTextBoxColumn
            // 
            this.vacancyStatusDataGridViewTextBoxColumn.DataPropertyName = "VacancyStatus";
            this.vacancyStatusDataGridViewTextBoxColumn.HeaderText = "VacancyStatus";
            this.vacancyStatusDataGridViewTextBoxColumn.Name = "vacancyStatusDataGridViewTextBoxColumn";
            this.vacancyStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // vacancyTypeDataGridViewTextBoxColumn
            // 
            this.vacancyTypeDataGridViewTextBoxColumn.DataPropertyName = "VacancyType";
            this.vacancyTypeDataGridViewTextBoxColumn.HeaderText = "VacancyType";
            this.vacancyTypeDataGridViewTextBoxColumn.Name = "vacancyTypeDataGridViewTextBoxColumn";
            this.vacancyTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Visible = false;
            // 
            // employerIDDataGridViewTextBoxColumn
            // 
            this.employerIDDataGridViewTextBoxColumn.DataPropertyName = "EmployerID";
            this.employerIDDataGridViewTextBoxColumn.HeaderText = "EmployerID";
            this.employerIDDataGridViewTextBoxColumn.Name = "employerIDDataGridViewTextBoxColumn";
            this.employerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vACANCYBindingSource
            // 
            this.vACANCYBindingSource.DataMember = "VACANCY";
            this.vACANCYBindingSource.DataSource = this.lGRAgencyDBDataSet;
            // 
            // lblCandidates
            // 
            this.lblCandidates.AutoSize = true;
            this.lblCandidates.Location = new System.Drawing.Point(21, 26);
            this.lblCandidates.Name = "lblCandidates";
            this.lblCandidates.Size = new System.Drawing.Size(128, 19);
            this.lblCandidates.TabIndex = 1;
            this.lblCandidates.Text = "Select a candidate";
            // 
            // lblVacancies
            // 
            this.lblVacancies.AutoSize = true;
            this.lblVacancies.Location = new System.Drawing.Point(21, 226);
            this.lblVacancies.Name = "lblVacancies";
            this.lblVacancies.Size = new System.Drawing.Size(116, 19);
            this.lblVacancies.TabIndex = 3;
            this.lblVacancies.Text = "Select a vacancy";
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.Location = new System.Drawing.Point(484, 247);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(93, 19);
            this.lblCandidateID.TabIndex = 4;
            this.lblCandidateID.Text = "Candidate ID";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(499, 290);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 19);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(498, 333);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 19);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(476, 376);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(101, 19);
            this.lblEmailAddress.TabIndex = 7;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(473, 419);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(104, 19);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Location = new System.Drawing.Point(460, 501);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(117, 19);
            this.lblApplicationDate.TabIndex = 9;
            this.lblApplicationDate.Text = "Application Date";
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Location = new System.Drawing.Point(583, 244);
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(59, 27);
            this.txtCandidateID.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(584, 287);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(202, 27);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(583, 330);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(202, 27);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(583, 373);
            this.txtEmailAddress.MaxLength = 30;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(258, 27);
            this.txtEmailAddress.TabIndex = 14;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(584, 416);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(117, 27);
            this.txtPhoneNumber.TabIndex = 15;
            // 
            // dtpApplicationDate
            // 
            this.dtpApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpApplicationDate.Location = new System.Drawing.Point(584, 495);
            this.dtpApplicationDate.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpApplicationDate.Name = "dtpApplicationDate";
            this.dtpApplicationDate.Size = new System.Drawing.Size(117, 27);
            this.dtpApplicationDate.TabIndex = 16;
            this.dtpApplicationDate.Value = new System.DateTime(2024, 6, 15, 0, 0, 0, 0);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(709, 560);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Location = new System.Drawing.Point(25, 560);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(132, 44);
            this.btnAddApplication.TabIndex = 18;
            this.btnAddApplication.Text = "Add Application";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // cANDIDATETableAdapter
            // 
            this.cANDIDATETableAdapter.ClearBeforeFill = true;
            // 
            // vACANCYTableAdapter
            // 
            this.vACANCYTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Application Status";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(363, 603);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(113, 19);
            this.lblRequiredFields.TabIndex = 47;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(135, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(707, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(145, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "*";
            // 
            // txtApplicationStatus
            // 
            this.txtApplicationStatus.Location = new System.Drawing.Point(583, 457);
            this.txtApplicationStatus.Name = "txtApplicationStatus";
            this.txtApplicationStatus.ReadOnly = true;
            this.txtApplicationStatus.Size = new System.Drawing.Size(118, 27);
            this.txtApplicationStatus.TabIndex = 51;
            this.txtApplicationStatus.Text = "Pending";
            // 
            // ApplicationAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 631);
            this.Controls.Add(this.txtApplicationStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.dtpApplicationDate);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.lblApplicationDate);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCandidateID);
            this.Controls.Add(this.lblVacancies);
            this.Controls.Add(this.dgvVacancy);
            this.Controls.Add(this.lblCandidates);
            this.Controls.Add(this.dgvCandidate);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplicationAddForm";
            this.Text = "Add Application";
            this.Load += new System.EventHandler(this.ApplicationAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACANCYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidate;
        private System.Windows.Forms.DataGridView dgvVacancy;
        private System.Windows.Forms.Label lblCandidates;
        private System.Windows.Forms.Label lblVacancies;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpApplicationDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddApplication;
        private LGRAgencyDBDataSet lGRAgencyDBDataSet;
        private System.Windows.Forms.BindingSource cANDIDATEBindingSource;
        private LGRAgencyDBDataSetTableAdapters.CANDIDATETableAdapter cANDIDATETableAdapter;
        private System.Windows.Forms.BindingSource vACANCYBindingSource;
        private LGRAgencyDBDataSetTableAdapters.VACANCYTableAdapter vACANCYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suburbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacancyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApplicationStatus;
    }
}