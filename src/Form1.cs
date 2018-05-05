using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Compressor
{
    public partial class Form1 : Form
    {
        dir.DirectoryHandle directoryHandle = new dir.DirectoryHandle();
        public Form1()
        {
            InitializeComponent();
            Setup();

        }

        private void Setup()
        {
            lblCurrentDir.Text = directoryHandle.GetDefaultDir();
            string[] contents = directoryHandle.GetDirContents();

            foreach (var item in contents)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void btnRLE_Click(object sender, EventArgs e)
        {
            try
            {


                string[] filesToCheck = new string[checkedListBox1.CheckedItems.Count];
                int i = 0;
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    filesToCheck[i] = item.ToString();
                    Console.WriteLine(filesToCheck[i]);
                    i++;
                }
                compalg.CompressionAlgorithm compressionAlgorithm = new compalg.CompressionAlgorithm(filesToCheck);
                compressionAlgorithm.setupRLEEncode();
            } catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No files selected!", "Error");
                return;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            directoryHandle.SetDefaultDir(Path.GetFullPath(Path.Combine(directoryHandle.GetDefaultDir(), @"..\")));
            directoryHandle.GetDirContents();
            Setup();
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            compalg.CompressionAlgorithm compressionAlgorithm = new compalg.CompressionAlgorithm();
            compressionAlgorithm.setupRLEDecode();
        }

        private void btnHuffman_Click(object sender, EventArgs e)
        {
            try
            {

                string[] filesToCheck = new string[checkedListBox1.CheckedItems.Count];
                int i = 0;
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    filesToCheck[i] = item.ToString();
                    Console.WriteLine(filesToCheck[i]);
                    i++;
                }
                compalg.CompressionAlgorithm compressionAlgorithm = new compalg.CompressionAlgorithm(filesToCheck);
                compressionAlgorithm.setupHuffmanEncode();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No files selected!", "Error");
                return;
            }
        }
    }
    
}
