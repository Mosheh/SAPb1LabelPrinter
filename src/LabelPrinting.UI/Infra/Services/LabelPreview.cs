using DevExpress.XtraLayout;
using LabelPrinting.UI.Domain.PrintServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Infra.Services
{
    public class LabelPreview : ILabelPreview
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resource">http://api.labelary.com/v1/printers</param>
        /// <param name="printSetting"></param>
        /// <param name="zplData"></param>
        /// <returns></returns>
        public MemoryStream GetLabel(string resource, PrintSetting printSetting, string zplData)
        {
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Accept, "image/png");
            var milimetes = GetMilimeters(printSetting);
            var size = GetLabelSizeInches(printSetting);
            var uri = $"{resource}/{milimetes}dpmm/labels/{size.Width}x{size.Heigth}/0/{zplData}";
            var bytes = webClient.DownloadData(uri);

            return new MemoryStream(bytes);
        }

        private LabelSize GetLabelSizeInches(PrintSetting printSetting)
        {
            return new LabelSize(printSetting.LabelSize.Width, printSetting.LabelSize.Heigth);
        }

        private decimal GetMilimeters(PrintSetting printSetting)
        {
            return printSetting.DPI;
        }
    }
}
