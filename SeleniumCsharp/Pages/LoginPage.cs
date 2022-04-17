using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumCsharp.Pages
{
    public class LoginPage
    {
        /// <summary>
        /// Поле "Пользователь"
        /// </summary>
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement TxtUsername { get; set; }

        /// <summary>
        /// Кнопка "Вход"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#login-form > fieldset > input.width-40.pull-right.btn.btn-success.btn-inverse.bigger-110")]
        public IWebElement BtnLogin { get; set; }

        /// <summary>
        /// Ссылка "Войти анонимно"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#login-box > div > div.toolbar.center > a.back-to-login-link.pull-right")]
        public IWebElement LinkLoginAnon { get; set; }

        /// <summary>
        /// Ссылка "Зарегистрировать новую учётную запись"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#login-box > div > div.toolbar.center > a.back-to-login-link.pull-left")]
        public IWebElement LinkSignUp { get; set; }
    }
}
