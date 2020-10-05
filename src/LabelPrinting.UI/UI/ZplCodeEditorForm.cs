using LabelPrinting.UI.Domain;
using LabelPrinting.UI.Domain.PrintServices;
using LabelPrinting.UI.Infra;
using LabelPrinting.UI.Infra.Services;
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
namespace LabelPrinting
{
    public partial class ZplCodeEditorForm : Form
    {
        private LabelModel _labelModel;
        ISboConnection _sboConnection;
        public ZplCodeEditorForm(LabelModel labelModel)
        {
            InitializeComponent();
            _labelModel = labelModel;
            _sboConnection = AppSession.SboConnection;
            gridViewFields.OptionsBehavior.ReadOnly = true;
            gridViewFields.DoubleClick += GridViewFields_DoubleClick;
            gridViewFields.OptionsView.ShowIndicator = true;
            FillFields();

            FillControls();
        }

        private void GridViewFields_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedField = gridViewFields.GetFocusedRow() as DataColumn;
                if (selectedField == null) return;

                string insertText = "{" + selectedField.ColumnName +"}";
                int selectionIndex = editMemoZplCode.SelectionStart;
                if (string.IsNullOrEmpty(editMemoZplCode.SelectedText))
                    this.editMemoZplCode.Text = editMemoZplCode.Text.Insert(selectionIndex, insertText);
                else
                    this.editMemoZplCode.Text = editMemoZplCode.Text.Insert(selectionIndex, insertText).Replace(editMemoZplCode.SelectedText, "");
                editMemoZplCode.SelectionStart = selectionIndex; // restore cursor position
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private void FillFields()
        {
            if (string.IsNullOrWhiteSpace(_labelModel.U_Query))
                throw new Exception("Não definida consulta sql");

            var columns = _sboConnection.GetColumns(_labelModel.U_Query);
            _labelModel.SetFields(columns);
            dataGridFields.DataSource = columns;
        }

        private void FillControls()
        {
            if (!string.IsNullOrEmpty(_labelModel.U_ZplCode))
                editMemoZplCode.Text = _labelModel.U_ZplCode;


        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            try
            {
                ILabelPreview labelPreview = new LabelPreview();
                var stream = labelPreview.GetLabel("http://api.labelary.com/v1/printers", new PrintSetting(), editMemoZplCode.Text);

                var image = Bitmap.FromStream(stream);
                pictureBoxPreview.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox(ex.Message);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                _labelModel.U_ZplCode = editMemoZplCode.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }

        }

        public string ZplCodeResult
        {
            get { return editMemoZplCode.Text; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
