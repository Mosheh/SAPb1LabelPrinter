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
using System.Text.RegularExpressions;
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
                });
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
                        var chooseAccount = new ChooseList.ListChooseForm<Domain.SAP.ChartOfAccount>();
                        if (chooseAccount.ShowDialog(this) == DialogResult.OK)
                        {
                            filter.Value = chooseAccount.SelectedItem.AcctCode;
                            filter.Description = chooseAccount.SelectedItem.AcctName;
                        }
                        break;
                    case BoLinkedObject.lf_BusinessPartner:
                        var chooseBP = new ChooseList.ListChooseForm<Domain.SAP.BusinessPartner>();
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
                        var chooseItemGroup = new ChooseList.ListChooseForm<Domain.SAP.ItemGroup>();
                        if (chooseItemGroup.ShowDialog(this) == DialogResult.OK)
                        {
                            filter.Value = chooseItemGroup.SelectedItem.ItmsGrpCod;
                            filter.Description = chooseItemGroup.SelectedItem.ItmsGrpNam;
                        }
                        break;

                    case BoLinkedObject.lf_None:
                        Program.ShowInf("Não há tabela vinculada, Digite o valor diretamente no campo a após descrição do campo");
                        break;
                    default:
                        break;
                }

                gridViewFilters.RefreshData();

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

            if (models.Count() == 1)
            {
                var first = models.First();
                comboBoxPrinterName.Select(first.Code, BoSearchKey.psk_ByValue);
                ComboBoxPrinterName_SelectedValueChanged(comboBoxPrinterName, null);
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
                if (model.U_NColumns <= 0)
                    throw new Exception("Não definido número de colunas para o modelo");
                var data = dataGridResult.DataSource as DataTable;
                if (data == null)
                    throw new Exception("Não há dados");
                if (gridViewResult.SelectedRowsCount == 0)
                    throw new Exception("Não há dados selecionados");

                var isMultiptle = gridViewResult.SelectedRowsCount % model.U_NColumns == 0;
                if (!isMultiptle)
                    throw new Exception($"Selecione um número de linhas que seja múltiplo de {model.U_NColumns} (colunas)");

                var selectedCount = gridViewResult.SelectedRowsCount;

                var labelGroup = new Dictionary<int, List<DataRow>>();

                var lines = selectedCount / model.U_NColumns;
                var skipLines = new List<int>();

                foreach (var rowIndex in gridViewResult.GetSelectedRows())
                {
                    if (skipLines.Contains(rowIndex)) continue;

                    var totalGroup = 0;

                    if (!gridViewResult.IsRowSelected(rowIndex)) continue;

                    var nColumns = model.U_NColumns;

                    var rows = new List<DataRow>();
                    labelGroup.Add(rowIndex, rows);
                    while (totalGroup < nColumns)
                    {
                        var newIndex = rowIndex + totalGroup;
                        if (gridViewResult.IsRowSelected(newIndex))
                        {
                            rows.Add(gridViewResult.GetDataRow(newIndex));
                            skipLines.Add(newIndex);

                        }
                        else
                        {
                            nColumns++;
                        }

                        totalGroup++;
                    }
                }


                foreach (var label in labelGroup)
                {
                    var zplCode = model.U_ZplCode;
                    foreach (var columnName in model.U_FieldsName.Split('|'))
                    {
                        if (string.IsNullOrEmpty(columnName)) continue;
                        var rx = new Regex("{" + columnName + "}", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                        var fieldsOcurrences = model.U_NColumns;

                        foreach (DataRow row in label.Value)
                        {
                            Match match = rx.Match(zplCode);

                            while (match.Success)
                            {
                                zplCode = zplCode.Remove(match.Index, match.Value.Length);
                                zplCode = zplCode.Insert(match.Index, GetFormattedValue( row[columnName], model));
                                break;
                            }
                        }

                    }
                    _zebraPrinterHelper.PrintLabel(zplCode, model.U_PrinterName, model);
            
                }


            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private string GetFormattedValue(object v, LabelModel model)
        {
            if(v.GetType().Name.Equals("Decimal"))
                return v.ToDecimal().ToString($"n{model.U_DecimalPlaces}");
            else
                return v.ToString();
        }

        private string GetFormattedLabel(string u_ZplCode, DataRow row, LabelModel model)
        {
            foreach (DataColumn column in row.Table.Columns)
            {
                if (column.ColumnName.Equals("Qtd")) continue;
                var value = row[column].ToString();
                if (column.DataType.Name.Equals("Decimal"))
                    value = row[column].ToDecimal().ToString($"n{model.U_DecimalPlaces}");
                var columnField = "{" + column.ColumnName + "}";
                u_ZplCode = u_ZplCode.Replace(columnField, value);
            }
            return u_ZplCode;
        }



        private void buttonApplyQty_Click(object sender, EventArgs e)
        {
            try
            {
                var model = GetSelectedModel();
                if (model == null)
                    throw new Exception("Modelo  não selecionado");

                if(model.U_NColumns >1)
                    throw new Exception("Para modelos de impressão com  mais de uma coluna não é permitido selecionar repetições, informe apenas quantidade múltipla da quantidade de colunas");

                var qtd = editTextQtd.EditValue.To<int>();
                if (qtd <= 0)
                    throw new Exception("Quantidade inválida");


                var data = dataGridResult.DataSource as DataTable;

                if (data == null)
                    return;

                

                foreach (var rowIndex in gridViewResult.GetSelectedRows())
                {
                    var row = gridViewResult.GetDataRow(rowIndex);

                    row["Qtd"] = qtd;
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
