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

    public partial class CandidateSkillRemoveForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmSkill;
        private CurrencyManager cmCandidateSkill;
        private int candidateID;
        private int skillID;



        public CandidateSkillRemoveForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
            loadCandidates();
        }
        private void loadCandidates()
        {
            string candidateText = "";
            foreach (DataRow drCandidate in DC.dtCandidate.Rows)
            {
                candidateText = drCandidate["CandidateID"] + ",";
                candidateText += drCandidate["CandidateLastName"] + " ";
                candidateText += drCandidate["CandidateFirstName"] + " ";
                lstCandidates.Items.Add(candidateText);
            }
        }
        public void BindControls()
        {
            cmCandidate = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATE"];
            cmSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "Skill"];
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATESKILL"];
        }

        public void ClearFields()
        {
            txtCandidateID.Text = "";
            //txtDescription.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            //txtSkillID.Text = "";
            txtStatus.Text = "";
            //txtYears.Text = "";
        }
       
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void lstCandidates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCandidates.SelectedItem != null)
            {
                string candidate, candidateskilltxt = "";
                lstSkills.Items.Clear();
                candidate = lstCandidates.SelectedItem.ToString();
                string[] parts = candidate.Split(',');
                candidateID = Convert.ToInt32(parts[0]);
                cmCandidate.Position = DC.candidateView.Find(candidateID);


                DataRow drCandidate = DC.dtCandidate.Rows[cmCandidate.Position];
                DataRow[] drCandidateSkills = drCandidate.GetChildRows(DC.dtCandidate.ChildRelations["Candidate_CandidateSkill"]);
                foreach (DataRow drSkill in drCandidateSkills)
                {
                    int skillID = Convert.ToInt32(drSkill["SkillID"].ToString());
                    cmSkill.Position = DC.skillView.Find(skillID);

                    //cmSkill.Position = DC.skillView.Find(skillID);
                    DataRow drskills = DC.dtSkill.Rows[cmSkill.Position];

                    candidateskilltxt = "Skill ID:," + drSkill["SkillID"] + ",  " + "Description: " + drskills["SkillDescription"] + ",  " + "Years of Experience: " + drSkill["YearsOfExperiance"];
                    lstSkills.Items.Add(candidateskilltxt);
                    //txtSkillID.Text = drSkill["SkillID"].ToString();
                    //txtDescription.Text = drskill["SkillDescription"].ToString();
                    //txtYears.Text = drSkill["YearsOfExperiance"].ToString();
                }
                txtCandidateID.Text = drCandidate["CandidateID"].ToString();
                txtFirstName.Text = drCandidate["CandidateFirstName"].ToString();
                txtLastName.Text = drCandidate["CandidateLastName"].ToString();
                txtStatus.Text = drCandidate["Status"].ToString();


            }
        }

        private void lstSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSkills.SelectedItem != null)
            {
                //DataRow drSkill = DC.dtSkill.Rows[cmSkill.Position];

                string skill = lstSkills.SelectedItem.ToString();
                string[] parts = skill.Split(',');
                skillID = Convert.ToInt32(parts[1]);
                //cmSkill.Position = DC.skillView.Find(skillID);
                //txtSkillID.Text = drSkill["SkillID"].ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if ((txtCandidateID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtStatus.Text == "" ))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete candidate skill?", "Warning",
                                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    object[] primaryKey = new object[2];
                    primaryKey[0] = candidateID;
                    primaryKey[1] = skillID;
                    cmCandidateSkill.Position = DC.candidateSkillView.Find(primaryKey);
                    DataRow deleteCandidateSkillRow = DC.dtCandidateSkill.Rows[cmCandidateSkill.Position];
                    deleteCandidateSkillRow.Delete();
                    DC.UpdateCandidateSkill();
                    MessageBox.Show("Skill removed from candidate skill successfully", "Acknowledgement", MessageBoxButtons.OK);
                    lstSkills.Items.Clear();
                    ClearFields();
                }

            }

            
            
           
        }
    }
}
