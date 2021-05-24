using IHSMarkitProject.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IHSMarkitProject.ControlHelper
{
   public class GenericHelper
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                bool flag = ObjectRepository.Driver.FindElements(locator).Count == 1;
                Thread.Sleep(2000);
                return flag;
            }
            catch (Exception)
            {

                return false;
            }
          
        }
        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator))
            {
                IWebElement element =ObjectRepository.Driver.FindElement(locator);
                return element;

            }
            else
            {
                throw new NoSuchElementException("Element Not Found!" +locator.ToString());
            }
        }
     
    }
}
