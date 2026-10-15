
namespace LookingGlassRecruitmentAgency
{
    partial class SkillAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(544, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(544, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(616, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "*Required Fields";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(750, 297);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(167, 42);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.Location = new System.Drawing.Point(431, 297);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(167, 42);
            this.btnAddSkill.TabIndex = 31;
            this.btnAddSkill.Text = "Add Skill";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(567, 121);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 27);
            this.txtDescription.TabIndex = 29;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(492, 183);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(69, 19);
            this.lblType.TabIndex = 28;
            this.lblType.Text = "Skill Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(448, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(113, 19);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Skill Description";
            // 
            // txtSkill
            // 
            this.txtSkill.Location = new System.Drawing.Point(33, 23);
            this.txtSkill.Multiline = true;
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSkill.Size = new System.Drawing.Size(379, 316);
            this.txtSkill.TabIndex = 26;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Hard",
            "Soft"});
            this.cboType.Location = new System.Drawing.Point(567, 180);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 27);
            this.cboType.TabIndex = 36;
            // 
            // SkillAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 374);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddSkill);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtSkill);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SkillAddForm";
            this.Text = "Add Skill";
            this.Load += new System.EventHandler(this.SkillAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.ComboBox cboType;
    }
}