using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace compalg
{
    class CompressionAlgorithm
    {
        private string filename;
        string[] files;
        string dir;

        public CompressionAlgorithm()
        {

        }

        public CompressionAlgorithm(string[] files)
        {
            this.files = files;
        }

        public void setupRLEEncode()
        {
            algorithms.RunLengthEncoding runLengthEncoding = new algorithms.RunLengthEncoding();

            //TODO concurrency
            StreamReader sr = new StreamReader(files[0]); // Get first file
            string textStr = sr.ReadToEnd(); // Read contents of file, split it up for concurrency
            char[] text = textStr.ToCharArray(); 
            Console.WriteLine(text);

            runLengthEncoding.DoEncode(text);
        }

        public void Save()
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt) |*.txt |All Files (*.*) | *.*";
            save.FileName = "Untitled";
            filename = save.FileName;

            if (save.ShowDialog() == DialogResult.OK)
            {
                dir = save.FileName;  //repeated to get new directory
                Console.WriteLine("File written: " + filename + " At directory: " + Path.GetFullPath(dir));
                
                
            }
             
        }

     
        public void writeFile(string compressedText)
        {
            try
            {
                Console.WriteLine("compressed text: " + compressedText);
                File.WriteAllText(dir, compressedText);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
             
        }
    }
}
