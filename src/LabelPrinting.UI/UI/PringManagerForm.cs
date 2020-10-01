using LabelPrinting.UI.Domain;
using LabelPrinting.UI.Infra;
using LabelPrinting.UI.Infra.UserTables;
using LabelPrinting.UI.Infra.ZebraPrinterHelpers;
using Nampula.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = Nampula.UI.Form;
namespace LabelPrinting.UI.UI
{
    public partial class PringManagerForm : Form
    {
        ILabelModelRepository _labelModelRepository;
        private ZebraPrinterHelper _zebraPrinterHelper;

        public PringManagerForm()
        {
            InitializeComponent();

            _labelModelRepository = new LabelModelRepository(AppSession.SboConnection);
            _zebraPrinterHelper = new ZebraPrinterHelper();

            FillLabelModels();
        }

        private void FillLabelModels()
        {
            var models = _labelModelRepository.GetAll();
            foreach (var item in models)
            {
                comboBoxPrinterName.ValidValues.Add(item.Code, item.Name);
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPrinterName.Selected == null)
                    throw new Exception("Selecione um modelo");

                var model = _labelModelRepository.GetByKey(comboBoxPrinterName.Selected.Value.To<int>());
                if (model == null) throw new Exception("Modelo não encontrado");
                if(string.IsNullOrEmpty(model.U_Query)) throw new Exception($"Modelo não possui query configurada");
                var result = AppSession.SboConnection.ExecuteSelect(model.U_Query);
                result.Columns.Add("Qtd", typeof(int)).SetOrdinal(0);
                foreach (DataRow row in result.Rows)
                {
                    row["Qtd"] = 1;
                }
                
                dataGridResult.DataSource = result;
                gridViewResult.BestFitColumns();
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPrinterName.Selected == null)
                    throw new Exception("Selecione um modelo");

                var model = _labelModelRepository.GetByKey(comboBoxPrinterName.Selected.Value.To<int>());

                var data = dataGridResult.DataSource as DataTable;
                if (data == null)
                    throw new Exception("Não há dados");
                if(gridViewResult.SelectedRowsCount == 0 )
                    throw new Exception("Não há dados selecionados");

                foreach (var rowIndex in gridViewResult.GetSelectedRows())
                {
                    var row = gridViewResult.GetDataRow(rowIndex);
                    var qtd = row["Qtd"].To<int>();

                    for (int i = 0; i < qtd; i++)
                    {
                        var labelReplacedValues = GetFormattedLabel(model.U_ZplCode, row);
                        _zebraPrinterHelper.PrintLabel(labelReplacedValues, model.U_PrinterName, model);
                    }
                }

                
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private string GetFormattedLabel(string u_ZplCode, DataRow row)
        {
            foreach (DataColumn column in row.Table.Columns)
            {
                if (column.ColumnName.Equals("Qtd")) continue;
                var value = row[column].ToString();
                var columnField = "{"+column.ColumnName+"}";
                u_ZplCode = u_ZplCode.Replace(columnField, value);
            }
            return u_ZplCode;
        }

        private void buttonApplyQty_Click(object sender, EventArgs e)
        {
            try
            {
                var qtd = editTextQtd.EditValue.To<int>();
                if (qtd <= 0)
                    throw new Exception("Quantidade inválida");
                
                var data = dataGridResult.DataSource as DataTable;

                if (data == null)
                    return;
                foreach (DataRow item in data.Rows)
                {
                    item["Qtd"] = qtd;
                }

                gridViewResult.RefreshData();
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }
    }
}
