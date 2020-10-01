using LabelPrinting.UI.Domain.Filters;
using SAPbouiCOM;
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

        System.Data.DataTable ExecuteSelect(string selectSql);

        System.Data.DataTable ExecuteSelectFiltering(string selectSql, params ColumnFilter[] columnFilters);
        DataColumnCollection GetColumns(string selectSql);
    }
}
