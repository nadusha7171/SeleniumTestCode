using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.SortablePages
{
    public partial class SortablePages : BasePage
    {
        public WebElement TargetBoxList => Driver.FindElement(By.CssSelector(".list-group-item.list-group-item-action:nth-child(3)"));

        public WebElement SourceBoxList => Driver.FindElement(By.CssSelector(".list-group-item.list-group-item-action:nth-child(1)"));

        public WebElement GridButton => Driver.FindElement(By.Id("demo-tab-grid"));

        public WebElement SourceBoxGrid => Driver.FindElement(By.XPath("//*[@class='grid-container mt-4']//div[5]"));

        public WebElement TargetBoxGrid => Driver.FindElement(By.XPath("//*[@class='grid-container mt-4']//div[8]"));

    }
}
