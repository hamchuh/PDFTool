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
        private List<string> documentsToMerge = new List<string>() { };


        private void buttonSelectDocuments_Click(object sender, EventArgs e)
        {
            documentsToMerge.AddRange(SelectDocuments());
            OnSelectedDocumentsChanged();
        }


        private void buttonMergeDocuments_Click(object sender, EventArgs e)
        {
            MergeDocuments();
        }

        private string[] SelectDocuments()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PDF Documents (*.pdf)|*.pdf";
            openFileDialog.Title = "Select documents to merge";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileNames;
            }
            else return new string[0];
        }

        private void MergeDocuments()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Documents (*.pdf)|*.pdf";
            saveFileDialog.Title = "Choose the output destination";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document resultDocument = new Document();
                foreach (var file in documentsToMerge)
                {
                    resultDocument.InsertPdf(new Document(file));
                }

                resultDocument.Save(saveFileDialog.FileName);
            }
        }

        private void DocumentsToMerge_OnSelectedDocumentsChanged(object sender, EventArgs e)
        {
            if (documentsToMerge.Count > 0)
            {
                buttonMoveDown.Enabled = true;
                buttonMoveUp.Enabled = true;
                buttonRemove.Enabled = true;
                buttonMergeDocuments.Enabled = true;
            }
            else
            {
                buttonMoveDown.Enabled = false;
                buttonMoveUp.Enabled = false;
                buttonRemove.Enabled = false;
                buttonMergeDocuments.Enabled = false;
            }
        }

        private void listBoxDocuments_OnSelectedDocumentsChanged(object sender, EventArgs e)
        {
            listBoxDocuments.Items.Clear();
            listBoxDocuments.Items.AddRange(documentsToMerge.ToArray());
        }

        private void listBoxDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: document preview
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            documentsToMerge.Clear();
            OnSelectedDocumentsChanged();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxDocuments.SelectedIndex;
            if (documentsToMerge.Count > 0 && selectedIndex < documentsToMerge.Count - 1 && selectedIndex != -1)
            {
                SwapIndices<string>(ref documentsToMerge, selectedIndex, selectedIndex + 1);
                OnSelectedDocumentsChanged();
                listBoxDocuments.SelectedIndex = selectedIndex + 1;
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxDocuments.SelectedIndex;
            if (documentsToMerge.Count > 0 && selectedIndex > 0)
            {
                SwapIndices<string>(ref documentsToMerge, selectedIndex, selectedIndex - 1);
                OnSelectedDocumentsChanged();
                listBoxDocuments.SelectedIndex = selectedIndex - 1;
            }
        }

    }
}
