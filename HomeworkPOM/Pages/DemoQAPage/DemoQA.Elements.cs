using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM
{
    public partial class DemoQAPage: BasePage
    {
        protected WebElement LeftPanel => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));

        public WebElement InteractionsButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text())='Interactions']"));

        public WebElement SubMenu(string subName) => LeftPanel.FindElement(By.XPath($".//*[normalize-space(text())='{subName}']"));

        public WebElement PageTitle => Driver.FindElement(By.ClassName("main-header"));
    }
}
