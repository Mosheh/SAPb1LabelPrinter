using LabelPrinting.UI.Domain;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Infra.UserTables
{
    public class UserTableList
    {
        private ISboConnection _sboConnection;

        public UserTableList(ISboConnection sboConnection)
        {
            _sboConnection = sboConnection;
            FillAllTables();            
        }   

        public List<Domain.UserTables.UserTable> Tables { get; set; } = new List<Domain.UserTables.UserTable>();        
        private void FillAllTables()
        {
            var tableLabelModel = new Domain.UserTables.UserTable();
            tableLabelModel.TableName = "IV_LP_LabelModel";
            tableLabelModel.TableDescription = "Modelo de etiqueta";
            tableLabelModel.TableType = BoUTBTableType.bott_NoObjectAutoIncrement;
            this.Tables.Add(tableLabelModel);

            var fieldName = new Domain.UserTables.UserField();
            fieldName.TableName = "IV_LP_LabelModel";
            fieldName.Name = "ZplCode";
            fieldName.Type = BoFieldTypes.db_Memo;
            
            tableLabelModel.Fields.Add(fieldName);

            var fieldPrinterName = new Domain.UserTables.UserField();
            fieldPrinterName.TableName = "IV_LP_LabelModel";
            fieldPrinterName.Name = "PrinterName";
            fieldPrinterName.Type = BoFieldTypes.db_Alpha;
            fieldPrinterName.Description = "Nome da impressora";
            fieldPrinterName.Size = 120;
            tableLabelModel.Fields.Add(fieldPrinterName);

            var fieldLabelAlignLeft = new Domain.UserTables.UserField();
            fieldLabelAlignLeft.TableName = "IV_LP_LabelModel";
            fieldLabelAlignLeft.Name = "LabelAlignLeft";
            fieldLabelAlignLeft.Type = BoFieldTypes.db_Numeric;
            fieldLabelAlignLeft.SubType = BoFldSubTypes.st_Measurement;
            fieldLabelAlignLeft.Description = "Alinhamento esquerda etiqueta";
            tableLabelModel.Fields.Add(fieldLabelAlignLeft); 
            
            var fieldLabelAlignTop = new Domain.UserTables.UserField();
            fieldLabelAlignTop.TableName = "IV_LP_LabelModel";
            fieldLabelAlignTop.Name = "LabelAlignTop";
            fieldLabelAlignTop.Type = BoFieldTypes.db_Numeric;
            fieldLabelAlignTop.SubType = BoFldSubTypes.st_Measurement;
            fieldLabelAlignTop.Description = "Alinhamento superior etiqueta";
            tableLabelModel.Fields.Add(fieldLabelAlignTop);

            var fieldWidth = new Domain.UserTables.UserField();
            fieldWidth.TableName = "IV_LP_LabelModel";
            fieldWidth.Name = "Width";
            fieldWidth.Type = BoFieldTypes.db_Numeric;
            fieldWidth.SubType =  BoFldSubTypes.st_Measurement;
            fieldWidth.Description = "Largura etiqueta";
            tableLabelModel.Fields.Add(fieldWidth);

            var fieldLength = new Domain.UserTables.UserField();
            fieldLength.TableName = "IV_LP_LabelModel";
            fieldLength.Name = "Length";
            fieldLength.Type = BoFieldTypes.db_Numeric;
            fieldLength.SubType = BoFldSubTypes.st_Measurement;
            fieldLength.Description = "Comprimento da etiqueta";
            tableLabelModel.Fields.Add(fieldLength);

            var fieldNColumn= new Domain.UserTables.UserField();
            fieldNColumn.TableName = "IV_LP_LabelModel";
            fieldNColumn.Name = "NColumns";
            fieldNColumn.Type = BoFieldTypes.db_Numeric;
            fieldNColumn.SubType = BoFldSubTypes.st_Measurement;
            fieldNColumn.Description = "Número de colunas";
            tableLabelModel.Fields.Add(fieldNColumn);

            var fieldQuery= new Domain.UserTables.UserField();
            fieldQuery.TableName = "IV_LP_LabelModel";
            fieldQuery.Name = "Query";
            fieldQuery.Type = BoFieldTypes.db_Memo;
            fieldQuery.Description = "Consulta";            
            tableLabelModel.Fields.Add(fieldQuery);

         
            var fieldsResultFieldsName= new Domain.UserTables.UserField();
            fieldsResultFieldsName.Name = "FieldsName";
            fieldsResultFieldsName.TableName = "IV_LP_LabelModel";
            fieldsResultFieldsName.Type = BoFieldTypes.db_Memo;
            fieldsResultFieldsName.Description = "Campos da consulta";
            tableLabelModel.Fields.Add(fieldsResultFieldsName);

            var fieldsDecimalPlaces= new Domain.UserTables.UserField();
            fieldsDecimalPlaces.Name = "DecimalPlaces";
            fieldsDecimalPlaces.TableName = "IV_LP_LabelModel";
            fieldsDecimalPlaces.Type = BoFieldTypes.db_Numeric;
            fieldsDecimalPlaces.Description = "N casas decimais para tipo valor";
            tableLabelModel.Fields.Add(fieldsDecimalPlaces);

        }
    }
}
