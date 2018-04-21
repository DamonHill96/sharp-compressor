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
            Directory.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] contents = directoryHandle.getDirContents();

            foreach (var item in contents)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
