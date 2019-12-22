using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssSelector,
        ClassName,
        XPath
    }
    class PropertiesCollection
    {
         public static IWebDriver driver { get; set; }
    }
}
