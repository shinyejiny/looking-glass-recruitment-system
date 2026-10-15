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
    public partial class SkillReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public SkillReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            //BindControls();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string skillText = "";
            txtSkills.Text = "\t\t\t\t" + "Skill Report" + "\r\n\r\n";
            CurrencyManager cmCandidateSkill;
            CurrencyManager cmVacancySkill;
            CurrencyManager cmSkill;
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CandidateSkill"];
            cmVacancySkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "VacancySkill"];
            cmSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "Skill"];


            foreach (DataRow drSkill in DC.dtSkill.Rows)

            {
                int aSkillID = Convert.ToInt32(drSkill["SkillID"].ToString());
                cmCandidateSkill.Position = DC.candidateView.Find(aSkillID);
                DataRow drCandidate = DC.dtCandidate.Rows[cmCandidateSkill.Position];

                skillText += "Skill ID:  " + drSkill["SkillID"] + "                 " + "Description:  " + drSkill["SkillDescription"] + "                " + "Skill Type:  " + drSkill["SkillType"] + "\r\n";
                skillText += "Count of Candidate: ";
                DataRow[] drCandidateskills = drSkill.GetChildRows(DC.dtSkill.ChildRelations["Skill_CandidateSkill"]);
                skillText += drCandidateskills.Length + "\r\n";

                skillText += "Count of Vacancy: ";
                DataRow[] drVacancyskills = drSkill.GetChildRows(DC.dtSkill.ChildRelations["Skill_VacancySkill"]);
                skillText += drVacancyskills.Length + "\r\n";

                skillText += "\r\n\r\n";
                skillText += " \r\n\r\n";
                txtSkills.Text += skillText;
                skillText = "";
            }

        }
    }
}





