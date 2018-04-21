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
        public DirectoryHandle()
        {
            setDefaultDir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        public String[] getDirContents()
        {

           return Directory.GetFiles(dir);
            
        }



       public string getDefaultDir()
        {
           return this.dir;
        }

        public void setDefaultDir(string dir)
        {
            this.dir = dir;
        }
    }
}
