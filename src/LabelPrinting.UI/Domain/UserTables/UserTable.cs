using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.UserTables
{
    public class UserTable
    {
        public string TableName { get; set; }

        public BoUTBTableType TableType { get; set; }
        public string TableDescription { get; internal set; }

        public List<UserField> Fields { get; set; } = new List<UserField>();
    }
}
