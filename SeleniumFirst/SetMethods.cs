using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void Click(this IWebElement element)
        {
            element.Click();
        }

        public static void FillResultField(this IWebElement element, int result)
        {
            element.SendKeys(result.ToString());
        }



    }
}
