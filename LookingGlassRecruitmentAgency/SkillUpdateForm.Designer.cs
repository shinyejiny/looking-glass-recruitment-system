
namespace LookingGlassRecruitmentAgency
{
    partial class SkillUpdateForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSkillType = new System.Windows.Forms.Label();
            this.lblSkillDescriptionv = new System.Windows.Forms.Label();
            this.lblSkillID = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblSelectSkill = new System.Windows.Forms.Label();
            this.btnUpdateSkill = new System.Windows.Forms.Button();
            this.cboSkillType = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtSkillDescription = new System.Windows.Forms.TextBox();
            this.txtSkillID = new System.Windows.Forms.TextBox();
            this.lstSkills = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(181, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(181, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(181, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "*";
            // 
            // lblSkillType
            // 
            this.lblSkillType.AutoSize = true;
            this.lblSkillType.Location = new System.Drawing.Point(113, 213);
            this.lblSkillType.Name = "lblSkillType";
            this.lblSkillType.Size = new System.Drawing.Size(69, 19);
            this.lblSkillType.TabIndex = 25;
            this.lblSkillType.Text = "Skill Type";
            // 
            // lblSkillDescriptionv
            // 
            this.lblSkillDescriptionv.AutoSize = true;
            this.lblSkillDescriptionv.Location = new System.Drawing.Point(69, 170);
            this.lblSkillDescriptionv.Name = "lblSkillDescriptionv";
            this.lblSkillDescriptionv.Size = new System.Drawing.Size(113, 19);
            this.lblSkillDescriptionv.TabIndex = 24;
            this.lblSkillDescriptionv.Text = "Skill Description";
            // 
            // lblSkillID
            // 
            this.lblSkillID.AutoSize = true;
            this.lblSkillID.Location = new System.Drawing.Point(129, 132);
            this.lblSkillID.Name = "lblSkillID";
            this.lblSkillID.Size = new System.Drawing.Size(53, 19);
            this.lblSkillID.TabIndex = 23;
            this.lblSkillID.Text = "Skill ID";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(353, 326);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(117, 19);
            this.lblRequired.TabIndex = 22;
            this.lblRequired.Text = "* Required fields";
            // 
            // lblSelectSkill
            // 
            this.lblSelectSkill.AutoSize = true;
            this.lblSelectSkill.Location = new System.Drawing.Point(92, 27);
            this.lblSelectSkill.Name = "lblSelectSkill";
            this.lblSelectSkill.Size = new System.Drawing.Size(90, 19);
            this.lblSelectSkill.TabIndex = 21;
            this.lblSelectSkill.Text = "Select a skill";
            // 
            // btnUpdateSkill
            // 
            this.btnUpdateSkill.Location = new System.Drawing.Point(17, 290);
            this.btnUpdateSkill.Name = "btnUpdateSkill";
            this.btnUpdateSkill.Size = new System.Drawing.Size(134, 44);
            this.btnUpdateSkill.TabIndex = 20;
            this.btnUpdateSkill.Text = "Update Skill ";
            this.btnUpdateSkill.UseVisualStyleBackColor = true;
            this.btnUpdateSkill.Click += new System.EventHandler(this.btnUpdateSkill_Click);
            // 
            // cboSkillType
            // 
            this.cboSkillType.FormattingEnabled = true;
            this.cboSkillType.Items.AddRange(new object[] {
            "Hard",
            "Soft"});
            this.cboSkillType.Location = new System.Drawing.Point(204, 210);
            this.cboSkillType.MaxLength = 4;
            this.cboSkillType.Name = "cboSkillType";
            this.cboSkillType.Size = new System.Drawing.Size(70, 27);
            this.cboSkillType.TabIndex = 19;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(672, 290);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 44);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtSkillDescription
            // 
            this.txtSkillDescription.Location = new System.Drawing.Point(204, 167);
            this.txtSkillDescription.MaxLength = 50;
            this.txtSkillDescription.Name = "txtSkillDescription";
            this.txtSkillDescription.Size = new System.Drawing.Size(500, 27);
            this.txtSkillDescription.TabIndex = 17;
            // 
            // txtSkillID
            // 
            this.txtSkillID.Location = new System.Drawing.Point(204, 129);
            this.txtSkillID.MaxLength = 3;
            this.txtSkillID.Name = "txtSkillID";
            this.txtSkillID.ReadOnly = true;
            this.txtSkillID.Size = new System.Drawing.Size(30, 27);
            this.txtSkillID.TabIndex = 16;
            // 
            // lstSkills
            // 
            this.lstSkills.FormattingEnabled = true;
            this.lstSkills.ItemHeight = 19;
            this.lstSkills.Location = new System.Drawing.Point(204, 27);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(530, 80);
            this.lstSkills.TabIndex = 15;
            this.lstSkills.SelectedIndexChanged += new System.EventHandler(this.lstSkills_SelectedIndexChanged);
            // 
            // SkillUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSkillType);
            this.Controls.Add(this.lblSkillDescriptionv);
            this.Controls.Add(this.lblSkillID);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblSelectSkill);
            this.Controls.Add(this.btnUpdateSkill);
            this.Controls.Add(this.cboSkillType);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtSkillDescription);
            this.Controls.Add(this.txtSkillID);
            this.Controls.Add(this.lstSkills);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SkillUpdateForm";
            this.Text = "SkillUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSkillType;
        private System.Windows.Forms.Label lblSkillDescriptionv;
        private System.Windows.Forms.Label lblSkillID;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblSelectSkill;
        private System.Windows.Forms.Button btnUpdateSkill;
        private System.Windows.Forms.ComboBox cboSkillType;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtSkillDescription;
        private System.Windows.Forms.TextBox txtSkillID;
        private System.Windows.Forms.ListBox lstSkills;
    }
}