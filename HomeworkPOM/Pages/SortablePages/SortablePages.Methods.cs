using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.SortablePages
{
    public partial class SortablePages: BasePage
    {
        public SortablePages(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://demoqa.com/sortable";
    }
}

