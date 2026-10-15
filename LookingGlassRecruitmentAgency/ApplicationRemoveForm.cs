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
    public partial class ApplicationRemoveForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmApplication;
        private int vacancyID;
        private int candidateID;

        public ApplicationRemoveForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
            loadCandidates();
        }

        private void loadCandidates()
        {
            string candidateText = "";
            foreach (DataRow drCandidate in DC.dtCandidate.Rows)
            {

                if (drCandidate["Status"].ToString() != "Unavailable")
                {
                    candidateText = drCandidate["CandidateID"] + ", ";
                    candidateText += drCandidate["CandidateLastName"] + "' ";
                    candidateText += drCandidate["CandidateFirstName"] + "' ";
                    lstCandidates.Items.Add(candidateText);
                }
            }
        }

        public void BindControls()
        {
            cmCandidate = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATE"];
            cmApplication = (CurrencyManager)this.BindingContext[DC.dsLGRA, "APPLICATION"];
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCY"];

        }

        public void ClearFields()
        {
            txtCandidateID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtFirstName.Text = "";
            txtEmailAddress.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }
        private void lstCandidates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCandidates.SelectedItem != null)
            {
                string candidiate, applicationtxt = "";
                lstApplication.Items.Clear();
                candidiate = lstCandidates.SelectedItem.ToString();
                string[] parts = candidiate.Split(',');
                candidateID = Convert.ToInt32(parts[0]);
                cmCandidate.Position = DC.candidateView.Find(candidateID);


                DataRow drCandidate = DC.dtCandidate.Rows[cmCandidate.Position];
                DataRow[] drApplications = drCandidate.GetChildRows(DC.dtCandidate.ChildRelations["Candidate_Appication"]);


                foreach (DataRow drApplication in drApplications)
                {
                    int vacancyID = Convert.ToInt32(drApplication["VacancyID"].ToString());
                    cmVacancy.Position = DC.vacancyView.Find(vacancyID);
                    DataRow drVacancy = DC.dtVacancy.Rows[cmVacancy.Position];

                    /*DateTime formatappDate = Convert.ToDateTime(drApplication["ApplicationDate"]);
                    string newAppDate = formatappDate.ToString("dd-MM-yyyy");

                    applicationtxt = "Date:  " + newAppDate + "          Status:  " + drApplication["ApplicationStatus"]
                        + "          Vacancy ID:  " + drApplication["VacancyID"] + "          Vacancy  Description.:  " + drVacancy["VacancyDescription"];
                    lstApplication.Items.Add(applicationtxt);*/

                    applicationtxt = "Date:  " + drApplication["ApplicationDate"] + "          Status:  " + drApplication["ApplicationStatus"]
                        + "          Vacancy ID: ," + drApplication["VacancyID"] + ",          Vacancy  Description:  " + drVacancy["VacancyDescription"];
                    lstApplication.Items.Add(applicationtxt);

                }
                txtCandidateID.Text = drCandidate["CandidateID"].ToString();
                txtLastName.Text = drCandidate["CandidateLastName"].ToString();
                txtFirstName.Text = drCandidate["CandidateFirstName"].ToString();
                txtEmailAddress.Text = drCandidate["EmailAddress"].ToString();

            }
        }

        private void lstApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstApplication.SelectedItem != null)
            {
                string application = lstApplication.SelectedItem.ToString();
                string[] parts = application.Split(',');
                vacancyID = Convert.ToInt32(parts[1]);


            }
        }

        private void btnRmoveApplication_Click(object sender, EventArgs e)
        {
            if ((txtCandidateID.Text == "" || txtLastName.Text == "" || txtFirstName.Text == "" || txtEmailAddress.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Are you sure you want to delete this application?", "Warning",
                                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    object[] primaryKey = new object[2];
                    primaryKey[0] = candidateID;
                    primaryKey[1] = vacancyID;
                    cmApplication.Position = DC.applicationView.Find(primaryKey);
                    DataRow deleteApplicationRow = DC.dtApplication.Rows[cmApplication.Position];
                    deleteApplicationRow.Delete();
                    DC.UpdateApplication();
                    MessageBox.Show("Application deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                    lstApplication.Items.Clear();
                    ClearFields();
                }
            }

        }
    }
}



