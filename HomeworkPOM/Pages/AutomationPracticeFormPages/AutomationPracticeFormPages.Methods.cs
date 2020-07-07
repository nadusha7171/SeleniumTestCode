using HomeworkPOM.Core;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkPOM.Pages.AutomationPracticeFormPages
{
    public partial class AutomationPracticeFormPages: BasePage
    {
        public AutomationPracticeFormPages(WebDriver driver): base(driver)
        {

        }

        public override string Url => "http://automationpractice.com/index.php?controller=authentication";

        public void ReachRegistrationForm()
        {
            string expectedEmail = "vsxcsn@mai.bg";

            EmailAddressTextField.SetText(expectedEmail);

            CreateAnAccountButton.Click();
        }

        public Boolean CheckErrors(string expectedError)
        {
            bool checkError = false;
            List<WebElement> list = Driver.FindElements(By.CssSelector("#center_column > div li")).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (expectedError == list[i].Text)
                {
                    checkError = true;
                }
            }
            return checkError;
        }
    }

   
}
