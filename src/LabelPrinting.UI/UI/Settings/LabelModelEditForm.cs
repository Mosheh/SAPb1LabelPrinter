using LabelPrinting.UI.Domain.PrintServices;
using LabelPrinting.UI.Infra;
using LabelPrinting.UI.Infra.Helpers;
using LabelPrinting.UI.Infra.UserTables;
using Nampula.Framework;
using Nampula.UI.Helpers;
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

namespace LabelPrinting.UI.UI.Settings
{
    public partial class LabelModelEditForm : Form
    {
        Dictionary<string, Control> _binds = new Dictionary<string, Control>();
        private LabelModel _labelModel;
        private LabelModelRepository _labelModelRepository;

        public LabelModelEditForm(LabelModel labelModel)
        {
            InitializeComponent();
            _labelModelRepository = new LabelModelRepository(AppSession.SboConnection);

            _binds.Add(nameof(LabelModel.Name), editTextName);
            _binds.Add(nameof(LabelModel.U_PrinterName), comboBoxPrinterName);

            foreach (var item in SettingPrinter.GetPrinterNames())
                comboBoxPrinterName.ValidValues.Add(item, item);

            _labelModel = labelModel;
            FillControls();
        }

        private void FillControls()
        {
            editTextName.EditValue = _labelModel.Name;
            if (comboBoxPrinterName.ExistKey(_labelModel.U_PrinterName))
                comboBoxPrinterName.Select(_labelModel.U_PrinterName, Nampula.UI.BoSearchKey.psk_ByValue);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                _labelModel.Name = editTextName.Text;
                _labelModel.U_PrinterName = comboBoxPrinterName.Selected != null ? comboBoxPrinterName.Selected.Value.ToString() : "";
                if (_labelModel.Code.IsEmpty())
                {
                    _labelModelRepository.Add(_labelModel);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    _labelModelRepository.Update(_labelModel);
                    this.DialogResult = DialogResult.OK;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
