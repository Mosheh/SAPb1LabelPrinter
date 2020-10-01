using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Common
{
    public static class Extentions
    {
        public static bool ExistsTable(this ICompany company, string tableName)
        {
            var tableCount = company.SqlExecuteScalar<int>(
              $"SELECT 1 FROM [OUTB] WHERE [TableName] = '{tableName.ToUpper()}'".ToSQLAnsi());

            return tableCount > 0;
        }

        public static bool ExistsField(this ICompany company, string tableName, string fieldName)
        {
            var querForCountField =
             $"Select Count('A') AS Count From CUFD Where (\"TableID\" = '{tableName.ToUpper()}' OR \"TableID\" = '@{tableName.ToUpper()}') And \"AliasID\" = '{fieldName}'";

            var countOfUserField = company.SqlExecuteScalar<int>(querForCountField);

            return countOfUserField != 0;
        }

        public static string Prefix(this string value)
        {
            return $"IV_LP_{value}";
        }
        public static string PrefixUserTable(this string value)
        {
            return $"@IV_LP_{value}";
        }

        public static string ToSQLAnsi(this string value)
        {
            return value.Replace("[", "\"").Replace("]", "\"");
        }

        public static UserTablesMD GetUserTableMd(this ICompany company)
        {
            var userFieldMd = company.GetBusinessObject(BoObjectTypes.oUserTables) as UserTablesMD;

            Debug.Assert(userFieldMd != null, "userFieldMd != null");

            return userFieldMd;
        }

        public static UserFieldsMD GetUserFieldMd(this ICompany company)
        {
            var userFieldMd = company.GetBusinessObject(BoObjectTypes.oUserFields) as UserFieldsMD;

            Debug.Assert(userFieldMd != null, "partner != null");

            return userFieldMd;
        }

        public static void ThrowExceptionForLastError(this ICompany company, string message)
        {
            var messageException = $"{message}:\n Código do Erro [{company.GetLastErrorCode()}] - [{company.GetLastErrorDescription()}]";

            throw new Exception(messageException);
        }

        public static void SqlExecute(this ICompany sboCompany, string query)
        {
            var recordSet = sboCompany.GetBusinessObject(BoObjectTypes.BoRecordset) as Recordset;

            try
            {

                recordSet.DoQuery(query);
            }
            finally
            {
                recordSet.ReleaseCom();
            }
        }

        public static TT SqlExecuteScalar<TT>(this ICompany sboCompany, string query)
        {
            var recordSet = sboCompany.GetBusinessObject(BoObjectTypes.BoRecordset) as Recordset;

            try
            {

                recordSet.DoQuery(query);

                return !recordSet.EoF
                    ? (TT)Convert.ChangeType(recordSet.Fields.Item(0).Value, typeof(TT))
                    : default(TT);
            }
            finally
            {
                if (recordSet != null)
                    Marshal.ReleaseComObject(recordSet);
            }
        }

        public static void ReleaseCom(this object comObject)
        {
            if (comObject != null)
                Marshal.ReleaseComObject(comObject);
        }
    }
}
