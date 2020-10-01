using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.SAP
{
    [Table("OITB")]
    public class ItemGroup
    {
        public int ItmsGrpCod { get; set; }
        public string ItmsGrpNam { get; set; }
    }
}
