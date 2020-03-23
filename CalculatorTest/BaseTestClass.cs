namespace CalculatorTest
{
    using System;
    using CalculatorTest.Utility;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Windows;
    using OpenQA.Selenium.Remote;

    public class BaseTestClass
    {
        private const string windowsApplicationDriverUrl = "http://127.0.0.1:4723";

        
        protected static WindowsDriver<WindowsElement> session;
        protected static RemoteTouchScreen touchScreen;

       public InformationalWebDriver LaunchWinApplication(string appId)
        {
            if (session == null || touchScreen == null)
            {
                // Create a new session to bring up the application by application ID
                AppiumOptions opt = new AppiumOptions();
                opt.AddAdditionalCapability("app", appId);
                opt.AddAdditionalCapability("deviceName", "WindowsPC");
                session = new WindowsDriver<WindowsElement>(new Uri(windowsApplicationDriverUrl), opt);
                session.Manage().Window.Maximize();
            }

            return new InformationalWebDriver(session, session);
        }
    }
}
