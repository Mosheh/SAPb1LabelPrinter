using LabelPrinting.UI.Domain.PrintServices;
using SharpZebra;
using SharpZebra.Commands;
using SharpZebra.Printing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Infra.ZebraPrinterHelpers
{
    public class ZebraPrinterHelper
    {
        public void PrintLabel(string label, string printerName, LabelModel model)
        {
            if (string.IsNullOrEmpty(printerName))
                throw new Exception("Nenhuma impressora selecionada.");

            var page = new List<byte>();
            var printerSettings = GetPrinterSettings(printerName, model);

            var barCode = new Barcode
            {
                Type = BarcodeType.CODE128_AUTO,
                BarWidthNarrow = 3
            };

            page.AddRange(ZPLCommands.ClearPrinter(printerSettings));
            page.AddRange(ZPLCommands.BarCodeWrite(printerSettings.AlignLeft, printerSettings.AlignTop, 100, ElementDrawRotation.NO_ROTATION, barCode, true, label));

            Print(page, printerSettings);
        }

        private void Print(List<byte> page, PrinterSettings printerSettings)
        {
            new SpoolPrinter(printerSettings).Print(page.ToArray());
        }

        private PrinterSettings GetPrinterSettings(string printerName, LabelModel setting)
        {
            var printerSettings = new PrinterSettings
            {
                AlignLeft = setting.U_LabelAlignLeft,
                AlignTop = setting.U_LabelAlignTop,
                Width = 203 * 4,
                Length = 309,
                Darkness = 12,
                PrintSpeed = 2,
                PrinterName = printerName
            };

            return printerSettings;
        }
    }
}
