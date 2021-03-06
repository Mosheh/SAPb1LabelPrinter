﻿using DevExpress.XtraExport.Xls;
using DevExpress.XtraReports.Design;
using LabelPrinting.UI.Common;
using LabelPrinting.UI.Domain;
using LabelPrinting.UI.Domain.PrintServices;
using LabelPrinting.UI.Domain.UserTables;
using SimpleQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Infra.UserTables
{
    public class LabelModelRepository : ILabelModelRepository
    {
        private ISboConnection _connection;

        public LabelModelRepository(ISboConnection sboConnection)
        {
            _connection = sboConnection;
        }
        public void Add(LabelModel labelModel)
        {
            Validated(labelModel);
            var userTable = _connection.Company.UserTables.Item(nameof(LabelModel).Prefix());

            FillProperties(labelModel, userTable);

            if (userTable.Add() != 0)
                _connection.Company.ThrowExceptionForLastError("Erro ao inserir dados do modelo");
        }

        private static void FillProperties(LabelModel labelModel, SAPbobsCOM.UserTable userTable)
        {
            userTable.Name = labelModel.Name;
            userTable.UserFields.Fields.Item(nameof(LabelModel.U_PrinterName)).Value = labelModel.U_PrinterName;

            userTable.UserFields.Fields.Item(nameof(LabelModel.U_LabelAlignTop)).Value = labelModel.U_LabelAlignTop;
            userTable.UserFields.Fields.Item(nameof(LabelModel.U_LabelAlignLeft)).Value = labelModel.U_LabelAlignLeft;
            userTable.UserFields.Fields.Item(nameof(LabelModel.U_Width)).Value = labelModel.U_Width;
            userTable.UserFields.Fields.Item(nameof(LabelModel.U_Length)).Value = labelModel.U_Length;

            if (!string.IsNullOrEmpty(labelModel.U_ZplCode))
                userTable.UserFields.Fields.Item(nameof(LabelModel.U_ZplCode)).Value = labelModel.U_ZplCode;
            if (!string.IsNullOrEmpty(labelModel.U_Query))
                userTable.UserFields.Fields.Item(nameof(LabelModel.U_Query)).Value = labelModel.U_Query;
            if (!string.IsNullOrEmpty(labelModel.U_FieldsName))
                userTable.UserFields.Fields.Item(nameof(LabelModel.U_FieldsName)).Value = labelModel.U_FieldsName;

            userTable.UserFields.Fields.Item(nameof(LabelModel.U_DecimalPlaces)).Value = labelModel.U_DecimalPlaces;
            userTable.UserFields.Fields.Item(nameof(LabelModel.U_NColumns)).Value = labelModel.U_NColumns;
        }

        private void Validated(LabelModel labelModel)
        {
            if (labelModel == null)
                throw new Exception("Dados inválidos");
            if (string.IsNullOrEmpty(labelModel.Name))
                throw new Exception("Nome inválido");
            if (string.IsNullOrEmpty(labelModel.U_PrinterName))
                throw new Exception("Impressora não informada");

            if(labelModel.U_NColumns<=0)
                throw new Exception("N colunas inválido");
            if (labelModel.U_DecimalPlaces < 0)
                throw new Exception("N de cassas decimais inválido");
            
        }

        public IEnumerable<LabelModel> GetAll()
        {
            var sql = "SELECT * FROM \"@IV_LP_LABELMODEL\"";
            return _connection.Connection.Query<LabelModel>(sql);
        }

        public void Remove(int key)
        {
            var userTable = _connection.Company.UserTables.Item(nameof(LabelModel).Prefix());
            if (!userTable.GetByKey(key.ToString()))
                throw new Exception("Modelo não encontrado");

            if (userTable.Remove() != 0)
                _connection.Company.ThrowExceptionForLastError("Erro ao remover modelo");

        }

        public void Update(LabelModel labelModel)
        {
            var userTable = _connection.Company.UserTables.Item(nameof(LabelModel).Prefix());
            userTable.GetByKey(labelModel.Code);

            FillProperties(labelModel, userTable);
            if (userTable.Update() != 0)
                _connection.Company.ThrowExceptionForLastError("Erro ao atualizar dados do modelo");
        }

        public LabelModel GetByKey(int key)
        {
            var sql = $"SELECT * FROM [@IV_LP_LABELMODEL] where \"Code\"={key}".ToSQLAnsi();
            var list = _connection.Connection.Query<LabelModel>(sql);
            return list.LastOrDefault();
        }
    }
}
