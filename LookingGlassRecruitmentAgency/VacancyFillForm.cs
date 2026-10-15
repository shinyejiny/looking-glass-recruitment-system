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
    public partial class VacancyFillForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmApplication;
        private CurrencyManager cmEmployer;
        private CurrencyManager cmCandidate;
        private int vacancyID;
        private int candidateID;

        public VacancyFillForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
            loadVacancies();
        }

        private void loadVacancies()
        {
            string vacancyText = "";
            foreach (DataRow drVacancy in DC.dtVacancy.Rows)
            {
                if (drVacancy["VacancyStatus"].ToString() == "Current")
                {
                    DataRow[] drApplications = drVacancy.GetChildRows(DC.dtVacancy.ChildRelations["Vacancy_Appication"]);
                    if (drApplications.Length != 0)
                    {
                        vacancyText = drVacancy["VacancyID"] + ", ";
                        vacancyText += drVacancy["VacancyDescription"];

                        lstVacancies.Items.Add(vacancyText);

                    }

                }


            }
        }

        private void clearFields()
        {
            txtVacancyID.Text = "";
            txtVacancyDescription.Text = "";
            txtVacancyStatus.Text = "";
            txtEmployerName.Text = "";
        }

        public void BindControls()
        {
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCY"];
            cmApplication = (CurrencyManager)this.BindingContext[DC.dsLGRA, "APPLICATION"];
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGRA, "EMPLOYER"];
            cmCandidate = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATE"];

            //txtVacancyID.DataBindings.Add("Text", DC.dsLGRA, "Vacancy.VacancyID");
            //txtVacancyDescription.DataBindings.Add("Text", DC.dsLGRA, "Vacancy.VacancyDescription");
            //txtVacancyStatus.DataBindings.Add("Text", DC.dsLGRA, "Vacancy.VacancyStatus");
            //txtEmployerName.DataBindings.Add("Text", DC.dsLGRA, "Employer.EmployerName");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void lstVacancies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vacancy, ApplicationText = "";
            lstApplications.Items.Clear();
            vacancy = lstVacancies.SelectedItem.ToString();
            string[] parts = vacancy.Split(',');
            vacancyID = Convert.ToInt32(parts[0]);
            cmVacancy.Position = DC.vacancyView.Find(vacancyID);

            DataRow drVacancy = DC.dtVacancy.Rows[cmVacancy.Position];
            DataRow[] drApplications = drVacancy.GetChildRows(DC.dtVacancy.ChildRelations["Vacancy_Appication"]);

            foreach (DataRow drApplication in drApplications)
            {

                //string level = drVacancySkill["Level"].ToString();
                //string appDate = drApplication["ApplicationDate"].ToString();
                int candidateID = Convert.ToInt32(drApplication["CandidateID"].ToString());
                cmCandidate.Position = DC.candidateView.Find(candidateID);
                DataRow drCandidate = DC.dtCandidate.Rows[cmCandidate.Position];
                //string description = drSkill["SkillDescription"].ToString();

                //DateTime formatappDate = Convert.ToDateTime(drApplication["ApplicationDate"]);
                //tring newAppDate = formatappDate.ToString("dd-mm-yyyy");
                ApplicationText = "Application Status:  ," + drApplication["ApplicationStatus"] + ",       Date:  ," + drApplication["ApplicationDate"]
                   + ",            Candidate ID:  ," + drApplication["CandidateID"] + ",            Last Name:  ," + drCandidate["CandidateLastName"] + "           First Name:  ," + drCandidate["CandidateFirstName"];

                lstApplications.Items.Add(ApplicationText);
            }

            txtVacancyID.Text = drVacancy["VacancyID"].ToString();
            txtVacancyDescription.Text = drVacancy["VacancyDescription"].ToString();
            txtVacancyStatus.Text = drVacancy["VacancyStatus"].ToString();
            int aEmployerID = Convert.ToInt32(drVacancy["EmployerID"].ToString());
            cmEmployer.Position = DC.employerView.Find(aEmployerID);
            DataRow drEmployer = DC.dtEmployer.Rows[cmEmployer.Position];
            txtEmployerName.Text = drEmployer["EmployerName"].ToString();
        }

        private void lstApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstApplications.SelectedItem != null)
            {
                string apps = lstApplications.SelectedItem.ToString();
                string[] parts = apps.Split(',');
                //string showCandID = (parts[5]).ToString();
                //textBox1.Text = showCandID;
                candidateID = Convert.ToInt32(parts[5]);
                //cmVacancySkill.Position = DC.vacancySkillView.Find(askillID);

            }
        }

        private void btnFillVacancy_Click(object sender, EventArgs e)
        {

            DataRow updateVacancyRow = DC.dtVacancy.Rows[cmVacancy.Position];
            updateVacancyRow["VacancyStatus"] = "Filled";
            cmVacancy.EndCurrentEdit();
            DC.UpdateVacancy();

            object[] primaryKey = new object[2];
            primaryKey[0] = candidateID;
            primaryKey[1] = vacancyID;
            cmApplication.Position = DC.applicationView.Find(primaryKey);
            DataRow updateApplicationRow = DC.dtApplication.Rows[cmApplication.Position];
            updateApplicationRow["ApplicationStatus"] = "Successful";
            cmApplication.EndCurrentEdit();
            DC.UpdateApplication();
            lstApplications.Items.Clear();
            clearFields();
            MessageBox.Show("Vacancy filled successfully", "Success");


        }
    }

    /*private void lstApplications_SelectedIndexChanged(object sender, EventArgs e)
    {

    }*/
}

