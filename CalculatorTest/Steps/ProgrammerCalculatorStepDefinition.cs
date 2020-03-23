namespace CalculatorTest.Steps
{
    using CalculatorTest.Pages;
    using CalculatorTest.Utility;
    using NUnit.Framework;
    using TechTalk.SpecFlow;

    [Binding]
    public sealed class ProgrammerCalculatorStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly InformationalWebDriver webDriver;
        private MainPage mainPage;
        private ProgrammerPage programmerPage;

        public ProgrammerCalculatorStepDefinition(InformationalWebDriver appDriver)
        {
            webDriver = appDriver;
        }

        [Given(@"Go To Programmer Calculator")]
        public void GivenGoToProgrammerCalculator()
        {
            mainPage = new MainPage(webDriver.Session);
            mainPage.ClickElement(mainPage.togglePaneButton);
            mainPage.ClickElement(mainPage.programmerCalculator);
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            programmerPage = new ProgrammerPage(webDriver.Session);
            programmerPage.ClickElement(programmerPage.numberEightButton);
            programmerPage.ClickElement(programmerPage.numberZeorButton);
        }

        [Then(@"the result of HEX should be (.*)")]
        public void ThenTheResultOfHEXShouldBe(int p0)
        {
            programmerPage.ClickElement(programmerPage.hexButton);
            programmerPage.VerifyCalculateResult("50", programmerPage.GetResultText());
        }

        [Then(@"the result of DEC should be (.*)")]
        public void ThenTheResultOfDECShouldBe(int p0)
        {
            programmerPage.ClickElement(programmerPage.decButton);
            programmerPage.VerifyCalculateResult("80", programmerPage.GetResultText());
        }

        [Then(@"the result of OCT should be (.*)")]
        public void ThenTheResultOfOCTShouldBe(int p0)
        {
            programmerPage.ClickElement(programmerPage.octoButton);
            programmerPage.VerifyCalculateResult("120", programmerPage.GetResultText());
        }

        [Then(@"the result of BIN should be (.*)")]
        public void ThenTheResultOfBINShouldBe(string p0)
        {
            programmerPage.ClickElement(programmerPage.binaryButton);
            programmerPage.VerifyCalculateResult("1010000", programmerPage.GetResultText());
        }
    }
}
