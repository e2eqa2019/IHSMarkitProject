using IHSMarkitProject.ControlHelper;
using IHSMarkitProject.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace IHSMarkitProject.PageObjectModel
{
    public class LoginPage
    {
        #region WebElements

        private readonly By loginLabel = By.XPath("//*[@class='modal-title' and @id='login-modal-label']");
        private readonly By twitterLink = By.XPath("//*[@class='remote-login' and contains(.,'Twitter')]");
        private readonly By gmailLink = By.XPath("//*[@class='remote-login' and contains(.,'Gmail')]");
        private readonly By facebookLink = By.XPath("//*[@class='remote-login' and contains(.,'Facebook')]");
        private readonly By dotNetFiddlSharedAccountLink = By.XPath("//*[@class='welly']//*[ contains(text(),'.NET Fiddle')]");
        private readonly By dotNetAcademyAccountLink = By.XPath("//*[@class='welly']//*[ contains(text(),'.NET Academy')]");
        private readonly By emailTextBox = By.XPath("//*[@id='Email' and @class='form-control']");
        private readonly By passwordTextBox = By.XPath("//*[@id='Password' and @class='form-control']");
        private readonly By rememberMeCheckBox = By.XPath("//*[@id='RememberMe' and @type='checkbox']");
        private readonly By loginBtn = By.XPath("//*[@class='btn btn-default' and @type='submit']");
        private readonly By signUpLink = By.XPath("//*[@class='row text-center']//a[contains(text(),'Sign up')]");
        private readonly By resetPassowdLind = By.XPath("//*[@class='row text-center']//a[contains(text(),'Reset password')]");
        private readonly By closeModalDialog = By.XPath("//*[@class='close' and @data-dismiss='modal']");



        #endregion

        #region Action
        public void CloselDialogBox()=>GenericHelper.GetElement(closeModalDialog).Click();
        #endregion

        #region Navigation


        #endregion
        #region Validaion
        public void ValidateLoginLabel()=>GenericHelper.GetElement(loginLabel);
        public void ValidateTwitterLink()=>GenericHelper.GetElement(twitterLink);
        public void ValidateGmailLink()=>GenericHelper.GetElement(gmailLink);
        public void ValidateFacebookLink()=>GenericHelper.GetElement(facebookLink);
        public void ValidateDotNetFiddlSharedAccountLink()=>GenericHelper.GetElement(dotNetFiddlSharedAccountLink);
        public void ValidateDotNetAcademyAccountLink()=>GenericHelper.GetElement(dotNetAcademyAccountLink);

        public void ValidateEmailTextBox()
        {
            GenericHelper.GetElement(emailTextBox);
            TextBoxHelper.TextBoxField(emailTextBox, "ValidteEmailTextBoxFunctionality@gmail.com");
        }

        public void ValidatePasswordTextBox()
        {
            GenericHelper.GetElement(passwordTextBox);
            GenericHelper.GetElement(passwordTextBox);
            TextBoxHelper.TextBoxField(passwordTextBox, "Validate TypeInto Password Text Box Functionality");
        }

        public void ValidateRememberMeCheckBox()=>GenericHelper.GetElement(rememberMeCheckBox);
        public void ValidateLoginBtn()=>  GenericHelper.GetElement(loginBtn);
        public void ValidateSignUpLink()=>  GenericHelper.GetElement(signUpLink);
        public void ValidateResetPassowdLink()=>GenericHelper.GetElement(resetPassowdLind);

        #endregion
    }
}
