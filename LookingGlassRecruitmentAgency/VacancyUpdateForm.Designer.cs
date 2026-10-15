
namespace LookingGlassRecruitmentAgency
{
    partial class VacancyUpdateForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lstVacancies = new System.Windows.Forms.ListBox();
            this.btnUpdateVacancy = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtVacancyDescription = new System.Windows.Forms.TextBox();
            this.txtVacancyID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblVacancyType = new System.Windows.Forms.Label();
            this.lblVacancyStatus = new System.Windows.Forms.Label();
            this.lblVacancyDescription = new System.Windows.Forms.Label();
            this.lblVacancyID = new System.Windows.Forms.Label();
            this.lblSelectVacancy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(152, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(290, 418);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(117, 19);
            this.lblRequiredFields.TabIndex = 43;
            this.lblRequiredFields.Text = "* Required fields";
            // 
            // lstVacancies
            // 
            this.lstVacancies.FormattingEnabled = true;
            this.lstVacancies.ItemHeight = 19;
            this.lstVacancies.Location = new System.Drawing.Point(191, 37);
            this.lstVacancies.Name = "lstVacancies";
            this.lstVacancies.Size = new System.Drawing.Size(501, 80);
            this.lstVacancies.TabIndex = 42;
            this.lstVacancies.SelectedIndexChanged += new System.EventHandler(this.lstVacancies_SelectedIndexChanged);
            // 
            // btnUpdateVacancy
            // 
            this.btnUpdateVacancy.Location = new System.Drawing.Point(30, 380);
            this.btnUpdateVacancy.Name = "btnUpdateVacancy";
            this.btnUpdateVacancy.Size = new System.Drawing.Size(132, 44);
            this.btnUpdateVacancy.TabIndex = 41;
            this.btnUpdateVacancy.Text = "Update Vacancy";
            this.btnUpdateVacancy.UseVisualStyleBackColor = true;
            this.btnUpdateVacancy.Click += new System.EventHandler(this.btnUpdateVacancy_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(559, 380);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 40;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(191, 342);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.ReadOnly = true;
            this.txtEmployerName.Size = new System.Drawing.Size(500, 27);
            this.txtEmployerName.TabIndex = 39;
            // 
            // nudSalary
            // 
            this.nudSalary.DecimalPlaces = 2;
            this.nudSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSalary.Location = new System.Drawing.Point(191, 302);
            this.nudSalary.Maximum = new decimal(new int[] {
            25000000,
            0,
            0,
            131072});
            this.nudSalary.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            131072});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(120, 27);
            this.nudSalary.TabIndex = 38;
            this.nudSalary.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            131072});
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Full-time",
            "Part-time"});
            this.cboType.Location = new System.Drawing.Point(191, 262);
            this.cboType.MaxLength = 9;
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(90, 27);
            this.cboType.TabIndex = 37;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Cancelled",
            "Current"});
            this.cboStatus.Location = new System.Drawing.Point(191, 220);
            this.cboStatus.MaxLength = 9;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(90, 27);
            this.cboStatus.TabIndex = 36;
            // 
            // txtVacancyDescription
            // 
            this.txtVacancyDescription.Location = new System.Drawing.Point(192, 181);
            this.txtVacancyDescription.MaxLength = 50;
            this.txtVacancyDescription.Name = "txtVacancyDescription";
            this.txtVacancyDescription.Size = new System.Drawing.Size(500, 27);
            this.txtVacancyDescription.TabIndex = 35;
            // 
            // txtVacancyID
            // 
            this.txtVacancyID.Location = new System.Drawing.Point(192, 146);
            this.txtVacancyID.MaxLength = 8;
            this.txtVacancyID.Name = "txtVacancyID";
            this.txtVacancyID.ReadOnly = true;
            this.txtVacancyID.Size = new System.Drawing.Size(80, 27);
            this.txtVacancyID.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(168, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(168, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(168, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(168, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "*";
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployerName.Location = new System.Drawing.Point(53, 344);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(111, 19);
            this.lblEmployerName.TabIndex = 29;
            this.lblEmployerName.Text = "Employer Name";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(120, 304);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 19);
            this.lblSalary.TabIndex = 28;
            this.lblSalary.Text = "Salary";
            // 
            // lblVacancyType
            // 
            this.lblVacancyType.AutoSize = true;
            this.lblVacancyType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacancyType.Location = new System.Drawing.Point(129, 262);
            this.lblVacancyType.Name = "lblVacancyType";
            this.lblVacancyType.Size = new System.Drawing.Size(39, 19);
            this.lblVacancyType.TabIndex = 27;
            this.lblVacancyType.Text = "Type";
            // 
            // lblVacancyStatus
            // 
            this.lblVacancyStatus.AutoSize = true;
            this.lblVacancyStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacancyStatus.Location = new System.Drawing.Point(120, 223);
            this.lblVacancyStatus.Name = "lblVacancyStatus";
            this.lblVacancyStatus.Size = new System.Drawing.Size(49, 19);
            this.lblVacancyStatus.TabIndex = 26;
            this.lblVacancyStatus.Text = "Status";
            // 
            // lblVacancyDescription
            // 
            this.lblVacancyDescription.AutoSize = true;
            this.lblVacancyDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacancyDescription.Location = new System.Drawing.Point(26, 189);
            this.lblVacancyDescription.Name = "lblVacancyDescription";
            this.lblVacancyDescription.Size = new System.Drawing.Size(140, 19);
            this.lblVacancyDescription.TabIndex = 25;
            this.lblVacancyDescription.Text = "Vacancy Description";
            // 
            // lblVacancyID
            // 
            this.lblVacancyID.AutoSize = true;
            this.lblVacancyID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacancyID.Location = new System.Drawing.Point(89, 154);
            this.lblVacancyID.Name = "lblVacancyID";
            this.lblVacancyID.Size = new System.Drawing.Size(80, 19);
            this.lblVacancyID.TabIndex = 24;
            this.lblVacancyID.Text = "Vacancy ID";
            // 
            // lblSelectVacancy
            // 
            this.lblSelectVacancy.AutoSize = true;
            this.lblSelectVacancy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVacancy.Location = new System.Drawing.Point(41, 37);
            this.lblSelectVacancy.Name = "lblSelectVacancy";
            this.lblSelectVacancy.Size = new System.Drawing.Size(116, 19);
            this.lblSelectVacancy.TabIndex = 23;
            this.lblSelectVacancy.Text = "Select a vacancy";
            // 
            // VacancyUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 457);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.lstVacancies);
            this.Controls.Add(this.btnUpdateVacancy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtVacancyDescription);
            this.Controls.Add(this.txtVacancyID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblVacancyType);
            this.Controls.Add(this.lblVacancyStatus);
            this.Controls.Add(this.lblVacancyDescription);
            this.Controls.Add(this.lblVacancyID);
            this.Controls.Add(this.lblSelectVacancy);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VacancyUpdateForm";
            this.Text = "Update Vacancy";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.ListBox lstVacancies;
        private System.Windows.Forms.Button btnUpdateVacancy;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtVacancyDescription;
        private System.Windows.Forms.TextBox txtVacancyID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblVacancyType;
        private System.Windows.Forms.Label lblVacancyStatus;
        private System.Windows.Forms.Label lblVacancyDescription;
        private System.Windows.Forms.Label lblVacancyID;
        private System.Windows.Forms.Label lblSelectVacancy;
    }
}