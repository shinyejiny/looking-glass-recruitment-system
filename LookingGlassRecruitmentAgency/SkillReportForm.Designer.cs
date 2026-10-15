
namespace LookingGlassRecruitmentAgency
{
    partial class SkillReportForm
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.lblEmpRepo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(575, 471);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(41, 471);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(132, 44);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display Report";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtSkills
            // 
            this.txtSkills.BackColor = System.Drawing.Color.White;
            this.txtSkills.Location = new System.Drawing.Point(41, 41);
            this.txtSkills.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSkills.Multiline = true;
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.ReadOnly = true;
            this.txtSkills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSkills.Size = new System.Drawing.Size(666, 417);
            this.txtSkills.TabIndex = 6;
            // 
            // lblEmpRepo
            // 
            this.lblEmpRepo.AutoSize = true;
            this.lblEmpRepo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpRepo.Location = new System.Drawing.Point(278, 17);
            this.lblEmpRepo.Name = "lblEmpRepo";
            this.lblEmpRepo.Size = new System.Drawing.Size(158, 19);
            this.lblEmpRepo.TabIndex = 43;
            this.lblEmpRepo.Text = "THE REPORT OF SKLLS";
            // 
            // SkillReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 548);
            this.Controls.Add(this.lblEmpRepo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtSkills);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SkillReportForm";
            this.Text = "Skill Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtSkills;
        private System.Windows.Forms.Label lblEmpRepo;
    }
}