using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SteamSpecflowTests.Drivers;
using SteamSpecflowTests.Helpers;
using SteamSpecflowTests.PageObjects;

namespace SteamSpecflowTests.StepDefinitions
{
    [Binding]
    public class MainPageStepDefinitions
    {
        private readonly MainPage _mainPage = new MainPage(BaseBrowserDriverSetUp.Driver);

        [Given("list of languages is opened")]
        public void GivenListOfLanguagesIsOpened()
        {
            _mainPage.ClickOpenLanguagesListButton();
        }

        [When("Deutsch language is selected")]
        public void WhenDeutschLanguageIsSelected()
        {
            _mainPage.ClickDeutschLanguageButton();
        }

        [Then("name of the button for opening the list of languages ​​is now in Deutsch")]
        public void ThenOpenLanguagesListButtonNameIsDisplayedInDeutsch()
        {
            var actualResult = _mainPage.GetOpenLanguagesListButtonText();

            string expectedResult = "Sprache";

            actualResult.Should().Be(expectedResult);
        }

        [Given("game title (.*) is setted to search field")]
        public void GivenTheGameTitleIsSettedToSearchField(string gameTitle)
        {
            _mainPage.SetTextToGameSearchField(gameTitle);
        }

        [When("search game button is clicked")]
        public void WhenSearchGameButtonIsClicked()
        {
            _mainPage.ClickSearchGameButton();
        }

        [Then("name of the first game in the list (.*) is equal to the title that was typed into the search field")]
        public void ThenNameOfFirstGameInGameListIsEqualTo(string expectedResult)
        {
            var actualResult = _mainPage.FirstGameInListTitle.Text;

            actualResult.Should().Be(expectedResult);
        }

        [Given("login button is clicked")]
        public void GivenLoginButtonIsClicked()
        {
            _mainPage.ClickLoginButton();
        }

        [When("login (.*) is setted to login field")]
        public void WhenLoginFieldIsSetted(string login)
        {
            _mainPage.SetTextToLoginField(login);
        }

        [When("password (.*) is setted to password field")]
        public void WhenPasswordIsSetted(string password)
        {
            _mainPage.PasswordField.SendKeys(password);
        }

        [When("confirm login button is clicked")]
        public void WhenConfirmLoginButtonIsClicked()
        {
            _mainPage.ConfirmLoginButton.Click();
        }

        [Then("account name on mainpage is displayed")]
        public void ThenAccountNameOnMainPageIsDisplayed()
        {
            _mainPage.AccountName.Should().NotBeNull();
        }

        [Given("tags button is clicked")]
        public void WhenTagsButtonIsClicked()
        {
            _mainPage.ClickTagsButton();
        }

        [When("indie tag is clicked")]
        public void WhenIndieTagIsClicked()
        {
            _mainPage.ClickIndieTag();
        }

        [Then("game header appears")]
        public void ThenGameHeaderAppears()
        {
            _mainPage.GameHeader.Should().NotBeNull();
        }
        
        [Given("intstal steam button is clicked")]
        public void GivenInstallSteamAppButtonIsClicked()
        {
            _mainPage.ClickDownloadSteamAppButton();
        }

        [When("confirm steam instal button is clicked")]
        public void WhenConfrimSteamButtonIsClicked()
        {
            _mainPage.ClickConfirmDownloadSteamAppButton();
        }

        [Then("steam app file is downloaded")]
        public void ThenSteamAppFileIsDownloaded()
        {
            var appIsDownloaded = CheckDownloadingHelper.CheckIfSteamAppFileDownloaded();

            appIsDownloaded.Should().Be(true);
        }
    }
}
