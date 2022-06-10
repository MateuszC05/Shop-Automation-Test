using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCase
{
    class Config
    {
        IWebDriver driver;

        public Config(IWebDriver driver)
        {
            this.driver = driver;
        }

        [SetUp]
        public void OpenPage()
        {
            driver = new ChromeDriver();

            driver.Url = "http://www.google.com";
        }

        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
