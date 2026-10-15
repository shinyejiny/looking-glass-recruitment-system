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
    public partial class CandidateAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public CandidateAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();

        }

        public void DisplayCandidates()
        {
            string candidateText = "";
            txtCandidates.Text = "";

            foreach (DataRow drCandidate in DC.dtCandidate.Rows)
            {
                candidateText += "Candidate ID: " + drCandidate["CandidateID"] + ", ";
                candidateText += drCandidate["CandidateLastName"] + ", ";
                candidateText += drCandidate["CandidateFirstName"] + "\r\n";
                txtCandidates.Text += candidateText;
                candidateText = "";
            }
        }
        private void clearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtPhoneNumber.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtEmailAddress.Text = "";
            txtCity.Text = "";
            cboStatus.Text = "Available";
            cboWorkType.Text = "Full-time";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }


        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtPhoneNumber.Text == "" ||
                txtStreetAddress.Text == "" || txtSuburb.Text == "" || txtEmailAddress.Text == "" ||
                txtCity.Text == "" || cboStatus.Text == "" || cboWorkType.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newCandidateRow = DC.dtCandidate.NewRow();
                newCandidateRow["CandidateLastName"] = txtLastName.Text;
                newCandidateRow["CandidateFirstName"] = txtFirstName.Text;
                newCandidateRow["StreetAddress"] = txtStreetAddress.Text;
                newCandidateRow["Suburb"] = txtSuburb.Text;
                newCandidateRow["City"] = txtCity.Text;
                newCandidateRow["EmailAddress"] = txtEmailAddress.Text;
                newCandidateRow["PhoneNumber"] = txtPhoneNumber.Text;
                newCandidateRow["WorkType"] = cboWorkType.Text;
                newCandidateRow["Status"] = cboStatus.Text;
                DC.dsLGRA.Tables["CANDIDATE"].Rows.Add(newCandidateRow);
                DC.UpdateCandidate();
                DisplayCandidates();
                MessageBox.Show("Candidate added successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
        }

        private void CandidateAddForm_Load(object sender, EventArgs e)
        {
            DisplayCandidates();
        }
    }
}
