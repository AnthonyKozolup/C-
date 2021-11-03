using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace TestProject1
{
    public class Tests
    {
        OpenQA.Selenium.IWebDriver driver;

        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.google.com/";
            IWebElement seachField = driver.FindElement(By.XPath("//input[@name='q']"));
            seachField.SendKeys("Black Cats" + Keys.Escape);

            IWebElement searchButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[3]/center/input[1]"));
            searchButton.Click();

            Assert.Pass();
        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}