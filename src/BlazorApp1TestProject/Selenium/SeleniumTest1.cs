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
            driver = new ChromeDriver();
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
            driver.FindElement(By.TagName("button")).Click();
            Assert.AreEqual(driver.FindElement(By.TagName("p")).Text, "Current count: 1");

        }
    }
}