using BlueSkyProject2.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject2.StepDefinitions
{
    [Binding]
    public class DataDrivenWithFeature2Steps
    {
        DataDrivenWithFeature2 dataDrivenWithFeature2;

        public DataDrivenWithFeature2Steps()
        {
            dataDrivenWithFeature2 = new DataDrivenWithFeature2();
        }

        [When(@"I select the Multi-Select ""(.*)"", ""(.*)""")]
        public void WhenISelectTheMulti_Select(string option1, string option2)
        {
            dataDrivenWithFeature2.MultiSelect123(option1, option2);

        }
        

        [When(@"I select in the Radio List ""(.*)""")]
        public void WhenISelectInTheRadioList(string option)
        {
            dataDrivenWithFeature2.SelectOneFromSelectRadio(option);
        }
        
        [When(@"I select the Checkbox List ""(.*)"", ""(.*)""")]
        public void WhenISelectTheCheckboxList(string option1, string option2)
        {
            dataDrivenWithFeature2.MultiSelectorCheckList();
        }
        
        [When(@"I select the Country ""(.*)""")]
        public void WhenISelectTheCountry(string option)
        {
            dataDrivenWithFeature2.SelectUkFromCountry(option);
        }
        
        [When(@"I select ""(.*)"" of the current month")]
        public void WhenISelectOfTheCurrentMonth(string date)
        {
            dataDrivenWithFeature2.SelectDate(date);
        }
    }
}
