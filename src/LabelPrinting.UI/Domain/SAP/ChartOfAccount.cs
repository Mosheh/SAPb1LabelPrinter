using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.SAP
{
    [Table("OACT")]
    public class ChartOfAccount
    {
        public string AcctCode { get; set; }
        public string AcctName { get; set; }
    }
}
