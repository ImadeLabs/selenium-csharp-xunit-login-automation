using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumCSharpXunitLoginAutomation.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        private readonly By UsernameInput = By.Id("username");
        private readonly By PasswordInput = By.Id("password");
        private readonly By LoginButton = By.CssSelector("button[type='submit']");
        private readonly By FlashMessage = By.Id("flash");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
            _wait.Until(ExpectedConditions.ElementIsVisible(UsernameInput));
        }

        public void EnterUsername(string username)
        {
            var usernameField = _wait.Until(ExpectedConditions.ElementIsVisible(UsernameInput));
            usernameField.Clear();
            usernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            var passwordField = _wait.Until(ExpectedConditions.ElementIsVisible(PasswordInput));
            passwordField.Clear();
            passwordField.SendKeys(password);
        }

        public void ClickLogin()
        {
            var loginButton = _wait.Until(ExpectedConditions.ElementToBeClickable(LoginButton));
            loginButton.Click();
        }

        public string GetFlashMessage()
        {
            var flashMessage = _wait.Until(ExpectedConditions.ElementIsVisible(FlashMessage));
            return flashMessage.Text;
        }
    }
}