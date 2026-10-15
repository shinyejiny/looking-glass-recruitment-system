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
    public partial class CandidateDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmcandidate;


        public CandidateDeleteForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
            loadCandidates();

        }

        public void BindControls()
        {
            cmcandidate = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATE"];

            //txtCandidateID.DataBindings.Add("Text", DC.dsLGRA, "Candidate.CandidateID");
            //txtCity.DataBindings.Add("Text", DC.dsLGRA, "Candidate.City");
            //txtFirstName.DataBindings.Add("Text", DC.dsLGRA, "Candidate.CandidateFirstName");
            //txtLastName.DataBindings.Add("Text", DC.dsLGRA, "Candidate.CandidateLastName");
            //txtStreetAddress.DataBindings.Add("Text", DC.dsLGRA, "Candidate.StreetAddress");
            //txtSuburb.DataBindings.Add("Text", DC.dsLGRA, "Candidate.Suburb");
            //txtStatus.DataBindings.Add("Text", DC.dsLGRA, "Candidate.Status");

            //lstCandidates.DataSource = DC.dsLGRA;

            //lstCandidates.DisplayMember = "Candidate.CandidateLastName";
            //lstCandidates.ValueMember = "Candidate.CandidateLastName";
            //lstCandidates.DisplayMember = "Candidate.CandidateFirstName";
            //lstCandidates.ValueMember = "Candidate.CandidateFirstName";
            //cmcandidate = (CurrencyManager)this.BindingContext[DC.dsLGRA, "Candidate"];
        }

        private void loadCandidates()
        {
            string candidateText = "";
            foreach (DataRow drCandidate in DC.dtCandidate.Rows)
            {
                DataRow[] drCandidateInApplication = drCandidate.GetChildRows(DC.dtCandidate.ChildRelations["Candidate_Appication"]);
                if (drCandidateInApplication.Length == 0)
                {
                    candidateText = drCandidate["CandidateID"] + ",";
                    candidateText += drCandidate["CandidateLastName"] + ",";
                    candidateText += drCandidate["CandidateFirstName"] + " ";
                    lstCandidates.Items.Add(candidateText);
                }
            }

        }

        private void clearFields()
        {
            txtCandidateID.Text = "";
            txtCity.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStatus.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
        }

        private void lstCandidates_SelectedIndexChanged(object sender, EventArgs e)
        {

            string candidate = "";
            candidate = lstCandidates.SelectedItem.ToString();
            string[] parts = candidate.Split(',');
            int candidateID = Convert.ToInt32(parts[0]);
            cmcandidate.Position = DC.candidateView.Find(candidateID);
            DataRow drCandidate = DC.dtCandidate.Rows[cmcandidate.Position];
            txtCandidateID.Text = drCandidate["CandidateID"].ToString();
            txtFirstName.Text = drCandidate["CandidateFirstName"].ToString();
            txtLastName.Text = drCandidate["CandidateLastName"].ToString();
            txtCity.Text = drCandidate["City"].ToString();
            txtStreetAddress.Text = drCandidate["StreetAddress"].ToString();
            txtSuburb.Text = drCandidate["Suburb"].ToString();
            txtStatus.Text = drCandidate["Status"].ToString();


        }



        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            DataRow deleteCandidateRow = DC.dtCandidate.Rows[cmcandidate.Position];
            DataRow[] drApplication = deleteCandidateRow.GetChildRows(DC.dtCandidate.ChildRelations["Candidate_Appication"]);
            if (drApplication.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this candidate?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRow[] drCandidateSkills = deleteCandidateRow.GetChildRows(DC.dtCandidate.ChildRelations["Candidate_CandidateSkill"]);
                    foreach (DataRow drCandidateSkill in drCandidateSkills)
                    {
                        drCandidateSkill.Delete();

                    }
                    deleteCandidateRow.Delete();
                    DC.UpdateCandidateSkill();
                    DC.UpdateCandidate();
                    lstCandidates.Items.Clear();
                    loadCandidates();
                    MessageBox.Show("Candidate deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                    clearFields();
                }
            }
            else
            {
                MessageBox.Show("This candidate with applicaitons cannot be deleted", "Error");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }
    }
}

