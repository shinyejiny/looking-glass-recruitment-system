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
    public partial class CandidateReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        CurrencyManager cmVacancy;

        public CandidateReportForm(DataController dc, MainForm mnu)
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string candidateText = "";
            txtCandidates.Text = "\t\t\t\t" + "Candidate Report" + "\r\n\r\n"; ;
            foreach (DataRow drCandidate in DC.dtCandidate.Rows)

            {


                candidateText += "Candidate ID:   " + drCandidate["CandidateID"] + "\r\n";
                candidateText += "Candidate Name:   " + drCandidate["CandidateLastName"] + drCandidate["CandidateFirstName"] + "\r\n";
                candidateText += "Candidate Address: " + drCandidate["StreetAddress"] + ", " + drCandidate["Suburb"] + ", " + drCandidate["City"] + "\r\n";
                candidateText += "Email:" + drCandidate["EmailAddress"] + "\r\n";
                candidateText += "Phone Number: " + drCandidate["PhoneNumber"] + "\r\n";
                candidateText += "WorkType: " + drCandidate["WorkType"] + "" + "                                  Status: " + drCandidate["Status"] + "\r\n\r\n";

                DataRow[] drApplications = drCandidate.GetChildRows(DC.dtCandidate.ChildRelations["Candidate_Appication"]);
                foreach (DataRow drApplication in drApplications)
                {
                    DataRow[] drDetailsApplications = drCandidate.GetParentRows(DC.dtCandidate.ParentRelations["Vacancy_Appication"]);

                    candidateText += "Vacancy ID: " + drApplication["VacancyID"] + "\r\n\r";
                    candidateText += "Application Date: " + drApplication["ApplicationDate"] + "\r\n";
                    candidateText += "Application Status: " + drApplication["ApplicationStatus"] + "\r\n";
                }
                candidateText += "\r\n\r\n";
                candidateText += "\r\n\r\n";
                txtCandidates.Text += candidateText;
                candidateText = "";

            }

        }
    }
}

