
namespace LookingGlassRecruitmentAgency
{
    partial class DataController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataController));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.ctnLGRAgency = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daApplication = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daCandidate = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.daCandidateSkill = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.daEmployer = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.daSkill = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
            this.daVacancy = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
            this.daVacancySkill = new System.Data.OleDb.OleDbDataAdapter();
            this.dsLGRA = new LookingGlassRecruitmentAgency.LGRAgencyDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dsLGRA)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        ApplicationDate, ApplicationStatus, CandidateID, VacancyID\r\nFROM   " +
    "         APPLICATION\r\nORDER BY CandidateID, VacancyID";
            this.oleDbSelectCommand1.Connection = this.ctnLGRAgency;
            // 
            // ctnLGRAgency
            // 
            this.ctnLGRAgency.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\5607\\LGRAgencyDB.mdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `APPLICATION` (`ApplicationDate`, `ApplicationStatus`, `CandidateID`," +
    " `VacancyID`) VALUES (?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.ctnLGRAgency;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ApplicationDate", System.Data.OleDb.OleDbType.Date, 0, "ApplicationDate"),
            new System.Data.OleDb.OleDbParameter("ApplicationStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "ApplicationStatus"),
            new System.Data.OleDb.OleDbParameter("CandidateID", System.Data.OleDb.OleDbType.Integer, 0, "CandidateID"),
            new System.Data.OleDb.OleDbParameter("VacancyID", System.Data.OleDb.OleDbType.Integer, 0, "VacancyID")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.ctnLGRAgency;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ApplicationDate", System.Data.OleDb.OleDbType.Date, 0, "ApplicationDate"),
            new System.Data.OleDb.OleDbParameter("ApplicationStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "ApplicationStatus"),
            new System.Data.OleDb.OleDbParameter("CandidateID", System.Data.OleDb.OleDbType.Integer, 0, "CandidateID"),
            new System.Data.OleDb.OleDbParameter("VacancyID", System.Data.OleDb.OleDbType.Integer, 0, "VacancyID"),
            new System.Data.OleDb.OleDbParameter("IsNull_ApplicationDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ApplicationDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ApplicationDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ApplicationDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ApplicationStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ApplicationStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ApplicationStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ApplicationStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.ctnLGRAgency;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("IsNull_ApplicationDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ApplicationDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ApplicationDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ApplicationDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ApplicationStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ApplicationStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ApplicationStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ApplicationStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null)});
            // 
            // daApplication
            // 
            this.daApplication.DeleteCommand = this.oleDbDeleteCommand1;
            this.daApplication.InsertCommand = this.oleDbInsertCommand1;
            this.daApplication.SelectCommand = this.oleDbSelectCommand1;
            this.daApplication.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "APPLICATION", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ApplicationDate", "ApplicationDate"),
                        new System.Data.Common.DataColumnMapping("ApplicationStatus", "ApplicationStatus"),
                        new System.Data.Common.DataColumnMapping("CandidateID", "CandidateID"),
                        new System.Data.Common.DataColumnMapping("VacancyID", "VacancyID")})});
            this.daApplication.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        CandidateID, CandidateLastName, CandidateFirstName, StreetAddress, " +
    "Suburb, City, EmailAddress, PhoneNumber, WorkType, Status\r\nFROM            CANDI" +
    "DATE\r\nORDER BY CandidateID";
            this.oleDbSelectCommand2.Connection = this.ctnLGRAgency;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `CANDIDATE` (`CandidateLastName`, `CandidateFirstName`, `StreetAddres" +
    "s`, `Suburb`, `City`, `EmailAddress`, `PhoneNumber`, `WorkType`, `Status`) VALUE" +
    "S (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.ctnLGRAgency;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CandidateLastName", System.Data.OleDb.OleDbType.VarWChar, 0, "CandidateLastName"),
            new System.Data.OleDb.OleDbParameter("CandidateFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "CandidateFirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("WorkType", System.Data.OleDb.OleDbType.VarWChar, 0, "WorkType"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.ctnLGRAgency;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CandidateLastName", System.Data.OleDb.OleDbType.VarWChar, 0, "CandidateLastName"),
            new System.Data.OleDb.OleDbParameter("CandidateFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "CandidateFirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("WorkType", System.Data.OleDb.OleDbType.VarWChar, 0, "WorkType"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CandidateLastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CandidateLastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateLastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CandidateFirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CandidateFirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_WorkType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WorkType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_WorkType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WorkType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.ctnLGRAgency;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CandidateLastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CandidateLastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateLastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CandidateFirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CandidateFirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_WorkType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WorkType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_WorkType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WorkType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null)});
            // 
            // daCandidate
            // 
            this.daCandidate.DeleteCommand = this.oleDbDeleteCommand2;
            this.daCandidate.InsertCommand = this.oleDbInsertCommand2;
            this.daCandidate.SelectCommand = this.oleDbSelectCommand2;
            this.daCandidate.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CANDIDATE", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CandidateID", "CandidateID"),
                        new System.Data.Common.DataColumnMapping("CandidateLastName", "CandidateLastName"),
                        new System.Data.Common.DataColumnMapping("CandidateFirstName", "CandidateFirstName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("EmailAddress", "EmailAddress"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("WorkType", "WorkType"),
                        new System.Data.Common.DataColumnMapping("Status", "Status")})});
            this.daCandidate.UpdateCommand = this.oleDbUpdateCommand2;
            this.daCandidate.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daCandidate_RowUpdated_1);
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        YearsOfExperiance, CandidateID, SkillID\r\nFROM            CANDIDATES" +
    "KILL\r\nORDER BY CandidateID, SkillID";
            this.oleDbSelectCommand3.Connection = this.ctnLGRAgency;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `CANDIDATESKILL` (`YearsOfExperiance`, `CandidateID`, `SkillID`) VALU" +
    "ES (?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.ctnLGRAgency;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("YearsOfExperiance", System.Data.OleDb.OleDbType.SmallInt, 0, "YearsOfExperiance"),
            new System.Data.OleDb.OleDbParameter("CandidateID", System.Data.OleDb.OleDbType.Integer, 0, "CandidateID"),
            new System.Data.OleDb.OleDbParameter("SkillID", System.Data.OleDb.OleDbType.Integer, 0, "SkillID")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.ctnLGRAgency;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("YearsOfExperiance", System.Data.OleDb.OleDbType.SmallInt, 0, "YearsOfExperiance"),
            new System.Data.OleDb.OleDbParameter("CandidateID", System.Data.OleDb.OleDbType.Integer, 0, "CandidateID"),
            new System.Data.OleDb.OleDbParameter("SkillID", System.Data.OleDb.OleDbType.Integer, 0, "SkillID"),
            new System.Data.OleDb.OleDbParameter("IsNull_YearsOfExperiance", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "YearsOfExperiance", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_YearsOfExperiance", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "YearsOfExperiance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM `CANDIDATESKILL` WHERE (((? = 1 AND `YearsOfExperiance` IS NULL) OR (" +
    "`YearsOfExperiance` = ?)) AND (`CandidateID` = ?) AND (`SkillID` = ?))";
            this.oleDbDeleteCommand3.Connection = this.ctnLGRAgency;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("IsNull_YearsOfExperiance", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "YearsOfExperiance", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_YearsOfExperiance", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "YearsOfExperiance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null)});
            // 
            // daCandidateSkill
            // 
            this.daCandidateSkill.DeleteCommand = this.oleDbDeleteCommand3;
            this.daCandidateSkill.InsertCommand = this.oleDbInsertCommand3;
            this.daCandidateSkill.SelectCommand = this.oleDbSelectCommand3;
            this.daCandidateSkill.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CANDIDATESKILL", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("YearsOfExperiance", "YearsOfExperiance"),
                        new System.Data.Common.DataColumnMapping("CandidateID", "CandidateID"),
                        new System.Data.Common.DataColumnMapping("SkillID", "SkillID")})});
            this.daCandidateSkill.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT       EmployerID, EmployerName, StreetAddress, Suburb, City, EmailAddress," +
    " PhoneNumber, EmployerStatus\r\nFROM            EMPLOYER\r\nORDER BY EmployerID";
            this.oleDbSelectCommand4.Connection = this.ctnLGRAgency;
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO `EMPLOYER` (`EmployerName`, `StreetAddress`, `Suburb`, `City`, `Email" +
    "Address`, `PhoneNumber`, `EmployerStatus`) VALUES (?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand4.Connection = this.ctnLGRAgency;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmployerName", System.Data.OleDb.OleDbType.VarWChar, 0, "EmployerName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("EmployerStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "EmployerStatus")});
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = resources.GetString("oleDbUpdateCommand4.CommandText");
            this.oleDbUpdateCommand4.Connection = this.ctnLGRAgency;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmployerName", System.Data.OleDb.OleDbType.VarWChar, 0, "EmployerName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("EmployerStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "EmployerStatus"),
            new System.Data.OleDb.OleDbParameter("Original_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerStatus", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = resources.GetString("oleDbDeleteCommand4.CommandText");
            this.oleDbDeleteCommand4.Connection = this.ctnLGRAgency;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerStatus", System.Data.DataRowVersion.Original, null)});
            // 
            // daEmployer
            // 
            this.daEmployer.DeleteCommand = this.oleDbDeleteCommand4;
            this.daEmployer.InsertCommand = this.oleDbInsertCommand4;
            this.daEmployer.SelectCommand = this.oleDbSelectCommand4;
            this.daEmployer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "EMPLOYER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployerID", "EmployerID"),
                        new System.Data.Common.DataColumnMapping("EmployerName", "EmployerName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("EmailAddress", "EmailAddress"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("EmployerStatus", "EmployerStatus")})});
            this.daEmployer.UpdateCommand = this.oleDbUpdateCommand4;
            this.daEmployer.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daEmployer_RowUpdated);
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT        SkillID, SkillDescription, SkillType\r\nFROM            SKILL\r\nORDER " +
    "BY SkillID";
            this.oleDbSelectCommand5.Connection = this.ctnLGRAgency;
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO `SKILL` (`SkillDescription`, `SkillType`) VALUES (?, ?)";
            this.oleDbInsertCommand5.Connection = this.ctnLGRAgency;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SkillDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "SkillDescription"),
            new System.Data.OleDb.OleDbParameter("SkillType", System.Data.OleDb.OleDbType.VarWChar, 0, "SkillType")});
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = resources.GetString("oleDbUpdateCommand5.CommandText");
            this.oleDbUpdateCommand5.Connection = this.ctnLGRAgency;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SkillDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "SkillDescription"),
            new System.Data.OleDb.OleDbParameter("SkillType", System.Data.OleDb.OleDbType.VarWChar, 0, "SkillType"),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_SkillDescription", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SkillDescription", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillDescription", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_SkillType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SkillType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillType", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = "DELETE FROM `SKILL` WHERE ((`SkillID` = ?) AND ((? = 1 AND `SkillDescription` IS " +
    "NULL) OR (`SkillDescription` = ?)) AND ((? = 1 AND `SkillType` IS NULL) OR (`Ski" +
    "llType` = ?)))";
            this.oleDbDeleteCommand5.Connection = this.ctnLGRAgency;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_SkillDescription", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SkillDescription", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillDescription", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_SkillType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SkillType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillType", System.Data.DataRowVersion.Original, null)});
            // 
            // daSkill
            // 
            this.daSkill.DeleteCommand = this.oleDbDeleteCommand5;
            this.daSkill.InsertCommand = this.oleDbInsertCommand5;
            this.daSkill.SelectCommand = this.oleDbSelectCommand5;
            this.daSkill.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SKILL", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SkillID", "SkillID"),
                        new System.Data.Common.DataColumnMapping("SkillDescription", "SkillDescription"),
                        new System.Data.Common.DataColumnMapping("SkillType", "SkillType")})});
            this.daSkill.UpdateCommand = this.oleDbUpdateCommand5;
            this.daSkill.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daSkill_RowUpdated);
            // 
            // oleDbSelectCommand6
            // 
            this.oleDbSelectCommand6.CommandText = "SELECT       VacancyID, VacancyDescription, VacancyStatus, VacancyType, Salary, E" +
    "mployerID\r\nFROM            VACANCY\r\nORDER BY VacancyID";
            this.oleDbSelectCommand6.Connection = this.ctnLGRAgency;
            // 
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = "INSERT INTO `VACANCY` (`VacancyDescription`, `VacancyStatus`, `VacancyType`, `Sal" +
    "ary`, `EmployerID`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand6.Connection = this.ctnLGRAgency;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("VacancyDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "VacancyDescription"),
            new System.Data.OleDb.OleDbParameter("VacancyStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "VacancyStatus"),
            new System.Data.OleDb.OleDbParameter("VacancyType", System.Data.OleDb.OleDbType.VarWChar, 0, "VacancyType"),
            new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Currency, 0, "Salary"),
            new System.Data.OleDb.OleDbParameter("EmployerID", System.Data.OleDb.OleDbType.Integer, 0, "EmployerID")});
            // 
            // oleDbUpdateCommand6
            // 
            this.oleDbUpdateCommand6.CommandText = resources.GetString("oleDbUpdateCommand6.CommandText");
            this.oleDbUpdateCommand6.Connection = this.ctnLGRAgency;
            this.oleDbUpdateCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("VacancyDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "VacancyDescription"),
            new System.Data.OleDb.OleDbParameter("VacancyStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "VacancyStatus"),
            new System.Data.OleDb.OleDbParameter("VacancyType", System.Data.OleDb.OleDbType.VarWChar, 0, "VacancyType"),
            new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Currency, 0, "Salary"),
            new System.Data.OleDb.OleDbParameter("EmployerID", System.Data.OleDb.OleDbType.Integer, 0, "EmployerID"),
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VacancyDescription", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VacancyDescription", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyDescription", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VacancyStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VacancyStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VacancyType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VacancyType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = resources.GetString("oleDbDeleteCommand6.CommandText");
            this.oleDbDeleteCommand6.Connection = this.ctnLGRAgency;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VacancyDescription", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VacancyDescription", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyDescription", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VacancyStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VacancyStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VacancyType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VacancyType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, null)});
            // 
            // daVacancy
            // 
            this.daVacancy.DeleteCommand = this.oleDbDeleteCommand6;
            this.daVacancy.InsertCommand = this.oleDbInsertCommand6;
            this.daVacancy.SelectCommand = this.oleDbSelectCommand6;
            this.daVacancy.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "VACANCY", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VacancyID", "VacancyID"),
                        new System.Data.Common.DataColumnMapping("VacancyDescription", "VacancyDescription"),
                        new System.Data.Common.DataColumnMapping("VacancyStatus", "VacancyStatus"),
                        new System.Data.Common.DataColumnMapping("VacancyType", "VacancyType"),
                        new System.Data.Common.DataColumnMapping("Salary", "Salary"),
                        new System.Data.Common.DataColumnMapping("EmployerID", "EmployerID")})});
            this.daVacancy.UpdateCommand = this.oleDbUpdateCommand6;
            this.daVacancy.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daVacancy_RowUpdated);
            // 
            // oleDbSelectCommand7
            // 
            this.oleDbSelectCommand7.CommandText = "SELECT        [Level], VacancyID, SkillID\r\nFROM            VACANCYSKILL\r\nORDER BY" +
    " VacancyID, SkillID";
            this.oleDbSelectCommand7.Connection = this.ctnLGRAgency;
            // 
            // oleDbInsertCommand7
            // 
            this.oleDbInsertCommand7.CommandText = "INSERT INTO `VACANCYSKILL` (`Level`, `VacancyID`, `SkillID`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand7.Connection = this.ctnLGRAgency;
            this.oleDbInsertCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Level", System.Data.OleDb.OleDbType.SmallInt, 0, "Level"),
            new System.Data.OleDb.OleDbParameter("VacancyID", System.Data.OleDb.OleDbType.Integer, 0, "VacancyID"),
            new System.Data.OleDb.OleDbParameter("SkillID", System.Data.OleDb.OleDbType.Integer, 0, "SkillID")});
            // 
            // oleDbUpdateCommand7
            // 
            this.oleDbUpdateCommand7.CommandText = "UPDATE `VACANCYSKILL` SET `Level` = ?, `VacancyID` = ?, `SkillID` = ? WHERE (((? " +
    "= 1 AND `Level` IS NULL) OR (`Level` = ?)) AND (`VacancyID` = ?) AND (`SkillID` " +
    "= ?))";
            this.oleDbUpdateCommand7.Connection = this.ctnLGRAgency;
            this.oleDbUpdateCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Level", System.Data.OleDb.OleDbType.SmallInt, 0, "Level"),
            new System.Data.OleDb.OleDbParameter("VacancyID", System.Data.OleDb.OleDbType.Integer, 0, "VacancyID"),
            new System.Data.OleDb.OleDbParameter("SkillID", System.Data.OleDb.OleDbType.Integer, 0, "SkillID"),
            new System.Data.OleDb.OleDbParameter("IsNull_Level", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Level", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Level", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Level", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand7
            // 
            this.oleDbDeleteCommand7.CommandText = "DELETE FROM `VACANCYSKILL` WHERE (((? = 1 AND `Level` IS NULL) OR (`Level` = ?)) " +
    "AND (`VacancyID` = ?) AND (`SkillID` = ?))";
            this.oleDbDeleteCommand7.Connection = this.ctnLGRAgency;
            this.oleDbDeleteCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("IsNull_Level", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Level", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Level", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Level", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null)});
            // 
            // daVacancySkill
            // 
            this.daVacancySkill.DeleteCommand = this.oleDbDeleteCommand7;
            this.daVacancySkill.InsertCommand = this.oleDbInsertCommand7;
            this.daVacancySkill.SelectCommand = this.oleDbSelectCommand7;
            this.daVacancySkill.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "VACANCYSKILL", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Level", "Level"),
                        new System.Data.Common.DataColumnMapping("VacancyID", "VacancyID"),
                        new System.Data.Common.DataColumnMapping("SkillID", "SkillID")})});
            this.daVacancySkill.UpdateCommand = this.oleDbUpdateCommand7;
            // 
            // dsLGRA
            // 
            this.dsLGRA.DataSetName = "LGRAgencyDBDataSet";
            this.dsLGRA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataController";
            this.Text = "DataController";
            ((System.ComponentModel.ISupportInitialize)(this.dsLGRA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection ctnLGRAgency;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter daApplication;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter daCandidate;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter daCandidateSkill;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
        private System.Data.OleDb.OleDbDataAdapter daEmployer;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
        private System.Data.OleDb.OleDbDataAdapter daSkill;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
        private System.Data.OleDb.OleDbDataAdapter daVacancy;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
        private System.Data.OleDb.OleDbDataAdapter daVacancySkill;
        public LGRAgencyDBDataSet dsLGRA;
    }
}