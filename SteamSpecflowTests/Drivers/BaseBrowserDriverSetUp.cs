using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamSpecflowTests.Drivers
{
    [Binding]
    public class BaseBrowserDriverSetUp
    {
        public static IWebDriver Driver;
        private const int _implicitWaitingTimeMs = 5000;

        [Before]
        public void DriverSetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(_implicitWaitingTimeMs);
            Driver.Url = "https://store.steampowered.com";
        }

        [After]
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
