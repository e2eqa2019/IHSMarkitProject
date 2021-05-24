using IHSMarkitProject.ControlHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IHSMarkitProject.Settings;
using System.Collections.ObjectModel;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using OpenQA.Selenium.Support.UI;

namespace IHSMarkitProject.PageObjectModel
{
    public class ShareLinkPage
    {
        #region WebElements
        private readonly By popupWindowTitle = By.XPath("//*[@id='share-dialog' and @class='sub-dialog show']//b[contains(text(),'Share Link')]");
        private readonly By linkAddressForIframeTextBox = By.XPath("//*[@class='share-input share-widget-output' and @id='EmbedLink']");
        private readonly By advancedWidgetBuilderLink = By.XPath("//*[@class='share-input share-widget-output' and @id='EmbedLink']");
        private readonly By previewBtn = By.XPath("//*[@id='widget-preview' and @class='btn']");
        private readonly By httpsCopyToClipboardIcon = By.XPath("//*[@id='share-dialog' and@class='sub-dialog show']/*[@class='copy-clipboard' and @title='Copy to Clipboard']");
        private readonly By iFrameCopyToClipboardIcon = By.XPath("//*[@style='position: relative;' ]/*[@class='copy-clipboard' and @title='Copy to Clipboard']");
        private readonly By sendToEmailIcon = By.XPath("//*[@class='email-share' and@id='email-share']");
        private readonly By shareToTwitterIcon = By.XPath("//*[@class='twitter-share' and@title='Share to Twitter']");
        private readonly By shareToFacebookIcon = By.XPath("//*[@class='facebook-share' and@title='Share to Facebook']");
        #endregion

        #region Action
        
        #endregion

        #region Navigation

        #endregion

        #region Validation Region
        public void ValidatePopupWindowTitle()=>GenericHelper.GetElement(popupWindowTitle);
        public void ValidatePopupWindowLinkAddressForHttpsTextBox()
        {
            string expectedResult = "https://dotnetfiddle.net/CsCons";
            var actualResult = ((IJavaScriptExecutor)ObjectRepository.Driver).ExecuteScript("return document.querySelector('#ShareLink').value;").ToString();
            Console.WriteLine(actualResult);
            Assert.IsTrue(actualResult.StartsWith("https"));
            Assert.AreEqual(actualResult, expectedResult);
        }
        public void ValidatePopupWindowLinkAddressForIframeTextBox() =>GenericHelper.GetElement(linkAddressForIframeTextBox);
        public void ValidatePopupWindowAdvancedWidgetBuilderLink()=>GenericHelper.GetElement(advancedWidgetBuilderLink);
        public void ValidatePopupWindowPreviewBtn()=>GenericHelper.GetElement(previewBtn);
        public void ValidatePopupWindowHttpsCopyToClipboardIcon()=>GenericHelper.GetElement(httpsCopyToClipboardIcon);
        public void ValidatePopupWindowIFrameCopyToClipboardIcon()=>GenericHelper.GetElement(iFrameCopyToClipboardIcon);
        public void ValidatePopupWindowSendToEmailIcon()=>GenericHelper.GetElement(sendToEmailIcon);
        public void ValidatePopupWindowShareToTwitterIcon()=>GenericHelper.GetElement(shareToTwitterIcon);
        public void ValidatePopupWindowShareToFacebookIcon()=>GenericHelper.GetElement(shareToFacebookIcon);
        #endregion
    }
}
