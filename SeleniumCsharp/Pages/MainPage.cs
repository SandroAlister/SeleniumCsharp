using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumCsharp.Pages
{
    public class MainPage
    {
        /// <summary>
        /// Кнопка "Вход"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#breadcrumbs > ul > div > a:nth-child(1)")]
        public IWebElement BtnLogin { get; set; }

    }
}
