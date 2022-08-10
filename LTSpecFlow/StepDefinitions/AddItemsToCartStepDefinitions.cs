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

        [Given(@"I navigate to (.*)")]
        public void GivenINavigateToLaptops(string category)
        {
            
            _browserInteractions.WaitAndReturnElement(By.XPath($"//h4[contains(text(),'{category}')]")).ClickWithRetry();
            _browserInteractions.WaitUntil(
                () => _browserInteractions.WaitAndReturnElement(By.XPath($"//h1[text() = '{category}']")),
                result => result.Displayed);
        }

        [When(@"I select the first product")]
        public void WhenISelectTheFirstProduct()
        {
            _browserInteractions.WaitAndReturnElement(By.XPath("(//a[@class='text-ellipsis-2'])[1]")).ClickWithRetry();
        }

        [When(@"I add it to the cart")]
        public void WhenIAddItToTheCart()
        {

            _browserInteractions.WaitAndReturnElement(By.XPath("//button[@title='Add to Cart']")).ClickWithRetry();
        }

        [Then(@"the total price should be \$(.*)")]
        public void ThenTheTotalPriceShouldBe(Decimal expectePrice)
        {
            _browserInteractions.WaitAndReturnElement(By.XPath("//div[@id='entry_217825']//a[@role='button']")).ClickWithRetry();
            _browserInteractions.WaitAndReturnElement(By.LinkText(" Edit cart")).ClickWithRetry();
            string actualPrice = _browserInteractions.WaitAndReturnElement(By.XPath("//td[@class='text-right'][text()='Total:']//following-sibling::td")).Text;
            Assert.AreEqual(actualPrice, expectePrice.ToString(), $"The expected price was: {expectePrice}. The actual price was {actualPrice}");
        }
    }
}
