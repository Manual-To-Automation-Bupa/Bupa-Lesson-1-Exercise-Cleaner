using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Lesson1_Exercise_LoginAndVerify.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I am on ""(.*)""")]
        public void GivenIAmOnWebsite(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
        }

        [When(@"I login with the username (.*) using the password (.*)")]
        public void WhenIEnterCorrectLoginDetails(string username, string password)
        {
            IWebElement usernameField = _driver.FindElement(By.Id("username"));
            usernameField.SendKeys(username);

            IWebElement passwordField = _driver.FindElement(By.Id("password"));
            passwordField.SendKeys(password);

            IWebElement loginButton = _driver.FindElement(By.Id("submit"));
            loginButton.Click();
        }

        [Then(@"The login should have (.*)")]
        public void ThenLoginSuccessful(String status)
        {
            if (status == "passed")
            {
                Assert.IsTrue(_driver.FindElement(By.ClassName("post-title")).Displayed);
                Assert.AreEqual(_driver.FindElement(By.ClassName("post-title")).Text, "Logged In Successfully");
                Assert.IsTrue(_driver.Url.Equals("https://practicetestautomation.com/logged-in-successfully/"));
            } 
            else if (status == "failed")
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(c => c.FindElement(By.CssSelector("#error")).Displayed);
                _driver.FindElement(By.CssSelector("#error")).Displayed.Should().BeTrue();
            }
        }
    }
}
