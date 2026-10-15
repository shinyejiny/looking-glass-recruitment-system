
namespace LookingGlassRecruitmentAgency
{
    partial class VacancyDeleteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteVacancy = new System.Windows.Forms.Button();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtVacancyDescription = new System.Windows.Forms.TextBox();
            this.txtVacancyID = new System.Windows.Forms.TextBox();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.lblVacancyDescription = new System.Windows.Forms.Label();
            this.lblVacancyID = new System.Windows.Forms.Label();
            this.lblSelectVacancy = new System.Windows.Forms.Label();
            this.lstVacancies = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(293, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "*Required fields";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(150, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "*";
            // 
            // btnDeleteVacancy
            // 
            this.btnDeleteVacancy.Location = new System.Drawing.Point(31, 297);
            this.btnDeleteVacancy.Name = "btnDeleteVacancy";
            this.btnDeleteVacancy.Size = new System.Drawing.Size(132, 44);
            this.btnDeleteVacancy.TabIndex = 27;
            this.btnDeleteVacancy.Text = "Delete Vacancy";
            this.btnDeleteVacancy.UseVisualStyleBackColor = true;
            this.btnDeleteVacancy.Click += new System.EventHandler(this.btnDeleteVacancy_Click);
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(173, 227);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.ReadOnly = true;
            this.txtEmployerName.Size = new System.Drawing.Size(500, 27);
            this.txtEmployerName.TabIndex = 26;
            // 
            // txtVacancyDescription
            // 
            this.txtVacancyDescription.Location = new System.Drawing.Point(173, 174);
            this.txtVacancyDescription.Name = "txtVacancyDescription";
            this.txtVacancyDescription.ReadOnly = true;
            this.txtVacancyDescription.Size = new System.Drawing.Size(500, 27);
            this.txtVacancyDescription.TabIndex = 25;
            // 
            // txtVacancyID
            // 
            this.txtVacancyID.Location = new System.Drawing.Point(173, 123);
            this.txtVacancyID.Name = "txtVacancyID";
            this.txtVacancyID.ReadOnly = true;
            this.txtVacancyID.Size = new System.Drawing.Size(80, 27);
            this.txtVacancyID.TabIndex = 24;
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Location = new System.Drawing.Point(56, 229);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(111, 19);
            this.lblEmployerName.TabIndex = 23;
            this.lblEmployerName.Text = "Employer Name";
            // 
            // lblVacancyDescription
            // 
            this.lblVacancyDescription.AutoSize = true;
            this.lblVacancyDescription.Location = new System.Drawing.Point(27, 176);
            this.lblVacancyDescription.Name = "lblVacancyDescription";
            this.lblVacancyDescription.Size = new System.Drawing.Size(140, 19);
            this.lblVacancyDescription.TabIndex = 22;
            this.lblVacancyDescription.Text = "Vacancy Description";
            // 
            // lblVacancyID
            // 
            this.lblVacancyID.AutoSize = true;
            this.lblVacancyID.Location = new System.Drawing.Point(87, 125);
            this.lblVacancyID.Name = "lblVacancyID";
            this.lblVacancyID.Size = new System.Drawing.Size(80, 19);
            this.lblVacancyID.TabIndex = 21;
            this.lblVacancyID.Text = "Vacancy ID";
            // 
            // lblSelectVacancy
            // 
            this.lblSelectVacancy.AutoSize = true;
            this.lblSelectVacancy.Location = new System.Drawing.Point(39, 25);
            this.lblSelectVacancy.Name = "lblSelectVacancy";
            this.lblSelectVacancy.Size = new System.Drawing.Size(116, 19);
            this.lblSelectVacancy.TabIndex = 20;
            this.lblSelectVacancy.Text = "Select a vacancy";
            // 
            // lstVacancies
            // 
            this.lstVacancies.FormattingEnabled = true;
            this.lstVacancies.ItemHeight = 19;
            this.lstVacancies.Location = new System.Drawing.Point(173, 25);
            this.lstVacancies.Name = "lstVacancies";
            this.lstVacancies.Size = new System.Drawing.Size(500, 80);
            this.lstVacancies.TabIndex = 19;
            this.lstVacancies.SelectedIndexChanged += new System.EventHandler(this.lstVacancies_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(541, 297);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // VacancyDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteVacancy);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtVacancyDescription);
            this.Controls.Add(this.txtVacancyID);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.lblVacancyDescription);
            this.Controls.Add(this.lblVacancyID);
            this.Controls.Add(this.lblSelectVacancy);
            this.Controls.Add(this.lstVacancies);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VacancyDeleteForm";
            this.Text = "Delete Vacancy";
            this.Load += new System.EventHandler(this.VacancyDeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteVacancy;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtVacancyDescription;
        private System.Windows.Forms.TextBox txtVacancyID;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.Label lblVacancyDescription;
        private System.Windows.Forms.Label lblVacancyID;
        private System.Windows.Forms.Label lblSelectVacancy;
        private System.Windows.Forms.ListBox lstVacancies;
        private System.Windows.Forms.Button btnReturn;
    }
}