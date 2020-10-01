using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.PrintServices
{
    public interface ILabelPreview
    {
        MemoryStream GetLabel(string resource, PrintSetting printSetting, string zplData );

    }
}
