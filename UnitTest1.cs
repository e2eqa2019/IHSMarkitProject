using IHSMarkitProject.ControlHelper;
using IHSMarkitProject.PageObjectModel;
using IHSMarkitProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace IHSMarkitProject
{
    [TestClass]
    public class UnitTest1
    {
        DotNetFiddleLandingPage fiddleLandingPageObject;
        ShareLinkPage shareLinkPage;
        LoginPage loginPage;
        OverviewPage overviewPage;

        [TestMethod]
        [TestCategory("Exploratory")]
        public void VerifyAllTheMajorControlsOnDotNetFiddleLandingPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            fiddleLandingPageObject = new DotNetFiddleLandingPage();
            fiddleLandingPageObject.ValidateNewBtn();
            fiddleLandingPageObject.ValidateSaveBtn();
            fiddleLandingPageObject.ValidateRunBtn();
            fiddleLandingPageObject.ValidateShareBtn();
            fiddleLandingPageObject.ValidateCollaborateBtn();
            fiddleLandingPageObject.ValidateTidyUpdropdownArrow();
            fiddleLandingPageObject.ValidateGettingStartedLink();
            fiddleLandingPageObject.ValidateSearchIcon();
            fiddleLandingPageObject.ValidateLogInLink();
            fiddleLandingPageObject.ValidateSignUpLink();
            fiddleLandingPageObject.ValidateGroupNavigationDropdownBtn();
            fiddleLandingPageObject.ValidateAlignJustiiedIcon();
            fiddleLandingPageObject.ValidateOptionsLabel();
            fiddleLandingPageObject.ValidateLetArrowToggle();
            fiddleLandingPageObject.ValidateRightArrowToggleExpander();
            fiddleLandingPageObject.ValidateLanguageDropdownArrow();
            fiddleLandingPageObject.ValidateProjectTypeDropDownArrow();
            fiddleLandingPageObject.ValidatecompilerDrowDownArrow();
            fiddleLandingPageObject.ValidateSidebarPushpin();
            fiddleLandingPageObject.ValidatePackageNameSearchBox();
            fiddleLandingPageObject.ValidateAutoRunYes();
            fiddleLandingPageObject.ValidateAutoRunNo();
            fiddleLandingPageObject.ValidateDotNetFiddleKnowledgeBaseLink();
            fiddleLandingPageObject.ValidateFormControlAccessDropdown();
        }
        [TestMethod]
        [TestCategory("Exploratory")]
        public void VerifyRunOutputDisplayed()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            fiddleLandingPageObject = new DotNetFiddleLandingPage();
            fiddleLandingPageObject.ValidateRunOutputDisplayed();
        }
       
        [TestMethod]
        [TestCategory("A-B-C-D-E")]
        public void VerifyPackageSelectedBasedOnFirstNameInitial()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            fiddleLandingPageObject = new DotNetFiddleLandingPage();
            fiddleLandingPageObject.SelectFromLanguage("CSharp");
            fiddleLandingPageObject.SelectFromProjectType("Console");
            fiddleLandingPageObject.SelectFromCompiler("Net45");
            fiddleLandingPageObject.SelectPackageBasedOnNameGrouping("A-B-C-D-E", "NUnit");
            fiddleLandingPageObject.ValidateSelectionFromPackageName();
        }
        [TestMethod]
        [TestCategory("F-G-H-I-J-K")]
        public void VerifyAllowArtifactsSharingBasedOnFirstNameInitial()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            fiddleLandingPageObject = new DotNetFiddleLandingPage();
            fiddleLandingPageObject.SelectFromLanguage("CSharp");
            fiddleLandingPageObject.SelectFromProjectType("Console");
            fiddleLandingPageObject.SelectFromCompiler("Net45");
            fiddleLandingPageObject.PermissionToShareArtifactsBasedOnFirstNameInitial("F-G-H-I-J-K");
            shareLinkPage = new ShareLinkPage();
            shareLinkPage.ValidatePopupWindowAdvancedWidgetBuilderLink();
            shareLinkPage.ValidatePopupWindowHttpsCopyToClipboardIcon();
            shareLinkPage.ValidatePopupWindowIFrameCopyToClipboardIcon();
            shareLinkPage.ValidatePopupWindowLinkAddressForHttpsTextBox();
            shareLinkPage.ValidatePopupWindowLinkAddressForIframeTextBox();
            shareLinkPage.ValidatePopupWindowPreviewBtn();
            shareLinkPage.ValidatePopupWindowSendToEmailIcon();
            shareLinkPage.ValidatePopupWindowShareToFacebookIcon();
            shareLinkPage.ValidatePopupWindowShareToTwitterIcon();
            shareLinkPage.ValidatePopupWindowTitle();
        }
        [TestMethod]
        [TestCategory("L-M-N-O-P")]
        public void VerifyPermissionToChangeHomePageSettingsBasedOnFirstNameInitiale()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            fiddleLandingPageObject = new DotNetFiddleLandingPage();
            fiddleLandingPageObject.SelectFromLanguage("CSharp");
            fiddleLandingPageObject.SelectFromProjectType("Console");
            fiddleLandingPageObject.SelectFromCompiler("Net45");
            fiddleLandingPageObject.PermissionToChangeLandingPageSettingsBasedOnFirstNameInitial("L-M-N-O-P");
        }

        [TestMethod] 
        [TestCategory("Q-R-S-T-U")]
        public void VerifyPermissionToNavigateTOLoginPageBasedOnFirstNameInitial()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            fiddleLandingPageObject = new DotNetFiddleLandingPage();
            fiddleLandingPageObject.PermissionToNavigateTOLoginPageBasedOnFirstNameInitial("Q-R-S-T-U");
            loginPage = new LoginPage();
            loginPage.ValidateDotNetAcademyAccountLink();
            loginPage.ValidateDotNetFiddlSharedAccountLink();
            loginPage.ValidateEmailTextBox();
            loginPage.ValidatePasswordTextBox();
            loginPage.ValidateFacebookLink();
            loginPage.ValidateGmailLink();
            loginPage.ValidateLoginBtn();
            loginPage.ValidateLoginLabel();
            loginPage.ValidateRememberMeCheckBox();
            loginPage.ValidateResetPassowdLink();
            loginPage.ValidateSignUpLink();
            loginPage.ValidateTwitterLink();
            loginPage.CloselDialogBox();
        }
        [TestMethod] 
        [TestCategory("V-W-X-Y-Z")]
        public void VerifyPermissionToNavigateToOverviewPageBasedOnFirstNameInitial()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            fiddleLandingPageObject = new DotNetFiddleLandingPage();
            fiddleLandingPageObject.PermissionToNavigateToOverviewPageBasedOnFirstNameInitial("V-W-X-Y-Z");
            overviewPage = new OverviewPage();
            overviewPage.ValidateBackToEditorArrowBtn();
            overviewPage.ValidateCommunityOverviewHeader();
            overviewPage.ValidateFeaturesOverviewHeader();
            overviewPage.ValidateGettingStartedLink();
            overviewPage.ValidateGettingStartedOverviewHeader();
            overviewPage.ValidateLogInLink();
            overviewPage.ValidatePageTitleLogoIsDotNetFiddle();
            overviewPage.ValidateSearchIcon();
            overviewPage.ValidateSignUpLink();
            overviewPage.NavigateBackToDotNetFiddleLandingPage();
            fiddleLandingPageObject = new DotNetFiddleLandingPage();
            fiddleLandingPageObject.ValidateRunOutputDisplayed();
        }
    }
}
