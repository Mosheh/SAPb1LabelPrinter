using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.SAP
{
    [Table("OCRD")]
    public class BusinessPartner
    {
        public string CardCode { get; set; }
        public string CardName { get; set; }
    }
}
