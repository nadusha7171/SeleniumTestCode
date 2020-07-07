using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.SeleniumGooglePages
{
    public partial class SeleniumGooglePages
    {
        public WebElement GoToSearchArea => Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));

        public WebElement ClickFirstResult => Driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div[1]/a"));
    }
}
