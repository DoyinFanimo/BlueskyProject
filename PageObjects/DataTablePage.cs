using BlueSkyProject2.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;



namespace BlueSkyProject2.PageObjects
{
    class DataTablePage
    {
        IWebDriver driver;

        IWebElement enterEmail => driver.FindElement(By.CssSelector("#nf-field-124"));

        IWebElement enterPassword => driver.FindElement(By.Id("nf-field-144"));

        public DataTablePage()
        {
            driver = Hook.driver;
        }

        public void EnterEmailAndPassword(string email, string password)
        {
            enterEmail.SendKeys(email);
            enterPassword.SendKeys(password);
        }
    }
}
