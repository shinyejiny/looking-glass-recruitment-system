
namespace LookingGlassRecruitmentAgency
{
    partial class ApplicationsReportForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.txtApplicationReport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(574, 483);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 44;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(40, 474);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(132, 44);
            this.btnDisplayReport.TabIndex = 43;
            this.btnDisplayReport.Text = "Display Report";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // txtApplicationReport
            // 
            this.txtApplicationReport.Location = new System.Drawing.Point(40, 50);
            this.txtApplicationReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtApplicationReport.Multiline = true;
            this.txtApplicationReport.Name = "txtApplicationReport";
            this.txtApplicationReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtApplicationReport.Size = new System.Drawing.Size(666, 396);
            this.txtApplicationReport.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "THE REPORT OF APPLICATIONS";
            // 
            // ApplicationsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.txtApplicationReport);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplicationsReportForm";
            this.Text = "Applications Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.TextBox txtApplicationReport;
        private System.Windows.Forms.Label label1;
    }
}