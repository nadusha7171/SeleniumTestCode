using AutoFixture.Kernel;
using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.SoftUniQAAutomationPages
{
    public partial class SoftUniQAAutomationPages: BasePage
    {
        public WebElement GoToObucheniaPage => Driver.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li:nth-child(2) > a > span"));

        public WebElement OpenActiveCourse => Driver.FindElement(By.XPath("//*[@class='category-title sub uppercase my-collapsible-header'][normalize-space(text())='Активни курсове']"));

        public WebElement QAAutomationCourse => Driver.FindElement(By.XPath("//*[@class='my-collapsible-body']//*[normalize-space(text())='QA Automation - май 2020']"));

        public WebElement HeaderElement => Driver.FindElement(By.XPath("//*[@class='lead-header image-background']//h1"));
    }
}
