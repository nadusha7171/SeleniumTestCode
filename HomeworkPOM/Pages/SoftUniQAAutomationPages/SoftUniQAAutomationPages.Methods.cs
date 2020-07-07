using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.SoftUniQAAutomationPages
{
    public partial class SoftUniQAAutomationPages: BasePage
    {
        public SoftUniQAAutomationPages(WebDriver driver): base(driver)
        {
        }

        public override string Url => "https://softuni.bg";
    }
}
