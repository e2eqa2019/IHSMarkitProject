using IHSMarkitProject.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHSMarkitProject.ControlHelper
{
   public class TextBoxHelper
    {
        private static IWebElement element;

        public static void ClearTextBoxField(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Clear();
        }
        public static void TextBoxField(By locator, string text)
        {
            element = GenericHelper.GetElement(locator);
            element.SendKeys(text);
        }
    }
}
