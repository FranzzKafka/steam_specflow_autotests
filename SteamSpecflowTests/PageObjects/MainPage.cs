using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamSpecflowTests.PageObjects
{
    public class MainPage
    {
        public IWebDriver _webDriver;

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        public IWebElement OpenLanguagesListButton => _webDriver.FindElement(By.Id("language_pulldown"));
        public IWebElement DeutschLanguageButton => _webDriver.FindElement(By.XPath(".//*[@href='?l=german']"));
        public IWebElement GameSearchField => _webDriver.FindElement(By.Id("store_nav_search_term"));
        public IWebElement SearchGameButton => _webDriver.FindElement(By.XPath(".//*[@src='https://store.akamai.steamstatic.com/public/images/blank.gif']"));
        public IWebElement FirstGameInListTitle => _webDriver.FindElement(By.ClassName("title"));
        public IWebElement LoginField => _webDriver.FindElement(By.XPath(".//*[@type='text']"));
        public IWebElement PasswordField => _webDriver.FindElement(By.XPath(".//*[@type='password']"));
        public IWebElement ConfirmLoginButton => _webDriver.FindElement(By.ClassName("newlogindialog_SubmitButton_2QgFE"));
        public IWebElement AccountName => _webDriver.FindElement(By.Id("account_pulldown"));
        public IWebElement TagsButton => _webDriver.FindElement(By.XPath(".//*[@href='https://store.steampowered.com/tag/browse/?snr=1_4_4__125#yours']"));
        public IWebElement IndieTag => _webDriver.FindElement(By.XPath(".//*[@data-tagid='492']"));
        public IWebElement GameHeader => _webDriver.FindElement(By.ClassName("browse_tag_game_name"));
        public IWebElement DownloadSteamAppButton => _webDriver.FindElement(By.ClassName("header_installsteam_btn_content"));
        public IWebElement ConfirmDownloadSteamAppButton => _webDriver.FindElement(By.ClassName("about_install_steam_link"));

        public void ClickOpenLanguagesListButton()
        {
            OpenLanguagesListButton.Click();
        }

        public void ClickDeutschLanguageButton()
        {
            DeutschLanguageButton.Click();
        }

        public string GetOpenLanguagesListButtonText()
        {
            return OpenLanguagesListButton.Text;
        }

        public void SetTextToGameSearchField(string gameTitle)
        {
            GameSearchField.SendKeys(gameTitle);
        }

        public void ClickSearchGameButton()
        {
            SearchGameButton.Click();
        }

        public void ClickLoginButton()
        {
            const int elementToBeClickableWaitingTimeMs = 5000;

            IWebElement ClickableLoginButton = (new WebDriverWait(_webDriver, TimeSpan.FromSeconds(elementToBeClickableWaitingTimeMs)).
                Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[@href='https://store.steampowered.com/login/?redir=&redir_ssl=1&snr=1_4_4__global-header']"))));

            ClickableLoginButton.Click();
        }

        public void SetTextToLoginField(string login)
        {
            LoginField.SendKeys(login);
        }

        public void SetTextToPasswordField(string password)
        {
            PasswordField.SendKeys(password);
        }

        public void ClickConfirmLoginButton()
        {
            ConfirmLoginButton.Click();
        }

        public void ClickTagsButton()
        {
            TagsButton.Click();
        }

        public void ClickIndieTag()
        {
            IndieTag.Click();
        }

        public void ClickDownloadSteamAppButton()
        {
            DownloadSteamAppButton.Click();
        }

        public void ClickConfirmDownloadSteamAppButton()
        {
            ConfirmDownloadSteamAppButton.Click();
        }
    }
}
