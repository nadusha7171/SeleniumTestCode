﻿using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.DragabblePages
{
    public partial class DragabblePages: BasePage
    {
        public DragabblePages(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://demoqa.com/dragabble";
    }
}
