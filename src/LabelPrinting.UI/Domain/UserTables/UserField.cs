using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.UserTables
{
    public class UserField
    {
        public string TableName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BoFieldTypes Type { get; set; }
        public BoFldSubTypes SubType { get; set; }
        public int Size { get; set; }
        public string AliasID { get; set; }        

    }
}
