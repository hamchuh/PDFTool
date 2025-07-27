using System.ComponentModel;

namespace PDFTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TabMerger_Enter(object sender, EventArgs e)
        {
            SelectedDocumentsChanged = null;
            SelectedDocumentsChanged += DocumentsToMerge_OnSelectedDocumentsChanged;
            SelectedDocumentsChanged += listBoxDocuments_OnSelectedDocumentsChanged;
        }

        private void TabToImages_Enter(object sender, EventArgs e)
        {
            SelectedDocumentsChanged = null;
            SelectedDocumentsChanged += DocumentToConvert_SelectedDocumentChanged;
        }

        private void SwapIndices<T>(ref List<T> collection, int a, int b)
        {
            var temp = collection[a];
            collection[a] = collection[b];
            collection[b] = temp;
        }

    }
}
