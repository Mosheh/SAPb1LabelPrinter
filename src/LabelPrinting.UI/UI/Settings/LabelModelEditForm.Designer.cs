namespace LabelPrinting.UI.UI.Settings
{
    partial class LabelModelEditForm
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
            this.staticText1 = new Nampula.UI.StaticText();
            this.editTextName = new Nampula.UI.EditText();
            this.comboBoxPrinterName = new Nampula.UI.ComboBox();
            this.staticText2 = new Nampula.UI.StaticText();
            this.buttonCancel = new Nampula.UI.Button();
            this.buttonOK = new Nampula.UI.Button();
            this.editTextAlignTop = new Nampula.UI.EditText();
            this.staticText3 = new Nampula.UI.StaticText();
            this.editTextAlignLeft = new Nampula.UI.EditText();
            this.staticText4 = new Nampula.UI.StaticText();
            this.editTextWidth = new Nampula.UI.EditText();
            this.staticText5 = new Nampula.UI.StaticText();
            this.editTextLength = new Nampula.UI.EditText();
            this.staticText6 = new Nampula.UI.StaticText();
            this.editTextDecimalPlaces = new Nampula.UI.EditText();
            this.staticText7 = new Nampula.UI.StaticText();
            ((System.ComponentModel.ISupportInitialize)(this.editTextName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPrinterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextAlignTop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextAlignLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextDecimalPlaces.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // staticText1
            // 
            this.staticText1.LinkedTo = this.editTextName;
            this.staticText1.Location = new System.Drawing.Point(3, 11);
            this.staticText1.Name = "staticText1";
            this.staticText1.Size = new System.Drawing.Size(157, 17);
            this.staticText1.TabIndex = 0;
            this.staticText1.Text = "Nome do modelo";
            // 
            // editTextName
            // 
            this.editTextName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editTextName.DataSourceInformation = null;
            this.editTextName.Location = new System.Drawing.Point(160, 11);
            this.editTextName.Name = "editTextName";
            this.editTextName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextName.Properties.Appearance.Options.UseFont = true;
            this.editTextName.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextName.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextName.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextName.Properties.AutoHeight = false;
            this.editTextName.Properties.DisplayFormat.FormatString = "f0";
            this.editTextName.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextName.Properties.EditFormat.FormatString = "f0";
            this.editTextName.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextName.Properties.MaxLength = 100;
            this.editTextName.Size = new System.Drawing.Size(261, 17);
            this.editTextName.TabIndex = 1;
            // 
            // comboBoxPrinterName
            // 
            this.comboBoxPrinterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPrinterName.DataSourceInformation = null;
            this.comboBoxPrinterName.Location = new System.Drawing.Point(160, 28);
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
            this.comboBoxPrinterName.ShowTextCombo = Nampula.UI.eShowTextCombo.eAll;
            this.comboBoxPrinterName.Size = new System.Drawing.Size(261, 17);
            this.comboBoxPrinterName.TabIndex = 3;
            this.comboBoxPrinterName.ValueAlign = Nampula.UI.eValueAlign.eLeft;
            // 
            // staticText2
            // 
            this.staticText2.LinkedTo = this.comboBoxPrinterName;
            this.staticText2.Location = new System.Drawing.Point(3, 28);
            this.staticText2.Name = "staticText2";
            this.staticText2.Size = new System.Drawing.Size(157, 17);
            this.staticText2.TabIndex = 2;
            this.staticText2.Text = "Impressora";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(87, 158);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Location = new System.Drawing.Point(6, 158);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // editTextAlignTop
            // 
            this.editTextAlignTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editTextAlignTop.DataSourceInformation = null;
            this.editTextAlignTop.Location = new System.Drawing.Point(160, 45);
            this.editTextAlignTop.Name = "editTextAlignTop";
            this.editTextAlignTop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextAlignTop.Properties.Appearance.Options.UseFont = true;
            this.editTextAlignTop.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextAlignTop.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextAlignTop.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextAlignTop.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextAlignTop.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextAlignTop.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextAlignTop.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextAlignTop.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextAlignTop.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextAlignTop.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextAlignTop.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextAlignTop.Properties.AutoHeight = false;
            this.editTextAlignTop.Properties.DisplayFormat.FormatString = "f0";
            this.editTextAlignTop.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextAlignTop.Properties.EditFormat.FormatString = "f0";
            this.editTextAlignTop.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextAlignTop.Properties.MaxLength = 100;
            this.editTextAlignTop.Size = new System.Drawing.Size(261, 17);
            this.editTextAlignTop.TabIndex = 7;
            // 
            // staticText3
            // 
            this.staticText3.LinkedTo = this.editTextAlignTop;
            this.staticText3.Location = new System.Drawing.Point(3, 45);
            this.staticText3.Name = "staticText3";
            this.staticText3.Size = new System.Drawing.Size(157, 17);
            this.staticText3.TabIndex = 6;
            this.staticText3.Text = "Alinhamento superior";
            // 
            // editTextAlignLeft
            // 
            this.editTextAlignLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editTextAlignLeft.DataSourceInformation = null;
            this.editTextAlignLeft.Location = new System.Drawing.Point(160, 62);
            this.editTextAlignLeft.Name = "editTextAlignLeft";
            this.editTextAlignLeft.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextAlignLeft.Properties.Appearance.Options.UseFont = true;
            this.editTextAlignLeft.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextAlignLeft.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextAlignLeft.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextAlignLeft.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextAlignLeft.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextAlignLeft.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextAlignLeft.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextAlignLeft.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextAlignLeft.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextAlignLeft.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextAlignLeft.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextAlignLeft.Properties.AutoHeight = false;
            this.editTextAlignLeft.Properties.DisplayFormat.FormatString = "f0";
            this.editTextAlignLeft.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextAlignLeft.Properties.EditFormat.FormatString = "f0";
            this.editTextAlignLeft.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextAlignLeft.Properties.MaxLength = 100;
            this.editTextAlignLeft.Size = new System.Drawing.Size(261, 17);
            this.editTextAlignLeft.TabIndex = 9;
            // 
            // staticText4
            // 
            this.staticText4.LinkedTo = this.editTextAlignLeft;
            this.staticText4.Location = new System.Drawing.Point(3, 62);
            this.staticText4.Name = "staticText4";
            this.staticText4.Size = new System.Drawing.Size(157, 17);
            this.staticText4.TabIndex = 8;
            this.staticText4.Text = "Alinhamento esquerdo";
            // 
            // editTextWidth
            // 
            this.editTextWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editTextWidth.DataSourceInformation = null;
            this.editTextWidth.Location = new System.Drawing.Point(160, 96);
            this.editTextWidth.Name = "editTextWidth";
            this.editTextWidth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextWidth.Properties.Appearance.Options.UseFont = true;
            this.editTextWidth.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextWidth.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextWidth.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextWidth.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextWidth.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextWidth.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextWidth.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextWidth.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextWidth.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextWidth.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextWidth.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextWidth.Properties.AutoHeight = false;
            this.editTextWidth.Properties.DisplayFormat.FormatString = "f0";
            this.editTextWidth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextWidth.Properties.EditFormat.FormatString = "f0";
            this.editTextWidth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextWidth.Properties.MaxLength = 100;
            this.editTextWidth.Size = new System.Drawing.Size(261, 17);
            this.editTextWidth.TabIndex = 13;
            // 
            // staticText5
            // 
            this.staticText5.LinkedTo = this.editTextWidth;
            this.staticText5.Location = new System.Drawing.Point(3, 96);
            this.staticText5.Name = "staticText5";
            this.staticText5.Size = new System.Drawing.Size(157, 17);
            this.staticText5.TabIndex = 12;
            this.staticText5.Text = "Largura";
            // 
            // editTextLength
            // 
            this.editTextLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editTextLength.DataSourceInformation = null;
            this.editTextLength.Location = new System.Drawing.Point(160, 79);
            this.editTextLength.Name = "editTextLength";
            this.editTextLength.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextLength.Properties.Appearance.Options.UseFont = true;
            this.editTextLength.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextLength.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextLength.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextLength.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextLength.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextLength.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextLength.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextLength.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextLength.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextLength.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextLength.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextLength.Properties.AutoHeight = false;
            this.editTextLength.Properties.DisplayFormat.FormatString = "f0";
            this.editTextLength.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextLength.Properties.EditFormat.FormatString = "f0";
            this.editTextLength.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextLength.Properties.MaxLength = 100;
            this.editTextLength.Size = new System.Drawing.Size(261, 17);
            this.editTextLength.TabIndex = 11;
            // 
            // staticText6
            // 
            this.staticText6.LinkedTo = this.editTextLength;
            this.staticText6.Location = new System.Drawing.Point(3, 79);
            this.staticText6.Name = "staticText6";
            this.staticText6.Size = new System.Drawing.Size(157, 17);
            this.staticText6.TabIndex = 10;
            this.staticText6.Text = "Altura";
            // 
            // editTextDecimalPlaces
            // 
            this.editTextDecimalPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editTextDecimalPlaces.DataSourceInformation = null;
            this.editTextDecimalPlaces.Location = new System.Drawing.Point(160, 119);
            this.editTextDecimalPlaces.Name = "editTextDecimalPlaces";
            this.editTextDecimalPlaces.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextDecimalPlaces.Properties.Appearance.Options.UseFont = true;
            this.editTextDecimalPlaces.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextDecimalPlaces.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextDecimalPlaces.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextDecimalPlaces.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextDecimalPlaces.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextDecimalPlaces.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextDecimalPlaces.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextDecimalPlaces.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextDecimalPlaces.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextDecimalPlaces.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextDecimalPlaces.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextDecimalPlaces.Properties.AutoHeight = false;
            this.editTextDecimalPlaces.Properties.DisplayFormat.FormatString = "f0";
            this.editTextDecimalPlaces.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextDecimalPlaces.Properties.EditFormat.FormatString = "f0";
            this.editTextDecimalPlaces.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextDecimalPlaces.Properties.MaxLength = 100;
            this.editTextDecimalPlaces.Size = new System.Drawing.Size(81, 17);
            this.editTextDecimalPlaces.TabIndex = 15;
            this.editTextDecimalPlaces.ToolTip = "Formatar números do tipo valor (preço) com apenas duas casas";
            // 
            // staticText7
            // 
            this.staticText7.LinkedTo = this.editTextDecimalPlaces;
            this.staticText7.Location = new System.Drawing.Point(3, 119);
            this.staticText7.Name = "staticText7";
            this.staticText7.Size = new System.Drawing.Size(157, 17);
            this.staticText7.TabIndex = 14;
            this.staticText7.Text = "Casas decimais para tipo valor";
            // 
            // LabelModelEditForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 193);
            this.Controls.Add(this.editTextDecimalPlaces);
            this.Controls.Add(this.staticText7);
            this.Controls.Add(this.editTextWidth);
            this.Controls.Add(this.staticText5);
            this.Controls.Add(this.editTextLength);
            this.Controls.Add(this.staticText6);
            this.Controls.Add(this.editTextAlignLeft);
            this.Controls.Add(this.staticText4);
            this.Controls.Add(this.editTextAlignTop);
            this.Controls.Add(this.staticText3);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.staticText2);
            this.Controls.Add(this.comboBoxPrinterName);
            this.Controls.Add(this.editTextName);
            this.Controls.Add(this.staticText1);
            this.Name = "LabelModelEditForm";
            this.Text = "Edição";
            ((System.ComponentModel.ISupportInitialize)(this.editTextName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPrinterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextAlignTop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextAlignLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextDecimalPlaces.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Nampula.UI.StaticText staticText1;
        private Nampula.UI.EditText editTextName;
        private Nampula.UI.ComboBox comboBoxPrinterName;
        private Nampula.UI.StaticText staticText2;
        private Nampula.UI.Button buttonCancel;
        private Nampula.UI.Button buttonOK;
        private Nampula.UI.EditText editTextAlignTop;
        private Nampula.UI.StaticText staticText3;
        private Nampula.UI.EditText editTextAlignLeft;
        private Nampula.UI.StaticText staticText4;
        private Nampula.UI.EditText editTextWidth;
        private Nampula.UI.StaticText staticText5;
        private Nampula.UI.EditText editTextLength;
        private Nampula.UI.StaticText staticText6;
        private Nampula.UI.EditText editTextDecimalPlaces;
        private Nampula.UI.StaticText staticText7;
    }
}