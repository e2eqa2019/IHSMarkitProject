using IHSMarkitProject.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHSMarkitProject.ControlHelper
{
   public class JavaScriptPopUpHelper
    {
        public static bool IsPopUpPresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        public static string GetPopUpText()
        {

            if (!IsPopUpPresent())
            {
                return string.Empty;
            }
            else
            {
                return ObjectRepository.Driver.SwitchTo().Alert().Text;
            }
        }
    }
}
