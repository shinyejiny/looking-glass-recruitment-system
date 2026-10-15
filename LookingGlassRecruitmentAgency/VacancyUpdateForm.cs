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
    public partial class VacancyUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmEmployer;


        public VacancyUpdateForm(DataController dc, MainForm mnu)
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
                    vacancyText = drVacancy["VacancyID"] + ", ";
                    vacancyText += drVacancy["VacancyDescription"];
                    lstVacancies.Items.Add(vacancyText);

                }

            }
        }
        private void clearFields()
        {
            txtVacancyID.Text = "";
            txtVacancyDescription.Text = "";
            nudSalary.Value = 20000;
            //nudSalary.Text = ""
            cboType.Text = "";
            cboStatus.Text = "";
            txtEmployerName.Text = "";
        }

        public void BindControls()
        {
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCY"];
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGRA, "EMPLOYER"];

        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }


        private void btnUpdateVacancy_Click(object sender, EventArgs e)
        {
            DataRow updateVacancyRow = DC.dtVacancy.Rows[cmVacancy.Position];
            if ((txtVacancyDescription.Text == "") || (cboStatus.Text == "") || (nudSalary.Text == "") ||
                (cboType.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                updateVacancyRow["VacancyDescription"] = txtVacancyDescription.Text;
                updateVacancyRow["Salary"] = nudSalary.Value;
                updateVacancyRow["VacancyStatus"] = cboStatus.Text;
                updateVacancyRow["VacancyType"] = cboType.Text;
                cmVacancy.EndCurrentEdit();
                DC.UpdateVacancy();
                lstVacancies.Items.Clear();
                loadVacancies();
                MessageBox.Show("Vacancy updated successfully", "Success");
                clearFields();
            }

        }

        private void lstVacancies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vacancy = "";
            vacancy = lstVacancies.SelectedItem.ToString();
            string[] parts = vacancy.Split(',');
            int vacancyID = Convert.ToInt32(parts[0]);
            cmVacancy.Position = DC.vacancyView.Find(vacancyID);
            DataRow drVacancy = DC.dtVacancy.Rows[cmVacancy.Position];
            txtVacancyID.Text = drVacancy["VacancyID"].ToString();

            int aEmployerID = Convert.ToInt32(drVacancy["EmployerID"].ToString());
            cmEmployer.Position = DC.employerView.Find(aEmployerID);
            DataRow drEmployer = DC.dtEmployer.Rows[cmEmployer.Position];

            txtVacancyDescription.Text = drVacancy["VacancyDescription"].ToString();
            cboStatus.Text = drVacancy["VacancyStatus"].ToString();
            cboType.Text = drVacancy["VacancyType"].ToString();
            txtEmployerName.Text = drEmployer["EmployerName"].ToString();
            nudSalary.Text = drVacancy["Salary"].ToString();
        }
    }
}



