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
    public partial class ApplicationsReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;


        public ApplicationsReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            String applicationText = "";
            txtApplicationReport.Text = "\t\t\t\t" + "Applications Report" + "\r\n\r\n";
            //applicationText += "                                                               Applications Report" + "\r\n\r";
            CurrencyManager cmEmployer, cmCandiate, cmVacancy;
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGRA, "Employer"];
            cmCandiate = (CurrencyManager)this.BindingContext[DC.dsLGRA, "Candidate"];
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGRA, "Vacancy"];

            
            foreach (DataRow drCandidate in DC.dtCandidate.Rows)
            {
                
                DataRow[] drApplications = drCandidate.GetChildRows(DC.dtCandidate.ChildRelations["Candidate_Appication"]);
                foreach (DataRow drApplication in drApplications)
                {

                    /*DateTime formatappDate = Convert.ToDateTime(drApplication["ApplicationDate"]);
                    string newAppDate = formatappDate.ToString("dd-MM-yyyy");

                    applicationText += "Application Date: " + newAppDate + "\t\t" + "                    Application Status: " + drApplication["ApplicationStatus"] + "\r\n\r";
                    applicationText += "      Candidate ID: " + drCandidate["CandidateID"]  +"\r\n\r" + "Candidate Name: " + drCandidate["CandidateLastName"] + ", " + drCandidate["CandidateFirstName"] + "\r\n\r\n";*/

                    applicationText += "Application Date: " + drApplication["ApplicationDate"] + "\t\t" + "                    Application Status: " + drApplication["ApplicationStatus"] + "\r\n\r";
                    applicationText += "      Candidate ID: " + drCandidate["CandidateID"] + "\r\n\r" + "Candidate Name: " + drCandidate["CandidateLastName"] + ", " + drCandidate["CandidateFirstName"] + "\r\n\r\n";

                    int aVacancyID = Convert.ToInt32(drApplication["VacancyID"].ToString());
                    cmVacancy.Position = DC.vacancyView.Find(aVacancyID);
                    DataRow drVacancy = DC.dtVacancy.Rows[cmVacancy.Position];

                    int anEmployerID = Convert.ToInt32(drVacancy["EmployerID"].ToString());
                    cmEmployer.Position = DC.employerView.Find(anEmployerID);
                    DataRow drEmployer = DC.dtEmployer.Rows[cmEmployer.Position];

                    applicationText += "      Employer ID: " + drEmployer["EmployerID"] + "\r\n\r";
                    applicationText += "Employer Name: " + drEmployer["EmployerName"] + "\r\n\r\n";
                    applicationText += "\t\t" + "Vacancy ID" + "\t\t" + "      " + "Description" + "\r\n\r";
                    applicationText += "\t\t" + "      " + drVacancy["VacancyID"] + "\t\t\t" + drVacancy["VacancyDescription"] + "\r\n\r\n";
                    applicationText += "-------------------------------------------------------------------------------------------------------------------------------\r\n\r\n";
                }

                //applicationText += "\r\n\r";
                //applicationText += "\r\n\r";
                txtApplicationReport.Text += applicationText;
                applicationText = "";
            }

        }
    }
}
