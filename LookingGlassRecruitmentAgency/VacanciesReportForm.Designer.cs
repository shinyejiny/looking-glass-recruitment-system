
namespace LookingGlassRecruitmentAgency
{
    partial class VacanciesReportForm
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
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtVacancies = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(30, 422);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(132, 44);
            this.btnDisplayReport.TabIndex = 5;
            this.btnDisplayReport.Text = "Display Report";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(564, 422);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtVacancies
            // 
            this.txtVacancies.AcceptsReturn = true;
            this.txtVacancies.BackColor = System.Drawing.Color.White;
            this.txtVacancies.Location = new System.Drawing.Point(30, 51);
            this.txtVacancies.Multiline = true;
            this.txtVacancies.Name = "txtVacancies";
            this.txtVacancies.ReadOnly = true;
            this.txtVacancies.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVacancies.Size = new System.Drawing.Size(666, 338);
            this.txtVacancies.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "THE REPORT OF VACANCIES";
            // 
            // VacanciesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtVacancies);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VacanciesReportForm";
            this.Text = "Vacancies Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtVacancies;
        private System.Windows.Forms.Label label1;
    }
}