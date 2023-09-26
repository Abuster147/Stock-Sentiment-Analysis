using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Program
{
    static void Main()
    {
        // Create a Chrome WebDriver instance
        IWebDriver driver = new ChromeDriver();

        // Navigate to the page
        driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

        try
        {
            // Find elements using explicit waits for better stability
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Find the First Name input field
            IWebElement firstNameInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("firstName")));
            firstNameInput.SendKeys("John");

            // Find the Last Name input field
            IWebElement lastNameInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("lastName")));
            lastNameInput.SendKeys("Doe");

            // Find the Email input field
            IWebElement emailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("userEmail")));
            emailInput.SendKeys("test@example.com");

            // Your testing logic here, e.g., validation or further actions

            // Pause briefly (you can remove this in production)
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));

            // Close the browser
            driver.Quit();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            // Handle the error gracefully, log it, and take necessary actions
        }
    }
}