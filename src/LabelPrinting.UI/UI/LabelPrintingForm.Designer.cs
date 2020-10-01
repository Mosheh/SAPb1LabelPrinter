namespace LabelPrinting
{
    partial class LabelPrintingForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelPrintingForm));
            this.button1 = new Nampula.UI.Button();
            this.button2 = new Nampula.UI.Button();
            this.spliContainer1 = new Nampula.UI.SpliContainer();
            this.buttonPreview = new Nampula.UI.Button();
            this.comboBox2 = new Nampula.UI.ComboBox();
            this.staticText4 = new Nampula.UI.StaticText();
            this.editText2 = new Nampula.UI.EditText();
            this.editText1 = new Nampula.UI.EditText();
            this.staticText2 = new Nampula.UI.StaticText();
            this.comboBox1 = new Nampula.UI.ComboBox();
            this.staticText1 = new Nampula.UI.StaticText();
            this.editMemo1 = new Nampula.UI.EditMemo();
            this.spliContainer2 = new Nampula.UI.SpliContainer();
            this.dataGridFields = new Nampula.UI.DataGrid();
            this.gridViewFields = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureBoxPreview = new Nampula.UI.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spliContainer1)).BeginInit();
            this.spliContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editText2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editText1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editMemo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spliContainer2)).BeginInit();
            this.spliContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(93, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            // 
            // spliContainer1
            // 
            this.spliContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spliContainer1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.spliContainer1.Location = new System.Drawing.Point(12, 11);
            this.spliContainer1.Name = "spliContainer1";
            this.spliContainer1.Panel1.Controls.Add(this.buttonPreview);
            this.spliContainer1.Panel1.Controls.Add(this.comboBox2);
            this.spliContainer1.Panel1.Controls.Add(this.staticText4);
            this.spliContainer1.Panel1.Controls.Add(this.editText2);
            this.spliContainer1.Panel1.Controls.Add(this.editText1);
            this.spliContainer1.Panel1.Controls.Add(this.staticText2);
            this.spliContainer1.Panel1.Controls.Add(this.comboBox1);
            this.spliContainer1.Panel1.Controls.Add(this.staticText1);
            this.spliContainer1.Panel1.Controls.Add(this.editMemo1);
            this.spliContainer1.Panel1.Text = "Panel1";
            this.spliContainer1.Panel2.Controls.Add(this.spliContainer2);
            this.spliContainer1.Panel2.Text = "Panel2";
            this.spliContainer1.Size = new System.Drawing.Size(776, 366);
            this.spliContainer1.SplitterPosition = 291;
            this.spliContainer1.TabIndex = 2;
            this.spliContainer1.Text = "spliContainer1";
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.Location = new System.Drawing.Point(6, 342);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(284, 21);
            this.buttonPreview.TabIndex = 9;
            this.buttonPreview.Text = "Visualizar";
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DataSourceInformation = null;
            this.comboBox2.Location = new System.Drawing.Point(231, 319);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.comboBox2.Properties.Appearance.Options.UseFont = true;
            this.comboBox2.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.comboBox2.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.comboBox2.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.comboBox2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.comboBox2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.comboBox2.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.comboBox2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.comboBox2.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.comboBox2.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.comboBox2.Properties.AutoHeight = false;
            this.comboBox2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBox2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBox2.ShowTextCombo = Nampula.UI.eShowTextCombo.eAll;
            this.comboBox2.Size = new System.Drawing.Size(59, 17);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueAlign = Nampula.UI.eValueAlign.eLeft;
            // 
            // staticText4
            // 
            this.staticText4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.staticText4.LinkedTo = null;
            this.staticText4.Location = new System.Drawing.Point(148, 320);
            this.staticText4.Name = "staticText4";
            this.staticText4.Size = new System.Drawing.Size(14, 13);
            this.staticText4.TabIndex = 7;
            this.staticText4.Text = "X";
            // 
            // editText2
            // 
            this.editText2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editText2.DataSourceInformation = null;
            this.editText2.Location = new System.Drawing.Point(167, 319);
            this.editText2.Name = "editText2";
            this.editText2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editText2.Properties.Appearance.Options.UseFont = true;
            this.editText2.Properties.Appearance.Options.UseTextOptions = true;
            this.editText2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editText2.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editText2.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editText2.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editText2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editText2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editText2.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editText2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editText2.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editText2.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editText2.Properties.AutoHeight = false;
            this.editText2.Properties.DisplayFormat.FormatString = "f0";
            this.editText2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editText2.Properties.EditFormat.FormatString = "f0";
            this.editText2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editText2.Size = new System.Drawing.Size(55, 17);
            this.editText2.TabIndex = 6;
            this.editText2.ToolTip = "Altura";
            // 
            // editText1
            // 
            this.editText1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editText1.DataSourceInformation = null;
            this.editText1.Location = new System.Drawing.Point(87, 318);
            this.editText1.Name = "editText1";
            this.editText1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editText1.Properties.Appearance.Options.UseFont = true;
            this.editText1.Properties.Appearance.Options.UseTextOptions = true;
            this.editText1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editText1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editText1.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editText1.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editText1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editText1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editText1.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editText1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editText1.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editText1.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editText1.Properties.AutoHeight = false;
            this.editText1.Properties.DisplayFormat.FormatString = "f0";
            this.editText1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editText1.Properties.EditFormat.FormatString = "f0";
            this.editText1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editText1.Size = new System.Drawing.Size(55, 17);
            this.editText1.TabIndex = 4;
            this.editText1.ToolTip = "Largura";
            // 
            // staticText2
            // 
            this.staticText2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.staticText2.LinkedTo = null;
            this.staticText2.Location = new System.Drawing.Point(3, 322);
            this.staticText2.Name = "staticText2";
            this.staticText2.Size = new System.Drawing.Size(57, 13);
            this.staticText2.TabIndex = 3;
            this.staticText2.Text = "Tamanho";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSourceInformation = null;
            this.comboBox1.Location = new System.Drawing.Point(87, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.comboBox1.Properties.Appearance.Options.UseFont = true;
            this.comboBox1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.comboBox1.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.comboBox1.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.comboBox1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.comboBox1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.comboBox1.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.comboBox1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.comboBox1.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.comboBox1.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.comboBox1.Properties.AutoHeight = false;
            this.comboBox1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBox1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBox1.ShowTextCombo = Nampula.UI.eShowTextCombo.eAll;
            this.comboBox1.Size = new System.Drawing.Size(203, 17);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ToolTip = "DPI (Pontos por polegada)";
            this.comboBox1.ValueAlign = Nampula.UI.eValueAlign.eLeft;
            // 
            // staticText1
            // 
            this.staticText1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.staticText1.LinkedTo = null;
            this.staticText1.Location = new System.Drawing.Point(3, 306);
            this.staticText1.Name = "staticText1";
            this.staticText1.Size = new System.Drawing.Size(57, 13);
            this.staticText1.TabIndex = 1;
            this.staticText1.Text = "Densidade";
            // 
            // editMemo1
            // 
            this.editMemo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editMemo1.DataSourceInformation = null;
            this.editMemo1.EditValue = resources.GetString("editMemo1.EditValue");
            this.editMemo1.Location = new System.Drawing.Point(0, 0);
            this.editMemo1.Name = "editMemo1";
            this.editMemo1.Size = new System.Drawing.Size(290, 297);
            this.editMemo1.TabIndex = 0;
            // 
            // spliContainer2
            // 
            this.spliContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spliContainer2.Location = new System.Drawing.Point(0, 0);
            this.spliContainer2.Name = "spliContainer2";
            this.spliContainer2.Panel1.Controls.Add(this.dataGridFields);
            this.spliContainer2.Panel1.Text = "Panel1";
            this.spliContainer2.Panel2.Controls.Add(this.pictureBoxPreview);
            this.spliContainer2.Panel2.Text = "Panel2";
            this.spliContainer2.Size = new System.Drawing.Size(479, 366);
            this.spliContainer2.SplitterPosition = 208;
            this.spliContainer2.TabIndex = 0;
            this.spliContainer2.Text = "spliContainer2";
            // 
            // dataGridFields
            // 
            this.dataGridFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFields.DontSavePosition = false;
            this.dataGridFields.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.dataGridFields.Location = new System.Drawing.Point(0, 0);
            this.dataGridFields.MainView = this.gridViewFields;
            this.dataGridFields.Name = "dataGridFields";
            this.dataGridFields.Size = new System.Drawing.Size(208, 366);
            this.dataGridFields.TabIndex = 0;
            this.dataGridFields.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFields});
            // 
            // gridViewFields
            // 
            this.gridViewFields.GridControl = this.dataGridFields;
            this.gridViewFields.Name = "gridViewFields";
            this.gridViewFields.OptionsView.ShowGroupPanel = false;
            this.gridViewFields.OptionsView.ShowIndicator = false;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPreview.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBoxPreview.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureBoxPreview.Size = new System.Drawing.Size(265, 366);
            this.pictureBoxPreview.TabIndex = 0;
            // 
            // LabelPrintingForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.spliContainer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "LabelPrintingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de etiquetas";
            ((System.ComponentModel.ISupportInitialize)(this.spliContainer1)).EndInit();
            this.spliContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editText2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editText1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editMemo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spliContainer2)).EndInit();
            this.spliContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Nampula.UI.Button button1;
        private Nampula.UI.Button button2;
        private Nampula.UI.SpliContainer spliContainer1;
        private Nampula.UI.SpliContainer spliContainer2;
        private Nampula.UI.DataGrid dataGridFields;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFields;
        private Nampula.UI.PictureBox pictureBoxPreview;
        private Nampula.UI.EditMemo editMemo1;
        private Nampula.UI.ComboBox comboBox1;
        private Nampula.UI.StaticText staticText1;
        private Nampula.UI.StaticText staticText4;
        private Nampula.UI.EditText editText2;
        private Nampula.UI.EditText editText1;
        private Nampula.UI.StaticText staticText2;
        private Nampula.UI.ComboBox comboBox2;
        private Nampula.UI.Button buttonPreview;
    }
}

