namespace CalculatorTest.Steps
{
    using CalculatorTest.Pages;
    using CalculatorTest.Utility;
    using NUnit.Framework;
    using TechTalk.SpecFlow;

    [Binding]
    public sealed class SwitchToDifferentCalculatorClassesStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly InformationalWebDriver webDriver;
        private MainPage mainPage;
        public SwitchToDifferentCalculatorClassesStepDefinition(InformationalWebDriver appDriver)
        {
            webDriver = appDriver;
        }

        [Given(@"Click Open Navigation Button")]
        public void GivenClickOpenNavigationButton()
        {
            mainPage = new MainPage(webDriver.Session);
            mainPage.ClickElement(mainPage.togglePaneButton);
        }

        [Given(@"Click Scientific item")]
        public void GivenClickScientificItem()
        {
            mainPage.ClickElement(mainPage.scientificCalculator);     
        }

        [Then(@"Click Number Nine and xpower Three button")]
        public void ThenClickNumberNineAndXpowerThreeButton()
        {
            mainPage.ClickElement(mainPage.numberNine);
            mainPage.ClickElement(mainPage.xpowerThree);          
        }

        [Then(@"Verify the result it (.*)")]
        public void ThenVerifyTheResultIt(int p0)
        {
            mainPage.VerifyCalculateResult("729", mainPage.GetResultText());
        }

    }
}
