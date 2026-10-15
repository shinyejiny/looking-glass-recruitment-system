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
    public partial class VacancyDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmEmployer;

        public VacancyDeleteForm(DataController dc, MainForm mnu)
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
                if (drVacancy["VacancyStatus"].ToString() != "Current")
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
            txtEmployerName.Text = "";
        }

        public void BindControls()
        {
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCY"];
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGRA, "EMPLOYER"];

            //txtVacancyID.DataBindings.Add("Text", DC.dsLGRA, "Vacancy.VacancyID");
            //txtVacancyDescription.DataBindings.Add("Text", DC.dsLGRA, "Vacancy.VacancyDescription");
            //txtEmployerName.DataBindings.Add("Text", DC.dsLGRA, "Employer.EmployerName");

            //private void lblSelectVacancy_Click(object sender, EventArgs e)
            //{

            //}
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
            txtEmployerName.Text = drEmployer["EmployerName"].ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void btnDeleteVacancy_Click(object sender, EventArgs e)
        {
            DataRow deleteVacancyRow = DC.dtVacancy.Rows[cmVacancy.Position];
            if (deleteVacancyRow["VacancyStatus"].ToString() != "Current")
            {
                if (MessageBox.Show("Are you sure you want to delete this vacancy?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRow[] drVacancySkills = deleteVacancyRow.GetChildRows(DC.dtVacancy.ChildRelations["Vacancy_VacancySkill"]);
                    DataRow[] drApplications = deleteVacancyRow.GetChildRows(DC.dtVacancy.ChildRelations["Vacancy_Appication"]);
                    foreach (DataRow drVacancySkill in drVacancySkills)
                    {
                        drVacancySkill.Delete();
                    }
                    foreach (DataRow drApplication in drApplications)
                    {
                        drApplication.Delete();
                    }
                    DC.UpdateVacancySkill();
                    DC.UpdateApplication();
                    deleteVacancyRow.Delete();
                    DC.UpdateVacancy();
                    lstVacancies.Items.Clear();
                    loadVacancies();
                    MessageBox.Show("Vacancy deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                    clearFields();
                }
            }

        }

        private void VacancyDeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}

