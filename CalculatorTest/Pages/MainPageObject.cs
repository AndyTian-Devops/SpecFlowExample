namespace CalculatorTest.Pages
{
    using NUnit.Framework;
    using OpenQA.Selenium.Appium.Windows;

    public class MainPage
    {
        public WindowsDriver<WindowsElement> session;

        public string togglePaneButton = "TogglePaneButton";

        public string scientificCalculator = "Scientific";

        public string trigButton = "trigButton";

        public string trigText = "trigTextBlock";

        public string trigDisplayText = "Trigonometry";

        public string numberNine = "num9Button";

        public string xpowerThree = "xpower3Button";

        public string calculatorResults = "CalculatorResults";

        public string programmerCalculator = "Programmer";



        public MainPage(WindowsDriver<WindowsElement> pageSession)
        {
            session = pageSession;
        }

        public void ClickElement(string elementName)
        {
            session.FindElementByAccessibilityId(elementName).Click();
        }

        public string GetResultText()
        {
            WindowsElement element = session.FindElementByAccessibilityId(calculatorResults);
            return element.Text.Remove(0,11);
        }

        public void VerifyCalculateResult(string expected, string actual)
        {
            Assert.AreEqual(expected, GetResultText());
        }
    }
}
