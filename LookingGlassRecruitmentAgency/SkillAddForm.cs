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
    public partial class SkillAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        public SkillAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        public void DisplaySkills()
        {
            string skillText = "";
            txtSkill.Text = "";

            foreach (DataRow drSkill in DC.dtSkill.Rows)
            {
                skillText += "Skill ID: " + drSkill["SkillID"] + ",   ";
                skillText += "Skill Description: " + drSkill["SkillDescription"] + "\r\n";
                txtSkill.Text += skillText;
                skillText = "";
            }
        }
        private void SkillAddForm_Load(object sender, EventArgs e)
        {
            DisplaySkills();
        }
        private void clearFields()
        {
            //txtSkill.Text = "";
            cboType.Text = "Hard";
            txtDescription.Text = "";
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || cboType.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newSkillRow = DC.dtSkill.NewRow();
                newSkillRow["SkillDescription"] = txtDescription.Text;
                newSkillRow["SkillType"] = cboType.Text;
                DC.dsLGRA.Tables["SKILL"].Rows.Add(newSkillRow);
                DC.UpdateSkill();
                DisplaySkills();
                MessageBox.Show("Skill added successfully", "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();

            }
        }
    }
}
