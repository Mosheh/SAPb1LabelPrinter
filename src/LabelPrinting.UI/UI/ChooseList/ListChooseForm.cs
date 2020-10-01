using Form = Nampula.UI.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nampula.DI;
using LabelPrinting.UI.Infra;
using SimpleQuery;

namespace LabelPrinting.UI.UI.ChooseList
{
    public partial class ListChooseForm<T>: Form where T:class, new()
    {
        public ListChooseForm()
        {
            InitializeComponent();

            var scriptBuilder = AppSession.SboConnection.Connection.GetScriptBuild();
            var selectScript = scriptBuilder.GetSelectCommand<T>(new T());
            var list = AppSession.SboConnection.Connection.Query<T>(selectScript);

            dataGrid1.DataSource = null;
            dataGrid1.DataSource = list;
            gridView1.BestFitColumns();
            dataGrid1.DoubleClick += DataGrid1_DoubleClick;
        }

        private void DataGrid1_DoubleClick(object sender, EventArgs e)
        {
            buttonOK_Click(sender, e);
        }

        public T SelectedItem { get; set; }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                
               SelectedItem =  gridView1.GetFocusedRow() as T;
                if (SelectedItem == null)
                    throw new Exception("Não houve seleção");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }
    }
}
