using BlueSkyProject2.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject2.StepDefinitions
{
    [Binding]
    public class DataDrivenWithFeatureSteps
    {
        AutomationTestingPage automationTestingPage;

        public DataDrivenWithFeatureSteps()
        {
            automationTestingPage = new AutomationTestingPage();
        }

        [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            automationTestingPage.NavigateToForm(url);
        }

        [When(@"I enter the Single Line Text ""(.*)""")]
        public void WhenIEnterTheSingleLineText(string text)
        {
            automationTestingPage.EnterSingleLineText(text);
            
        }

        [When(@"I select an option in the Select box ""(.*)""")]
        public void WhenISelectAnOptionInTheSelectBox(string option)
        {
            automationTestingPage.SelectAnOption(option);
        }


        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            automationTestingPage.EnterEmail(email);
        }
        
        [When(@"i enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            automationTestingPage.EnterPassword(password);
        }
        
        [When(@"i click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            
        }
        
        [Then(@"the form is submitted")]
        public void ThenTheFormIsSubmitted()
        {
            // Assert.AreEqual(, automationTestingPage.GetSingleLineTxt());
            automationTestingPage.ValidateForm();
        }
    }
}
