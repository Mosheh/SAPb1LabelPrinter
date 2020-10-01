namespace LabelPrinting.UI.UI
{
    partial class PringManagerForm
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
            this.staticText2 = new Nampula.UI.StaticText();
            this.comboBoxPrinterName = new Nampula.UI.ComboBox();
            this.buttonList = new Nampula.UI.Button();
            this.dataGridResult = new Nampula.UI.DataGrid();
            this.gridViewResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonClose = new Nampula.UI.Button();
            this.buttonPrint = new Nampula.UI.Button();
            this.buttonApplyQty = new Nampula.UI.Button();
            this.editTextQtd = new Nampula.UI.EditText();
            this.staticText1 = new Nampula.UI.StaticText();
            this.dataGridFilters = new Nampula.UI.DataGrid();
            this.gridViewFilters = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPrinterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextQtd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilters)).BeginInit();
            this.SuspendLayout();
            // 
            // staticText2
            // 
            this.staticText2.LinkedTo = this.comboBoxPrinterName;
            this.staticText2.Location = new System.Drawing.Point(12, 4);
            this.staticText2.Name = "staticText2";
            this.staticText2.Size = new System.Drawing.Size(131, 17);
            this.staticText2.TabIndex = 4;
            this.staticText2.Text = "Selecione um modelo";
            // 
            // comboBoxPrinterName
            // 
            this.comboBoxPrinterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPrinterName.DataSourceInformation = null;
            this.comboBoxPrinterName.Location = new System.Drawing.Point(143, 4);
            this.comboBoxPrinterName.Name = "comboBoxPrinterName";
            this.comboBoxPrinterName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.comboBoxPrinterName.Properties.Appearance.Options.UseFont = true;
            this.comboBoxPrinterName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.comboBoxPrinterName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.comboBoxPrinterName.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.comboBoxPrinterName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.comboBoxPrinterName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.comboBoxPrinterName.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.comboBoxPrinterName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.comboBoxPrinterName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.comboBoxPrinterName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.comboBoxPrinterName.Properties.AutoHeight = false;
            this.comboBoxPrinterName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxPrinterName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxPrinterName.ShowTextCombo = Nampula.UI.eShowTextCombo.eName;
            this.comboBoxPrinterName.Size = new System.Drawing.Size(205, 17);
            this.comboBoxPrinterName.TabIndex = 5;
            this.comboBoxPrinterName.ValueAlign = Nampula.UI.eValueAlign.eLeft;
            // 
            // buttonList
            // 
            this.buttonList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonList.Location = new System.Drawing.Point(689, 4);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(99, 23);
            this.buttonList.TabIndex = 6;
            this.buttonList.Text = "Listar";
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // dataGridResult
            // 
            this.dataGridResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResult.DontSavePosition = false;
            this.dataGridResult.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.dataGridResult.Location = new System.Drawing.Point(15, 109);
            this.dataGridResult.MainView = this.gridViewResult;
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(773, 311);
            this.dataGridResult.TabIndex = 7;
            this.dataGridResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResult});
            // 
            // gridViewResult
            // 
            this.gridViewResult.GridControl = this.dataGridResult;
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.OptionsSelection.MultiSelect = true;
            this.gridViewResult.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewResult.OptionsView.ColumnAutoWidth = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(15, 426);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(99, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Fechar";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Location = new System.Drawing.Point(689, 426);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(99, 23);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Imprimir";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonApplyQty
            // 
            this.buttonApplyQty.Location = new System.Drawing.Point(249, 23);
            this.buttonApplyQty.Name = "buttonApplyQty";
            this.buttonApplyQty.Size = new System.Drawing.Size(99, 17);
            this.buttonApplyQty.TabIndex = 10;
            this.buttonApplyQty.Text = "Aplicar";
            this.buttonApplyQty.Click += new System.EventHandler(this.buttonApplyQty_Click);
            // 
            // editTextQtd
            // 
            this.editTextQtd.DataSourceInformation = null;
            this.editTextQtd.DataType = Nampula.UI.BoDataType.dt_QUANTITY;
            this.editTextQtd.DecimalPlaces = 0;
            this.editTextQtd.Location = new System.Drawing.Point(143, 23);
            this.editTextQtd.Name = "editTextQtd";
            this.editTextQtd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextQtd.Properties.Appearance.Options.UseFont = true;
            this.editTextQtd.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextQtd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.editTextQtd.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextQtd.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextQtd.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextQtd.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.editTextQtd.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.editTextQtd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextQtd.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextQtd.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextQtd.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.editTextQtd.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.editTextQtd.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextQtd.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextQtd.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextQtd.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.editTextQtd.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.editTextQtd.Properties.AutoHeight = false;
            this.editTextQtd.Properties.DisplayFormat.FormatString = "n0";
            this.editTextQtd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextQtd.Properties.EditFormat.FormatString = "n0";
            this.editTextQtd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextQtd.Properties.Mask.EditMask = "n0";
            this.editTextQtd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.editTextQtd.Properties.MaxLength = 2;
            this.editTextQtd.Size = new System.Drawing.Size(100, 17);
            this.editTextQtd.TabIndex = 11;
            // 
            // staticText1
            // 
            this.staticText1.LinkedTo = this.editTextQtd;
            this.staticText1.Location = new System.Drawing.Point(12, 23);
            this.staticText1.Name = "staticText1";
            this.staticText1.Size = new System.Drawing.Size(131, 17);
            this.staticText1.TabIndex = 12;
            this.staticText1.Text = "Alterar quantidade para";
            // 
            // dataGridFilters
            // 
            this.dataGridFilters.DontSavePosition = false;
            this.dataGridFilters.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.dataGridFilters.Location = new System.Drawing.Point(354, 4);
            this.dataGridFilters.MainView = this.gridViewFilters;
            this.dataGridFilters.Name = "dataGridFilters";
            this.dataGridFilters.Size = new System.Drawing.Size(329, 99);
            this.dataGridFilters.TabIndex = 13;
            this.dataGridFilters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFilters});
            // 
            // gridViewFilters
            // 
            this.gridViewFilters.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnValue,
            this.gridColumnDescription});
            this.gridViewFilters.GridControl = this.dataGridFilters;
            this.gridViewFilters.Name = "gridViewFilters";
            this.gridViewFilters.OptionsView.ShowColumnHeaders = false;
            this.gridViewFilters.OptionsView.ShowGroupPanel = false;
            this.gridViewFilters.OptionsView.ShowIndicator = false;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Campo";
            this.gridColumnName.FieldName = "ColumnDescription";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            // 
            // gridColumnValue
            // 
            this.gridColumnValue.Caption = "Valor de filtro";
            this.gridColumnValue.FieldName = "Value";
            this.gridColumnValue.Name = "gridColumnValue";
            this.gridColumnValue.Visible = true;
            this.gridColumnValue.VisibleIndex = 1;
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.Caption = "Descrição";
            this.gridColumnDescription.FieldName = "Description";
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 2;
            // 
            // PringManagerForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.dataGridFilters);
            this.Controls.Add(this.staticText1);
            this.Controls.Add(this.editTextQtd);
            this.Controls.Add(this.buttonApplyQty);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridResult);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.staticText2);
            this.Controls.Add(this.comboBoxPrinterName);
            this.Name = "PringManagerForm";
            this.Text = "Impressão de etiquetas";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPrinterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextQtd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Nampula.UI.StaticText staticText2;
        private Nampula.UI.ComboBox comboBoxPrinterName;
        private Nampula.UI.Button buttonList;
        private Nampula.UI.DataGrid dataGridResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResult;
        private Nampula.UI.Button buttonClose;
        private Nampula.UI.Button buttonPrint;
        private Nampula.UI.Button buttonApplyQty;
        private Nampula.UI.EditText editTextQtd;
        private Nampula.UI.StaticText staticText1;
        private Nampula.UI.DataGrid dataGridFilters;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFilters;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
    }
}