using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LookingGlassRecruitmentAgency
{
    public partial class DataController : Form
    {
        public DataTable dtEmployer;
        public DataTable dtVacancy;
        public DataTable dtVacancySkill;
        public DataTable dtApplication;
        public DataTable dtCandidate;
        public DataTable dtCandidateSkill;
        public DataTable dtSkill;
        public DataView employerView;
        public DataView vacancyView;
        public DataView vacancySkillView;
        public DataView applicationView;
        public DataView candidateView;
        public DataView candidateSkillView;
        public DataView skillView;



        public DataController()
        {
            InitializeComponent();
            dsLGRA.EnforceConstraints = false;
            daEmployer.Fill(dsLGRA);
            daVacancy.Fill(dsLGRA);
            daVacancySkill.Fill(dsLGRA);
            daApplication.Fill(dsLGRA);
            daCandidate.Fill(dsLGRA);
            daCandidateSkill.Fill(dsLGRA);
            daSkill.Fill(dsLGRA);
            dtEmployer = dsLGRA.Tables["EMPLOYER"];
            dtVacancy = dsLGRA.Tables["VACANCY"];
            dtVacancySkill = dsLGRA.Tables["VACANCYSKILL"];
            dtApplication = dsLGRA.Tables["APPLICATION"];
            dtCandidate = dsLGRA.Tables["CANDIDATE"];
            dtCandidateSkill = dsLGRA.Tables["CANDIDATESKILL"];
            dtSkill = dsLGRA.Tables["SKILL"];
            employerView = new DataView(dtEmployer);
            employerView.Sort = "EmployerID";
            vacancyView = new DataView(dtVacancy);
            vacancyView.Sort = "VacancyID";
            vacancySkillView = new DataView(dtVacancySkill);
            vacancySkillView.Sort = "VacancyID, SkillID";
            applicationView = new DataView(dtApplication);
            applicationView.Sort = "CandidateID, VacancyID";
            candidateView = new DataView(dtCandidate);
            candidateView.Sort = "CandidateID";
            candidateSkillView = new DataView(dtCandidateSkill);
            candidateSkillView.Sort = "CandidateID, SkillID";
            skillView = new DataView(dtSkill);
            skillView.Sort = "SkillID";
            dsLGRA.EnforceConstraints = true;
        }

        //Arosh
        public void UpdateEmployer()
        {
            daEmployer.Update(dsLGRA, "Employer");
        }

        private void daEmployer_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnLGRAgency);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the EmployeeID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EmployerID"] = newID;
            }
        }

        public void UpdateApplication()
        {
            daApplication.Update(dsLGRA, "APPLICATION");
        }

        public void UpdateSkill() //Arosh & Yejin
        {
            daSkill.Update(dsLGRA, "SKILL");
        }

        private void daSkill_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnLGRAgency);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["SkillID"] = newID;
            }
        }

        public void UpdateVacancySkill()
        {
            daVacancySkill.Update(dsLGRA, "VACANCYSKILL");
        }

        //Yejin
        public void UpdateCandidate()
        {
            daCandidate.Update(dsLGRA, "Candidate");
        }

        private void daCandidate_RowUpdated_1(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnLGRAgency);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CandidateID"] = newID;
            }
        }

        public void UpdateCandidateSkill()
        {
            daCandidateSkill.Update(dsLGRA, "CandidateSkill");
        }

        //Anna
        public void UpdateVacancy()
        {
            daVacancy.Update(dsLGRA, "Vacancy");
        }

        private void daVacancy_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnLGRAgency);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the VacancyID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VacancyID"] = newID;
            }

        }
    }
}
