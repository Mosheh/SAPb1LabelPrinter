using DevExpress.Office.Utils;
using DevExpress.XtraReports.Import.Interop.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.UI
{
    public static class Extentions
    {
        public static void FillControls<T>(this Dictionary<string, Control> bind, T model) where T: class, new()
        {
            foreach (var item in bind)
            {
                
            }
        }

        public static bool ExistKey(this Nampula.UI.ComboBox comboBox, object key)
        {
            if (key == null) return false;
            for (int i = 0; i < comboBox.ValidValues.Count; i++)
            {                

                if (comboBox.ValidValues.Item(i).Value.ToString() == key.ToString())
                    return true;
            }

            return false;
        }
    }
}
