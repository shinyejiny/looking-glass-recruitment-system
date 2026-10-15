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
    public partial class SkillDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmSkill;
        private int askillID;

        public SkillDeleteForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindControls();
            loadSkills();
        }

        private void loadSkills()
        {
            string skillText = "";
            foreach (DataRow drSkill in DC.dtSkill.Rows)
            {
                DataRow[] drSkillInVacancy = drSkill.GetChildRows(DC.dtSkill.ChildRelations["Skill_VacancySkill"]);
               
                    DataRow[] drSkillInCandidate = drSkill.GetChildRows(DC.dtSkill.ChildRelations["Skill_CandidateSkill"]);
                    if (drSkillInCandidate.Length == 0  && (drSkillInVacancy.Length == 0))
                    {
                        skillText = drSkill["SkillID"] + ", ";
                        skillText += drSkill["SkillDescription"];
                        lstSkills.Items.Add(skillText);
                    }
            }

        }
        private void bindControls()
        {
            cmSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "Skill"];
        }

        private void ClearFields()
        {
            txtSkillID.Text = "";
            txtSkillDiscription.Text = "";
            txtSkillType.Text = "";

        }

        private void lstSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSkills.SelectedItem != null)
            {
                string skill = "";
                skill = lstSkills.SelectedItem.ToString();
                string[] parts = skill.Split(',');
                int skillID = Convert.ToInt32(parts[0]);
                askillID = Convert.ToInt32(parts[0]);
                cmSkill.Position = DC.skillView.Find(skillID);
                DataRow drSkill = DC.dtSkill.Rows[cmSkill.Position];
                txtSkillID.Text = drSkill["SkillID"].ToString();
                txtSkillDiscription.Text = drSkill["SkillDescription"].ToString();
                txtSkillType.Text = drSkill["SkillType"].ToString();
            }

        }

        private void btnDeleteSkill_Click(object sender, EventArgs e)
        {
            
            if ((txtSkillID.Text == "" || txtSkillDiscription.Text == "" || txtSkillType.Text == "" ))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                
                if (MessageBox.Show("Are you sure you want to delete this skill?", "Warning",
                                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    cmSkill.Position = DC.skillView.Find(askillID);
                    DataRow drSkill = DC.dtSkill.Rows[cmSkill.Position];
                    DataRow deleteSkillRows = DC.dtSkill.Rows[cmSkill.Position];
                    deleteSkillRows.Delete();
                    DC.UpdateSkill();
                    lstSkills.Items.Clear();
                    loadSkills();
                    MessageBox.Show("Skill deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                    ClearFields();
                }

            }

        
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }
    }
}