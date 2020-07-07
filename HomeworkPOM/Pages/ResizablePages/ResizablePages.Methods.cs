using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.ResizablePages
{
    public partial class ResizablePages : BasePage
    {
        public ResizablePages(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://demoqa.com/resizable";
    }
}
