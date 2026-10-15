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
    public partial class EmployerDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmEmployer;
        //private int employerID;
        

        public EmployerDeleteForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            bindControls();
            frmMenu.Hide();
            loadEmployers();
        }

        private void bindControls()
        {
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGRA, "Employer"];
        }

        private void loadEmployers()
        {
            string employerText = "";
            foreach (DataRow drEmployer in DC.dtEmployer.Rows)
            {
                DataRow[] drVacancy = drEmployer.GetChildRows(DC.dtEmployer.ChildRelations["Employer_Vacancy"]);
                if (drVacancy.Length == 0)
                {
                    employerText = drEmployer["EmployerID"] + ", ";
                    employerText += drEmployer["EmployerName"];
                    lstEmployerDeatils.Items.Add(employerText);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        public void ClearFields()
        {
            txtEmployerID.Text = "";
            txtEmployerName.Text = "";
            txtEmailAddress.Text = "";
            txtStatus.Text = "";
        }

        private void lstEmployerDeatils_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployerDeatils.SelectedItem != null)
            {
                string employer = "";
                employer = lstEmployerDeatils.SelectedItem.ToString();
                string[] parts = employer.Split(',');
                int employerID = Convert.ToInt32(parts[0]);
                cmEmployer.Position = DC.employerView.Find(employerID);
                DataRow drEmployer = DC.dtEmployer.Rows[cmEmployer.Position];
                txtEmployerID.Text = drEmployer["EmployerID"].ToString();
                txtEmployerName.Text = drEmployer["EmployerName"].ToString();
                txtEmailAddress.Text = drEmployer["EmailAddress"].ToString();
                txtStatus.Text = drEmployer["EmployerStatus"].ToString();
            }
        }

        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            if ((txtEmployerID.Text == "" || txtEmployerName.Text == "" || txtEmployerName.Text == "" || txtStatus.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this employer?", "Warning",
                                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //string employerRow = "";
                    //string[] parts = employerRow.Split(',');
                    //int employerRowID = Convert.ToInt32(parts[0]);
                    //cmEmployer.Position = DC.employerView.Find(employerRowID);
                    DataRow deleteEmployerRow = DC.dtEmployer.Rows[cmEmployer.Position];
                    deleteEmployerRow.Delete();
                    DC.UpdateEmployer();
                    lstEmployerDeatils.Items.Clear();
                    loadEmployers();
                    MessageBox.Show("Employer deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                    ClearFields();

                }

            }
        }
    }
}