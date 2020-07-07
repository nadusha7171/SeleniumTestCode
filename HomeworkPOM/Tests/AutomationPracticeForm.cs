using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using HomeworkPOM.Pages.AutomationPracticeFormPages;
using HomeworkPOM.Utilities;
using NUnit.Framework.Interfaces;
using System.IO;

namespace HomeworkPOM.Tests
{
    [TestFixture]
    public class AutomationPracticeForm: BaseTest
    {
        private AutomationPracticeFormPages _automationPracticeFormPages;
        [SetUp]

        public void Setup()
        {
            Initialize();
            _automationPracticeFormPages = new AutomationPracticeFormPages(Driver);
            _automationPracticeFormPages.NaviteTo();
            _automationPracticeFormPages.Maximize();

        }
        [Test]
        public void CheckError_WhenSubmitInvalidFirstName()
        {
            _automationPracticeFormPages.ReachRegistrationForm();

            var user = UserFactory.CreateValidUser();
            user.FirstName = "24342454345435";
            _automationPracticeFormPages.FillForm(user);

            String expectedError = "firstname is invalid.";


            Assert.IsTrue(_automationPracticeFormPages.CheckErrors(expectedError));
        }

        [Test]
        public void CheckError_WhenSubmitWithoutAllias()
        {
            var user = UserFactory.CreateValidUser();
            String expectedError = "alias is required.";
            _automationPracticeFormPages.ReachRegistrationForm();

            
            _automationPracticeFormPages.Allias.ScrollTo().Clear();
            user.Alias = string.Empty;
            _automationPracticeFormPages.FillForm(user);


            Assert.IsTrue(_automationPracticeFormPages.CheckErrors(expectedError));
        }

        [Test]
        public void CheckError_WhenSubmitWithoutCountry()
        {
            var user = UserFactory.CreateValidUser();
            String expectedError = "Country cannot be loaded with address->id_country";
            _automationPracticeFormPages.ReachRegistrationForm();

            _automationPracticeFormPages.Country.ScrollTo();
            user.Country = "-";
            _automationPracticeFormPages.FillForm(user);


            Assert.IsTrue(_automationPracticeFormPages.CheckErrors(expectedError));
        }

        [Test]
        public void CheckError_WhenSubmitWithInvalidPassword()
        {
            var user = UserFactory.CreateValidUser();
            String expectedError = "passwd is invalid.";
            _automationPracticeFormPages.ReachRegistrationForm();

            user.Password = "1234";
            _automationPracticeFormPages.FillForm(user);


            Assert.IsTrue(_automationPracticeFormPages.CheckErrors(expectedError));
        }

        [Test]
        public void CheckError_WhenSubmitWithInvalidZipCode()
        {
            var user = UserFactory.CreateValidUser();
            String expectedError = "The Zip/Postal code you've entered is invalid. It must follow this format: 00000";
            _automationPracticeFormPages.ReachRegistrationForm();

            user.PostCode = "3678364876487";
            _automationPracticeFormPages.FillForm(user);


            Assert.IsTrue(_automationPracticeFormPages.CheckErrors(expectedError));
        }

    }
}
