using LabelPrinting.UI.Domain.PrintServices;
using LabelPrinting.UI.Infra.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = Nampula.UI.Form;
namespace LabelPrinting
{
    public partial class LabelPrintingForm : Form
    {
        public LabelPrintingForm()
        {
            InitializeComponent();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            try
            {
                ILabelPreview labelPreview = new LabelPreview();
                var stream = labelPreview.GetLabel("http://api.labelary.com/v1/printers", new PrintSetting(), editMemo1.Text);

                var image = Bitmap.FromStream(stream);
                pictureBoxPreview.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox(ex.Message);
            }
        }
    }
}
