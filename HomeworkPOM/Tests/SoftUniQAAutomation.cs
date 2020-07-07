using HomeworkPOM.Pages.SoftUniQAAutomationPages;
using HomeworkPOM.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA;
using OpenQA.Selenium;

namespace HomeworkPOM.Tests
{
    [TestFixture]
    public class SoftUniQAAutomation : BaseTest
    {
        private SoftUniQAAutomationPages _softUniQAAutomationPages;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _softUniQAAutomationPages = new SoftUniQAAutomationPages(Driver);
            _softUniQAAutomationPages.NaviteTo();
            _softUniQAAutomationPages.Maximize();
        }
        [Test]
        public void SoftUniContainsQACourse()
        {
            _softUniQAAutomationPages.GoToObucheniaPage.ScrollTo().Click();

            _softUniQAAutomationPages.OpenActiveCourse.ScrollTo().Click();

            _softUniQAAutomationPages.QAAutomationCourse.Click();


            Assert.That(_softUniQAAutomationPages.HeaderElement.Text.Contains("QA Automation - май 2020"));

        }
    }
}
