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
    public partial class ApplicationAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmCandidateSkill;
        private CurrencyManager cmVacancySkill;
        private CurrencyManager cmApplication;

        public ApplicationAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }

        private void ApplicationAddForm_Load(object sender, EventArgs e)
        {
            
        }

        public void BindControls()
        {
            cmCandidate = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATE"];
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCY"];
            cmApplication = (CurrencyManager)this.BindingContext[DC.dsLGRA, "APPLICATION"];
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATESKILL"];
            cmVacancySkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCYSKILL"];


            dgvVacancy.DataSource = DC.dsLGRA;
            dgvVacancy.DataMember = "VACANCY";
            dgvCandidate.DataSource = DC.dsLGRA;
            dgvCandidate.DataMember = "CANDIDATE";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void dgvCandidate_Click(object sender, EventArgs e)
        {
            int aCandidateID = Convert.ToInt32(dgvCandidate["CandidateID", cmCandidate.Position].Value);
            cmCandidate.Position = DC.candidateView.Find(aCandidateID);
            DataRow drCandidate = DC.dtCandidate.Rows[cmCandidate.Position];
            txtCandidateID.Text = drCandidate["CandidateID"].ToString();
            txtLastName.Text = drCandidate["CandidateLastName"].ToString();
            txtFirstName.Text = drCandidate["CandidateFirstName"].ToString();
            txtEmailAddress.Text = drCandidate["EmailAddress"].ToString();
            txtPhoneNumber.Text = drCandidate["PhoneNumber"].ToString();
        }

        public void ClearFields()
        {
            txtCandidateID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtFirstName.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            //cboApplicationStatus.Text = "";
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {

            if (txtCandidateID.Text == "" || txtLastName.Text == "" || txtFirstName.Text == "" ||
                    txtEmailAddress.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please fill in all fields correcty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               
                DataRow drVacancyRows = DC.dtVacancy.Rows[cmVacancy.Position];
                DataRow[] drSkillIDInVacancy = drVacancyRows.GetChildRows(DC.dtVacancy.ChildRelations["Vacancy_VacancySkill"]);
                int aSkillID = drSkillIDInVacancy.Length;
                int matches = 0;
                foreach (DataRow drVskillID in drSkillIDInVacancy)
                {
                    int aVacancy_sSkillID = Convert.ToInt32(drVskillID["SkillID"].ToString());
                    DataRow CandaditeIDRow = DC.dtCandidate.Rows[cmCandidate.Position];
                    DataRow[] drCandidate_sSkillIDs = CandaditeIDRow.GetChildRows(DC.dtCandidate.ChildRelations["Candidate_CandidateSkill"]);
                    foreach (DataRow drCskillID in drCandidate_sSkillIDs)
                    {
                        int aCandidate_sSkliiID = Convert.ToInt32(drCskillID["SkillID"].ToString());
                        if (aVacancy_sSkillID == aCandidate_sSkliiID)
                        {
                            matches += 1;
                        }
                        if (matches != aSkillID)
                        {
                            MessageBox.Show("Candidate not suitable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            
                            try
                            {
                                DataRow newApplication = DC.dtApplication.NewRow();
                                newApplication["CandidateID"] = dgvCandidate["CandidateID", cmCandidate.Position].Value;
                                newApplication["VacancyID"] = dgvVacancy["VacancyID", cmVacancy.Position].Value;
                                newApplication["ApplicationStatus"] = txtApplicationStatus.Text;
                                //newApplication["ApplicationStatus"] = cboApplicationStatus.Text;
                                newApplication["ApplicationDate"] = dtpApplicationDate.Value;
                                DC.dsLGRA.Tables["Application"].Rows.Add(newApplication);
                                DC.UpdateApplication();
                                MessageBox.Show("Application added successfully", "Acknowledgement", MessageBoxButtons.OK);
                                ClearFields();
                            }
                            catch (System.Data.ConstraintException)
                            {
                                MessageBox.Show("This Candidate has already applied for this vacancy.", "Error", MessageBoxButtons.OK);
                            }
                        }

                    }

                }
            }
        }
    }
}