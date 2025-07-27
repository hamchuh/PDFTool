using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuPDF.NET;

namespace PDFTool
{
    public partial class MainForm
    {
        private Document documentToConvert;
        private void buttonSelectDocumentToSlice_Click(object sender, EventArgs e)
        {
            string documentPath = SelectDocument();
            if (documentPath is not null) documentToConvert = new Document(documentPath);
            OnSelectedDocumentsChanged();
        }

        private string SelectDocument()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Documents (*.pdf)|*.pdf";
            openFileDialog.Title = "Select document to slice";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else return null;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the output folder";
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog.SelectedPath;

                int pageFrom = (int)numberPageFrom.Value;
                int pageTo = (int)numberPageTo.Value;

                for (int i = pageFrom-1; i < pageTo; ++i)
                {
                    var pixmap = documentToConvert[i].GetPixmap(dpi: (int)numberImageQuality.Value);
                    pixmap.Save($"{selectedFolder}/" +
                                $"{Path.GetFileName(documentToConvert.Name)}__page{i + 1}{comboBoxFileFormat.SelectedItem}", 
                                jpgQuality: (int)numberJPEGQuality.Value);
                }
            }
        }

        private void comboBoxFileFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonConvert.Text = $"Convert to {comboBoxFileFormat.SelectedItem}";
            if (comboBoxFileFormat.SelectedItem == ".jpg") numberJPEGQuality.Enabled = true;
            else numberJPEGQuality.Enabled = false;
        }

        private void numberPageFrom_ValueChanged(object sender, EventArgs e)
        {
            if (numberPageFrom.Value > numberPageTo.Value) numberPageTo.Value = numberPageFrom.Value;
            numberPageTo.Minimum = numberPageFrom.Value;
        }


        private void DocumentToConvert_SelectedDocumentChanged(object sender, EventArgs e) { 
            if (documentToConvert is not null)
            {
                groupBoxPreferences.Enabled = true;
                buttonConvert.Enabled = true;

                groupBoxPreferences.Text = $"Preferences (selected document: {Path.GetFileName(documentToConvert.Name)}";
                comboBoxFileFormat.SelectedItem = ".jpg";

                numberPageFrom.Minimum = 1;
                numberPageFrom.Maximum = documentToConvert.PageCount;
                numberPageTo.Minimum = 1;
                numberPageTo.Maximum = documentToConvert.PageCount;

                numberPageFrom.Value = 1;
                numberPageTo.Value = documentToConvert.PageCount;

            }
        }
    }
}
