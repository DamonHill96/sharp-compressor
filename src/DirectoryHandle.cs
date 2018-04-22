using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace dir
{
    class DirectoryHandle
    {
        private string dir;
        public DirectoryHandle() => SetDefaultDir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

        public String[] GetDirContents()
        {

           return Directory.GetFiles(dir, "*.txt", SearchOption.TopDirectoryOnly);
            
        }



       public string GetDefaultDir()
        {
           return this.dir;
        }

        public void SetDefaultDir(string dir)
        {
            this.dir = dir;
        }
    }
}
