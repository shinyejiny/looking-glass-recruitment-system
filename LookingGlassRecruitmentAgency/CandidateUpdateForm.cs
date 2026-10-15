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
    public partial class CandidateUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCandidate;
        private string CdtStatus;
        private string CdtWorkType;

        public CandidateUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }

        public void BindControls()
        {
            cmCandidate = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATE"];
            // txtCandidates.DataBindings.Add("Text", DC.dsLGRA, "Candidate.CandidateID");
            dgvCandidates.DataSource = DC.dsLGRA;
            dgvCandidates.DataMember = "CANDIDATE";

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void dgvCandidates_Click(object sender, EventArgs e)
        {
            if (cmCandidate.Position != -1)
            {
                DataRow drCandidate = DC.dtCandidate.Rows[cmCandidate.Position];

                txtCandidates.Text = dgvCandidates["CandidateID", cmCandidate.Position].Value.ToString();
                txtLastName.Text = dgvCandidates["CandidateLastName", cmCandidate.Position].Value.ToString();
                txtFirstName.Text = dgvCandidates["CandidateFirstName", cmCandidate.Position].Value.ToString();
                txtStreetAddress.Text = dgvCandidates["StreetAddress", cmCandidate.Position].Value.ToString();
                txtSuburb.Text = dgvCandidates["Suburb", cmCandidate.Position].Value.ToString();
                txtCity.Text = dgvCandidates["City", cmCandidate.Position].Value.ToString();
                txtEmailAddress.Text = dgvCandidates["EmailAddress", cmCandidate.Position].Value.ToString();
                txtPhoneNumber.Text = dgvCandidates["PhoneNumber", cmCandidate.Position].Value.ToString();

                CdtWorkType = drCandidate["WorkType"].ToString();
                CdtStatus = drCandidate["Status"].ToString();
                if (CdtWorkType == "Full-time")
                {
                    rbnFullTime.Checked = true;
                    rbnPartTime.Checked = false;
                }
                else
                {
                    rbnFullTime.Checked = false;
                    rbnPartTime.Checked = true;
                }


                if (CdtStatus == "Unavailable")
                {
                    rbnAvailable.Checked = false;
                    rbnUnavailable.Checked = true;
                }
                else
                {

                    rbnAvailable.Checked = true;
                    rbnUnavailable.Checked = false;
                }
            }
        }
        private void clearFields()
        {
            txtCandidates.Text = "";
            txtCity.Text = "";
            txtEmailAddress.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
        }

        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            string newStatus;
            string newWorkType;

            DataRow updateCandidateRow = DC.dtCandidate.Rows[cmCandidate.Position];
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") || (txtCity.Text == "") ||
                (txtEmailAddress.Text == "") || (txtPhoneNumber.Text == "") || (txtStreetAddress.Text == "") ||
                (txtSuburb.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                updateCandidateRow["CandidateLastName"] = txtLastName.Text;
                updateCandidateRow["CandidateFirstName"] = txtFirstName.Text;
                updateCandidateRow["City"] = txtCity.Text;
                updateCandidateRow["EmailAddress"] = txtEmailAddress.Text;
                updateCandidateRow["PhoneNumber"] = txtPhoneNumber.Text;
                updateCandidateRow["StreetAddress"] = txtStreetAddress.Text;
                updateCandidateRow["Suburb"] = txtSuburb.Text;

                if (rbnAvailable.Checked == true)
                {
                    newStatus = "Available";
                }
                else
                {
                    newStatus = "Unavailable";
                }
                if (rbnAvailable.Checked == true)
                {
                    newWorkType = "Full-time";
                }
                else
                {
                    newWorkType = "Part-time";
                }
                updateCandidateRow["Status"] = newStatus;
                updateCandidateRow["WorkType"] = newWorkType;
                cmCandidate.EndCurrentEdit();
                DC.UpdateCandidate();
                MessageBox.Show("Candidate updated successfully", "Success");
                clearFields();
            }
        }
    }
}

