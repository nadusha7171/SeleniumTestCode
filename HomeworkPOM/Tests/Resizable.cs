using HomeworkPOM.Pages.ResizablePages;
using HomeworkPOM.Utilities;
using NUnit.Framework;
using System;

namespace HomeworkPOM.Tests
{

    [TestFixture]
    public class Resizable : BaseTest
    {
        private ResizablePages _resizablePages;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _resizablePages = new ResizablePages(Driver);
            _resizablePages.NaviteTo();
            _resizablePages.Maximize();
        }

        [Test]

        public void IncreaseTheFiesl_WHenMoveIt()
        {
            var boxBefore = _resizablePages.BoxBeforeFirstBox.Size;

            Builder
                .MoveToElement(_resizablePages.MouseDragFirstBox.WrappedElement)
                .ClickAndHold()
                .MoveByOffset(50, 50)
                .Click()
                .Perform();
             
            Assert.AreNotSame(boxBefore, _resizablePages.BoxBeforeFirstBox.Size);
        }
        [Test]
        public void IncreaseWidth_WhenAdd50ToWidth()
        {
            _resizablePages.BoxBelow.ScrollTo();
            var boxBeforeWidth = (Int32.Parse(_resizablePages.BoxBelow.WrappedElement.GetCssValue("width").Split("px")[0]) + 50) + "px";

            Builder
                .MoveToElement(_resizablePages.MouseDragBelow.WrappedElement)
                .ClickAndHold()
                .MoveByOffset(50, 0)
                .Click()
                .Perform();

            Assert.AreNotEqual(boxBeforeWidth, _resizablePages.BoxBelow.Size);
        }
    }
}
