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
    public class DepartmentTableTests : SqlDatabaseTestClass
    {

        public DepartmentTableTests()
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
        public void Proc_SaveDepartment_AddOneDepartmentToTable()
        {
            SqlDatabaseTestActions testActions = this.Proc_SaveDepartment_AddOneDepartmentToTableData;
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
        [TestMethod()]
        public void Func_GetSearchTermCount_SuccessfullyFindsDepartments()
        {
            SqlDatabaseTestActions testActions = this.Func_GetSearchTermCount_SuccessfullyFindsDepartmentsData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }


        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Proc_SaveDepartment_AddOneDepartmentToTable_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Proc_SaveDepartment_AddOneDepartmentToTable_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition executionTimeCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Proc_SaveDepartment_AddOneDepartmentToTable_PosttestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentTableTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Func_GetSearchTermCount_SuccessfullyFindsDepartments_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            this.Proc_SaveDepartment_AddOneDepartmentToTableData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Func_GetSearchTermCount_SuccessfullyFindsDepartmentsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Proc_SaveDepartment_AddOneDepartmentToTable_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Proc_SaveDepartment_AddOneDepartmentToTable_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            executionTimeCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition();
            Proc_SaveDepartment_AddOneDepartmentToTable_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Func_GetSearchTermCount_SuccessfullyFindsDepartments_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // Proc_SaveDepartment_AddOneDepartmentToTableData
            // 
            this.Proc_SaveDepartment_AddOneDepartmentToTableData.PosttestAction = Proc_SaveDepartment_AddOneDepartmentToTable_PosttestAction;
            this.Proc_SaveDepartment_AddOneDepartmentToTableData.PretestAction = Proc_SaveDepartment_AddOneDepartmentToTable_PretestAction;
            this.Proc_SaveDepartment_AddOneDepartmentToTableData.TestAction = Proc_SaveDepartment_AddOneDepartmentToTable_TestAction;
            // 
            // Proc_SaveDepartment_AddOneDepartmentToTable_PretestAction
            // 
            Proc_SaveDepartment_AddOneDepartmentToTable_PretestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(Proc_SaveDepartment_AddOneDepartmentToTable_PretestAction, "Proc_SaveDepartment_AddOneDepartmentToTable_PretestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 6;
            // 
            // Proc_SaveDepartment_AddOneDepartmentToTable_TestAction
            // 
            Proc_SaveDepartment_AddOneDepartmentToTable_TestAction.Conditions.Add(executionTimeCondition1);
            resources.ApplyResources(Proc_SaveDepartment_AddOneDepartmentToTable_TestAction, "Proc_SaveDepartment_AddOneDepartmentToTable_TestAction");
            // 
            // executionTimeCondition1
            // 
            executionTimeCondition1.Enabled = true;
            executionTimeCondition1.ExecutionTime = System.TimeSpan.Parse("00:00:01");
            executionTimeCondition1.Name = "executionTimeCondition1";
            // 
            // Proc_SaveDepartment_AddOneDepartmentToTable_PosttestAction
            // 
            Proc_SaveDepartment_AddOneDepartmentToTable_PosttestAction.Conditions.Add(rowCountCondition2);
            resources.ApplyResources(Proc_SaveDepartment_AddOneDepartmentToTable_PosttestAction, "Proc_SaveDepartment_AddOneDepartmentToTable_PosttestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 7;
            // 
            // Func_GetSearchTermCount_SuccessfullyFindsDepartmentsData
            // 
            this.Func_GetSearchTermCount_SuccessfullyFindsDepartmentsData.PosttestAction = null;
            this.Func_GetSearchTermCount_SuccessfullyFindsDepartmentsData.PretestAction = null;
            this.Func_GetSearchTermCount_SuccessfullyFindsDepartmentsData.TestAction = Func_GetSearchTermCount_SuccessfullyFindsDepartments_TestAction;
            // 
            // Func_GetSearchTermCount_SuccessfullyFindsDepartments_TestAction
            // 
            Func_GetSearchTermCount_SuccessfullyFindsDepartments_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(Func_GetSearchTermCount_SuccessfullyFindsDepartments_TestAction, "Func_GetSearchTermCount_SuccessfullyFindsDepartments_TestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "2";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
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

        private SqlDatabaseTestActions Proc_SaveDepartment_AddOneDepartmentToTableData;
        private SqlDatabaseTestActions Func_GetSearchTermCount_SuccessfullyFindsDepartmentsData;
    }
}
