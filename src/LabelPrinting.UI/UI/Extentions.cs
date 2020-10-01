using DevExpress.Office.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.Import.Interop.Access;
using Nampula.UI;
using Nampula.UI.Helpers.Extentions;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static void SetLinkedButton(this GridView gridView, DataColumnCollection dataColumnCollection)
        {
            foreach (DataColumn column in dataColumnCollection)
            {
                if (column.ColumnName.Equals("Qtd")) continue;
                gridView.Columns[column.ColumnName].OptionsColumn.ReadOnly = true;

                if (SapColumns.ContainsKey(column.ColumnName))
                    gridView.Columns[column.ColumnName].SetLinkedButton(SapColumns[column.ColumnName]);
            }
        }

        internal static Dictionary<string, BoLinkedObject> SapColumns = new Dictionary<string, BoLinkedObject>()
        {{"ItemCode", BoLinkedObject.lf_Items },
            { "CardCode", BoLinkedObject.lf_BusinessPartner},
            { "ItmsGrpCod", BoLinkedObject.lf_ItemGroups },
            { "AcctCode", BoLinkedObject.lf_GLAccounts },
        };

        internal static Dictionary<BoLinkedObject, string> SapColumnDescription = new Dictionary<BoLinkedObject, string>()
        {{ BoLinkedObject.lf_Items, "Código de item" },
            {  BoLinkedObject.lf_BusinessPartner, "Código PN"},
            {  BoLinkedObject.lf_ItemGroups, "Grupo de item" },
            {  BoLinkedObject.lf_GLAccounts , "Conta contábil"},
        };

      
    }
}
