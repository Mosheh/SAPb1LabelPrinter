using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.PrintServices
{
    public class PrintSetting
    {
        public PrintSetting()
        {
            Unit = Unit.Millimeter;
            this.DPI = 6;
            this.LabelSize = new LabelSize(6, 4);
        }
        public Unit Unit { get; set; } 
        public decimal DPI { get; set; }
        public LabelSize LabelSize { get; set; }
    }

    /// <summary>
    /// M
    /// </summary>
    public enum Unit
    {
        Millimeter,
        Centimeters,
        Inches
    }

    public struct LabelSize
    {
        public LabelSize(decimal width, decimal height)
        {
            this.Width = width;
            this.Heigth = height;
        }
        public decimal Width { get; set; }
        public decimal Heigth { get; set; }

    }

}
