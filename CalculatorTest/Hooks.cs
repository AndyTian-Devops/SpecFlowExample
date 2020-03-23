namespace CalculatorTest
{
    using BoDi;
    using CalculatorTest.Utility;
    using TechTalk.SpecFlow;


    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private InformationalWebDriver informationalWebDriver;
        private const string applicationId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        private readonly IObjectContainer objectContainer;

        public Hooks(IObjectContainer newObjectContainer)
        {
            objectContainer = newObjectContainer;
        }

        /// <summary>
        /// Before any scenarios, we need to start the app
        /// </summary>
        [BeforeScenario]
        public void BeforeScenario()
        {
            var appFactory = new BaseTestClass();
            var appInstance = appFactory.LaunchWinApplication(applicationId);
            informationalWebDriver = appInstance;
            objectContainer.RegisterInstanceAs<InformationalWebDriver>(appInstance);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            informationalWebDriver.Session.Quit();
        }
    }
}
