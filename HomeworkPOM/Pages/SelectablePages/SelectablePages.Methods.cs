using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.SelectablePages
{
    public partial class SelectablePages: BasePage
    {
        public SelectablePages(WebDriver driver): base(driver)
        {
        }

        public override string Url => "http://demoqa.com/selectable";
    }
}
