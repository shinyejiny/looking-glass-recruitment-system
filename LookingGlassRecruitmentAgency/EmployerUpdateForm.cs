using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlassRecruitmentAgency
{
    public partial class EmployerUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmEmployer;
        private string empStatus;

        public EmployerUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }

        public void BindControls()
        {
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGRA, "EMPLOYER"];
            dgvEmployers.DataSource = DC.dsLGRA;
            dgvEmployers.DataMember = "EMPLOYER";
        }

        private void clearFields()
        {
            txtEmployerID.Text = "";
            txtEmployerName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void lstEmployers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployerUpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lGRAgencyDBDataSet.EMPLOYER' table. You can move, or remove it, as needed.
            this.eMPLOYERTableAdapter.Fill(this.lGRAgencyDBDataSet.EMPLOYER);

        }

        private void dgvEmployers_Click(object sender, EventArgs e)
        {
            if (cmEmployer.Position != -1)
            {
                DataRow drEmployer = DC.dtEmployer.Rows[cmEmployer.Position];
                txtEmployerID.Text = drEmployer["EmployerID"].ToString();
                txtEmployerName.Text = drEmployer["EmployerName"].ToString();
                txtStreetAddress.Text = drEmployer["StreetAddress"].ToString();
                txtSuburb.Text = drEmployer["Suburb"].ToString();
                txtCity.Text = drEmployer["City"].ToString();
                txtEmailAddress.Text = drEmployer["EmailAddress"].ToString();
                txtPhoneNumber.Text = drEmployer["PhoneNumber"].ToString();
                empStatus = drEmployer["EmployerStatus"].ToString();
                if (empStatus == "Active")
                {
                  rbnActive.Checked = true;
                  rbnInactive.Checked = false;
                }
                else
                {
                  rbnActive.Checked = false;
                  rbnInactive.Checked = true;
                }
            }


        }

        private void btnUpdateEmployer_Click(object sender, EventArgs e)
        {
            string newStatus;
            DataRow updateEmployerRow = DC.dtEmployer.Rows[cmEmployer.Position];
            if ((txtEmployerName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (txtCity.Text == "") ||
                (txtEmailAddress.Text == "") || (txtPhoneNumber.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                updateEmployerRow["EmployerName"] = txtEmployerName.Text;
                updateEmployerRow["StreetAddress"] = txtStreetAddress.Text;
                updateEmployerRow["Suburb"] = txtSuburb.Text; ;
                updateEmployerRow["City"] = txtCity.Text;
                updateEmployerRow["EmailAddress"] = txtEmailAddress.Text;
                updateEmployerRow["PhoneNumber"] = txtPhoneNumber.Text;
                if (rbnActive.Checked == true)
                {
                    newStatus = "Active";
                }
                else
                {
                    newStatus = "Inactive";
                }
                updateEmployerRow["EmployerStatus"] = newStatus;
                DC.UpdateEmployer();
                MessageBox.Show("Employer updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
        }
    }
}
