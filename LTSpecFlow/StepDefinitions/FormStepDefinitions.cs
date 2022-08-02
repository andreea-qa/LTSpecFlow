using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;
using SpecFlow.Actions.Selenium;

namespace LTSpecFlow.StepDefinitions
{
    [Binding]
    public class FormStepDefinitions
    {
        private readonly IBrowserInteractions _browserInteractions;

        public FormStepDefinitions(IBrowserInteractions browserInteractions)
        {
            _browserInteractions = browserInteractions;
        }

        [Given(@"I navigate to the LambdaTest Form Demo page")]
        public void GivenINavigateToTheLambdaTestFormDemoPage()
        {
            _browserInteractions.GoToUrl("https://www.lambdatest.com/selenium-playground/simple-form-demo");
        }

        [When(@"I input the values (.*) and (.*)")]
        public void WhenIInputTheValueForNumberA(int firstNumber, int secondNumber)
        {
            _browserInteractions.WaitAndReturnElement(By.Id("sum1")).SendKeysWithClear(firstNumber.ToString());
            _browserInteractions.WaitAndReturnElement(By.Id("sum2")).SendKeysWithClear(secondNumber.ToString());
        }

        [When(@"I press to get the values")]
        public void WhenIPressToGetTheValues()
        {
            _browserInteractions.WaitAndReturnElement(By.XPath("//button[normalize-space()='Get values']")).ClickWithRetry();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedSum)
        {
            string actualSum = _browserInteractions.WaitAndReturnElement(By.Id("addmessage")).Text;
            Assert.AreEqual(actualSum, expectedSum.ToString());
        }
    }
}
