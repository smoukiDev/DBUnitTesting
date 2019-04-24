using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DBUnitTesting.Tests
{
    [TestClass()]
    public class SubDepartmentTableTests : SqlDatabaseTestClass
    {

        public SubDepartmentTableTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        [TestMethod()]
        public void Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTable()
        {
            SqlDatabaseTestActions testActions = this.Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTableData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTable_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubDepartmentTableTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition SubDepartmentLogRowCount;
            this.Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTableData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTable_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            SubDepartmentLogRowCount = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTableData
            // 
            this.Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTableData.PosttestAction = null;
            this.Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTableData.PretestAction = null;
            this.Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTableData.TestAction = Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTable_TestAction;
            // 
            // Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTable_TestAction
            // 
            Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTable_TestAction.Conditions.Add(SubDepartmentLogRowCount);
            resources.ApplyResources(Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTable_TestAction, "Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTable_TestAction");
            // 
            // SubDepartmentLogRowCount
            // 
            SubDepartmentLogRowCount.Enabled = true;
            SubDepartmentLogRowCount.Name = "SubDepartmentLogRowCount";
            SubDepartmentLogRowCount.ResultSet = 1;
            SubDepartmentLogRowCount.RowCount = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        private SqlDatabaseTestActions Trigger_SubDepartment_Update_InsertsLogRecordToSubDepartmentLogTableData;
    }
}
