using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Nampula.Framework;

namespace LabelPrinting.UI.Infra.Helpers
{
    public class SettingPrinter
    {
        public static List<string> GetPrinterNames()
        {
            var names = new List<string>();
            var printerQuery = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");

            foreach (var printer in printerQuery.Get())
            {
                var name = printer.GetPropertyValue("Name") ?? string.Empty;
                var isNertWork = printer.GetPropertyValue("NetWork") ?? false;
                var ServerName = printer.GetPropertyValue("ServerName") ?? string.Empty;

                if (isNertWork.To<bool>())
                    name = name.ToString().RemoveCharacter(ServerName.ToString(), "");

                names.Add(name.ToString());
            }

            return names;
        }

        public string GetPrinterName(string partialPrinterName)
        {
            var printerQuery = new ManagementObjectSearcher(string.Format("SELECT * FROM Win32_Printer WHERE Name LIKE '%{0}'", partialPrinterName));
            var printerName = string.Empty;

            foreach (var printer in printerQuery.Get())
            {
                printerName = printer.GetPropertyValue("Name") == null ?
                              string.Empty : printer.GetPropertyValue("Name").ToString();

                break;
            }

            return printerName;
        }
    }
}
