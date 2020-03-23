namespace CalculatorTest.Pages
{
    using NUnit.Framework;
    using OpenQA.Selenium.Appium.Windows;
    using System;

    public class ProgrammerPage
    {
        public WindowsDriver<WindowsElement> session;

        public ProgrammerPage(WindowsDriver<WindowsElement> programmerPageSession)
        {
            session = programmerPageSession;
        }

        public string hexButton = "hexButton";

        public string decButton = "decimalButton";

        public string octoButton = "octolButton";

        public string binaryButton = "binaryButton";

        public string calculatorResults = "CalculatorResults";

        public string numberEightButton = "num8Button";

        public string numberZeorButton = "num0Button";


        public void ClickElement(string elementName)
        {
            session.FindElementByAccessibilityId(elementName).Click();
        }

        public string GetResultText()
        {
            WindowsElement element = session.FindElementByAccessibilityId(calculatorResults);
            return element.Text.Remove(0, 11).Replace(" ", String.Empty);
        }

        public void VerifyCalculateResult(string expected, string actual)
        {
            Assert.AreEqual(expected, GetResultText());
        }
    }
}
