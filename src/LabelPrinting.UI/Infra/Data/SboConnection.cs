using DevExpress.CodeParser;
using LabelPrinting.UI.Domain;
using LabelPrinting.UI.Infra.UserTables;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabelPrinting.UI.Common;
using System.Runtime.InteropServices;
using LabelPrinting.UI.Domain.Filters;
using DevExpress.DataProcessing;
using DevExpress.XtraReports.UI;

namespace LabelPrinting.UI.Infra.Data
{
    public class SboConnection : ISboConnection
    {

        public static void Init(ICompany company, IDbConnection dbConnection)
        {
            if (company == null)
                throw new Exception("Objeto de conexão inválido");

            SboConnection.company = company;
            SboConnection._connection = dbConnection;

        }

        public void CreateUserTables()
        {
            var list = new UserTableList(this);
            foreach (var item in list.Tables)
            {
                if (!Company.ExistsTable(item.TableName))
                {
                    var userTablesMd = Company.GetUserTableMd();
                    try
                    {
                        userTablesMd.TableName = item.TableName;
                        userTablesMd.TableDescription = item.TableDescription;
                        userTablesMd.TableType = item.TableType;

                        if (userTablesMd.Add() != 0)
                            Company.ThrowExceptionForLastError("Criação de Tabela de Usuário ");
                    }
                    finally
                    {
                        Marshal.ReleaseComObject(userTablesMd);
                    }
                }

                foreach (var field in item.Fields)
                {
                    if (!Company.ExistsField($"@{field.TableName}", field.Name))
                        AddUserField(field);
                }
            }



        }

        private void AddUserField(Domain.UserTables.UserField userField)
        {
            UserFieldsMD userFieldMd = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            var company = Company;
            userFieldMd = company.GetUserFieldMd();

            try
            {
                userFieldMd.TableName = userField.TableName;

                userFieldMd.Name = userField.Name;
                userFieldMd.Description = userField.Description;
                userFieldMd.Type = userField.Type;


                if (userField.SubType != BoFldSubTypes.st_None)
                    userFieldMd.SubType = userField.SubType;

                if (userField.Size != 0)
                    userFieldMd.EditSize = userField.Size;


                if (userFieldMd.Add() != 0)
                {
                    var message = $"$Criação de Campo de Usuário [{userField.TableName} - {userField.Name}]";
                    company.ThrowExceptionForLastError(message);
                }
            }
            finally
            {

                userFieldMd.ReleaseCom();
            }
        }

        public DataTable ExecuteSelect(string selectSql)
        {
            var currentState = Connection.State;
            if (currentState == ConnectionState.Closed)
                AppSession.SboConnection.Connection.Open();

            var command = AppSession.SboConnection.Connection.CreateCommand();

            command.CommandText = selectSql;

            var reader = command.ExecuteReader();
            var data = new DataTable();
            data.Load(reader);

            if (currentState == ConnectionState.Closed)
                AppSession.SboConnection.Connection.Close();

            return data;
        }

        public DataColumnCollection GetColumns(string selectSql)
        {
            var strSql = "";
            if (Nampula.DI.Connection.Instance.IsHana)
                strSql = $"select * from ({selectSql}) limit 1";
            else
                strSql = $"select top 1 * from ({selectSql}) RESSULT";

            var data = ExecuteSelect(strSql);

            return data.Columns;
        }

        public DataTable ExecuteSelectFiltering(string selectSql, params ColumnFilter[] columnFilters)
        {

            var strSql = $"select * from ({selectSql}) T";
            var validFilters = columnFilters.Where(c => c.Value != null).Where(c => c.Value.ToString() != string.Empty).ToList();

            bool isFirst = true;
            foreach (var filter in validFilters)
            {
                if (isFirst)
                    strSql += $" where \"T\".\"{filter.ColumnName}\"={GetValueField(filter)}";
                else
                    strSql += $" and \"T\".\"{filter.ColumnName}\"={GetValueField(filter)}";

                isFirst = false;
            }

            var data = ExecuteSelect(strSql);
            return data;
        }

        private object GetValueField(ColumnFilter filter)
        {
            switch (filter.Type.Name)
            {
                case "Int16":
                    return filter.Value;
                case "Int32":
                    return filter.Value;
                case "Int64":
                    return filter.Value;
                case "String":
                    return $"'{filter.Value}'";
                case "Decimal":
                    return $"{filter.Value}";
                case "Double":
                    return $"{filter.Value}";

                default:
                    throw new Exception($"Tipo não mapeado {filter.Type}");                    
            }
        }

        private static ICompany company;


        public ICompany Company
        {
            get
            {
                if (company == null)
                    throw new Exception("Método init não foi chamado");
                return company;
            }
            private set { company = value; }
        }

        private static IDbConnection _connection;

        public IDbConnection Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

    }
}
