using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.Filters
{
    public class ColumnFilter
    {
        public string ColumnName { get; set; }
        public string ColumnDescription { get; set; }
        public object Value { get; set; }
        public string Description { get; set; }
        public Type Type { get; set; }
        public Nampula.UI.BoLinkedObject BoLinkedObject { get; set; }
    }
}
