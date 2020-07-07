using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM
{
    public partial class DroppablePages : BasePage
    {
        public DroppablePages(WebDriver driver)
            : base(driver)
        {
        }
            
        public override string Url => "http://demoqa.com/droppable";
    }
}