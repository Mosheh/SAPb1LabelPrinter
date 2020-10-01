namespace LabelPrinting.UI.UI.Settings
{
    partial class LabelModelForm
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
            this.dataGridModel = new Nampula.UI.DataGrid();
            this.gridViewModel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrinterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonOK = new Nampula.UI.Button();
            this.buttonSqlEditor = new Nampula.UI.Button();
            this.buttonSetZplCode = new Nampula.UI.Button();
            this.buttonNew = new Nampula.UI.Button();
            this.buttonEdit = new Nampula.UI.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridModel
            // 
            this.dataGridModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridModel.DontSavePosition = false;
            this.dataGridModel.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.dataGridModel.Location = new System.Drawing.Point(12, 11);
            this.dataGridModel.MainView = this.gridViewModel;
            this.dataGridModel.Name = "dataGridModel";
            this.dataGridModel.Size = new System.Drawing.Size(776, 366);
            this.dataGridModel.TabIndex = 0;
            this.dataGridModel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewModel});
            // 
            // gridViewModel
            // 
            this.gridViewModel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnPrinterName});
            this.gridViewModel.GridControl = this.dataGridModel;
            this.gridViewModel.Name = "gridViewModel";
            this.gridViewModel.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Nome";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            // 
            // gridColumnPrinterName
            // 
            this.gridColumnPrinterName.Caption = "Impressora";
            this.gridColumnPrinterName.FieldName = "U_PrinterName";
            this.gridColumnPrinterName.Name = "gridColumnPrinterName";
            this.gridColumnPrinterName.Visible = true;
            this.gridColumnPrinterName.VisibleIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 383);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            // 
            // buttonSqlEditor
            // 
            this.buttonSqlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSqlEditor.Location = new System.Drawing.Point(542, 383);
            this.buttonSqlEditor.Name = "buttonSqlEditor";
            this.buttonSqlEditor.Size = new System.Drawing.Size(120, 21);
            this.buttonSqlEditor.TabIndex = 4;
            this.buttonSqlEditor.Text = "Definir consulta SQL";
            this.buttonSqlEditor.Click += new System.EventHandler(this.buttonSqlEditor_Click);
            // 
            // buttonSetZplCode
            // 
            this.buttonSetZplCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetZplCode.Location = new System.Drawing.Point(668, 383);
            this.buttonSetZplCode.Name = "buttonSetZplCode";
            this.buttonSetZplCode.Size = new System.Drawing.Size(120, 21);
            this.buttonSetZplCode.TabIndex = 5;
            this.buttonSetZplCode.Text = "Definir modelo etiqueta";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(380, 383);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 21);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Novo";
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(461, 383);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 21);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // LabelModelForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSetZplCode);
            this.Controls.Add(this.buttonSqlEditor);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridModel);
            this.Name = "LabelModelForm";
            this.Text = "Modelos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Nampula.UI.DataGrid dataGridModel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewModel;
        private Nampula.UI.Button buttonOK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrinterName;
        private Nampula.UI.Button buttonSqlEditor;
        private Nampula.UI.Button buttonSetZplCode;
        private Nampula.UI.Button buttonNew;
        private Nampula.UI.Button buttonEdit;
    }
}