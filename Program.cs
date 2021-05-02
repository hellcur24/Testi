using System;
using System.IO;
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
            Thread.Sleep(3000);

            var element = driver.FindElement(By.XPath("html/body/div[3]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[2]/button[1]")).Click();
            Thread.Sleep(1000); 
            var element1 = driver.FindElement(By.Id("edit-je-suis-0"));
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(element1);
            actions1.Perform();
            driver.FindElement(By.Id("edit-je-suis-0")).Click();
            Thread.Sleep(1000);
            var element2 = driver.FindElement(By.Id("edit-je-suis-ne-e-en-annee-year"));
            Actions actions2 = new Actions(driver);
            actions2.MoveToElement(element2);
            actions2.Perform();

            driver.FindElement(By.Id("edit-je-suis-ne-e-en-annee-year")).SendKeys("1990");
            Thread.Sleep(1000);
            var element3 = driver.FindElement(By.Id("edit-je-fais-du-sport-chaque-semaine-1"));
            Actions actions3 = new Actions(driver);
            actions3.MoveToElement(element3);
            actions3.Perform();
 
            driver.FindElement(By.Id("edit-je-fais-du-sport-chaque-semaine-1")).Click();
            Thread.Sleep(1000);
            var element4 = driver.FindElement(By.Id("edit-je-suis-2-1"));
            Actions actions4 = new Actions(driver);
            actions4.MoveToElement(element4);
            actions4.Perform();

            driver.FindElement(By.Id("edit-je-suis-2-1")).Click();
            Thread.Sleep(1000);
            var element5 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[2]/section[2]/div/div[2]/form/div[3]/div/div[4]/label"));
            Actions actions5 = new Actions(driver);
            actions5.MoveToElement(element5);
            actions5.Perform();
  
            driver.FindElement(By.Id("edit-mes-traitements-medicaux-sont")).SendKeys("Hello");
            Thread.Sleep(1000);
            var element6 = driver.FindElement(By.Id("edit-user-weight"));
            Actions actions6 = new Actions(driver);
            actions6.MoveToElement(element6);
            actions6.Perform();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-user-weight")).SendKeys("80");


            driver.FindElement(By.Id("edit-user-height")).SendKeys("180");
            Thread.Sleep(1000);
            var element8 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[2]/section[2]/div/div[2]/form/div[3]/div/fieldset[5]"));
            Actions actions8 = new Actions(driver);
            actions8.MoveToElement(element8);
            actions8.Perform();
            driver.FindElement(By.Id("edit-je-vis-1")).Click();
            Thread.Sleep(1000);
            var element9 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[2]/section[2]/div/div[2]/form/div[3]/div/div[6]"));
            Actions actions9 = new Actions(driver);
            actions9.MoveToElement(element9);
            actions9.Perform();

            driver.FindElement(By.Id("edit-j-ai-enfants-nombre-")).SendKeys("1");
            Thread.Sleep(2000);
            var element10 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[2]/section[2]/div/div[2]/form/div[3]/div/fieldset[6]"));
            Actions actions10 = new Actions(driver);
            actions10.MoveToElement(element10);
            actions10.Perform();
            driver.FindElement(By.Id("edit-patient-goals-29")).Click();
            Thread.Sleep(4000);
            var element11 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[2]/section[2]/div/div[2]/form/div[3]/div/div[7]"));
            Actions actions11 = new Actions(driver);
            actions11.MoveToElement(element11);
            actions11.Perform();

            driver.FindElement(By.Id("edit-email")).SendKeys("re@mail.com");
            Thread.Sleep(1000);
            var element12 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[2]/section[2]/div/div[2]/form/div[3]/div/div[9]"));
            Actions actions12 = new Actions(driver);
            actions12.MoveToElement(element12);
            actions12.Perform();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("edit-last-name")).SendKeys("ily");

            var element13 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[2]/section[2]/div/div[2]/form/div[4]/button[2]"));
            Actions actions13 = new Actions(driver);
            actions13.MoveToElement(element13);
            actions13.Perform();

            driver.FindElement(By.Id("edit-wizard-next")).Click();
            Thread.Sleep(1000);
            var err = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[2]/div/section[2]/div/div[2]/form/div[1]/div/div/ul")).Text;
            Console.WriteLine(err);
            Thread.Sleep(2000);
            TextReader tr = new StreamReader("data.txt");
            string ttr = tr.ReadToEnd();
            tr.Close();
            TextWriter tw = new StreamWriter("data.txt");
            tw.WriteLine(DateTime.Now + ": " + "\n" + err + "\n" + ttr);
            tw.Close();




            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
