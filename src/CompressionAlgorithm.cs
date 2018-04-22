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
            for(int i = 0; i < files.Length; i++)
            {
            

                StreamReader sr = new StreamReader(files[i]); // Get first file
                string textStr = sr.ReadToEnd(); // Read contents of file, split it up for concurrency
                char[] text = textStr.ToCharArray();
                Console.WriteLine(text);

                runLengthEncoding.DoEncode(text);
            }
        }

        internal void setupRLEDecode()
        {
            
            algorithms.RunLengthEncoding runLengthEncoding = new algorithms.RunLengthEncoding();
            Open("RLE files (*.rle) |*.rle |All Files (*.*) | *.*");
            string textToDecodeStr = readFile();
            string[] textToDecode = textToDecodeStr.Split(','); //delimited by ,
            runLengthEncoding.DoDecode(textToDecode);
        }

        internal void setupHuffmanEncode()
        {
            throw new NotImplementedException();
        }


        public void Save(string filter)
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = filter;
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (save.ShowDialog() == DialogResult.OK)
            {
                dir = save.FileName;  
                Console.WriteLine("File written: " + filename + " At directory: " + Path.GetFullPath(dir));
                
                
            }
             
        }
        public void Open(string filter)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = filter;


            if (open.ShowDialog() == DialogResult.OK)
            {
                dir = open.FileName;  
                Console.WriteLine("File opened: " + open.FileName + " At directory: " + Path.GetFullPath(dir));


            }
            else
            {
                return;
            }
        }

      
        public void writeFile(string text)
        {
            try
            {
                Console.WriteLine("compressed text: " + text);
                Console.WriteLine(dir);
                File.WriteAllText(dir, text);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
             
        }

       public string readFile()
        {
            StreamReader sr = new StreamReader(dir);
            string read = sr.ReadToEnd();
            Console.WriteLine(read);

            return read;
        }
    }
}
