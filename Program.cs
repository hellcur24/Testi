using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
           IWebDriver driver = new ChromeDriver(@"C:\Users\Hellcur\Desktop\demoProject\chromedriver_win32"); //<-Add your path
            
            driver.Navigate().GoToUrl("https://prelive.aptimea.com/form/questionnaire?current=/node/96");
            Thread.Sleep(5000);
            
            driver.FindElement(By.Id("edit-je-suis-0")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-je-suis-ne-e-en-annee-year")).SendKeys("1990");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-je-fais-du-sport-chaque-semaine-1")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-je-suis-2-1")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-mes-traitements-medicaux-sont")).SendKeys("Hello");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-user-weight")).SendKeys("80");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-user-height")).SendKeys("180");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-je-vis-1")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-j-ai-enfants-nombre-")).SendKeys("1");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-patient-goals-29")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-email")).SendKeys("re@mail.com");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-last-name")).SendKeys("ily");
            Thread.Sleep(1000);

            driver.FindElement(By.Id("edit-wizard-next")).Click();
            Thread.Sleep(20000);
            driver.Quit();
        }
    }
}
