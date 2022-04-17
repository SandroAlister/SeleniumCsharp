using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumCsharp.Pages
{
    public class LoginPasswordPage
    {
        /// <summary>
        /// Поле "Пароль"
        /// </summary>
        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement TxtPassword { get; set; }

        //class width-40 pull-right btn btn-success btn-inverse bigger-110
        /// <summary>
        /// Кнопка "Вход"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#login-form > fieldset > input.width-40.pull-right.btn.btn-success.btn-inverse.bigger-110")]
        public IWebElement BtnLogin { get; set; }

        //class pull-right
        /// <summary>
        /// Ссылка "Забыли пароль?"
        /// </summary>
        [FindsBy(How = How.ClassName, Using = "pull-right")]
        public IWebElement LinkLostPassword { get; set; }

        //id secure-session
        /// <summary>
        /// Чекбокс "Доступ к этой сессии будет только с данного IP-адреса
        /// (не рекомендуется при плохой связи, когда возможны частые обновления ip-адреса)."
        /// </summary>
        [FindsBy(How = How.Id, Using = "secure-session")]
        public IWebElement ChbSecureSession { get; set; }

        //id remember-login
        /// <summary>
        /// Чекбокс "Оставаться в системе"
        /// </summary>
        [FindsBy(How = How.Id, Using = "remember-login")]
        public IWebElement ChbRememberLogin { get; set; }
    }
}
