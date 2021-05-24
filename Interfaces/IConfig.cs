using IHSMarkitProject.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHSMarkitProject.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetUserName();
        string GetPassword();
        string GetWebsite();

    }
}
