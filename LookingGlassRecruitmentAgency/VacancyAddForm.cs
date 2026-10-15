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
    public partial class VacancyAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public VacancyAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            //BindControls();
        }

        private void LoadEmployers()
        {
            cboEmployerName.DataSource = DC.dsLGRA;
            cboEmployerName.DisplayMember = "Employer.EmployerName";
            cboEmployerName.ValueMember = "Employer.EmployerName";
            cboEmployerID.DataSource = DC.dsLGRA;
            cboEmployerID.DisplayMember = "Employer.EmployerID";
            cboEmployerID.ValueMember = "Employer.EmployerID";
        }

        private void clearFields()
        {
            txtVacancyDescription.Text = "";
            nudSalary.Value = 20000;
            cboType.Text = "";
            cboStatus.Text = "";
            cboEmployerID.Text = "";
            cboEmployerName.Text = "";
        }

        //public void BindControls()
        //{
        //txtLastName.DataBindings.Add("Text", DC.dsGlenEden, "Owner.OwnerLastName");
        //txtFirstName.DataBindings.Add("Text", DC.dsGlenEden, "Owner.OwnerFirstName");
        //currencyManager = (CurrencyManager)this.BindingContext[DC.dsGlenEden, "OWNER"];
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VacancyAddForm_Load(object sender, EventArgs e)
        {
            LoadEmployers();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            if (txtVacancyDescription.Text == "" || cboStatus.Text == "" || cboType.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newVacancyRow = DC.dtVacancy.NewRow();
                newVacancyRow["VacancyDescription"] = txtVacancyDescription.Text;
                newVacancyRow["VacancyStatus"] = cboStatus.Text;
                newVacancyRow["VacancyType"] = cboType.Text;
                newVacancyRow["Salary"] = nudSalary.Value;
                newVacancyRow["EmployerID"] = cboEmployerID.Text;
                DC.dsLGRA.Tables["VACANCY"].Rows.Add(newVacancyRow);
                DC.UpdateVacancy();
                MessageBox.Show("Vacancy added successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
        }
    }
}
