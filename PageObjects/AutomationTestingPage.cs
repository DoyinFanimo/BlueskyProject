using System;
using System.Collections.Generic;
using System.Text;
using BlueSkyProject2.Hooks;
using BlueSkyProject2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BlueSkyProject2.PageObjects
{
    class AutomationTestingPage
    {

        IWebDriver driver;

        Waits waits;

        IWebElement singleLineText => driver.FindElement(By.Id("nf-field-135"));

        IWebElement selectOneTwoThree => driver.FindElement(By.Id("nf-field-136"));

        IWebElement enterEmail => driver.FindElement(By.Name("email"));

        IWebElement multiSelect123 => driver.FindElement(By.CssSelector("#nf-field-137"));

        IWebElement enterPassword => driver.FindElement(By.Id("nf-field-144"));

        IWebElement selectRadio => driver.FindElement(By.CssSelector("#nf-label-class-field-138-0"));

        IWebElement multiSelectCheckList => driver.FindElement(By.CssSelector("#nf-field-139-wrap")); 

        IWebElement selectCountry => driver.FindElement(By.Id("nf-field-140"));

        IWebElement selectDate => driver.FindElement(By.CssSelector("input.pikaday__display.pikaday__display--pikaday.ninja-forms-field.nf-element.datepicker"));

        IWebElement clickSubmit => driver.FindElement(By.Id("nf-field-133"));

        IWebElement errorMsg => driver.FindElement(By.CssSelector("#nf-form-errors-9 > nf-errors > nf-section > div"));

        IWebElement validMsg => driver.FindElement(By.CssSelector("#nf-form-9-cont > div > div.nf-response-msg"));

        public void ValidateForm()
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(singleLineText.Displayed);
                Assert.IsTrue(enterEmail.Displayed);
                Assert.IsTrue(selectOneTwoThree.Displayed);
            });
        }
        public void EnterSingleLineText(string text)
        {
            singleLineText.SendKeys(text);
        }
        public void EnterPassword(string password)
        {
            enterPassword.SendKeys(password);
        }

        public void SelectAnOption(string option)
        {
            SelectElement select = new SelectElement(selectOneTwoThree);
            select.SelectByValue(option);
        }
        /* public string GetValidMsg()
         {
             return waits.WaitForElement(driver, validMsg).Text;
         }*/

        public string GetPageTitle => driver.Title;

        public string GetPageUrl => driver.Url;

        public void CheckErrorMsg()
        {
            Assert.IsTrue(errorMsg.Displayed);
        }

        public string GetTextForError()
        {
           return waits.WaitForElement(driver, errorMsg).Text;
        }

        public void SelectClickSubmit()
        {
            clickSubmit.Click();
        }

        public void SelectDateFromCalendar()
        {
            selectDate.SendKeys("12/02/2020");      
        }

        public void SelectUkFromCountry()
        {
            SelectElement country = new SelectElement(selectCountry);
            country.SelectByValue("GB");
        }


        public void MultiSelectorCheckList()
        {
            multiSelectCheckList.FindElement(By.Id("nf-label-field-139-0")).Click();
            multiSelectCheckList.FindElement(By.Id("nf-label-field-139-1")).Click();
        }

        public void SelectOneFromSelectRadio()
        {
            selectRadio.Click();
        }

        public void MultiSelector123()
        {
            SelectElement multiSelector = new SelectElement(multiSelect123);
            multiSelector.SelectByText("Two");
            multiSelector.SelectByText("Three");
        }

        public void EnterEmailTxt()
        {
            enterEmail.SendKeys("mclight07@hotmail.co.uk");
           
        }
        public void EnterEmail(string email)
        {
           enterEmail.SendKeys(email);
        }
        public void SelectOneFromSelectOneTwoThree()
        {
            SelectElement select = new SelectElement(selectOneTwoThree);
            select.SelectByValue("one");
        }

        public void EnterSingleLineText()
        {
            singleLineText.SendKeys("Doyin");
        }

        public AutomationTestingPage()
        {
            driver = Hook.driver;
            waits = new Waits();
        }

        public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("https://blueskycitadel.com/automation-testing-form/");
            
        }

        public void NavigateToForm(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
