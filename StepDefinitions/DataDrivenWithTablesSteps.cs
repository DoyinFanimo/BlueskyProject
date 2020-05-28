using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using BlueSkyProject2;
using BlueSkyProject2.PageObjects;

namespace BlueSkyProject2.StepDefinitions
{
    [Binding]
    public class DataDrivenWithTablesSteps
    {
        DataTablePage dataTablePage;

        public DataDrivenWithTablesSteps()
        {
            dataTablePage = new DataTablePage();
        }

        [When(@"I enter email and password")]
        public void WhenIEnterEmailAndPassword(Table table)
        {
            var emailAndPassword = table.CreateInstance<Details>();

            string email = emailAndPassword.Email;
            string password = emailAndPassword.Password;

            dataTablePage.EnterEmailAndPassword(email, password);
        }
    }
}
