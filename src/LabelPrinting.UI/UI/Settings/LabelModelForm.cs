using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Form = Nampula.UI.Form;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabelPrinting.UI.Domain;
using LabelPrinting.UI.Infra.UserTables;
using LabelPrinting.UI.Infra;
using LabelPrinting.UI.Domain.PrintServices;
using LabelPrinting.UI.UI.SqlEditors;

namespace LabelPrinting.UI.UI.Settings
{
    public partial class LabelModelForm : Form
    {
        private LabelModelRepository _labelModelRepository;
        

        public LabelModelForm()
        {
            InitializeComponent();

            _labelModelRepository = new LabelModelRepository(AppSession.SboConnection);

            FillGrid();
        }

        private void FillGrid()
        {
            dataGridModel.DataSource = _labelModelRepository.GetAll(); 
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new LabelModel();
                var form = new LabelModelEditForm(model);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Program.ShowSuccessfullMessage();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var model = gridViewModel.GetFocusedRow() as LabelModel;
                if (model == null)
                    throw new Exception("Selecione um modelo");

                var form = new LabelModelEditForm(model);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Program.ShowSuccessfullMessage();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private void buttonSqlEditor_Click(object sender, EventArgs e)
        {
            try
            {
                var model = gridViewModel.GetFocusedRow() as LabelModel;
                if (model == null)
                    throw new Exception("Selecione um modelo");

                var form = new SqlEditorForm(model.U_Query);
                if (form.ShowDialog(this) == DialogResult.OK)
                {

                    model.U_Query = form.ResultSQL;
                    _labelModelRepository.Update(model);
                    Program.ShowSuccessfullMessage();
                }
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private void buttonSetZplCode_Click(object sender, EventArgs e)
        {
            try
            {
                var model = gridViewModel.GetFocusedRow() as LabelModel;
                if (model == null)
                    throw new Exception("Selecione um modelo");

                var form = new ZplCodeEditorForm(model);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    model.U_ZplCode = form.ZplCodeResult;
                    _labelModelRepository.Update(model);
                    Program.ShowSuccessfullMessage();
                }
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private void LabelModelForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
