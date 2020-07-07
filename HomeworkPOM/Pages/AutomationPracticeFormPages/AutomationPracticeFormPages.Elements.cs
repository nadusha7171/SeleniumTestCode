using Fare;
using OpenQA.Selenium;
using System.Runtime.InteropServices.ComTypes;
using OpenQA.Selenium.Support.UI;
using HomeworkPOM.Core;
using HomeworkPOM.Utilities;

namespace HomeworkPOM.Pages.AutomationPracticeFormPages
{
    public partial class AutomationPracticeFormPages: BasePage
    {
        public WebElement EmailAddressTextField => Driver.FindElement(By.XPath("//*[@id='email_create']"));

        public WebElement CreateAnAccountButton => Driver.FindElement(By.CssSelector("#SubmitCreate > span"));

        public WebElement ActualEmail => Driver.FindElement(By.CssSelector("#email"));

        public WebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public WebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public WebElement Password => Driver.FindElement(By.Id("passwd"));

        public WebElement Date => Driver.FindElement(By.Id("days"));

        public WebElement Month => Driver.FindElement(By.Id("months"));

        public WebElement Year => Driver.FindElement(By.Id("year"));

        public WebElement RealFirstName => Driver.FindElement(By.Id("firstname"));

        public WebElement RealLastName => Driver.FindElement(By.Id("lastname"));

        public WebElement Address => Driver.FindElement(By.Id("address1"));

        public WebElement City => Driver.FindElement(By.Id("city"));

        public WebElement State => Driver.FindElement(By.Id("id_state"));

        public SelectElement StateSelect => new SelectElement(State.WrappedElement);

        public WebElement Postcode => Driver.FindElement(By.Id("postcode"));

        public WebElement Country => Driver.FindElement(By.Id("id_country"));

        public SelectElement CountrySelect => new SelectElement(Country.WrappedElement);


        public WebElement Phone => Driver.FindElement(By.Id("phone_mobile"));

        public WebElement Allias => Driver.FindElement(By.Id("alias"));

        public WebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

        public void FillForm(RegistrationUser user)
        {
            FirstName.SetText(user.FirstName);
            LastName.SetText(user.LastName);
            Password.SetText(user.Password);
            Address.SetText(user.Address);
            City.SetText(user.City);
            StateSelect.SelectByText(user.State);
            Postcode.SetText(user.PostCode);
            CountrySelect.SelectByText(user.Country);
            Phone.SetText(user.Phone);
            Allias.SetText(user.Alias);

            RegisterButton.ScrollTo().Click();


           




        }




    }
}
