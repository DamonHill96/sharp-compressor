namespace C_sharp_Compressor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRLE = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblCurrentDir = new System.Windows.Forms.Label();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnHuffman = new System.Windows.Forms.Button();
            this.btnAutomatic = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnRLE
            // 
            this.btnRLE.Location = new System.Drawing.Point(10, 36);
            this.btnRLE.Name = "btnRLE";
            this.btnRLE.Size = new System.Drawing.Size(139, 23);
            this.btnRLE.TabIndex = 1;
            this.btnRLE.Text = "Run-Length Encoding";
            this.btnRLE.UseVisualStyleBackColor = true;
            this.btnRLE.Click += new System.EventHandler(this.btnRLE_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(10, 215);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(44, 21);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblCurrentDir
            // 
            this.lblCurrentDir.AutoSize = true;
            this.lblCurrentDir.Location = new System.Drawing.Point(10, 163);
            this.lblCurrentDir.Name = "lblCurrentDir";
            this.lblCurrentDir.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentDir.TabIndex = 4;
            this.lblCurrentDir.Text = "label1";
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(677, 215);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(110, 21);
            this.btnSelectDir.TabIndex = 5;
            this.btnSelectDir.Text = "Select Directory";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(10, 260);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(778, 184);
            this.checkedListBox1.TabIndex = 6;
            // 
            // btnHuffman
            // 
            this.btnHuffman.Location = new System.Drawing.Point(184, 36);
            this.btnHuffman.Name = "btnHuffman";
            this.btnHuffman.Size = new System.Drawing.Size(139, 23);
            this.btnHuffman.TabIndex = 7;
            this.btnHuffman.Text = "Huffman Coding";
            this.btnHuffman.UseVisualStyleBackColor = true;
            // 
            // btnAutomatic
            // 
            this.btnAutomatic.Location = new System.Drawing.Point(365, 36);
            this.btnAutomatic.Name = "btnAutomatic";
            this.btnAutomatic.Size = new System.Drawing.Size(139, 23);
            this.btnAutomatic.TabIndex = 8;
            this.btnAutomatic.Text = "Auto-Select";
            this.btnAutomatic.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(10, 96);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(139, 23);
            this.btnDecode.TabIndex = 9;
            this.btnDecode.Text = "Decode RLE";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnAutomatic);
            this.Controls.Add(this.btnHuffman);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.lblCurrentDir);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRLE);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnRLE;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblCurrentDir;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnHuffman;
        private System.Windows.Forms.Button btnAutomatic;
        private System.Windows.Forms.Button btnDecode;
    }
}

