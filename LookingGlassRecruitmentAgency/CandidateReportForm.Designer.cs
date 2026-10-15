
namespace LookingGlassRecruitmentAgency
{
    partial class CandidateReportForm
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
            this.txtCandidates = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCandidates
            // 
            this.txtCandidates.BackColor = System.Drawing.Color.White;
            this.txtCandidates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidates.Location = new System.Drawing.Point(41, 56);
            this.txtCandidates.Multiline = true;
            this.txtCandidates.Name = "txtCandidates";
            this.txtCandidates.ReadOnly = true;
            this.txtCandidates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCandidates.Size = new System.Drawing.Size(666, 396);
            this.txtCandidates.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(575, 471);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(41, 471);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(132, 44);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display Report";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "THE REPORT OF CANDIDATES";
            // 
            // CandidateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCandidates);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplay);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CandidateReportForm";
            this.Text = "CandidateReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCandidates;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label1;
    }
}