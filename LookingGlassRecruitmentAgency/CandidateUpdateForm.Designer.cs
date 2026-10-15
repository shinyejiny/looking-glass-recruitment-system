
namespace LookingGlassRecruitmentAgency
{
    partial class CandidateUpdateForm
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
            this.lGRAgencyDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lGRAgencyDBDataSet = new LookingGlassRecruitmentAgency.LGRAgencyDBDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCandidates = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateCandidate = new System.Windows.Forms.Button();
            this.rgbStatus = new System.Windows.Forms.GroupBox();
            this.rbnUnavailable = new System.Windows.Forms.RadioButton();
            this.rbnAvailable = new System.Windows.Forms.RadioButton();
            this.rgbWorkType = new System.Windows.Forms.GroupBox();
            this.rbnPartTime = new System.Windows.Forms.RadioButton();
            this.rbnFullTime = new System.Windows.Forms.RadioButton();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblWorkType = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCandidates = new System.Windows.Forms.Label();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).BeginInit();
            this.rgbStatus.SuspendLayout();
            this.rgbWorkType.SuspendLayout();
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
            this.StreetAddress,
            this.Suburb,
            this.City,
            this.EmailAddress,
            this.PhoneNumber,
            this.WorkType,
            this.Status});
            this.dgvCandidates.DataMember = "CANDIDATE";
            this.dgvCandidates.DataSource = this.lGRAgencyDBDataSetBindingSource;
            this.dgvCandidates.Location = new System.Drawing.Point(29, 25);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.RowTemplate.Height = 23;
            this.dgvCandidates.Size = new System.Drawing.Size(606, 166);
            this.dgvCandidates.TabIndex = 27;
            this.dgvCandidates.Click += new System.EventHandler(this.dgvCandidates_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(242, 581);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 19);
            this.label10.TabIndex = 68;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(242, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 67;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(244, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(242, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(242, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(243, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(242, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(244, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(244, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(261, 671);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "*Required Fields";
            // 
            // txtCandidates
            // 
            this.txtCandidates.Location = new System.Drawing.Point(265, 197);
            this.txtCandidates.MaxLength = 25;
            this.txtCandidates.Name = "txtCandidates";
            this.txtCandidates.ReadOnly = true;
            this.txtCandidates.Size = new System.Drawing.Size(56, 27);
            this.txtCandidates.TabIndex = 58;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(491, 646);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(144, 44);
            this.btnReturn.TabIndex = 57;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateCandidate
            // 
            this.btnUpdateCandidate.Location = new System.Drawing.Point(29, 646);
            this.btnUpdateCandidate.Name = "btnUpdateCandidate";
            this.btnUpdateCandidate.Size = new System.Drawing.Size(144, 44);
            this.btnUpdateCandidate.TabIndex = 56;
            this.btnUpdateCandidate.Text = "Update Candidate";
            this.btnUpdateCandidate.UseVisualStyleBackColor = true;
            this.btnUpdateCandidate.Click += new System.EventHandler(this.btnUpdateCandidate_Click);
            // 
            // rgbStatus
            // 
            this.rgbStatus.Controls.Add(this.rbnUnavailable);
            this.rgbStatus.Controls.Add(this.rbnAvailable);
            this.rgbStatus.Location = new System.Drawing.Point(261, 587);
            this.rgbStatus.Name = "rgbStatus";
            this.rgbStatus.Size = new System.Drawing.Size(216, 42);
            this.rgbStatus.TabIndex = 55;
            this.rgbStatus.TabStop = false;
            // 
            // rbnUnavailable
            // 
            this.rbnUnavailable.AutoSize = true;
            this.rbnUnavailable.Location = new System.Drawing.Point(103, 13);
            this.rbnUnavailable.Name = "rbnUnavailable";
            this.rbnUnavailable.Size = new System.Drawing.Size(104, 23);
            this.rbnUnavailable.TabIndex = 3;
            this.rbnUnavailable.TabStop = true;
            this.rbnUnavailable.Text = "Unavailable";
            this.rbnUnavailable.UseVisualStyleBackColor = true;
            // 
            // rbnAvailable
            // 
            this.rbnAvailable.AutoSize = true;
            this.rbnAvailable.Location = new System.Drawing.Point(6, 13);
            this.rbnAvailable.Name = "rbnAvailable";
            this.rbnAvailable.Size = new System.Drawing.Size(87, 23);
            this.rbnAvailable.TabIndex = 2;
            this.rbnAvailable.TabStop = true;
            this.rbnAvailable.Text = "Available";
            this.rbnAvailable.UseVisualStyleBackColor = true;
            // 
            // rgbWorkType
            // 
            this.rgbWorkType.Controls.Add(this.rbnPartTime);
            this.rgbWorkType.Controls.Add(this.rbnFullTime);
            this.rgbWorkType.Location = new System.Drawing.Point(265, 530);
            this.rgbWorkType.Name = "rgbWorkType";
            this.rgbWorkType.Size = new System.Drawing.Size(212, 42);
            this.rgbWorkType.TabIndex = 54;
            this.rgbWorkType.TabStop = false;
            // 
            // rbnPartTime
            // 
            this.rbnPartTime.AutoSize = true;
            this.rbnPartTime.Location = new System.Drawing.Point(100, 13);
            this.rbnPartTime.Name = "rbnPartTime";
            this.rbnPartTime.Size = new System.Drawing.Size(87, 23);
            this.rbnPartTime.TabIndex = 1;
            this.rbnPartTime.TabStop = true;
            this.rbnPartTime.Text = "Part-time";
            this.rbnPartTime.UseVisualStyleBackColor = true;
            // 
            // rbnFullTime
            // 
            this.rbnFullTime.AutoSize = true;
            this.rbnFullTime.Location = new System.Drawing.Point(6, 13);
            this.rbnFullTime.Name = "rbnFullTime";
            this.rbnFullTime.Size = new System.Drawing.Size(84, 23);
            this.rbnFullTime.TabIndex = 0;
            this.rbnFullTime.TabStop = true;
            this.rbnFullTime.Text = "Full-time";
            this.rbnFullTime.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(265, 497);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(119, 27);
            this.txtPhoneNumber.TabIndex = 53;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(265, 452);
            this.txtEmailAddress.MaxLength = 30;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(212, 27);
            this.txtEmailAddress.TabIndex = 52;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(265, 413);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(171, 27);
            this.txtCity.TabIndex = 51;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(265, 376);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(171, 27);
            this.txtSuburb.TabIndex = 50;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(265, 331);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(252, 27);
            this.txtStreetAddress.TabIndex = 49;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(265, 291);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(194, 27);
            this.txtFirstName.TabIndex = 48;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(265, 251);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(194, 27);
            this.txtLastName.TabIndex = 47;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(206, 600);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "Status";
            // 
            // lblWorkType
            // 
            this.lblWorkType.AutoSize = true;
            this.lblWorkType.Location = new System.Drawing.Point(184, 545);
            this.lblWorkType.Name = "lblWorkType";
            this.lblWorkType.Size = new System.Drawing.Size(76, 19);
            this.lblWorkType.TabIndex = 45;
            this.lblWorkType.Text = "Work Type";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(157, 497);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(104, 19);
            this.lblPhoneNumber.TabIndex = 44;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(159, 452);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(101, 19);
            this.lblEmailAddress.TabIndex = 43;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(221, 413);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 19);
            this.lblCity.TabIndex = 42;
            this.lblCity.Text = "City";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(206, 376);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(53, 19);
            this.lblSuburb.TabIndex = 41;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(158, 334);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(103, 19);
            this.lblStreetAddress.TabIndex = 40;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(181, 291);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 19);
            this.lblFirstName.TabIndex = 39;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(181, 254);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 19);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCandidates
            // 
            this.lblCandidates.AutoSize = true;
            this.lblCandidates.Location = new System.Drawing.Point(186, 200);
            this.lblCandidates.Name = "lblCandidates";
            this.lblCandidates.Size = new System.Drawing.Size(82, 19);
            this.lblCandidates.TabIndex = 37;
            this.lblCandidates.Text = "Candidates";
            // 
            // CandidateID
            // 
            this.CandidateID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CandidateID.DataPropertyName = "CandidateID";
            this.CandidateID.HeaderText = "Candidate ID";
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.ReadOnly = true;
            this.CandidateID.Width = 118;
            // 
            // CandidateLastName
            // 
            this.CandidateLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateLastName.DataPropertyName = "CandidateLastName";
            this.CandidateLastName.HeaderText = "Candidate Last Name";
            this.CandidateLastName.Name = "CandidateLastName";
            this.CandidateLastName.ReadOnly = true;
            // 
            // CandidateFirstName
            // 
            this.CandidateFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateFirstName.DataPropertyName = "CandidateFirstName";
            this.CandidateFirstName.HeaderText = "Candidate First Name";
            this.CandidateFirstName.Name = "CandidateFirstName";
            this.CandidateFirstName.ReadOnly = true;
            // 
            // StreetAddress
            // 
            this.StreetAddress.DataPropertyName = "StreetAddress";
            this.StreetAddress.HeaderText = "StreetAddress";
            this.StreetAddress.Name = "StreetAddress";
            this.StreetAddress.ReadOnly = true;
            this.StreetAddress.Visible = false;
            // 
            // Suburb
            // 
            this.Suburb.DataPropertyName = "Suburb";
            this.Suburb.HeaderText = "Suburb";
            this.Suburb.Name = "Suburb";
            this.Suburb.ReadOnly = true;
            this.Suburb.Visible = false;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Visible = false;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Visible = false;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Visible = false;
            // 
            // WorkType
            // 
            this.WorkType.DataPropertyName = "WorkType";
            this.WorkType.HeaderText = "WorkType";
            this.WorkType.Name = "WorkType";
            this.WorkType.ReadOnly = true;
            this.WorkType.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // CandidateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 707);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCandidates);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateCandidate);
            this.Controls.Add(this.rgbStatus);
            this.Controls.Add(this.rgbWorkType);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblWorkType);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCandidates);
            this.Controls.Add(this.dgvCandidates);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CandidateUpdateForm";
            this.Text = "Update Candidate";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).EndInit();
            this.rgbStatus.ResumeLayout(false);
            this.rgbStatus.PerformLayout();
            this.rgbWorkType.ResumeLayout(false);
            this.rgbWorkType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.BindingSource lGRAgencyDBDataSetBindingSource;
        private LGRAgencyDBDataSet lGRAgencyDBDataSet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCandidates;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateCandidate;
        private System.Windows.Forms.GroupBox rgbStatus;
        private System.Windows.Forms.RadioButton rbnUnavailable;
        private System.Windows.Forms.RadioButton rbnAvailable;
        private System.Windows.Forms.GroupBox rgbWorkType;
        private System.Windows.Forms.RadioButton rbnPartTime;
        private System.Windows.Forms.RadioButton rbnFullTime;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblWorkType;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCandidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}