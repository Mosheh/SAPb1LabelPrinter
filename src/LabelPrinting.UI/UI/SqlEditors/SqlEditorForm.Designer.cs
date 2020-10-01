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
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
            this.spliContainer1 = new Nampula.UI.SpliContainer();
            this.dataGridResult = new Nampula.UI.DataGrid();
            this.gridViewResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExecuteSql = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spliContainer1)).BeginInit();
            this.spliContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.spliContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spliContainer1.Horizontal = false;
            this.spliContainer1.Location = new System.Drawing.Point(0, 27);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExecuteSql);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 27);
            this.panel1.TabIndex = 3;
            // 
            // buttonExecuteSql
            // 
            this.buttonExecuteSql.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonExecuteSql.Image = global::LabelPrinting.UI.Properties.Resources.play;
            this.buttonExecuteSql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExecuteSql.Location = new System.Drawing.Point(120, 0);
            this.buttonExecuteSql.Name = "buttonExecuteSql";
            this.buttonExecuteSql.Size = new System.Drawing.Size(120, 27);
            this.buttonExecuteSql.TabIndex = 1;
            this.buttonExecuteSql.Text = "Executar";
            this.buttonExecuteSql.UseVisualStyleBackColor = true;
            this.buttonExecuteSql.Click += new System.EventHandler(this.toolStripButtonExecute_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave.Image = global::LabelPrinting.UI.Properties.Resources.floppy;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 27);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Salvar e sair";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // SqlEditorForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spliContainer1);
            this.Name = "SqlEditorForm";
            this.Text = "Editor de consultas";
            ((System.ComponentModel.ISupportInitialize)(this.spliContainer1)).EndInit();
            this.spliContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
        private Nampula.UI.SpliContainer spliContainer1;
        private Nampula.UI.DataGrid dataGridResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExecuteSql;
        private System.Windows.Forms.Button buttonSave;
    }
}