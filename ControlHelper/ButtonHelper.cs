using IHSMarkitProject.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IHSMarkitProject.ControlHelper
{
    public class ButtonHelper
    {
        public static void ClickEvent(By locator)
        {

            Actions action = new Actions(ObjectRepository.Driver);
            action.MoveToElement(GenericHelper.GetElement(locator)).Click().Build().Perform();
            Thread.Sleep(3000);

        }
    }
}
