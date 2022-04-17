using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using SeleniumCsharp.Pages;

namespace SeleniumCsharp
{
    public class Tests
    {
        private static IWebDriver webDriver;
        private static string baseURL = "https://www.mantisbt.org/bugs/my_view_page.php";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        [OneTimeTearDown] 
        public void OneTimeTearDown()
        {
            webDriver.Quit();
        }


        [Test]
        public void Test1()
        {
            webDriver.Navigate().GoToUrl(baseURL);

            MainPage mainPage = new MainPage();
            PageFactory.InitElements(webDriver, mainPage);
            mainPage.BtnLogin.Click();

            LoginPage loginPage = new LoginPage();
            PageFactory.InitElements(webDriver, loginPage);
            loginPage.TxtUsername.Click();
            loginPage.TxtUsername.SendKeys("admin");
            loginPage.BtnLogin.Click();

            LoginPasswordPage loginPasswordPage = new LoginPasswordPage();
            PageFactory.InitElements(webDriver, loginPasswordPage);
            loginPasswordPage.TxtPassword.Click();
            loginPasswordPage.TxtPassword.SendKeys("admin");
            loginPasswordPage.BtnLogin.Click();

            var actualURL = webDriver.Url;
            Assert.IsTrue(!actualURL.Contains("error"));
        }


    }
}