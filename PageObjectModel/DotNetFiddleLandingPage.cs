using IHSMarkitProject.ControlHelper;
using IHSMarkitProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace IHSMarkitProject.PageObjectModel
{
	public class DotNetFiddleLandingPage
	{
		#region WebElement
		private readonly By newBtn = By.XPath("//*[@class ='btn btn-default' and @id='new-button']");
		private readonly By saveBtn = By.XPath("//*[@class ='btn btn-default' and @id='save-button']");
		private readonly By runBtn = By.XPath("//*[@class ='btn btn-default' and @id='run-button']");
        private readonly By shareBtn = By.XPath("//*[@class ='btn btn-default' and @id='Share']");
        private readonly By collaborateBtn = By.XPath("//*[@class ='btn btn-default' and @id='togetherjs']");
		private readonly By gettingStartedLink = By.XPath("//a[@class ='btn btn-default' and @type='button'and contains(.,' Getting Started')]");
		private readonly By dropdownArrow = By.XPath("//*[@class ='btn btn-default dropdown-toggle' and @id='tidyup-extra']");
		private readonly By searchIcon = By.XPath("//*[@class ='glyphicon glyphicon glyphicon-search' ]");
		private readonly By logInLink = By.XPath("//*[@class='user-name' and @id='login-button']");
		private readonly By signUpLink = By.XPath("//*[@class='user-name' and @id='signup-button']");
		private readonly By groupNavigationDropdownBtn = By.XPath("//*[@class='btn-group navbar-btn']//*[@class='btn btn-default dropdown-toggle']");
		private readonly By alignJustiiedIcon = By.XPath("//*[@class ='glyphicon glyphicon-align-justify' ]");
		private readonly By optionsLabel = By.XPath("//*[@class='text-center']/*[text()='Options']");
		private readonly By letArrowToggle = By.XPath("//*[@class='btn btn-default btn-xs btn-sidebar-toggle']/*[@class='glyphicon glyphicon-chevron-left']");
		private readonly By rightArrowToggleExpander = By.XPath("//*[@class='expander']/*[@class='glyphicon glyphicon-chevron-right']");
		private readonly By languageDropdownArrow = By.XPath("//*[@id='Language']");
		private readonly By projectTypeDropDownArrow = By.XPath("//*[@id='ProjectType']");
		private readonly By compilerDrowDownArrow = By.XPath("//*[@id='Compiler']");
		private readonly By sidebarPushpin = By.XPath("//*[@class='btn btn-default btn-xs btn-sidebar-pin']/span[@class='glyphicon glyphicon-pushpin']");
		private readonly By packageNameSearchBox = By.XPath("//*[@class='new-package form-control input-sm' and @placeholder='Package name...']");
		private readonly By autoRunYes = By.XPath("//*[@id='IsAutoRun_Yes' and @type='radio']");
		private readonly By autoRunNo = By.XPath("//*[@id='IsAutoRun_No' and @type='radio']");
		private readonly By dotNetFiddleKnowledgeBaseLink = By.XPath("//*[@class='glyphicon glyphicon-info-sign']");
		private readonly By formControlAccessDropdown = By.XPath("//*[@class='btn btn-default dropdown-toggle form-control' and @data-toggle='dropdown']");
		private readonly By nUnitAsAFeature = By.XPath("//*[@id='menu' and @class='ui-menu ui-widget ui-widget-content ui-corner-all']/li[contains(@title, 'NUnit features a fluent assert syntax')]");
		private readonly By nUnitPackageVersionNumber = By.XPath("//*[@class='ui-menu ui-widget ui-widget-content ui-corner-all' and @style='display: block; top: 4px; left: 227px; overflow: hidden auto;']//li[@class='ui-menu-item']//a[@package-id='NUnit' and @version-name='3.12.0.0']");
		private readonly By nUnitPackageName = By.XPath("//*[@package-id='NUnit' and @class='package-name' and contains(text(),'NUnit')] ");
		private readonly By runResponseValidation = By.XPath("//*[@id='output'and @class='output']");



		#endregion

		#region Action
		public void SelectFromLanguage(string value)
        {
			MultiBoxHelper.SelectAnElement(languageDropdownArrow,value);
        }

		public void SelectFromProjectType(string value)
		{
			MultiBoxHelper.SelectAnElement(projectTypeDropDownArrow, value);
		}

        public void SelectFromCompiler(string value)
        {
            MultiBoxHelper.SelectAnElement(compilerDrowDownArrow, value);
        }

		public void SelectPackageBasedOnNameGrouping(string name, string text)
		{
            if (name.ToUpper().StartsWith("A")||name.ToUpper().StartsWith("B") || name.ToUpper().StartsWith("C") || name.ToUpper().StartsWith("D") || name.ToUpper(). StartsWith("E"))
			{
				MultiBoxHelper.BootstrpMultiSelectElementDropDown(packageNameSearchBox, text);
                ButtonHelper.ClickEvent(packageNameSearchBox);
                ButtonHelper.ClickEvent(nUnitAsAFeature);
                ButtonHelper.ClickEvent(nUnitPackageVersionNumber);
            }
		}

		public void PermissionToShareArtifactsBasedOnFirstNameInitial(string firstName)
		{
			if (firstName.ToUpper().StartsWith("F") || firstName.ToUpper().StartsWith("G") || firstName.ToUpper().StartsWith("H") || firstName.ToUpper().StartsWith("I") || firstName.ToUpper().StartsWith("J") || firstName.ToUpper().StartsWith("K"))
			{
				NavigateToShareLinkPage();
			}
		}

		public void PermissionToChangeLandingPageSettingsBasedOnFirstNameInitial(string firstName)
		{
			if (firstName.ToUpper().StartsWith("L") || firstName.ToUpper().StartsWith("M") || firstName.ToUpper().StartsWith("N") || firstName.ToUpper().StartsWith("O") || firstName.ToUpper().StartsWith("P") )
			{
				IWebElement element =GenericHelper.GetElement(letArrowToggle);
				Assert.IsTrue(element.Displayed);
				ButtonHelper.ClickEvent(letArrowToggle);
				Assert.IsFalse(element.Displayed);
			}
		}

		public void PermissionToNavigateTOLoginPageBasedOnFirstNameInitial(string firstName)
		{
			if (firstName.ToUpper().StartsWith("Q") || firstName.ToUpper().StartsWith("R") || firstName.ToUpper().StartsWith("S") || firstName.ToUpper().StartsWith("T") || firstName.ToUpper().StartsWith("U"))
			{
				NavigateToLoginPage();
			}
		}

		public void PermissionToNavigateToOverviewPageBasedOnFirstNameInitial(string firstName)
		{
			if (firstName.ToUpper().StartsWith("V") || firstName.ToUpper().StartsWith("W") || firstName.ToUpper().StartsWith("X") || firstName.ToUpper().StartsWith("Y") || firstName.ToUpper().StartsWith("Z"))
			{
				NavigateToOverviewPage();
			}
		}

		public void SelectFromNuGetPackage(string text)
		{
			MultiBoxHelper.BootstrpMultiSelectElementDropDown(packageNameSearchBox, text);
			ButtonHelper.ClickEvent(packageNameSearchBox);
			ButtonHelper.ClickEvent(nUnitAsAFeature);
		}

		public void SelectFromNunitPackageVersionNumber()
		{
			ButtonHelper.ClickEvent(nUnitPackageVersionNumber);
        }

		#endregion

		#region Navigation
		public ShareLinkPage NavigateToShareLinkPage()
        {
			var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(30));
			wait.Until(ExpectedConditions.ElementToBeClickable(GenericHelper.GetElement(shareBtn))).Click();
			return new ShareLinkPage();
		}

		public LoginPage NavigateToLoginPage()
		{
			var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(30));
			wait.Until(ExpectedConditions.ElementToBeClickable(GenericHelper.GetElement(saveBtn))).Click();
			return new LoginPage();
		}

		public OverviewPage NavigateToOverviewPage()
		{
			GenericHelper.GetElement(gettingStartedLink).Click();
			return new OverviewPage();
		}
		#endregion

		#region Validation


		public void ValidateRunOutputDisplayed()
		{
			var expectedRunResponse = "Hello World";
			GenericHelper.GetElement(runBtn);
			IWebElement actualRunResponse=GenericHelper.GetElement(runResponseValidation);
			Assert.AreEqual(expectedRunResponse, actualRunResponse.Text);
		}

		public void ValidateSelectionFromPackageName() => GenericHelper.GetElement(nUnitPackageName);
		public void ValidateNewBtn()=> GenericHelper.GetElement(newBtn);
		public void ValidateSaveBtn() => GenericHelper.GetElement(saveBtn);
		public void ValidateRunBtn() => GenericHelper.GetElement(runBtn);
		public void ValidateShareBtn() => GenericHelper.GetElement(shareBtn);
		public void ValidateCollaborateBtn() => GenericHelper.GetElement(collaborateBtn);
		public void ValidateTidyUpdropdownArrow() => GenericHelper.GetElement(dropdownArrow);
		public void ValidateGettingStartedLink() => GenericHelper.GetElement(gettingStartedLink);
		public void ValidateSearchIcon() => GenericHelper.GetElement(searchIcon);
		public void ValidateLogInLink() => GenericHelper.GetElement(logInLink);
		public void ValidateSignUpLink() => GenericHelper.GetElement(signUpLink);
		public void ValidateGroupNavigationDropdownBtn() => GenericHelper.GetElement(groupNavigationDropdownBtn);
		public void ValidateAlignJustiiedIcon() => GenericHelper.GetElement(alignJustiiedIcon);
		public void ValidateOptionsLabel() => GenericHelper.GetElement(optionsLabel);
		public void ValidateLetArrowToggle() => GenericHelper.GetElement(letArrowToggle);
		public void ValidateRightArrowToggleExpander() => GenericHelper.GetElement(rightArrowToggleExpander);
		public void ValidateLanguageDropdownArrow() => GenericHelper.GetElement(languageDropdownArrow);
		public void ValidateProjectTypeDropDownArrow() => GenericHelper.GetElement(projectTypeDropDownArrow);
		public void ValidatecompilerDrowDownArrow() => GenericHelper.GetElement(compilerDrowDownArrow);
		public void ValidateSidebarPushpin() => GenericHelper.GetElement(sidebarPushpin);
		public void ValidatePackageNameSearchBox() => GenericHelper.GetElement(packageNameSearchBox);
		public void ValidateAutoRunYes() => GenericHelper.GetElement(autoRunYes);
		public void ValidateAutoRunNo() => GenericHelper.GetElement(autoRunNo);
		public void ValidateDotNetFiddleKnowledgeBaseLink() => GenericHelper.GetElement(dotNetFiddleKnowledgeBaseLink);
		public void ValidateFormControlAccessDropdown() => GenericHelper.GetElement(formControlAccessDropdown);
		public void ValidateNUnitAsAFeature() => GenericHelper.GetElement(nUnitAsAFeature);
		public void ValidateNUnitPackageVersionNumber() => GenericHelper.GetElement(nUnitPackageVersionNumber);
		public void ValidateNUnitPackageName() => GenericHelper.GetElement(nUnitPackageName);
		public void ValidateRunResponseValidation() => GenericHelper.GetElement(runResponseValidation);




		#endregion
	}
}
