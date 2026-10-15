
namespace LookingGlassRecruitmentAgency
{
    partial class EmployersReportForm
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
            this.txtEmployersReport = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.lblEmpRepo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmployersReport
            // 
            this.txtEmployersReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmployersReport.Location = new System.Drawing.Point(47, 37);
            this.txtEmployersReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployersReport.Multiline = true;
            this.txtEmployersReport.Name = "txtEmployersReport";
            this.txtEmployersReport.ReadOnly = true;
            this.txtEmployersReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEmployersReport.Size = new System.Drawing.Size(666, 417);
            this.txtEmployersReport.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(577, 482);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 41;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(47, 482);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(132, 44);
            this.btnDisplayReport.TabIndex = 40;
            this.btnDisplayReport.Text = "Display Report";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // lblEmpRepo
            // 
            this.lblEmpRepo.AutoSize = true;
            this.lblEmpRepo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpRepo.Location = new System.Drawing.Point(281, 14);
            this.lblEmpRepo.Name = "lblEmpRepo";
            this.lblEmpRepo.Size = new System.Drawing.Size(200, 19);
            this.lblEmpRepo.TabIndex = 42;
            this.lblEmpRepo.Text = "THE REPORT OF EMPOLYERS";
            // 
            // EmployersReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 549);
            this.Controls.Add(this.lblEmpRepo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.txtEmployersReport);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployersReportForm";
            this.Text = "Employers Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployersReport;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.Label lblEmpRepo;
    }
}