using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using TechTalk.SpecFlow;

namespace LTSpecFlow.StepDefinitions
{
    [Binding]
    public class AddItemsToCartStepDefinitions
    {
        private readonly IBrowserInteractions _browserInteractions;
        public AddItemsToCartStepDefinitions(IBrowserInteractions browserInteractions)
        {
            _browserInteractions = browserInteractions;
        }

        [BeforeScenario]
        public void SetUp()
        {
            _browserInteractions.GoToUrl("https://ecommerce-playground.lambdatest.io/");
        }

        [Given(@"I select the (.*) category")]
        public void GivenISelectTheCategory(string category)
        {
            _browserInteractions.WaitAndReturnElement(By.XPath("(//div[@class='dropdown search-category']/button[@type='button'])[1]")).ClickWithRetry();
            _browserInteractions.WaitAndReturnElement(By.XPath($"(//a[text()='{category}'])[1]")).ClickWithRetry();
        }

        [When(@"I search for (.*)")]
        public void WhenISearchForProduct(string product)
        {
            _browserInteractions.WaitAndReturnElement(By.XPath("(//input[@name='search'])[1]")).SendKeysWithClear(product);
            _browserInteractions.WaitAndReturnElement(By.XPath("(//button[normalize-space()='Search'])[1]")).ClickWithRetry();
        }

        [Then(@"I should get (.*) results")]
        public void ThenIShouldGetResults(int itemsCount)
        {
            int actualCount = _browserInteractions.WaitAndReturnElements(By.XPath("//div[@class='carousel-item active']")).Count();
            Assert.AreEqual(itemsCount, actualCount);
        }

    }
}