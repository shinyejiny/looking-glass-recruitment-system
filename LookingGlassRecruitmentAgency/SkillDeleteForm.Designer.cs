
namespace LookingGlassRecruitmentAgency
{
    partial class SkillDeleteForm
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
            this.btnDeleteSkill = new System.Windows.Forms.Button();
            this.txtSkillDiscription = new System.Windows.Forms.TextBox();
            this.txtSkillType = new System.Windows.Forms.TextBox();
            this.txtSkillID = new System.Windows.Forms.TextBox();
            this.lblSkillType = new System.Windows.Forms.Label();
            this.lblSkillDiscription = new System.Windows.Forms.Label();
            this.lblSkilID = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.lstSkills = new System.Windows.Forms.ListBox();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(332, 346);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 56;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteSkill
            // 
            this.btnDeleteSkill.Location = new System.Drawing.Point(28, 346);
            this.btnDeleteSkill.Name = "btnDeleteSkill";
            this.btnDeleteSkill.Size = new System.Drawing.Size(132, 44);
            this.btnDeleteSkill.TabIndex = 55;
            this.btnDeleteSkill.Text = "Delete Skill";
            this.btnDeleteSkill.UseVisualStyleBackColor = true;
            this.btnDeleteSkill.Click += new System.EventHandler(this.btnDeleteSkill_Click);
            // 
            // txtSkillDiscription
            // 
            this.txtSkillDiscription.Location = new System.Drawing.Point(139, 233);
            this.txtSkillDiscription.Name = "txtSkillDiscription";
            this.txtSkillDiscription.ReadOnly = true;
            this.txtSkillDiscription.Size = new System.Drawing.Size(323, 27);
            this.txtSkillDiscription.TabIndex = 54;
            // 
            // txtSkillType
            // 
            this.txtSkillType.Location = new System.Drawing.Point(139, 282);
            this.txtSkillType.Name = "txtSkillType";
            this.txtSkillType.ReadOnly = true;
            this.txtSkillType.Size = new System.Drawing.Size(80, 27);
            this.txtSkillType.TabIndex = 53;
            // 
            // txtSkillID
            // 
            this.txtSkillID.Location = new System.Drawing.Point(139, 183);
            this.txtSkillID.Name = "txtSkillID";
            this.txtSkillID.ReadOnly = true;
            this.txtSkillID.Size = new System.Drawing.Size(50, 27);
            this.txtSkillID.TabIndex = 52;
            // 
            // lblSkillType
            // 
            this.lblSkillType.AutoSize = true;
            this.lblSkillType.Location = new System.Drawing.Point(64, 285);
            this.lblSkillType.Name = "lblSkillType";
            this.lblSkillType.Size = new System.Drawing.Size(69, 19);
            this.lblSkillType.TabIndex = 50;
            this.lblSkillType.Text = "Skill Type";
            // 
            // lblSkillDiscription
            // 
            this.lblSkillDiscription.AutoSize = true;
            this.lblSkillDiscription.Location = new System.Drawing.Point(24, 236);
            this.lblSkillDiscription.Name = "lblSkillDiscription";
            this.lblSkillDiscription.Size = new System.Drawing.Size(109, 19);
            this.lblSkillDiscription.TabIndex = 49;
            this.lblSkillDiscription.Text = "Skill Discription";
            // 
            // lblSkilID
            // 
            this.lblSkilID.AutoSize = true;
            this.lblSkilID.Location = new System.Drawing.Point(80, 186);
            this.lblSkilID.Name = "lblSkilID";
            this.lblSkilID.Size = new System.Drawing.Size(53, 19);
            this.lblSkilID.TabIndex = 48;
            this.lblSkilID.Text = "Skill ID";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(43, 30);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(90, 19);
            this.lblSkill.TabIndex = 47;
            this.lblSkill.Text = "Select a Skill";
            // 
            // lstSkills
            // 
            this.lstSkills.FormattingEnabled = true;
            this.lstSkills.ItemHeight = 19;
            this.lstSkills.Location = new System.Drawing.Point(139, 30);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(323, 137);
            this.lstSkills.TabIndex = 57;
            this.lstSkills.SelectedIndexChanged += new System.EventHandler(this.lstSkills_SelectedIndexChanged);
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(189, 385);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(113, 19);
            this.lblRequiredFields.TabIndex = 58;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(125, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "*";
            // 
            // SkillDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.lstSkills);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteSkill);
            this.Controls.Add(this.txtSkillDiscription);
            this.Controls.Add(this.txtSkillType);
            this.Controls.Add(this.txtSkillID);
            this.Controls.Add(this.lblSkillType);
            this.Controls.Add(this.lblSkillDiscription);
            this.Controls.Add(this.lblSkilID);
            this.Controls.Add(this.lblSkill);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SkillDeleteForm";
            this.Text = "Delete Skill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteSkill;
        private System.Windows.Forms.TextBox txtSkillDiscription;
        private System.Windows.Forms.TextBox txtSkillType;
        private System.Windows.Forms.TextBox txtSkillID;
        private System.Windows.Forms.Label lblSkillType;
        private System.Windows.Forms.Label lblSkillDiscription;
        private System.Windows.Forms.Label lblSkilID;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.ListBox lstSkills;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label label1;
    }
}