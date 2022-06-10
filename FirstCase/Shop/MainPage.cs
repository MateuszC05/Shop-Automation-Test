using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace FirstCase
{
    class MainPage
    {
        private IWebDriver driver;

        private WebDriverWait wait;

        public MainPage()
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='site-title']")]
        private IWebElement homePage;

        [FindsBy(How = How.XPath, Using = "//a[@title='Catergries']")]
        private IWebElement dropCategories;

        [FindsBy(How = How.XPath, Using = "//a[@title='Shirts']")]
        private IWebElement shirts;

        [FindsBy(How = How.XPath, Using = "//a[@title='Featured']")]
        private IWebElement featured;

        [FindsBy(How = How.XPath, Using = "//a[@title='Trends']")]
        private IWebElement trends;

        [FindsBy(How = How.XPath, Using = "//a[@title='Scarfs']")]
        private IWebElement scarfs;

        [FindsBy(How = How.XPath, Using = "//a[@title='Shoes']")]
        private IWebElement shoes;

        [FindsBy(How = How.XPath, Using = "//a[@title='Tops']")]
        private IWebElement tops;

        [FindsBy(How = How.XPath, Using = "//a[@title='Blouse']")]
        private IWebElement blouse;

        [FindsBy(How = How.XPath, Using = "//a[@title='Jeans']")]
        private IWebElement jeans;

        [FindsBy(How = How.XPath, Using = "//a[@title='Dresses']")]
        private IWebElement dresses;


        public enum Categories
        {
            Shirts, Featured, Trends, Scarfs, Shoes, Tops, Blouse, Jeans, Dresses
        }

        public void OpenHomePage()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(homePage));
            homePage.Click();
        }

        public void OpenCategoriesAndSelect(Categories categories)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(homePage));
            dropCategories.Click();

            switch (categories)
            {
                case Categories.Shirts:
                    wait.Until(ExpectedConditions.ElementToBeClickable(shirts));
                    shirts.Click();
                    break;

                case Categories.Featured:
                    wait.Until(ExpectedConditions.ElementToBeClickable(featured));
                    featured.Click();
                    break;

                case Categories.Trends:
                    wait.Until(ExpectedConditions.ElementToBeClickable(trends));
                    trends.Click();
                    break;

                case Categories.Scarfs:
                    wait.Until(ExpectedConditions.ElementToBeClickable(scarfs));
                    scarfs.Click();
                    break;

                case Categories.Shoes:
                    wait.Until(ExpectedConditions.ElementToBeClickable(shoes));
                    shoes.Click();
                    break;
                case Categories.Tops:
                    wait.Until(ExpectedConditions.ElementToBeClickable(tops));
                    tops.Click();
                    break;

                case Categories.Blouse:
                    wait.Until(ExpectedConditions.ElementToBeClickable(blouse));
                    blouse.Click();
                    break;

                case Categories.Jeans:
                    wait.Until(ExpectedConditions.ElementToBeClickable(jeans));
                    jeans.Click();
                    break;

                case Categories.Dresses:
                    wait.Until(ExpectedConditions.ElementToBeClickable(dresses));
                    dresses.Click();
                    break;
            }
        }
    }
}
