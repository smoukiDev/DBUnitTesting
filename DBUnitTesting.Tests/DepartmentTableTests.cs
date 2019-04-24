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
        public void Procedure_SaveDepartment_AddOneDepartmentToTable()
        {
            SqlDatabaseTestActions testActions = this.Procedure_SaveDepartment_AddOneDepartmentToTableData;
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
        public void Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstring()
        {
            SqlDatabaseTestActions testActions = this.Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstringData;
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Procedure_SaveDepartment_AddOneDepartmentToTable_PretestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentTableTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Procedure_SaveDepartment_AddOneDepartmentToTable_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition executionTimeCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Procedure_SaveDepartment_AddOneDepartmentToTable_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstring_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition GetSearchTermCountScalarValueCondition;
            this.Procedure_SaveDepartment_AddOneDepartmentToTableData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstringData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Procedure_SaveDepartment_AddOneDepartmentToTable_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Procedure_SaveDepartment_AddOneDepartmentToTable_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            executionTimeCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition();
            Procedure_SaveDepartment_AddOneDepartmentToTable_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstring_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            GetSearchTermCountScalarValueCondition = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // Procedure_SaveDepartment_AddOneDepartmentToTable_PretestAction
            // 
            Procedure_SaveDepartment_AddOneDepartmentToTable_PretestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(Procedure_SaveDepartment_AddOneDepartmentToTable_PretestAction, "Procedure_SaveDepartment_AddOneDepartmentToTable_PretestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 6;
            // 
            // Procedure_SaveDepartment_AddOneDepartmentToTable_TestAction
            // 
            Procedure_SaveDepartment_AddOneDepartmentToTable_TestAction.Conditions.Add(executionTimeCondition1);
            resources.ApplyResources(Procedure_SaveDepartment_AddOneDepartmentToTable_TestAction, "Procedure_SaveDepartment_AddOneDepartmentToTable_TestAction");
            // 
            // executionTimeCondition1
            // 
            executionTimeCondition1.Enabled = true;
            executionTimeCondition1.ExecutionTime = System.TimeSpan.Parse("00:00:01");
            executionTimeCondition1.Name = "executionTimeCondition1";
            // 
            // Procedure_SaveDepartment_AddOneDepartmentToTable_PosttestAction
            // 
            Procedure_SaveDepartment_AddOneDepartmentToTable_PosttestAction.Conditions.Add(rowCountCondition2);
            resources.ApplyResources(Procedure_SaveDepartment_AddOneDepartmentToTable_PosttestAction, "Procedure_SaveDepartment_AddOneDepartmentToTable_PosttestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 7;
            // 
            // Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstring_TestAction
            // 
            Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstring_TestAction.Conditions.Add(GetSearchTermCountScalarValueCondition);
            resources.ApplyResources(Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstring_TestAction, "Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstring_TestAction" +
                    "");
            // 
            // GetSearchTermCountScalarValueCondition
            // 
            GetSearchTermCountScalarValueCondition.ColumnNumber = 1;
            GetSearchTermCountScalarValueCondition.Enabled = true;
            GetSearchTermCountScalarValueCondition.ExpectedValue = "2";
            GetSearchTermCountScalarValueCondition.Name = "GetSearchTermCountScalarValueCondition";
            GetSearchTermCountScalarValueCondition.NullExpected = false;
            GetSearchTermCountScalarValueCondition.ResultSet = 1;
            GetSearchTermCountScalarValueCondition.RowNumber = 1;
            // 
            // Procedure_SaveDepartment_AddOneDepartmentToTableData
            // 
            this.Procedure_SaveDepartment_AddOneDepartmentToTableData.PosttestAction = Procedure_SaveDepartment_AddOneDepartmentToTable_PosttestAction;
            this.Procedure_SaveDepartment_AddOneDepartmentToTableData.PretestAction = Procedure_SaveDepartment_AddOneDepartmentToTable_PretestAction;
            this.Procedure_SaveDepartment_AddOneDepartmentToTableData.TestAction = Procedure_SaveDepartment_AddOneDepartmentToTable_TestAction;
            // 
            // Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstringData
            // 
            this.Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstringData.PosttestAction = null;
            this.Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstringData.PretestAction = null;
            this.Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstringData.TestAction = Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstring_TestAction;
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

        private SqlDatabaseTestActions Procedure_SaveDepartment_AddOneDepartmentToTableData;
        private SqlDatabaseTestActions Function_GetSearchTermCount_FindsDepartmentsWhichNameContainsSubstringData;
    }
}
