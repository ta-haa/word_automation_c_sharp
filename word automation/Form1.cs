using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "empty";
            openFileDialog1.Filter = "word | *.rtf | text | *.txt";
            openFileDialog1.Title = "kaydet";
            openFileDialog1.ShowDialog();
            richTextBox1.LoadFile(openFileDialog1.FileName);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "empty";
            saveFileDialog1.Filter = "word | *.rtf | text | *.txt";
            saveFileDialog1.Title = "kaydet";
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "empty";
            saveFileDialog1.Filter = "word | *.rtf | text | *.txt";
            saveFileDialog1.Title = "kaydet";
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void yineleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font=new Font("comic sans ms",18,FontStyle.Bold);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void formAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void formKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TahaKeskin");
        }
    }
}
