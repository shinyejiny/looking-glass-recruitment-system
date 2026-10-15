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
    public partial class VacanciesReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public VacanciesReportForm(DataController dc, MainForm mnu)
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
            string vacancyText = "";
            txtVacancies.Text = "\t\t\t\t" + "Vacancies Report" + "\r\n\r\n";
            CurrencyManager cmEmployer;
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGRA, "Employer"];


            foreach (DataRow drVacancy in DC.dtVacancy.Rows)
            {
                int aEmployerID = Convert.ToInt32(drVacancy["EmployerID"].ToString());
                cmEmployer.Position = DC.employerView.Find(aEmployerID);
                DataRow drEmployer = DC.dtEmployer.Rows[cmEmployer.Position];

                vacancyText += "Vacancy Description: " + drVacancy["VacancyDescription"] + "\r\n";
                vacancyText += "Vacancy ID: " + drVacancy["VacancyID"] + "\t" + "Vacancy Status: ";
                vacancyText += drVacancy["VacancyStatus"] + "\t" + "Vacancy Type: " + drVacancy["VacancyType"] + "\r\n";
                vacancyText += "Salary: NZ$" + drVacancy["Salary"] + "\t" + "Number of applications: ";

                DataRow[] drApplications = drVacancy.GetChildRows(DC.dtVacancy.ChildRelations["Vacancy_Appication"]);
                vacancyText += drApplications.Length + "\r\n";

                vacancyText += "Employer ID: " + drEmployer["EmployerID"] + "\t" + "Employer Name: ";
                vacancyText += drEmployer["EmployerName"] + "\r\n\r\n";
                txtVacancies.Text += vacancyText;
                vacancyText = "";
            }

        }
    }
}
