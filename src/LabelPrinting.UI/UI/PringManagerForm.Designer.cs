﻿namespace LabelPrinting.UI.UI
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
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPrinterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // staticText2
            // 
            this.staticText2.LinkedTo = this.comboBoxPrinterName;
            this.staticText2.Location = new System.Drawing.Point(12, 9);
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
            this.comboBoxPrinterName.Location = new System.Drawing.Point(143, 9);
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
            this.comboBoxPrinterName.Size = new System.Drawing.Size(516, 17);
            this.comboBoxPrinterName.TabIndex = 5;
            this.comboBoxPrinterName.ValueAlign = Nampula.UI.eValueAlign.eLeft;
            // 
            // buttonList
            // 
            this.buttonList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonList.Location = new System.Drawing.Point(689, 3);
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
            this.dataGridResult.Location = new System.Drawing.Point(15, 32);
            this.dataGridResult.MainView = this.gridViewResult;
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(773, 377);
            this.dataGridResult.TabIndex = 7;
            this.dataGridResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResult});
            // 
            // gridViewResult
            // 
            this.gridViewResult.GridControl = this.dataGridResult;
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.OptionsView.ColumnAutoWidth = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(15, 415);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(99, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Fechar";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Location = new System.Drawing.Point(689, 415);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(99, 23);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Imprimir";
            // 
            // PringManagerForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}