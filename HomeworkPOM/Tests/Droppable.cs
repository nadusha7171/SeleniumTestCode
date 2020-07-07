using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using HomeworkPOM.Pages.DroppablePages;
using HomeworkPOM.Tests;
using HomeworkPOM.Utilities;

namespace HomeworkPOM.Tests
{
    [TestFixture]
    public class Droppable : BaseTest
    {
        private DroppablePages _droppablePages;
        [SetUp]
        public void Setup()
        {
            Initialize();
            _droppablePages = new DroppablePages(Driver);
            _droppablePages.NaviteTo();
            _droppablePages.Maximize();
        }

        [Test]

        public void DragButtonWillRever_WhenDragToContainer()
        {

            _droppablePages.RevertDraggable.Click();
            var willRevertBoxBefore = _droppablePages.WillRevertBox.Location;

            Builder.MoveToElement(_droppablePages.WillRevertBox.WrappedElement)
                    .ClickAndHold()
                    .MoveToElement(_droppablePages.TargetBox.WrappedElement)
                    .Click()
                    .Perform();
            Thread.Sleep(3000); //this is needed to wait until the animation of the element is over
            var willRevertBoxAfter = _droppablePages.WillRevertBox.Location;

            Assert.AreEqual(willRevertBoxBefore, willRevertBoxAfter);
        }

        [Test]
        public void DropElementChangeColorOfTarget_When_DragAndDropDragMe()
        {

            var colorBefore = _droppablePages.TragetBoxSimpleSection.WrappedElement.GetCssColor();

            Builder
                .MoveToElement(_droppablePages.DragMeBoxSimpleSection.WrappedElement)
                .ClickAndHold()
                .MoveToElement(_droppablePages.TragetBoxSimpleSection.WrappedElement)
                .Click()
                .Perform();

            Assert.AreNotEqual(colorBefore, _droppablePages.TragetBoxSimpleSection.WrappedElement.GetCssColor());



        }

        [Test]
        public void TargetBoxChangeOuterText_WhenDropIntoInnerBox()
        {
            _droppablePages.PreventPropogation.Click();
            var textBefore = _droppablePages.TargetBoxPreventPropogation.Text;

            Builder
                .MoveToElement(_droppablePages.DragMeBoxPreventPropogation.WrappedElement)
                .ClickAndHold()
                .MoveToElement(_droppablePages.TargetBoxPreventPropogation.WrappedElement)
                .Click()
                .Perform();

            Assert.AreNotEqual(textBefore, _droppablePages.TargetBoxPreventPropogation.Text);
        }



    }


}
