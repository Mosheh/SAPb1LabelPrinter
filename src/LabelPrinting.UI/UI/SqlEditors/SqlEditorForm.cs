﻿using DevExpress.XtraReports.Design;
using ICSharpCode.TextEditor.Document;
using LabelPrinting.UI.Infra;
using Nampula.UI;
using Nampula.UI.Helpers.Extentions;
using SimpleQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Form = Nampula.UI.Form;
namespace LabelPrinting.UI.UI.SqlEditors
{
    public partial class SqlEditorForm : Form
    {
        public SqlEditorForm(string strSql)
        {
            InitializeComponent();
            textEditorControl1.Text = strSql;
            textEditorControl1.Font = new Font("Consolas", 10, FontStyle.Regular);
            textEditorControl1.SetHighlighting("SQL");
            textEditorControl1.TextChanged += (s, a) =>
            {
                if (this.Text.Contains("*"))
                    return;
                var text = $"*{Text}";
                this.Text = text;
            };

            gridViewResult.CreateMenuExport();


        }

        public string ResultSQL
        {
            get { return this.textEditorControl1.Text; }

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

        private void toolStripButtonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewResult.Columns.Clear();
                dataGridResult.DataSource = AppSession.SboConnection.ExecuteSelect(textEditorControl1.Text);
                gridViewResult.SetLinkedButton((dataGridResult.DataSource as DataTable).Columns);
                gridViewResult.BestFitColumns();
            }
            catch (Exception ex)
            {
                Program.ShowMessageError(ex);
            }
        }

     
    }
   
    public class SyntaxEditor : ISyntaxModeFileProvider
    {
        public List<SyntaxMode> _syntaxModes = null;

        public SyntaxEditor()
        {
            using (var mem = new MemoryStream(Encoding.Default.GetBytes(Properties.Resources.SyntaxModes)))
            {
                _syntaxModes = SyntaxMode.GetSyntaxModes(mem);
            }
        }

        public ICollection<SyntaxMode> SyntaxModes => _syntaxModes;

        public XmlTextReader GetSyntaxModeFile(SyntaxMode syntaxMode)
        {
            return new System.Xml.XmlTextReader(new MemoryStream(Properties.Resources.SQL_Mode));
        }

        public void UpdateSyntaxModeList()
        {

        }





    }


}
