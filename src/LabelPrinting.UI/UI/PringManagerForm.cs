using LabelPrinting.UI.Domain;
using LabelPrinting.UI.Infra;
using LabelPrinting.UI.Infra.UserTables;
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
        public PringManagerForm()
        {
            InitializeComponent();

            _labelModelRepository = new LabelModelRepository(AppSession.SboConnection);

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

        }
    }
}
