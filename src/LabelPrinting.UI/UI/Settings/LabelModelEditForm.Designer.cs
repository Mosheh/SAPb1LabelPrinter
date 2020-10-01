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
            ((System.ComponentModel.ISupportInitialize)(this.editTextName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPrinterName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // staticText1
            // 
            this.staticText1.LinkedTo = this.editTextName;
            this.staticText1.Location = new System.Drawing.Point(3, 11);
            this.staticText1.Name = "staticText1";
            this.staticText1.Size = new System.Drawing.Size(121, 17);
            this.staticText1.TabIndex = 0;
            this.staticText1.Text = "Nome do modelo";
            // 
            // editTextName
            // 
            this.editTextName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editTextName.DataSourceInformation = null;
            this.editTextName.Location = new System.Drawing.Point(124, 11);
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
            this.editTextName.Size = new System.Drawing.Size(297, 17);
            this.editTextName.TabIndex = 1;
            // 
            // comboBoxPrinterName
            // 
            this.comboBoxPrinterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPrinterName.DataSourceInformation = null;
            this.comboBoxPrinterName.Location = new System.Drawing.Point(124, 34);
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
            this.comboBoxPrinterName.Size = new System.Drawing.Size(297, 17);
            this.comboBoxPrinterName.TabIndex = 3;
            this.comboBoxPrinterName.ValueAlign = Nampula.UI.eValueAlign.eLeft;
            // 
            // staticText2
            // 
            this.staticText2.LinkedTo = this.comboBoxPrinterName;
            this.staticText2.Location = new System.Drawing.Point(3, 34);
            this.staticText2.Name = "staticText2";
            this.staticText2.Size = new System.Drawing.Size(121, 17);
            this.staticText2.TabIndex = 2;
            this.staticText2.Text = "Impressora";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(87, 92);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Location = new System.Drawing.Point(6, 92);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // LabelModelEditForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 127);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Nampula.UI.StaticText staticText1;
        private Nampula.UI.EditText editTextName;
        private Nampula.UI.ComboBox comboBoxPrinterName;
        private Nampula.UI.StaticText staticText2;
        private Nampula.UI.Button buttonCancel;
        private Nampula.UI.Button buttonOK;
    }
}