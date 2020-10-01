namespace LabelPrinting.UI.UI.SqlEditors
{
    partial class SqlEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlEditorForm));
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
            this.spliContainer1 = new Nampula.UI.SpliContainer();
            this.dataGridResult = new Nampula.UI.DataGrid();
            this.gridViewResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExecuteSql = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.spliContainer1)).BeginInit();
            this.spliContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditorControl1.IsReadOnly = false;
            this.textEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.Size = new System.Drawing.Size(800, 223);
            this.textEditorControl1.TabIndex = 0;
            // 
            // spliContainer1
            // 
            this.spliContainer1.Horizontal = false;
            this.spliContainer1.Location = new System.Drawing.Point(0, 26);
            this.spliContainer1.Name = "spliContainer1";
            this.spliContainer1.Panel1.Controls.Add(this.textEditorControl1);
            this.spliContainer1.Panel1.Text = "Panel1";
            this.spliContainer1.Panel2.Controls.Add(this.dataGridResult);
            this.spliContainer1.Panel2.Text = "Panel2";
            this.spliContainer1.Size = new System.Drawing.Size(800, 388);
            this.spliContainer1.SplitterPosition = 223;
            this.spliContainer1.TabIndex = 1;
            this.spliContainer1.Text = "spliContainer1";
            // 
            // dataGridResult
            // 
            this.dataGridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResult.DontSavePosition = false;
            this.dataGridResult.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.dataGridResult.Location = new System.Drawing.Point(0, 0);
            this.dataGridResult.MainView = this.gridViewResult;
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(800, 159);
            this.dataGridResult.TabIndex = 0;
            this.dataGridResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResult});
            // 
            // gridViewResult
            // 
            this.gridViewResult.GridControl = this.dataGridResult;
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.OptionsView.ShowGroupPanel = false;
            this.gridViewResult.OptionsView.ShowIndicator = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonExecuteSql});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(88, 22);
            this.toolStripButtonSave.Text = "Salvar e sair";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonExecuteSql
            // 
            this.toolStripButtonExecuteSql.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExecuteSql.Image")));
            this.toolStripButtonExecuteSql.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExecuteSql.Name = "toolStripButtonExecuteSql";
            this.toolStripButtonExecuteSql.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonExecuteSql.Text = "Executar";
            this.toolStripButtonExecuteSql.Click += new System.EventHandler(this.toolStripButtonExecute_Click);
            // 
            // SqlEditorForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.spliContainer1);
            this.Name = "SqlEditorForm";
            this.Text = "Editor de consultas";
            ((System.ComponentModel.ISupportInitialize)(this.spliContainer1)).EndInit();
            this.spliContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
        private Nampula.UI.SpliContainer spliContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonExecuteSql;
        private Nampula.UI.DataGrid dataGridResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResult;
    }
}