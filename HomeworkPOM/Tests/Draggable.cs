using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using HomeworkPOM.Pages.DragabblePages;
using HomeworkPOM.Tests;
using HomeworkPOM.Utilities;
using System.Drawing;

namespace HomeworkPOM.Tests
{
    [TestFixture]
    public class Dragabble : BaseTest
    {
        private DragabblePages _dragabblePages;
        [SetUp]
        public void Setup()
        {
            Initialize();
            _dragabblePages = new DragabblePages(Driver);
            _dragabblePages.NaviteTo();
            _dragabblePages.Maximize();
        }
        [Test]
        public void DragBoxMove_WhenDragIt()
        {
            var locationBefore = _dragabblePages.DragMeBoxSimple.Location;
            var expectedLocation = new Point(341, 385);

            Builder
                .MoveToElement(_dragabblePages.DragMeBoxSimple.WrappedElement)
                .ClickAndHold()
                .DragAndDropToOffset(_dragabblePages.DragMeBoxSimple.WrappedElement, 50, 50)
                .Perform();

            Assert.AreEqual(expectedLocation, _dragabblePages.DragMeBoxSimple.Location);
        }

        [Test]
        public void MoveOnlyVertical_WhenDragTheBox()
        {
            _dragabblePages.AxisRestrictedSection.Click();
            var locationBefore = _dragabblePages.OnlyYBoxAxisRestriction.Location;
            var expectedLocation = new Point(locationBefore.X, locationBefore.Y + 50);

            Builder
                .MoveToElement(_dragabblePages.OnlyYBoxAxisRestriction.WrappedElement)
                .ClickAndHold()
                .DragAndDropToOffset(_dragabblePages.OnlyYBoxAxisRestriction.WrappedElement, 50, 50)
                .Perform();

            Assert.AreEqual(expectedLocation, _dragabblePages.OnlyYBoxAxisRestriction.Location);
        }

        [Test]
        public void MoveTheText()
        {
            _dragabblePages.ContainerRestrictedSection.Click();
            var locationDraggableBoxAfter = new Point(_dragabblePages.DragabbleBoxConteinerRestricted.Location.X + _dragabblePages.DragabbleBoxConteinerRestricted.Size.Width, _dragabblePages.DragabbleBoxConteinerRestricted.Location.Y + _dragabblePages.DragabbleBoxConteinerRestricted.Size.Height);
            var locationContainer = new Point(_dragabblePages.ContainerInConteinerRestricted.Location.X + _dragabblePages.ContainerInConteinerRestricted.Size.Width, _dragabblePages.ContainerInConteinerRestricted.Location.Y + _dragabblePages.ContainerInConteinerRestricted.Size.Height);

            Builder
                .MoveToElement(_dragabblePages.DragabbleBoxConteinerRestricted.WrappedElement)
                .ClickAndHold()
                .DragAndDropToOffset(_dragabblePages.DragabbleBoxConteinerRestricted.WrappedElement, 50, 50)
                .Perform();

            Assert.Less(locationDraggableBoxAfter.X, locationContainer.X);
            Assert.Less(locationDraggableBoxAfter.Y, locationContainer.Y);

        }
    }
}