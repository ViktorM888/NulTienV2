using FillOutForm_tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {

        static void Main1(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\Users\vikto\Documents\Automation\libSources\WebDrivers\");
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.ultimateqa.com/filling-out-forms/"); // Go to URL 
            Console.WriteLine("Opened URL"); //Print step Go to URL
            PropertiesCollection.driver.Manage().Window.Maximize(); //Maximize Browser 
            Console.WriteLine("Maximize the Browser");//Print step Maximize Browser


        }
        [TearDown]
        public void CloseBrowser()
        {
            
            PropertiesCollection.driver.Close(); //Close browser
            Console.WriteLine("Closing Browser..."); //Print step Closing Browser
            

        }
        [Test]
        public void RunTest()
        //-1 as sum

        {
            PageObject page = new PageObject();
            //Catch Captcha Number Before pressing submit button
            var beforesubmit = page.BoxNameField();
            //Print Captcha Before submit
            Console.WriteLine("Captcha before submit form: "+beforesubmit);

            //Filling all fields on the right
            page.SubmitForm("Viktor", "Hello there!", -1);
            Console.WriteLine("Filling all fields on the right");

            //Catch Captcha Number After pressing submit button
            var aftersubmit = page.BoxNameField();
            Console.WriteLine("Captcha after submit form: "+ aftersubmit);

            //if captcha are diferent print False
            Console.WriteLine("Are captcha numbers before and after pressing submit the same ? " + aftersubmit.Equals(beforesubmit));
        }
        [Test]
        public void TestCorrectNumber()
        //Test correct sum
        {
            //Catch Captcha number Before pressing submit button
            PageObject page = new PageObject();
            var beforesubmit = page.BoxNameField();
            Console.WriteLine("Captcha before pressing submit button: " + beforesubmit);
            
            //Getting sum from the two numbers in captcha box
            var correctResult = Calculation.Addition(beforesubmit);
            
            //Filling correct number into captcha box
            page.SubmitForm("Viktor", "Hello there!", correctResult);
            Console.WriteLine("Sum of the two numbers is " + correctResult);
            
            System.Threading.Thread.Sleep(6500);
            //Verifying that success message is "Success"
            var MessageSuccessSubmitForm = page.GetSucessErrorMsgText();
            Console.WriteLine("Message is: " + MessageSuccessSubmitForm);
            Assert.AreEqual("Success", MessageSuccessSubmitForm);

        }
    }
}
