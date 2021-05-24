using IHSMarkitProject.Configuration;
using IHSMarkitProject.CustomeException;
using IHSMarkitProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHSMarkitProject
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;

        }
        private static IWebDriver GetEdgeDriver()
        {
            var options = new Microsoft.Edge.SeleniumTools.EdgeOptions();
            options.UseChromium = true;
            options.AddArgument("--no-sandbox");
            IWebDriver driver = new Microsoft.Edge.SeleniumTools.EdgeDriver(options);
            return driver;

        }
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.Edge:
                    ObjectRepository.Driver = GetEdgeDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                default:
                    throw new NoSuitableDriverFound("Driver Not Found !" + ObjectRepository.Config.GetBrowser().ToString());
            }
        }
        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Quit();
            }
        }

    }
}
