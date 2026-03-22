using OpenQA.Selenium;
using SeleniumCSharpXunitLoginAutomation.Pages;
using SeleniumCSharpXunitLoginAutomation.Utilities;
using Xunit;

namespace SeleniumCSharpXunitLoginAutomation.Tests
{
    public class LoginTests : IDisposable
    {
        private readonly IWebDriver driver;
        private readonly LoginPage loginPage;

        public LoginTests()
        {
            driver = DriverFactory.CreateDriver();
            loginPage = new LoginPage(driver);
        }

        [Fact]
        public void ValidLoginTest()
        {
            loginPage.Open();
            loginPage.EnterUsername("tomsmith");
            loginPage.EnterPassword("SuperSecretPassword!");
            loginPage.ClickLogin();

            Assert.Contains("/secure", driver.Url);
        }

        [Fact]
        public void InvalidLoginTest()
        {
            loginPage.Open();
            loginPage.EnterUsername("wrong_user");
            loginPage.EnterPassword("wrong_password");
            loginPage.ClickLogin();

            Assert.Contains("Your username is invalid!", loginPage.GetFlashMessage());
        }

        [Fact]
        public void EmptyLoginTest()
        {
            loginPage.Open();
            loginPage.ClickLogin();

            Assert.Contains("Your username is invalid!", loginPage.GetFlashMessage());
        }

        public void Dispose()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}