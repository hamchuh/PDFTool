using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFTool
{
    partial class MainForm
    {
        public event EventHandler SelectedFilesChanged;

        protected virtual void OnSelectedFilesChanged() { 
            SelectedFilesChanged?.Invoke(this, EventArgs.Empty);
        }
 
    }
}
