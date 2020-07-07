using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.SelectablePages
{
    public partial class SelectablePages: BasePage
    {
        public WebElement SecondOption => Driver.FindElement(By.XPath("//*[@id='verticalListContainer']//li[2]"));

        public WebElement GridButton => Driver.FindElement(By.Id("demo-tab-grid"));

        public WebElement NumberFive => Driver.FindElement(By.XPath("//*[@class='grid-container mt-4']//*[@id='row1']//li[2]"));



    }
}
