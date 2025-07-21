using MuPDF;
using MuPDF.NET;
using System.ComponentModel;

namespace PDFTool
{
    public partial class MainForm : Form
    {
        private List<string> documentsToMerge = new List<string>() { };

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSelectDocuments_Click(object sender, EventArgs e)
        {
            documentsToMerge.AddRange(SelectDocuments());
            OnSelectedFilesChanged();
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

        private void MergeDocuments() {
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

        private void DocumentsToMerge_OnSelectedFilesChanged(object sender, EventArgs e)
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

        private void listBoxDocuments_OnSelectedFilesChanged(object sender, EventArgs e)
        {
            listBoxDocuments.Items.Clear();
            listBoxDocuments.Items.AddRange(documentsToMerge.ToArray());
        }

        private void TabMerger_Enter(object sender, EventArgs e)
        {
            SelectedFilesChanged += DocumentsToMerge_OnSelectedFilesChanged;
            SelectedFilesChanged += listBoxDocuments_OnSelectedFilesChanged;
        }

        private void listBoxDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: document preview
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            documentsToMerge.Clear();
            OnSelectedFilesChanged();
        }

        private void SwapIndices<T>(ref List<T> collection, int a, int b)
        {
            var temp = collection[a];
            collection[a] = collection[b];
            collection[b] = temp;
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxDocuments.SelectedIndex;
            if (documentsToMerge.Count > 0 && selectedIndex < documentsToMerge.Count - 1 && selectedIndex != -1)
            {
                SwapIndices<string>(ref documentsToMerge, selectedIndex, selectedIndex + 1);
                OnSelectedFilesChanged();
                listBoxDocuments.SelectedIndex = selectedIndex + 1;
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxDocuments.SelectedIndex;
            if (documentsToMerge.Count > 0 && selectedIndex > 0)
            {
                SwapIndices<string>(ref documentsToMerge, selectedIndex, selectedIndex - 1);
                OnSelectedFilesChanged();
                listBoxDocuments.SelectedIndex = selectedIndex - 1;
            }
        }

    }
}
