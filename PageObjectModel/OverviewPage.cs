using IHSMarkitProject.ControlHelper;
using IHSMarkitProject.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace IHSMarkitProject.PageObjectModel
{
   public  class OverviewPage
    {
        #region WebElement
        private readonly By pageTitleLogoIsDotNetFiddle = By.XPath("//*[@class ='logo navbar-brand' ]//img[@alt='.NET Fiddle']");
        private readonly By backToEditorArrowBtn = By.XPath("//*[@class='btn btn-default' and contains(.,'Back To Editor')]");
        private readonly By gettingStartedLink = By.XPath("//a[@class ='btn btn-default'and contains(.,' Getting Started')]");
        private readonly By searchIcon = By.XPath("//*[@class ='glyphicon glyphicon glyphicon-search' ]");
        private readonly By logInLink = By.XPath("//*[@class='user-name' and @id='login-button']");
        private readonly By signUpLink = By.XPath("//*[@class='user-name' and @id='signup-button']");
        private readonly By gettingStartedOverviewHeader = By.XPath("//*[text()='Getting Started']");
        private readonly By featuresOverviewHeader = By.XPath("//*[text()='Features']");
        private readonly By communityOverviewHeader = By.XPath("//*[text()='Community']");


        #endregion

        #region Action


        #endregion

        #region Navigation
        public DotNetFiddleLandingPage NavigateBackToDotNetFiddleLandingPage()
        {

            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(GenericHelper.GetElement(backToEditorArrowBtn))).Click();
            return new DotNetFiddleLandingPage();
        }

        #endregion

        #region Validation

        public void ValidatePageTitleLogoIsDotNetFiddle() => GenericHelper.GetElement(pageTitleLogoIsDotNetFiddle);
        public void ValidateBackToEditorArrowBtn() => GenericHelper.GetElement(backToEditorArrowBtn);
        public void ValidateGettingStartedLink() => GenericHelper.GetElement(gettingStartedLink);
        public void ValidateSearchIcon() => GenericHelper.GetElement(searchIcon);
        public void ValidateLogInLink() => GenericHelper.GetElement(logInLink);
        public void ValidateSignUpLink() => GenericHelper.GetElement(signUpLink);
        public void ValidateGettingStartedOverviewHeader() => GenericHelper.GetElement(gettingStartedOverviewHeader);
        public void ValidateFeaturesOverviewHeader() => GenericHelper.GetElement(featuresOverviewHeader);
        public void ValidateCommunityOverviewHeader() => GenericHelper.GetElement(communityOverviewHeader);


        #endregion
    }
}
