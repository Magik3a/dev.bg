using OpenQA.Selenium.Support.UI;

namespace BlazorApp1TestProject.Selenium
{
    [TestClass, TestCategory("Selenium")] // class containing the unit tests. 
    public class SeleniumTest1
    {
        static IWebDriver driver;

        [ClassInitialize] // Executes once for the test class
        public static void ClassInitialize(TestContext context)
        {
            // initialize the web driver
            var chromeOptions = new ChromeOptions();
#if !DEBUG
            chromeOptions.addArguments("start-maximized"); // open Browser in maximized mode
            chromeOptions.addArguments("disable-infobars"); // disabling infobars
            chromeOptions.addArguments("--disable-extensions"); // disabling extensions
            chromeOptions.addArguments("--disable-gpu"); // applicable to windows os only
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--no-sandbox");  // Bypass OS security model
            chromeOptions.AddArguments("--disable-dev-shm-usage"); // overcome limited resource problems
#endif
            driver = new ChromeDriver(chromeOptions);
            
        }

        [ClassCleanup] // Runs once after all tests in this class are executed.
        public static void ClassCleanup()
        {
            // close the web driver
            driver.Quit();
        }

        [TestMethod] //method that contains the test method
        public void TestMethod1()
        {
            driver.Url = "https://magik3a.github.io/dev.bg/";
            Assert.AreEqual(driver.Url, "https://magik3a.github.io/dev.bg/");
        }
        [TestMethod] //method that contains the test method
        public void TestMethod2()
        {
            driver.Url = "https://magik3a.github.io/dev.bg/counter";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement button = wait.Until(e => e.FindElement(By.ClassName("btn")));

            button.Click();
            Assert.AreEqual(driver.FindElement(By.TagName("p")).Text, "Current count: 1");

        }
    }
}