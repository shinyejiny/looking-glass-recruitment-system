
namespace LookingGlassRecruitmentAgency
{
    partial class VacancyAddForm
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
            this.btnAddVacancy = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cboEmployerName = new System.Windows.Forms.ComboBox();
            this.cboEmployerID = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.txtVacancyDescription = new System.Windows.Forms.TextBox();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmployers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVacancyType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVacancyStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVacancyDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddVacancy
            // 
            this.btnAddVacancy.Location = new System.Drawing.Point(28, 364);
            this.btnAddVacancy.Name = "btnAddVacancy";
            this.btnAddVacancy.Size = new System.Drawing.Size(132, 44);
            this.btnAddVacancy.TabIndex = 37;
            this.btnAddVacancy.Text = "Add Vacancy";
            this.btnAddVacancy.UseVisualStyleBackColor = true;
            this.btnAddVacancy.Click += new System.EventHandler(this.btnAddVacancy_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(741, 364);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 36;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cboEmployerName
            // 
            this.cboEmployerName.FormattingEnabled = true;
            this.cboEmployerName.Location = new System.Drawing.Point(330, 306);
            this.cboEmployerName.Name = "cboEmployerName";
            this.cboEmployerName.Size = new System.Drawing.Size(500, 26);
            this.cboEmployerName.TabIndex = 35;
            // 
            // cboEmployerID
            // 
            this.cboEmployerID.FormattingEnabled = true;
            this.cboEmployerID.Location = new System.Drawing.Point(263, 306);
            this.cboEmployerID.Name = "cboEmployerID";
            this.cboEmployerID.Size = new System.Drawing.Size(52, 26);
            this.cboEmployerID.TabIndex = 34;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Full-time",
            "Part-time"});
            this.cboType.Location = new System.Drawing.Point(263, 171);
            this.cboType.MaxLength = 9;
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 26);
            this.cboType.TabIndex = 33;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Cancelled",
            "Current",
            "Filled"});
            this.cboStatus.Location = new System.Drawing.Point(263, 102);
            this.cboStatus.MaxLength = 9;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(100, 26);
            this.cboStatus.TabIndex = 32;
            // 
            // nudSalary
            // 
            this.nudSalary.DecimalPlaces = 2;
            this.nudSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSalary.Location = new System.Drawing.Point(263, 239);
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
            this.nudSalary.Size = new System.Drawing.Size(100, 26);
            this.nudSalary.TabIndex = 31;
            this.nudSalary.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            131072});
            // 
            // txtVacancyDescription
            // 
            this.txtVacancyDescription.Location = new System.Drawing.Point(263, 42);
            this.txtVacancyDescription.MaxLength = 50;
            this.txtVacancyDescription.Name = "txtVacancyDescription";
            this.txtVacancyDescription.Size = new System.Drawing.Size(500, 26);
            this.txtVacancyDescription.TabIndex = 30;
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(392, 382);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(117, 19);
            this.lblRequiredFields.TabIndex = 29;
            this.lblRequiredFields.Text = "* Required fields";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(240, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "*";
            // 
            // lblEmployers
            // 
            this.lblEmployers.AutoSize = true;
            this.lblEmployers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployers.Location = new System.Drawing.Point(162, 314);
            this.lblEmployers.Name = "lblEmployers";
            this.lblEmployers.Size = new System.Drawing.Size(76, 19);
            this.lblEmployers.TabIndex = 27;
            this.lblEmployers.Text = "Employers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(240, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "*";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(191, 247);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 19);
            this.lblSalary.TabIndex = 25;
            this.lblSalary.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(240, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            // 
            // lblVacancyType
            // 
            this.lblVacancyType.AutoSize = true;
            this.lblVacancyType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacancyType.Location = new System.Drawing.Point(141, 179);
            this.lblVacancyType.Name = "lblVacancyType";
            this.lblVacancyType.Size = new System.Drawing.Size(96, 19);
            this.lblVacancyType.TabIndex = 23;
            this.lblVacancyType.Text = "Vacancy Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(240, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "*";
            // 
            // lblVacancyStatus
            // 
            this.lblVacancyStatus.AutoSize = true;
            this.lblVacancyStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacancyStatus.Location = new System.Drawing.Point(131, 110);
            this.lblVacancyStatus.Name = "lblVacancyStatus";
            this.lblVacancyStatus.Size = new System.Drawing.Size(106, 19);
            this.lblVacancyStatus.TabIndex = 21;
            this.lblVacancyStatus.Text = "Vacancy Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(240, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // lblVacancyDescription
            // 
            this.lblVacancyDescription.AutoSize = true;
            this.lblVacancyDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacancyDescription.Location = new System.Drawing.Point(97, 49);
            this.lblVacancyDescription.Name = "lblVacancyDescription";
            this.lblVacancyDescription.Size = new System.Drawing.Size(140, 19);
            this.lblVacancyDescription.TabIndex = 19;
            this.lblVacancyDescription.Text = "Vacancy Description";
            // 
            // VacancyAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 437);
            this.Controls.Add(this.btnAddVacancy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cboEmployerName);
            this.Controls.Add(this.cboEmployerID);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.txtVacancyDescription);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmployers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVacancyType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVacancyStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVacancyDescription);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VacancyAddForm";
            this.Text = " Add Vacancy";
            this.Load += new System.EventHandler(this.VacancyAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVacancy;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cboEmployerName;
        private System.Windows.Forms.ComboBox cboEmployerID;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.TextBox txtVacancyDescription;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmployers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVacancyType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVacancyStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVacancyDescription;
    }
}