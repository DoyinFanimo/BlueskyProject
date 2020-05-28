using BlueSkyProject2.PageObjects;
using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BlueSkyProject2.StepDefinitions
{
    [Binding]
    public class BlueSkyCitadelFormSteps
    {
        AutomationTestingPage automationTestingPage;

        public BlueSkyCitadelFormSteps()
        {
            automationTestingPage = new AutomationTestingPage();
        }

        [Given(@"I navigate to the blueskycitadel website")]
        public void GivenINavigateToTheBlueskycitadelWebsite()
        {

        }
        
        [Given(@"I select automation testing form")]
        public void GivenISelectAutomationTestingForm()
        {
            automationTestingPage.NavigateToForm();
        }
        
        [When(@"I enter the Single Line Text")]
        public void WhenIEnterTheSingleLineText()
        {
            automationTestingPage.EnterSingleLineText();
        }
        
        [When(@"I select One in the Select box")]
        public void WhenISelectOneInTheSelectBox()
        {
            automationTestingPage.SelectOneFromSelectOneTwoThree();
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            automationTestingPage.EnterEmailTxt();
        }
        
        [When(@"I select the Multi-Select")]
        public void WhenISelectTheMulti_Select()
        {
            automationTestingPage.MultiSelector123();
        }
        
        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {
            automationTestingPage.SelectOneFromSelectRadio();
        }
        
        [When(@"I select the Checkbox List")]
        public void WhenISelectTheCheckboxList()
        {
            automationTestingPage.MultiSelectorCheckList();
        }
        
        [When(@"I select the United Kingdom as Country")]
        public void WhenISelectTheUnitedKingdomAsCountry()
        {
            automationTestingPage.SelectUkFromCountry();
        }
        
        [When(@"I select (.*)th of the current month")]
        public void WhenISelectThOfTheCurrentMonth(int p0)
        {
            automationTestingPage.SelectDateFromCalendar();
        }
        
        [When(@"I click on the submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            automationTestingPage.SelectClickSubmit();
        }


        [Then(@"the error message ""(.*)""")]
        public void ThenTheErrorMessage(string errMsg)
        {
            automationTestingPage.CheckErrorMsg();
            Assert.AreEqual(errMsg, automationTestingPage.GetTextForError());
        }

        [Then(@"the page url is ""(.*)""")]
        public void ThenThePageUrlIs(string url)
        {
            Assert.AreEqual(url, automationTestingPage.GetPageUrl);
            url.Should().Be(automationTestingPage.GetPageUrl);
        }


        [Then(@"the message ""(.*)"" should be displayed")]
        public void ThenTheMessageShouldBeDisplayed(string validMsg)
        {
           // Assert.AreEqual(validMsg, automationTestingPage.GetValidMsg());
        }
    }
}
