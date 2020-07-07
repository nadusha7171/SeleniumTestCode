using HomeworkPOM.Core;
using OpenQA.Selenium;

namespace HomeworkPOM
{
    public partial class HomePage : BasePage
    {
        public WebElement CategotyButton(string categoryName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{categoryName}']/ancestor::div[contains(@class, 'top-card')]"));
    }
}