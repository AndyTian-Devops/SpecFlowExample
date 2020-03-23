namespace CalculatorTest.Utility
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.Windows;

    public class InformationalWebDriver : IInformationalWebDriver
    {
        public InformationalWebDriver(IWebDriver driver, WindowsDriver<WindowsElement> session)
        {
            WinAppDriver = driver;
            Session = session;
        }

        public IWebDriver WinAppDriver
        {
            get;
            private set;
        }


        public WindowsDriver<WindowsElement> Session
        {
            get;
            private set;
        }
    }
}
