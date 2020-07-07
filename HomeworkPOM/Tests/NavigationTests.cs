
using HomeworkPOM.Core;
using HomeworkPOM.Utilities;
using NUnit.Framework;

namespace HomeworkPOM.Tests
{
    public class NavigationTests : BaseTest
    {
        private HomePage _homePage;
        private DemoQAPage _demoQaPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _homePage = new HomePage(Driver);
            _demoQaPage = new DemoQAPage(Driver);
            _homePage.NaviteTo();
            _homePage.Maximize();
        }

        [Test]

      
        public void SuccessfullyPageLoaded_When_NavigateToDroppable()
        {
            _homePage.CategotyButton("Interactions").ScrollTo().Click();
            _demoQaPage.InteractionsButton.ScrollTo();
            
            _demoQaPage.SubMenu("Droppable").ScrollTo().Click();

            _demoQaPage.AssertPageTitle("Droppable");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
