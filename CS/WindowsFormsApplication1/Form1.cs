using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
			richEditControl1.Text = StringSample.SampleText;
            richEditControl1.ActiveView.ZoomFactor = .5f;
        }

        private void richEditControl1_PopupMenuShowing(object sender, DevExpress.XtraRichEdit.PopupMenuShowingEventArgs e) {
			e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Add watermark", AddImageWatermark));
            e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Remove watermark", RemoveImageWatermark));

        }

        private void simpleButton1_Click(object sender, EventArgs e) {
			richEditControl1.Document.AppendSection();
            richEditControl1.Document.InsertText(richEditControl1.Document.Range.End, StringSample.SampleText);
        }

        public void AddImageWatermark(object sender, EventArgs e) {
            Image watermarkImage = null;

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Select Image";
            dlg.Filter = "image files (*.png)|*.png";

            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                watermarkImage = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
            if(watermarkImage == null) {
                return;
            }

            Section currentSection = GetCurrentSection();
            SubDocument subDocument = currentSection.BeginUpdateHeader();
            subDocument.Delete(subDocument.Range);
            Shape shape = subDocument.InsertPicture(subDocument.Range.Start, watermarkImage);

            shape.RotationAngle = -45;
            shape.Offset = new PointF(Convert.ToInt64(currentSection.Page.Width) / 2 - Convert.ToInt64(shape.Size.Width) / 2, Convert.ToInt64(currentSection.Page.Height) / 2 - Convert.ToInt64(shape.Size.Height) / 2);
            currentSection.EndUpdateHeader(subDocument);
        }

        public Section GetCurrentSection() {
            return richEditControl1.Document.GetSection(richEditControl1.Document.CaretPosition);
        }

        public void RemoveImageWatermark(object sender, EventArgs e) {
            Section currentSection = GetCurrentSection();
            SubDocument subDocument = currentSection.BeginUpdateHeader();
            subDocument.Delete(subDocument.Range);
            currentSection.EndUpdateHeader(subDocument);
        }
    }
}
