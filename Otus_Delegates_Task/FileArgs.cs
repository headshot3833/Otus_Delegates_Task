using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Delegates_Task
{
    public class FileArgs : EventArgs
    {
        public string FileName { get; }

        public bool Cancel { get; set; }
        public FileArgs(string fileName)
        {
            FileName = fileName;
            Cancel = false;
        }
    }
}
