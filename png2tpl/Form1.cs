using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace png2tpl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Texture Palette Image (*.tpl)|*.tpl"+
                "|All Files (*.*)|*.*";
            OFD.Title = "Select file";
            if (OFD.ShowDialog() != DialogResult.OK) return;
            textBox1.Text = OFD.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Portable Network Graphics (*.png)|*.png";
            SFD.FilterIndex = 0;
            SFD.RestoreDirectory = true;
            SFD.Title = "Please select the saved directory";
            SFD.FileName = null;
            SFD.ShowDialog();
            string strPath = SFD.FileName;
            Image img = pictureBox1.Image;
            img.Save(strPath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }
    }
}