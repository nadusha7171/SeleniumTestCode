using HomeworkPOM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Pages.DragabblePages
{
    public partial class DragabblePages: BasePage
    {
        public WebElement DragMeBoxSimple => Driver.FindElement(By.XPath("//*[@id='draggableExample-tabpane-simple']//div"));

        public WebElement AxisRestrictedSection => Driver.FindElement(By.XPath("//*[@class='nav nav-tabs']//a[2]"));

        public WebElement OnlyYBoxAxisRestriction => Driver.FindElement(By.Id("restrictedY"));
        public WebElement ContainerRestrictedSection => Driver.FindElement(By.XPath("//*[@class='nav nav-tabs']//a[3]"));

        public WebElement DragabbleBoxConteinerRestricted => Driver.FindElement(By.CssSelector(".draggable.ui-widget-content.ui-draggable.ui-draggable-handle"));
        
        public WebElement ContainerInConteinerRestricted => Driver.FindElement(By.Id("containmentWrapper"));

    }
}
