using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.ResizablePages
{
    public partial class ResizablePages: BasePage
    {
        public WebElement MouseDragFirstBox => Driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']/span"));
        
        public WebElement BoxBeforeFirstBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));

        public WebElement BoxBelow => Driver.FindElement(By.Id("resizable"));

        public WebElement MouseDragBelow => Driver.FindElement(By.XPath("//*[@class='resizable-nolimit mt-4']//span"));

    }
}
