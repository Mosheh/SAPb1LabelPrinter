using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.PrintServices
{
    [Table("@IV_LP_LABELMODEL")]
    public class LabelModel
    {
        public LabelModel()
        {

        }        

        public string Code { get; set; }
        public string Name { get; set; }
        public string U_ZplCode { get; set; }
        public string U_PrinterName { get; set; }
        public int U_LabelAlignTop { get; set; } = 0;
        public int U_LabelAlignLeft { get; set; } = 0;
        public int U_Width { get; set; } = 812;
        public int U_Length { get; set; } = 309;
        public string U_Query { get; set; }
        public string U_FieldsName{ get; set; }

        public void SetFields(DataColumnCollection dataColumnCollection)
        {
            U_FieldsName = string.Empty;

            var stringColumns = new StringBuilder("|");
            foreach (DataColumn column in dataColumnCollection)
            {
                stringColumns.Append($"{column.ColumnName}|");
            }

            U_FieldsName = stringColumns.ToString();
        }
    }
}
