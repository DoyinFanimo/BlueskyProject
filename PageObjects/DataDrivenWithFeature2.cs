using BlueSkyProject2.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyProject2.PageObjects
{
    class DataDrivenWithFeature2
    {
        IWebDriver driver;

        public DataDrivenWithFeature2()
        {
            driver = Hook.driver;
        }

        IWebElement multiSelect123 => driver.FindElement(By.CssSelector("#nf-field-137"));

        public void MultiSelect123(string option1, string option2)
        {
            SelectElement multiSelector = new SelectElement(multiSelect123);
            multiSelector.SelectByText(option1);
            multiSelector.SelectByText(option2);

        }
        IWebElement selectRadio => driver.FindElement(By.CssSelector("#nf-label-class-field-138-0"));

        public void SelectOneFromSelectRadio(string option)
        {
            selectRadio.Click();
        }

        IWebElement selectCountry => driver.FindElement(By.Id("nf-field-140"));

        public void SelectUkFromCountry(string option)
        {
            SelectElement country = new SelectElement(selectCountry);
            country.SelectByValue(option);
        }

        IWebElement multiSelectCheckList => driver.FindElement(By.CssSelector("#nf-field-139-wrap"));


        public void MultiSelectorCheckList()
        {
            multiSelectCheckList.FindElement(By.Id("nf-label-field-139-0")).Click();
            multiSelectCheckList.FindElement(By.Id("nf-label-field-139-1")).Click();
        }

        IWebElement selectDate => driver.FindElement(By.CssSelector("input.pikaday__display.pikaday__display--pikaday.ninja-forms-field.nf-element.datepicker"));

        internal void SelectDate(string date)
        {
            selectDate.FindElements(By.LinkText(date));

        }
    }
}
