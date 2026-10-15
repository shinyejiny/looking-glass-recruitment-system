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
    public partial class VacancySkillRemoveForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmSkill;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmVacancySkill;
        //private CurrencyManager cmVacancy_VacancySkill;
        private CurrencyManager cmEmployer;
        private int askillID;
        private int vacancyID;

        public VacancySkillRemoveForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
            loadVacancies();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void loadVacancies()
        {
            string vacancyText = "";
            foreach (DataRow drVacancy in DC.dtVacancy.Rows)
            {
                DataRow[] drVacancySkills = drVacancy.GetChildRows(DC.dtVacancy.ChildRelations["Vacancy_VacancySkill"]);
                if (drVacancySkills.Length != 0)
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
            cmSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "SKILL"];
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCY"];
            cmVacancySkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCYSKILL"];
            //cmVacancy_VacancySkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VACANCY.VACANCY_VACANCYSKILL"];
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGRA, "EMPLOYER"];




        }

        private void lstVacancies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVacancies.SelectedItem != null)
            {
                string vacancy, AssignedSkilltxt = "";
                lstAssignedSkills.Items.Clear();
                vacancy = lstVacancies.SelectedItem.ToString();
                string[] parts = vacancy.Split(',');
                vacancyID = Convert.ToInt32(parts[0]);
                cmVacancy.Position = DC.vacancyView.Find(vacancyID);

                DataRow drVacancy = DC.dtVacancy.Rows[cmVacancy.Position];
                DataRow[] drVacancySkills = drVacancy.GetChildRows(DC.dtVacancy.ChildRelations["Vacancy_VacancySkill"]);


                //txtVacancyID.DataBindings.Add("Text", DC.dsLGRA, "Vacancy.VacancyID");
                //txtVacancyDescription.DataBindings.Add("Text", DC.dsLGRA, "Vacancy.VacancyDescription");
                //txtEmployerName.DataBindings.Add("Text", DC.dsLGRA, "Employer.EmployerName");

                //DataRow[] drVacancySkills = drVacancy.GetChildRows(DC.dtVacancy.ChildRelations["Vacancy_VacancySkill"]);

                /*foreach (DataRow drVacancySkill in drVacancySkills)
                {

                    int skillID = Convert.ToInt32(parts[0]);
                    cmSkill.Position = DC.skillView.Find(skillID);
                    DataRow drSkill = DC.dtSkill.Rows[cmSkill.Position];
                    string level = drVacancySkill["Level"].ToString();
                    AssignedSkilltxt = "Skill ID:  " + drSkill["SkillID"] + "               Skill  Description:  " + drSkill["SkillDescription"]
                        + "               Level:  " + level;
                    lstAssignedSkills.Items.Add(AssignedSkilltxt);
                }*/

                foreach (DataRow drVacancySkill in drVacancySkills)
                {

                    //int skillID = Convert.ToInt32(parts[0]);
                    //cmSkill.Position = DC.skillView.Find(skillID);
                    //DataRow drSkill = DC.dtSkill.Rows[cmSkill.Position];
                    string level = drVacancySkill["Level"].ToString();
                    int askillID = Convert.ToInt32(drVacancySkill["SkillID"].ToString());
                    cmSkill.Position = DC.skillView.Find(askillID);
                    DataRow drSkill = DC.dtSkill.Rows[cmSkill.Position];
                    string description = drSkill["SkillDescription"].ToString();
                    AssignedSkilltxt = "Skill ID:  ," + drVacancySkill["SkillID"] + ",               Level:  " + level + "               Skill  Description:  " + description;

                    lstAssignedSkills.Items.Add(AssignedSkilltxt);
                }

                txtVacancyID.Text = drVacancy["VacancyID"].ToString();
                txtVacancyDescription.Text = drVacancy["VacancyDescription"].ToString();

                int aEmployerID = Convert.ToInt32(drVacancy["EmployerID"].ToString());
                cmEmployer.Position = DC.employerView.Find(aEmployerID);
                DataRow drEmployer = DC.dtEmployer.Rows[cmEmployer.Position];
                txtEmployerName.Text = drEmployer["EmployerName"].ToString();
            }


        }

        private void lstAssignedSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAssignedSkills.SelectedItem != null)
            {
                string assignedskills = lstAssignedSkills.SelectedItem.ToString();
                string[] parts = assignedskills.Split(',');
                askillID = Convert.ToInt32(parts[1]);
                //cmVacancySkill.Position = DC.vacancySkillView.Find(askillID);

            }

        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to remove this skill?", "Warning",
                                   MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                object[] primaryKey = new object[2];
                primaryKey[0] = vacancyID;
                primaryKey[1] = askillID;
                cmVacancySkill.Position = DC.vacancySkillView.Find(primaryKey);
                DataRow deleteVacancySkillRow = DC.dtVacancySkill.Rows[cmVacancySkill.Position];
                deleteVacancySkillRow.Delete();
                DC.UpdateVacancySkill();
                MessageBox.Show("Skill removed from vacancy successfully", "Acknowledgement", MessageBoxButtons.OK);
                lstAssignedSkills.Items.Clear();
                clearFields();


            }
        }

        private void lblSelectSkill_Click(object sender, EventArgs e)
        {

        }
    }
}
