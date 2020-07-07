using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HomeworkPOM.Core;

namespace HomeworkPOM
{
    public partial class DroppablePages: BasePage
    { 
        public WebElement RevertDraggable => Driver.FindElement(By.XPath("//*[@class='nav nav-tabs']//a[4]"));

        public WebElement WillRevertBox => Driver.FindElement(By.XPath("//*[@class='revertable-drop-container']/div//*[contains(@id, 'revertable')]"));

        public WebElement TargetBox => Driver.FindElement(By.XPath("//*[@class='revertable-drop-container']//*[@class='drop-box ui-droppable']"));

        public WebElement DragMeBoxSimpleSection => Driver.FindElement(By.XPath("//*[@class='simple-drop-container']//div[1]"));

        public WebElement TragetBoxSimpleSection => Driver.FindElement(By.XPath("//*[@class='simple-drop-container']//div[2]"));

        public WebElement PreventPropogation => Driver.FindElement(By.XPath("//*[@class='nav nav-tabs']//a[3]"));

        public WebElement DragMeBoxPreventPropogation => Driver.FindElement(By.Id("dragBox"));

        public WebElement TargetBoxPreventPropogation => Driver.FindElement(By.Id("notGreedyDropBox"));


    }
}
