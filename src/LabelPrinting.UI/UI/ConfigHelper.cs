using Nampula.DI;
using Nampula.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.UI
{
    public class ConfigHelper
    {
        public static bool IsStandalone
        {
            get { return ConfigurationManager.AppSettings["Standalone"].To<bool>(); }
        }

        public static string Server
        {
            get { return ConfigurationManager.AppSettings["Server"]; }
        }
        public static string UserDb
        {
            get { return ConfigurationManager.AppSettings["UserDb"]; }
        }
        public static string UserDbPassword
        {
            get { return ConfigurationManager.AppSettings["UserDbPassword"]; }
        }

        public static DbServerType ServerType
        {
            get { return (DbServerType) ConfigurationManager.AppSettings["ServerType"].To<int>(); }
        }

        public static string CompanyDb
        {
            get { return ConfigurationManager.AppSettings["CompanyDb"]; }
        }

        public static string User
        {
            get { return ConfigurationManager.AppSettings["User"]; }
        }

        public static string Password
        {
            get { return ConfigurationManager.AppSettings["Password"]; }
        }
    }
}
