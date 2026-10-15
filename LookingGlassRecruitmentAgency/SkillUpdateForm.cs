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
    public partial class SkillUpdateForm : Form
    {

        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmSkill;

        public SkillUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
            loadSkills();
        }

        private void loadSkills()
        {
            string skillText = "";
            foreach (DataRow drSkill in DC.dtSkill.Rows)
            {

                skillText = drSkill["SkillID"] + ", ";
                skillText += drSkill["SkillDescription"];
                lstSkills.Items.Add(skillText);
            }
        }

        private void clearFields()
        {
            txtSkillID.Text = "";
            txtSkillDescription.Text = "";
            cboSkillType.Text = "";
        }

        public void BindControls()
        {
            cmSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "SKILL"];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void lstSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            string skills = "";
            skills = lstSkills.SelectedItem.ToString();
            string[] parts = skills.Split(',');
            int skillID = Convert.ToInt32(parts[0]);
            cmSkill.Position = DC.skillView.Find(skillID);
            DataRow drSkill = DC.dtSkill.Rows[cmSkill.Position];
            txtSkillID.Text = drSkill["SkillID"].ToString();


            txtSkillDescription.Text = drSkill["SkillDescription"].ToString();
            cboSkillType.Text = drSkill["SkillType"].ToString();

        }

        private void btnUpdateSkill_Click(object sender, EventArgs e)
        {
            DataRow updateSkillRow = DC.dtSkill.Rows[cmSkill.Position];
            if ((txtSkillDescription.Text == "") || (cboSkillType.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                updateSkillRow["SkillDescription"] = txtSkillDescription.Text;
                updateSkillRow["SkillType"] = cboSkillType.Text;
                cmSkill.EndCurrentEdit();
                DC.UpdateSkill();
                lstSkills.Items.Clear();
                loadSkills();
                MessageBox.Show("Skill updated successfully", "Success");
                clearFields();
            }
        }

    }
}
