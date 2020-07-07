using HomeworkPOM.Core;
using OpenQA.Selenium;

namespace HomeworkPOM
{
    public partial class HomePage
    {
        public HomePage(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://demoqa.com";
    }
}