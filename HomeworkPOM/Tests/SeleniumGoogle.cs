using HomeworkPOM.Pages.SeleniumGooglePages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HomeworkPOM.Tests
{
    [TestFixture]
    public class SeleniumGoogle : BaseTest
    {
        private SeleniumGooglePages _seleniumGooglePages;


        [SetUp]
        public void Setup()
        {
            Initialize();
            _seleniumGooglePages = new SeleniumGooglePages(Driver);
            _seleniumGooglePages.NaviteTo();
            _seleniumGooglePages.Maximize();
        }

        [Test]

        public void FindSelenium_WhenWriteInGoogle()
        {
            _seleniumGooglePages.GoToSearchArea.SetText("selenium");
            _seleniumGooglePages.GoToSearchArea.Submit();

            _seleniumGooglePages.ClickFirstResult.Click();

            Assert.AreEqual("https://www.selenium.dev/", Driver.WrappedDriver.Url);

        }
        [Test]
        public void SearchSeleniumInGoogleTitle()
        {
            _seleniumGooglePages.GoToSearchArea.SetText("selenium");
            _seleniumGooglePages.GoToSearchArea.Submit();

            _seleniumGooglePages.ClickFirstResult.Click();

            Assert.AreEqual("SeleniumHQ Browser Automation", Driver.WrappedDriver.Title);

        }

    }
}
