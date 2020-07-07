using HomeworkPOM.Pages.SelectablePages;
using HomeworkPOM.Utilities;
using NUnit.Framework;

namespace HomeworkPOM.Tests
{
    [TestFixture]
    public class Selectable: BaseTest
    {
        private SelectablePages _selectablePages;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectablePages = new SelectablePages(Driver);
            _selectablePages.NaviteTo();
            _selectablePages.Maximize();
        }

        [Test]

        public void ChangeColor_WhenSelectTheSecondOption()
        {
            var colorBefore = _selectablePages.SecondOption.WrappedElement.GetCssValue("background-color");
            
            _selectablePages.SecondOption.Click();

            Assert.AreNotEqual(colorBefore, _selectablePages.SecondOption.WrappedElement.GetCssValue("background-color"));

        }

        [Test]
        public void DoesNotChangeColorNumerFive_WhenSelectNumberTwo()
        {
            _selectablePages.GridButton.Click();
            var colorBefore = "rgba(0, 123, 255, 1)";

            _selectablePages.NumberFive.Click();

            Assert.AreEqual(colorBefore, _selectablePages.NumberFive.WrappedElement.GetCssColor());
        }
    }
}
