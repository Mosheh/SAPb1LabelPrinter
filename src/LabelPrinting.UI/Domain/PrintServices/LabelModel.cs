using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string U_Query { get; set; }
    }
}
