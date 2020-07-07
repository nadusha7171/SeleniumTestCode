using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.SeleniumGooglePages
{
    public partial class SeleniumGooglePages : BasePage
    {
        public SeleniumGooglePages(WebDriver driver) : base(driver)
        {

        }

        public override string Url => "http://google.com";
    }
}
