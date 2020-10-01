using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain
{
    public interface ISboConnection
    {
        SAPbobsCOM.ICompany Company { get; }

        void CreateUserTables();
        IDbConnection Connection { get; }
    }
}
