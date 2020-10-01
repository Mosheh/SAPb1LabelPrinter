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
            fieldName.Description = "Nome da impressora";
            fieldPrinterName.Size = 120;
            tableLabelModel.Fields.Add(fieldPrinterName);

            var fieldQuery= new Domain.UserTables.UserField();
            fieldQuery.TableName = "IV_LP_LabelModel";
            fieldQuery.Name = "Query";
            fieldQuery.Type = BoFieldTypes.db_Memo;
            fieldQuery.Description = "Consulta";            
            tableLabelModel.Fields.Add(fieldQuery);

        }
    }
}
