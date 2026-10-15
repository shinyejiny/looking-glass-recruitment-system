
namespace LookingGlassRecruitmentAgency
{
    partial class EmployerUpdateForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblEmployerID = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtEmployerID = new System.Windows.Forms.TextBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.rgbStatus = new System.Windows.Forms.GroupBox();
            this.rbnInactive = new System.Windows.Forms.RadioButton();
            this.rbnActive = new System.Windows.Forms.RadioButton();
            this.btnUpdateEmployer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvEmployers = new System.Windows.Forms.DataGridView();
            this.EmployerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lGRAgencyDBDataSet = new LookingGlassRecruitmentAgency.LGRAgencyDBDataSet();
            this.eMPLOYERTableAdapter = new LookingGlassRecruitmentAgency.LGRAgencyDBDataSetTableAdapters.EMPLOYERTableAdapter();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lblRfM1 = new System.Windows.Forms.Label();
            this.rgbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an employer";
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Location = new System.Drawing.Point(465, 91);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(111, 19);
            this.lblEmployerName.TabIndex = 2;
            this.lblEmployerName.Text = "Employer Name";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(473, 143);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(103, 19);
            this.lblStreetAddress.TabIndex = 3;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // lblEmployerID
            // 
            this.lblEmployerID.AutoSize = true;
            this.lblEmployerID.Location = new System.Drawing.Point(489, 39);
            this.lblEmployerID.Name = "lblEmployerID";
            this.lblEmployerID.Size = new System.Drawing.Size(87, 19);
            this.lblEmployerID.TabIndex = 4;
            this.lblEmployerID.Text = "Employer ID";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(523, 195);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(53, 19);
            this.lblSuburb.TabIndex = 5;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(542, 247);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 19);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(475, 299);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(101, 19);
            this.lblEmailAddress.TabIndex = 7;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(472, 351);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(104, 19);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(527, 403);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // txtEmployerID
            // 
            this.txtEmployerID.Location = new System.Drawing.Point(582, 36);
            this.txtEmployerID.Name = "txtEmployerID";
            this.txtEmployerID.ReadOnly = true;
            this.txtEmployerID.Size = new System.Drawing.Size(37, 27);
            this.txtEmployerID.TabIndex = 10;
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(582, 88);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(298, 27);
            this.txtEmployerName.TabIndex = 11;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(582, 140);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(298, 27);
            this.txtStreetAddress.TabIndex = 12;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(582, 192);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(155, 27);
            this.txtSuburb.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(582, 244);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 27);
            this.txtCity.TabIndex = 14;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(582, 296);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(227, 27);
            this.txtEmailAddress.TabIndex = 15;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(582, 348);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(93, 27);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // rgbStatus
            // 
            this.rgbStatus.Controls.Add(this.rbnInactive);
            this.rgbStatus.Controls.Add(this.rbnActive);
            this.rgbStatus.Location = new System.Drawing.Point(582, 381);
            this.rgbStatus.Name = "rgbStatus";
            this.rgbStatus.Size = new System.Drawing.Size(182, 58);
            this.rgbStatus.TabIndex = 17;
            this.rgbStatus.TabStop = false;
            // 
            // rbnInactive
            // 
            this.rbnInactive.AutoSize = true;
            this.rbnInactive.Location = new System.Drawing.Point(91, 20);
            this.rbnInactive.Name = "rbnInactive";
            this.rbnInactive.Size = new System.Drawing.Size(78, 23);
            this.rbnInactive.TabIndex = 1;
            this.rbnInactive.TabStop = true;
            this.rbnInactive.Text = "Inactive";
            this.rbnInactive.UseVisualStyleBackColor = true;
            // 
            // rbnActive
            // 
            this.rbnActive.AutoSize = true;
            this.rbnActive.Location = new System.Drawing.Point(6, 20);
            this.rbnActive.Name = "rbnActive";
            this.rbnActive.Size = new System.Drawing.Size(67, 23);
            this.rbnActive.TabIndex = 0;
            this.rbnActive.TabStop = true;
            this.rbnActive.Text = "Active";
            this.rbnActive.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployer
            // 
            this.btnUpdateEmployer.Location = new System.Drawing.Point(29, 472);
            this.btnUpdateEmployer.Name = "btnUpdateEmployer";
            this.btnUpdateEmployer.Size = new System.Drawing.Size(132, 44);
            this.btnUpdateEmployer.TabIndex = 18;
            this.btnUpdateEmployer.Text = "Update Employer";
            this.btnUpdateEmployer.UseVisualStyleBackColor = true;
            this.btnUpdateEmployer.Click += new System.EventHandler(this.btnUpdateEmployer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(748, 472);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvEmployers
            // 
            this.dgvEmployers.AutoGenerateColumns = false;
            this.dgvEmployers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployerID,
            this.EmployerName,
            this.StreetAddress,
            this.Suburb,
            this.City,
            this.EmailAddress,
            this.PhoneNumber,
            this.EmployerStatus});
            this.dgvEmployers.DataSource = this.eMPLOYERBindingSource;
            this.dgvEmployers.Location = new System.Drawing.Point(33, 37);
            this.dgvEmployers.Name = "dgvEmployers";
            this.dgvEmployers.ReadOnly = true;
            this.dgvEmployers.RowHeadersWidth = 51;
            this.dgvEmployers.Size = new System.Drawing.Size(416, 402);
            this.dgvEmployers.TabIndex = 20;
            this.dgvEmployers.Click += new System.EventHandler(this.dgvEmployers_Click);
            // 
            // EmployerID
            // 
            this.EmployerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmployerID.DataPropertyName = "EmployerID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployerID.DefaultCellStyle = dataGridViewCellStyle1;
            this.EmployerID.HeaderText = "Employer ID";
            this.EmployerID.MinimumWidth = 10;
            this.EmployerID.Name = "EmployerID";
            this.EmployerID.ReadOnly = true;
            this.EmployerID.Width = 112;
            // 
            // EmployerName
            // 
            this.EmployerName.DataPropertyName = "EmployerName";
            this.EmployerName.HeaderText = "Employer Name";
            this.EmployerName.MinimumWidth = 6;
            this.EmployerName.Name = "EmployerName";
            this.EmployerName.ReadOnly = true;
            this.EmployerName.Width = 250;
            // 
            // StreetAddress
            // 
            this.StreetAddress.DataPropertyName = "StreetAddress";
            this.StreetAddress.HeaderText = "StreetAddress";
            this.StreetAddress.MinimumWidth = 6;
            this.StreetAddress.Name = "StreetAddress";
            this.StreetAddress.ReadOnly = true;
            this.StreetAddress.Visible = false;
            this.StreetAddress.Width = 125;
            // 
            // Suburb
            // 
            this.Suburb.DataPropertyName = "Suburb";
            this.Suburb.HeaderText = "Suburb";
            this.Suburb.MinimumWidth = 6;
            this.Suburb.Name = "Suburb";
            this.Suburb.ReadOnly = true;
            this.Suburb.Visible = false;
            this.Suburb.Width = 125;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Visible = false;
            this.City.Width = 125;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.MinimumWidth = 6;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Visible = false;
            this.EmailAddress.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Visible = false;
            this.PhoneNumber.Width = 125;
            // 
            // EmployerStatus
            // 
            this.EmployerStatus.DataPropertyName = "EmployerStatus";
            this.EmployerStatus.HeaderText = "EmployerStatus";
            this.EmployerStatus.MinimumWidth = 6;
            this.EmployerStatus.Name = "EmployerStatus";
            this.EmployerStatus.ReadOnly = true;
            this.EmployerStatus.Visible = false;
            this.EmployerStatus.Width = 125;
            // 
            // eMPLOYERBindingSource
            // 
            this.eMPLOYERBindingSource.DataMember = "EMPLOYER";
            this.eMPLOYERBindingSource.DataSource = this.lGRAgencyDBDataSet;
            // 
            // lGRAgencyDBDataSet
            // 
            this.lGRAgencyDBDataSet.DataSetName = "LGRAgencyDBDataSet";
            this.lGRAgencyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYERTableAdapter
            // 
            this.eMPLOYERTableAdapter.ClearBeforeFill = true;
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(408, 504);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(113, 19);
            this.lblRequiredFields.TabIndex = 22;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // lblRfM1
            // 
            this.lblRfM1.AutoSize = true;
            this.lblRfM1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfM1.ForeColor = System.Drawing.Color.Red;
            this.lblRfM1.Location = new System.Drawing.Point(158, 14);
            this.lblRfM1.Name = "lblRfM1";
            this.lblRfM1.Size = new System.Drawing.Size(12, 13);
            this.lblRfM1.TabIndex = 29;
            this.lblRfM1.Text = "*";
            // 
            // EmployerUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 532);
            this.Controls.Add(this.lblRfM1);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.dgvEmployers);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateEmployer);
            this.Controls.Add(this.rgbStatus);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtEmployerID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblEmployerID);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployerUpdateForm";
            this.Text = "Update Employer";
            this.Load += new System.EventHandler(this.EmployerUpdateForm_Load);
            this.rgbStatus.ResumeLayout(false);
            this.rgbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGRAgencyDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblEmployerID;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtEmployerID;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox rgbStatus;
        private System.Windows.Forms.RadioButton rbnInactive;
        private System.Windows.Forms.RadioButton rbnActive;
        private System.Windows.Forms.Button btnUpdateEmployer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvEmployers;
        private LGRAgencyDBDataSet lGRAgencyDBDataSet;
        private System.Windows.Forms.BindingSource eMPLOYERBindingSource;
        private LGRAgencyDBDataSetTableAdapters.EMPLOYERTableAdapter eMPLOYERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployerStatus;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblRfM1;
    }
}