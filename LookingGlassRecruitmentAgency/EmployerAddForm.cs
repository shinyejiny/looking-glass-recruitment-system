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
    public partial class EmployerAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private string employerStatus;

        public EmployerAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        public void DisplayEmployers()
        {
            string employerText = "";
            txtEmployerList.Text = "";

            //employerText += "ID"+ "\t" + "Name" + "\r\n"; ;
            
            foreach (DataRow drEmployer in DC.dtEmployer.Rows)
            {
                
                employerText += drEmployer["EmployerID"] + "," + drEmployer["EmployerName"] + "\r\n";
                txtEmployerList.Text += employerText;
                employerText = "";
            }
        }
               
        private void clearFields()
        {
            txtEmployerName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            string newStatus;
            if (txtEmployerName.Text == "" || txtStreetAddress.Text == "" || txtSuburb.Text == "" || txtCity.Text == "" || txtPhoneNumber.Text == "" || txtEmailAddress.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newEmployerRow = DC.dtEmployer.NewRow();

                newEmployerRow["EmployerName"] = txtEmployerName.Text;
                newEmployerRow["StreetAddress"] = txtStreetAddress.Text;
                newEmployerRow["Suburb"] = txtSuburb.Text;
                newEmployerRow["City"] = txtCity.Text;
                newEmployerRow["EmailAddress"] = txtEmailAddress.Text;
                newEmployerRow["PhoneNumber"] = txtPhoneNumber.Text;
                employerStatus = newEmployerRow["EmployerStatus"].ToString();
                if (rbnActive.Checked == true)
                {
                    newStatus = "Active";
                }
                else
                {
                    newStatus = "Inactive";
                }
                newEmployerRow["EmployerStatus"] = newStatus;
                DC.dsLGRA.Tables["EMPLOYER"].Rows.Add(newEmployerRow);
                DC.UpdateEmployer();
                DisplayEmployers();
                MessageBox.Show("Employer added successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            } 
        }

        private void EmployerAddForm_Load(object sender, EventArgs e)
        {
            DisplayEmployers();
        }
    }
}
