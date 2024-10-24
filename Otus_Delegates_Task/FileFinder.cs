using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Otus_Delegates_Task
{
    public class FileSearcher : EventArgs
    {
        public event EventHandler<FileArgs> FileFound;
        public void SearchDirectory(string directory)
        {
            if(!Directory.Exists(directory)) throw new DirectoryNotFoundException();
            foreach (var file in Directory.GetFiles(directory))
            {
                var args = new FileArgs(file);
                OnFileFound(args);
                if(args.Cancel) 
                    break;
            }
        }

        protected virtual void OnFileFound(FileArgs e)
        {
            FileFound?.Invoke(this, e);
        }
    }
} 
