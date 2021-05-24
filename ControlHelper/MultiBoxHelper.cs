using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHSMarkitProject.ControlHelper
{
    public class MultiBoxHelper
    {
        private static SelectElement select;

        public static void SelectAnElement(By locator, string visibleText)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByValue(visibleText);
        }

        public static void BootstrpMultiSelectElementDropDown(By locator, string text)

        {
            TextBoxHelper.ClearTextBoxField(locator);
            TextBoxHelper.TextBoxField(locator, text);
            ButtonHelper.ClickEvent(locator);
            
        }
    }
}
