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
    public partial class MainForm : Form
    {
        //Arosh
        private DataController                  DC;                          // the reference to the form that holds the data controls.                                       
        private EmployerAddForm                 frmAddEmployer;              // the reference to the add employer form.
        private EmployerUpdateForm              frmUpdateEmployer;           // the reference to the update employer form.
        private EmployerDeleteForm              frmDeleteEmployer;           // the reference to the delete employer form.
        private EmployersReportForm             frmEmployerReport;           // the reference to the employers report form.
        private ApplicationAddForm              frmAddAppication;            // the reference to the add appication form.
        private ApplicationsReportForm          frmApplicationReport;        // the reference to the application report form.
        private SkillDeleteForm                 frmDeleteSkill;              // the reference to the delete Skill from.      
        private ApplicationRemoveForm           frmRemoveApplication;        // the reference to the remove application form.
        //Yejin
        private CandidateAddForm                frmAddCandidateForm;         // the reference to the add candidate form.
        private CandidateUpdateForm             frmUpdateCandidateForm;      // the reference to the update candidate form.
        private CandidateDeleteForm             frmDeleteCandidateForm;      // the reference to the delete candidate form.
        private CandidateReportForm             frmProduceCandidateForm;     // the reference to the candidate report form.
        private CandidateSkillAssignForm        frmAssignCandidateSkillForm; // the reference to the assign candidate skill report form.
        private CandidateSkillRemoveForm        frmRemoveCandidateSkillForm; // the reference to the remove candidate skill report form.
        private SkillAddForm                    frmAddSkillForm;             // the reference to the add skill form.
        private SkillReportForm                 frmProduceSkillForm;         // the reference to the skill report form.
        //Anna
        private VacancyAddForm                  frmVacancyAdd;               // the reference to the add vacancy form.
        private VacancyUpdateForm               frmVacancyUpdate;            // the reference to the update vacancy form
        private VacancyDeleteForm               frmVacancyDelete;            // the reference to the delete vacancy form.
        private VacanciesReportForm             frmVacanciesReport;          // the reference to the vacancies report form
        private VacancySkillAssignForm          frmVacancySkillAssign;       // the reference to the assign vacancy skill form
        private VacancySkillRemoveForm          frmVacancySkillRemove;       // the reference to the remove vacancy skill form
        private VacancyFillForm                 frmVacancyFill;              // the reference to the fill vacancy form
        private SkillUpdateForm                 frmSkillUpdate;              // the reference to the update skill form

        public MainForm()
        {
            InitializeComponent();
        }

        //Arosh
        private void MainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); //create the data controller and load the dataset
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            frmAddEmployer = new EmployerAddForm(DC, this);
            frmAddEmployer.ShowDialog();
        }

        private void btnUpdateEmployer_Click(object sender, EventArgs e)
        {
            frmUpdateEmployer = new EmployerUpdateForm(DC, this);
            frmUpdateEmployer.ShowDialog();
        }

        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            frmDeleteEmployer = new EmployerDeleteForm(DC, this);
            frmDeleteEmployer.ShowDialog();
        }

        private void btnEmployersReport_Click(object sender, EventArgs e)
        {
            frmEmployerReport = new EmployersReportForm(DC, this);
            frmEmployerReport.ShowDialog();
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            frmAddAppication = new ApplicationAddForm(DC, this);
            frmAddAppication.ShowDialog();
        }

        private void btnRemoveApplication_Click(object sender, EventArgs e)
        {
            frmRemoveApplication = new ApplicationRemoveForm(DC, this);
            frmRemoveApplication.ShowDialog();
        }

        private void btnApplicationsReport_Click(object sender, EventArgs e)
        {
            frmApplicationReport = new ApplicationsReportForm(DC, this);
            frmApplicationReport.ShowDialog();
        }

        private void btnDeleteSkill_Click(object sender, EventArgs e)
        {
            frmDeleteSkill = new SkillDeleteForm(DC, this);
            frmDeleteSkill.ShowDialog();
        }

        //Yejin

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            frmAddCandidateForm = new CandidateAddForm(DC, this);
            frmAddCandidateForm.ShowDialog();
        }


        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            frmUpdateCandidateForm = new CandidateUpdateForm(DC, this);
            frmUpdateCandidateForm.ShowDialog();

        }

        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            frmDeleteCandidateForm = new CandidateDeleteForm(DC, this);
            frmDeleteCandidateForm.ShowDialog();
        }

        private void btnCandidatesReport_Click(object sender, EventArgs e)
        {
            frmProduceCandidateForm = new CandidateReportForm(DC, this);
            frmProduceCandidateForm.ShowDialog();
        }

        private void btnAssignCandidateSkill_Click(object sender, EventArgs e)
        {
            frmAssignCandidateSkillForm = new CandidateSkillAssignForm(DC, this);
            frmAssignCandidateSkillForm.ShowDialog();
        }

        private void btnRemoveCandidateSkill_Click(object sender, EventArgs e)
        {
            frmRemoveCandidateSkillForm = new CandidateSkillRemoveForm(DC, this);
            frmRemoveCandidateSkillForm.ShowDialog();
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            frmAddSkillForm = new SkillAddForm(DC, this);
            frmAddSkillForm.ShowDialog();
        }

        private void btnSkillsReport_Click(object sender, EventArgs e)
        {
            frmProduceSkillForm = new SkillReportForm(DC, this);
            frmProduceSkillForm.ShowDialog();
        }

        //Anna
        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            frmVacancyAdd = new VacancyAddForm(DC, this);
            frmVacancyAdd.ShowDialog();
        }

        private void btnUpdateVacancy_Click(object sender, EventArgs e)
        {
            frmVacancyUpdate = new VacancyUpdateForm(DC, this);
            frmVacancyUpdate.ShowDialog();
        }

        private void btnDeleteVacancy_Click(object sender, EventArgs e)
        {
            frmVacancyDelete = new VacancyDeleteForm(DC, this);
            frmVacancyDelete.ShowDialog();
        }

        private void btnVacanciesReport_Click(object sender, EventArgs e)
        {
            frmVacanciesReport = new VacanciesReportForm(DC, this);
            frmVacanciesReport.ShowDialog();
        }

        private void btnAssignVacancySkill_Click(object sender, EventArgs e)
        {
            frmVacancySkillAssign = new VacancySkillAssignForm(DC, this);
            frmVacancySkillAssign.ShowDialog();
        }

        private void btnRemoveVacancySkill_Click(object sender, EventArgs e)
        {
            frmVacancySkillRemove = new VacancySkillRemoveForm(DC, this);
            frmVacancySkillRemove.ShowDialog();
        }

        private void btnFillVacancy_Click(object sender, EventArgs e)
        {
            frmVacancyFill = new VacancyFillForm(DC, this);
            frmVacancyFill.ShowDialog();

        }

        private void btnUpdateSkill_Click(object sender, EventArgs e)
        {
            frmSkillUpdate = new SkillUpdateForm(DC, this);
            frmSkillUpdate.ShowDialog();
        }
    }
}
