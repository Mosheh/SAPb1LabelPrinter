using DevExpress.XtraEditors.Controls;
using LabelPrinting.UI.Domain;
using LabelPrinting.UI.Domain.Filters;
using LabelPrinting.UI.Domain.PrintServices;
using LabelPrinting.UI.Infra;
using LabelPrinting.UI.Infra.UserTables;
using LabelPrinting.UI.Infra.ZebraPrinterHelpers;
using Nampula.Framework;
using Nampula.UI;
using Nampula.UI.Helpers;
using Nampula.UI.Helpers.Extentions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static LabelPrinting.UI.UI.Extentions;
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
            gridViewResult.CreateMenuExport();

            FillLabelModels();
            comboBoxPrinterName.SelectedValueChanged += ComboBoxPrinterName_SelectedValueChanged;

            CreateChooseButton();
        }

        private void CreateChooseButton()
        {
            var repository = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gridViewFilters.Columns[nameof(ColumnFilter.Description)].ColumnEdit = repository;
            
            repository.ButtonClick += ListLinkedButtonByContext;
        }

        private void ComboBoxPrinterName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillGridFilter();
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private void FillGridFilter()
        {
            dataGridFilters.DataSource = null;
            var selectedModel = GetSelectedModel();
            if (selectedModel == null) return;

            var columns = AppSession.SboConnection.GetColumns(selectedModel.U_Query);            

            var list = new List<ColumnFilter>();
            foreach (DataColumn col in columns)
            {
                Nampula.UI.BoLinkedObject boLinkedObject = BoLinkedObject.lf_None;
                if (Extentions.SapColumns.ContainsKey(col.ColumnName))
                {
                    boLinkedObject = Extentions.SapColumns[col.ColumnName];
                }

                string columnDescription = col.ColumnName;
                if (boLinkedObject != BoLinkedObject.lf_None)
                    columnDescription = Extentions.SapColumnDescription[boLinkedObject];
                list.Add(new ColumnFilter
                {
                    ColumnName = col.ColumnName,
                     ColumnDescription = columnDescription,
                     BoLinkedObject = boLinkedObject,
                      Type = col.DataType                       
                }) ;
            }

            dataGridFilters.DataSource = list;

        }

        private void ListLinkedButtonByContext(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                var filter = gridViewFilters.GetFocusedRow() as ColumnFilter;
                if (filter == null) return;

                switch (filter.BoLinkedObject)
                {
                    
                    case BoLinkedObject.lf_GLAccounts:
                        var chooseAccount= new ChooseList.ListChooseForm<Domain.SAP.ChartOfAccount>();
                        if (chooseAccount.ShowDialog(this) == DialogResult.OK)
                        {
                            filter.Value = chooseAccount.SelectedItem.AcctCode;
                            filter.Description = chooseAccount.SelectedItem.AcctName;
                        }
                        break;
                    case BoLinkedObject.lf_BusinessPartner:
                        var chooseBP= new ChooseList.ListChooseForm<Domain.SAP.BusinessPartner>();
                        if (chooseBP.ShowDialog(this) == DialogResult.OK)
                        {
                            filter.Value = chooseBP.SelectedItem.CardCode;
                            filter.Description = chooseBP.SelectedItem.CardName;
                        }
                        break;                    
                    case BoLinkedObject.lf_Items:
                        var chooseItem = new ChooseList.ListChooseForm<Domain.SAP.Item>();
                        if (chooseItem.ShowDialog(this) == DialogResult.OK)
                        {
                            filter.Value = chooseItem.SelectedItem.ItemCode;
                            filter.Description = chooseItem.SelectedItem.ItemName;
                        }

                        break;
                    
                    case BoLinkedObject.lf_ItemGroups:
                        var chooseItemGroup= new ChooseList.ListChooseForm<Domain.SAP.ItemGroup>();
                        if (chooseItemGroup.ShowDialog(this) == DialogResult.OK)
                        {
                            filter.Value = chooseItemGroup.SelectedItem.ItmsGrpCode;
                            filter.Description = chooseItemGroup.SelectedItem.ItmsGrpNam;
                        }
                        break;
                    
                    case BoLinkedObject.lf_None:
                        Program.ShowInf("Não há tabela vinculada, Digite o valor diretamente no campo a após descrição do campo");
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private LabelModel GetSelectedModel()
        {
            if (comboBoxPrinterName.Selected == null) return null;
            var label = _labelModelRepository.GetByKey(comboBoxPrinterName.Selected.Value.To<int>());
            return label;
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

                var filters = dataGridFilters.DataSource as List<ColumnFilter>;

                var model = _labelModelRepository.GetByKey(comboBoxPrinterName.Selected.Value.To<int>());
                if (model == null) throw new Exception("Modelo não encontrado");
                if (string.IsNullOrEmpty(model.U_Query)) throw new Exception($"Modelo não possui query configurada");
                var result = AppSession.SboConnection.ExecuteSelectFiltering(model.U_Query, filters.ToArray());
                result.Columns.Add("Qtd", typeof(int)).SetOrdinal(0);
                foreach (DataRow row in result.Rows)
                {
                    row["Qtd"] = 1;
                }
                gridViewResult.Columns.Clear();
                dataGridResult.DataSource = result;
                gridViewResult.SetLinkedButton(result.Columns);
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
                if (gridViewResult.SelectedRowsCount == 0)
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
                var columnField = "{" + column.ColumnName + "}";
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



        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
