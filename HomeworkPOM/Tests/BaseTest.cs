using HomeworkPOM.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace HomeworkPOM.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected WebDriver Driver { get; set; }

        protected Actions Builder { get; set; }

        protected WebDriverWait Wait { get; set; }


        public void Initialize()
        {
            Driver = new WebDriver();
            Driver.Start(Browser.Chrome);
            Builder = new Actions(Driver.WrappedDriver);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }
    }
}
