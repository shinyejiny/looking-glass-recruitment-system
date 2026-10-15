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
    public partial class CandidateSkillAssignForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmSkill;
        private CurrencyManager cmCandidateSkill;
        private string CdtStatus;
        public CandidateSkillAssignForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }

        public void BindControls()
        {
            cmCandidate = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATE"];
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "CANDIDATE.Candidate_CandidateSkill"];
            cmSkill = (CurrencyManager)this.BindingContext[DC.dsLGRA, "SKILL"];

            dgvCandidates.DataSource = DC.dsLGRA;
            dgvCandidates.DataMember = "CANDIDATE";
            dgvSkills.DataSource = DC.dsLGRA;
            dgvSkills.DataMember = "SKILL";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void clearFields()
        {
            txtCandidateID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStatus.Text = "";
            nudYears.Value = 1;

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newCandidateSkill = DC.dtCandidateSkill.NewRow();
                newCandidateSkill["CandidateID"] = dgvCandidates["CandidateID", cmCandidate.Position].Value;
                newCandidateSkill["SkillID"] = dgvSkills["SkillID", cmSkill.Position].Value;
                newCandidateSkill["YearsOfExperiance"] = nudYears.Value;
                DC.dsLGRA.Tables["CandidateSkill"].Rows.Add(newCandidateSkill);
                DC.UpdateCandidateSkill();
                MessageBox.Show("Skill assigned to candidate successfully", "Acknowledgement", MessageBoxButtons.OK);
            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("This skill already assigned to this candidate", "Error");
            }
            clearFields();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void dgvCandidates_Click(object sender, EventArgs e)
        {
            if (cmCandidate.Position != -1)
            {
                DataRow drCandidate = DC.dtCandidate.Rows[cmCandidate.Position];
                txtCandidateID.Text = dgvCandidates["CandidateID", cmCandidate.Position].Value.ToString();
                txtFirstName.Text = dgvCandidates["CandidateFirstName", cmCandidate.Position].Value.ToString();
                txtLastName.Text = dgvCandidates["CandidateLastName", cmCandidate.Position].Value.ToString();
                txtStatus.Text = dgvCandidates["Status", cmCandidate.Position].Value.ToString();

            }
        }
    }
}

