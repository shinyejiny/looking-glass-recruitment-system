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
    public partial class EmployersReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public EmployersReportForm(DataController dc, MainForm mnu)
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
            //Graphics g =
            //int linesSoFar = 0;
            //Font textFont = new Font("Calibri", 10, FontStyle.Regular);
            //Font textFondCenter = new Font("Calibri", 10, FontStyle.Regular);
            //Brush brush = new SolidBrush(Color.Black);
            //int leftMargin = .Left;
            // int topMargin = e.MarginBounds.Top;
            //int headingLeftMargin = 50;
            // int topMarginDetails = topMargin + 70;
            //int rightMargin = e.MarginBounds.Right;
            //string headingText = "Glen Eden Cat Clinic";
            //int centre = (e.PageBounds.Width - headingText.Length) / 2;


            string employerText = "";
            txtEmployersReport.Text = "";
            employerText += "\t\t\t" + "            " + "The Report of Employers" + "\r\n\r\n";
            foreach (DataRow drEmployer in DC.dtEmployer.Rows)
            {
                employerText += "         Employer ID: " + drEmployer["EmployerID"] + "\r\n";
                employerText += "   Employer Name: " + drEmployer["EmployerName"] + "\r\n";
                employerText += "Employer Address: " + drEmployer["StreetAddress"] + ", " + drEmployer["Suburb"] + ", " + drEmployer["City"] + "\r\n";
                employerText += "                   Status: " + drEmployer["EmployerStatus"] + "\r\n\r";
                employerText += "                    Email: " + drEmployer["EmailAddress"] + "                       " + "Phone Number :";
                employerText += drEmployer["PhoneNumber"] + "\r\n\r\n";
                DataRow[] drVacancies = drEmployer.GetChildRows(DC.dtEmployer.ChildRelations["Employer_Vacancy"]);
                if (drVacancies.Length != 0)
                {
                    foreach(DataRow drVacancy in drVacancies)
                        {
                        //employerText += "\t" + drVacancy["VacancyID"] + "\t\t" + "" + drVacancy["VacancyDescription"] + "\t\t" + "" + drVacancy["VacancyStatus"] + "\t\t" + "" + drVacancy["Salary"] + "\t" + "" + drVacancy["VacancyType"] + "\r\n\r";

                        employerText += "            Vacancy ID: " + drVacancy["VacancyID"] + "\r\n\r";
                        employerText += "           Description: " +
                                drVacancy["VacancyDescription"] + "\r\n\r" + "                   Status: " + drVacancy["VacancyStatus"] + "                 Salary: NZ$" + drVacancy["Salary"] + "            Vacancy Type: " + drVacancy["VacancyType"] + "\r\n\r\n";
                    }
                }
                else
                {
                    employerText += "\t\t\t" + "This employer has no vacancies allocated" + "\r\n\r\n";
                    //employerText += "\r\n\r\n -------------------------------------------------------------------------------------------------------------------------------" + "\r\n\r\n";
                }
                    /*foreach (DataRow drVacancy in drVacancies)
                    {
                    //employerText += "\t" + drVacancy["VacancyID"] + "\t\t" + "" + drVacancy["VacancyDescription"] + "\t\t" + "" + drVacancy["VacancyStatus"] + "\t\t" + "" + drVacancy["Salary"] + "\t" + "" + drVacancy["VacancyType"] + "\r\n\r";

                    employerText += "            Vacancy ID: " + drVacancy["VacancyID"] + "\r\n\r";
                    employerText += "           Description: " +
                            drVacancy["VacancyDescription"] + "\r\n\r" + "                   Status: " + drVacancy["VacancyStatus"] + "                 Salary: NZ$" + drVacancy["Salary"] + "            Vacancy Type: " + drVacancy["VacancyType"] + "\r\n\r\n";
                    }*/
                employerText += "\r\n\r\n-------------------------------------------------------------------------------------------------------------------------------";
                employerText += "                                                                                         \r\n\r\n";
                txtEmployersReport.Text += employerText;
                employerText = "";

            }
        }
    }
}
