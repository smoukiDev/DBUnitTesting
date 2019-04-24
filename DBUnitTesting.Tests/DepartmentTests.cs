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
    public class DepartmentTests : SqlDatabaseTestClass
    {

        public DepartmentTests()
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
        public void SaveDepartment_AddOneDepartmentToTable()
        {
            SqlDatabaseTestActions testActions = this.SaveDepartment_AddOneDepartmentToTableData;
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SaveDepartment_AddOneDepartmentToTable_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SaveDepartment_AddOneDepartmentToTable_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition executionTimeCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SaveDepartment_AddOneDepartmentToTable_PosttestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            this.SaveDepartment_AddOneDepartmentToTableData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            SaveDepartment_AddOneDepartmentToTable_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            SaveDepartment_AddOneDepartmentToTable_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            executionTimeCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition();
            SaveDepartment_AddOneDepartmentToTable_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // SaveDepartment_AddOneDepartmentToTableData
            // 
            this.SaveDepartment_AddOneDepartmentToTableData.PosttestAction = SaveDepartment_AddOneDepartmentToTable_PosttestAction;
            this.SaveDepartment_AddOneDepartmentToTableData.PretestAction = SaveDepartment_AddOneDepartmentToTable_PretestAction;
            this.SaveDepartment_AddOneDepartmentToTableData.TestAction = SaveDepartment_AddOneDepartmentToTable_TestAction;
            // 
            // SaveDepartment_AddOneDepartmentToTable_PretestAction
            // 
            SaveDepartment_AddOneDepartmentToTable_PretestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(SaveDepartment_AddOneDepartmentToTable_PretestAction, "SaveDepartment_AddOneDepartmentToTable_PretestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 6;
            // 
            // SaveDepartment_AddOneDepartmentToTable_TestAction
            // 
            SaveDepartment_AddOneDepartmentToTable_TestAction.Conditions.Add(executionTimeCondition1);
            resources.ApplyResources(SaveDepartment_AddOneDepartmentToTable_TestAction, "SaveDepartment_AddOneDepartmentToTable_TestAction");
            // 
            // executionTimeCondition1
            // 
            executionTimeCondition1.Enabled = true;
            executionTimeCondition1.ExecutionTime = System.TimeSpan.Parse("00:00:01");
            executionTimeCondition1.Name = "executionTimeCondition1";
            // 
            // SaveDepartment_AddOneDepartmentToTable_PosttestAction
            // 
            SaveDepartment_AddOneDepartmentToTable_PosttestAction.Conditions.Add(rowCountCondition2);
            resources.ApplyResources(SaveDepartment_AddOneDepartmentToTable_PosttestAction, "SaveDepartment_AddOneDepartmentToTable_PosttestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 7;
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

        private SqlDatabaseTestActions SaveDepartment_AddOneDepartmentToTableData;
    }
}
