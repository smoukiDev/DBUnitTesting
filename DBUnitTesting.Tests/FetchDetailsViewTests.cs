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
    public class FetchDetailsViewTests : SqlDatabaseTestClass
    {

        public FetchDetailsViewTests()
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
        public void FetchDetails_RetrieveCorrectRowCount()
        {
            SqlDatabaseTestActions testActions = this.FetchDetails_RetrieveCorrectRowCountData;
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction FetchDetails_RetrieveCorrectRowCount_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FetchDetailsViewTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition FetchDetailsRowCount;
            this.FetchDetails_RetrieveCorrectRowCountData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            FetchDetails_RetrieveCorrectRowCount_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            FetchDetailsRowCount = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // FetchDetails_RetrieveCorrectRowCount_TestAction
            // 
            FetchDetails_RetrieveCorrectRowCount_TestAction.Conditions.Add(FetchDetailsRowCount);
            resources.ApplyResources(FetchDetails_RetrieveCorrectRowCount_TestAction, "FetchDetails_RetrieveCorrectRowCount_TestAction");
            // 
            // FetchDetailsRowCount
            // 
            FetchDetailsRowCount.Enabled = true;
            FetchDetailsRowCount.Name = "FetchDetailsRowCount";
            FetchDetailsRowCount.ResultSet = 1;
            FetchDetailsRowCount.RowCount = 9;
            // 
            // FetchDetails_RetrieveCorrectRowCountData
            // 
            this.FetchDetails_RetrieveCorrectRowCountData.PosttestAction = null;
            this.FetchDetails_RetrieveCorrectRowCountData.PretestAction = null;
            this.FetchDetails_RetrieveCorrectRowCountData.TestAction = FetchDetails_RetrieveCorrectRowCount_TestAction;
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

        private SqlDatabaseTestActions FetchDetails_RetrieveCorrectRowCountData;
    }
}
