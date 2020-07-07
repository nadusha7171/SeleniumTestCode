using HomeworkPOM.Pages.SortablePages;
using NUnit.Framework;

namespace HomeworkPOM.Tests
{
    [TestFixture]
    public class Sortable: BaseTest
    {
        private SortablePages _sortablePages;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _sortablePages = new SortablePages(Driver);
            _sortablePages.NaviteTo();
            _sortablePages.Maximize();
        }

        [Test]

        public void MoveNumberOneBoxToNumberThree()
        {
            var expectedText = _sortablePages.SourceBoxList.Text;

            
            Builder
                .ClickAndHold(_sortablePages.SourceBoxList.WrappedElement)
                .DragAndDropToOffset(_sortablePages.TargetBoxList.WrappedElement, 0, 0)
               .Perform();


            Assert.AreEqual(expectedText, _sortablePages.TargetBoxList.Text);
        }

        [Test]

        public void MoveNumberFivetoNumberEight()
        {
            _sortablePages.GridButton.Click();
            var expectedText = _sortablePages.SourceBoxGrid.Text;
            
            
            Builder
               .ClickAndHold(_sortablePages.SourceBoxGrid.WrappedElement)
               .DragAndDropToOffset(_sortablePages.TargetBoxGrid.WrappedElement, 0, 0)
              .Perform();


            Assert.AreEqual(expectedText, _sortablePages.TargetBoxGrid.Text);

        }
    }
}
