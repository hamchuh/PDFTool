using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFTool
{
    partial class MainForm
    {
        public event EventHandler SelectedDocumentsChanged;

        protected virtual void OnSelectedDocumentsChanged() { 
            SelectedDocumentsChanged?.Invoke(this, EventArgs.Empty);
        }
         
    }
}
