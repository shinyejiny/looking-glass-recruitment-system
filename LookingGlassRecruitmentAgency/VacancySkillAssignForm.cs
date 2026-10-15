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
    public partial class VacancySkillAssignForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmSkill;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmVacancySkill;
        private CurrencyManager cmEmployer;

        public VacancySkillAssignForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }

        public void BindControls()
        {
            cmSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "SKILL"];
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCY"];
            cmVacancySkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCY.VACANCY_VACANCYSKILL"];
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGRA, "EMPLOYER"];

            dgvSkills.DataSource = DC.dsLGRA;
            dgvSkills.DataMember = "SKILL";
            dgvVacancies.DataSource = DC.dsLGRA;
            dgvVacancies.DataMember = "VACANCY";
            dgvVacancySkills.DataSource = DC.dsLGRA;
            dgvVacancySkills.DataMember = "VACANCY.VACANCY_VACANCYSKILL";


        }

        private void clearFields()
        {
            txtVacancyID.Text = "";
            txtVacancyDescription.Text = "";
            nudLevel.Value = 1;
            txtEmployerName.Text = "";
            txtAssignedSkill.Text = "";
        }

        private void lblSelectAssignedSkill_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void dgvVacancies_Click(object sender, EventArgs e)
        {
            if (cmVacancy.Position != -1)
            {
                txtVacancyID.Text = dgvVacancies["VacancyID", cmVacancy.Position].Value.ToString();
                txtVacancyDescription.Text = dgvVacancies["VacancyDescription", cmVacancy.Position].Value.ToString();
                int anEmployerID = Convert.ToInt32(dgvVacancies["EmployerID", cmVacancy.Position].Value);
                cmEmployer.Position = DC.employerView.Find(anEmployerID);
                DataRow drEmployer = DC.dtEmployer.Rows[cmEmployer.Position];
                txtEmployerName.Text = drEmployer["EmployerName"].ToString();
            }
        }

        private void btnAssignSkill_Click(object sender, EventArgs e)
        {
            if ((dgvVacancies["VacancyStatus", cmVacancy.Position].Value).ToString() == "Current")
            {
                try
                {
                    DataRow newVacancySkill = DC.dtVacancySkill.NewRow();
                    if (nudLevel.Text == "")

                    {
                        MessageBox.Show("Please fill in all fields correctly", "Error");
                    }
                    else


                    {
                        //DataRow newVacancySkill = DC.dtVacancySkill.NewRow();
                        newVacancySkill["VacancyID"] = dgvVacancies["VacancyID", cmVacancy.Position].Value;
                        newVacancySkill["SkillID"] = dgvSkills["SkillID2", cmSkill.Position].Value;
                        newVacancySkill["Level"] = nudLevel.Value;
                        DC.dsLGRA.Tables["VacancySkill"].Rows.Add(newVacancySkill);
                        DC.UpdateVacancySkill();
                        MessageBox.Show("Skill assigned to vacancy", "Acknowledgement", MessageBoxButtons.OK);
                        clearFields();
                    }

                }

                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("Skill already assigned to that vacancy", "Error");
                }
            }

            else
            {
                MessageBox.Show("Cannot assign skills to cancelled or filled vacancies", "Error");
            }

        }

        private void dgvVacancySkills_Click(object sender, EventArgs e)
        {
            if (cmVacancySkill.Position != -1)
            {
                int aSkillID = Convert.ToInt32(dgvVacancySkills["SkillID", cmVacancySkill.Position].Value);
                cmSkill.Position = DC.skillView.Find(aSkillID);
                DataRow drSkill = DC.dtSkill.Rows[cmSkill.Position];
                txtAssignedSkill.Text = drSkill["SkillDescription"].ToString();
            }
        }
    }
}

