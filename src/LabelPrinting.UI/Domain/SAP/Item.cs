using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.SAP
{
    [Table("OITM")]
    public class Item
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
    }
}
