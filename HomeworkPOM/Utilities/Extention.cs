using HomeworkPOM.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Utilities
{
    public static class Extention
    {
        public static WebElement ScrollTo(this WebElement element)
        {
            ((IJavaScriptExecutor)element.WrappedDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element.WrappedElement);
            return element;
        }

        public static WebElement ToBeVisible(this WebElement element)
        {
            var wait = new WebDriverWait(element.WrappedDriver, TimeSpan.FromSeconds(20));
            IWebElement nativeWebElement =
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element.By));

            return element;
        }
        public static string GetCssColor(this IWebElement element)
        {
            return element.GetCssValue("background-color");
        }

    }
}
