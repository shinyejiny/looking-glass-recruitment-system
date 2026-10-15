
namespace LookingGlassRecruitmentAgency
{
    partial class EmployerDeleteForm
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
            this.lstEmployerDeatils = new System.Windows.Forms.ListBox();
            this.lblSelectEmp = new System.Windows.Forms.Label();
            this.lblEmployerID = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.txtEmployerID = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteEmployer = new System.Windows.Forms.Button();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEmployerDeatils
            // 
            this.lstEmployerDeatils.FormattingEnabled = true;
            this.lstEmployerDeatils.ItemHeight = 19;
            this.lstEmployerDeatils.Location = new System.Drawing.Point(31, 47);
            this.lstEmployerDeatils.Name = "lstEmployerDeatils";
            this.lstEmployerDeatils.Size = new System.Drawing.Size(329, 289);
            this.lstEmployerDeatils.TabIndex = 0;
            this.lstEmployerDeatils.SelectedIndexChanged += new System.EventHandler(this.lstEmployerDeatils_SelectedIndexChanged);
            // 
            // lblSelectEmp
            // 
            this.lblSelectEmp.AutoSize = true;
            this.lblSelectEmp.Location = new System.Drawing.Point(27, 20);
            this.lblSelectEmp.Name = "lblSelectEmp";
            this.lblSelectEmp.Size = new System.Drawing.Size(132, 19);
            this.lblSelectEmp.TabIndex = 1;
            this.lblSelectEmp.Text = "Select an employer";
            // 
            // lblEmployerID
            // 
            this.lblEmployerID.AutoSize = true;
            this.lblEmployerID.Location = new System.Drawing.Point(433, 47);
            this.lblEmployerID.Name = "lblEmployerID";
            this.lblEmployerID.Size = new System.Drawing.Size(87, 19);
            this.lblEmployerID.TabIndex = 2;
            this.lblEmployerID.Text = "Employer ID";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(418, 145);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(101, 19);
            this.lblEmailAddress.TabIndex = 3;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(464, 194);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Location = new System.Drawing.Point(408, 93);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(111, 19);
            this.lblEmployerName.TabIndex = 5;
            this.lblEmployerName.Text = "Employer Name";
            // 
            // txtEmployerID
            // 
            this.txtEmployerID.Location = new System.Drawing.Point(526, 44);
            this.txtEmployerID.Name = "txtEmployerID";
            this.txtEmployerID.ReadOnly = true;
            this.txtEmployerID.Size = new System.Drawing.Size(37, 27);
            this.txtEmployerID.TabIndex = 31;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(525, 191);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(78, 27);
            this.txtStatus.TabIndex = 43;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(525, 142);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(227, 27);
            this.txtEmailAddress.TabIndex = 42;
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(525, 93);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.ReadOnly = true;
            this.txtEmployerName.Size = new System.Drawing.Size(298, 27);
            this.txtEmployerName.TabIndex = 41;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(691, 292);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 44);
            this.btnReturn.TabIndex = 45;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteEmployer
            // 
            this.btnDeleteEmployer.Location = new System.Drawing.Point(381, 292);
            this.btnDeleteEmployer.Name = "btnDeleteEmployer";
            this.btnDeleteEmployer.Size = new System.Drawing.Size(132, 44);
            this.btnDeleteEmployer.TabIndex = 44;
            this.btnDeleteEmployer.Text = "Delete Employer";
            this.btnDeleteEmployer.UseVisualStyleBackColor = true;
            this.btnDeleteEmployer.Click += new System.EventHandler(this.btnDeleteEmployer_Click);
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(543, 317);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(113, 19);
            this.lblRequiredFields.TabIndex = 46;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(156, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "*";
            // 
            // EmployerDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteEmployer);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtEmployerID);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblEmployerID);
            this.Controls.Add(this.lblSelectEmp);
            this.Controls.Add(this.lstEmployerDeatils);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployerDeleteForm";
            this.Text = "Delete Employer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployerDeatils;
        private System.Windows.Forms.Label lblSelectEmp;
        private System.Windows.Forms.Label lblEmployerID;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.TextBox txtEmployerID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteEmployer;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label label2;
    }
}