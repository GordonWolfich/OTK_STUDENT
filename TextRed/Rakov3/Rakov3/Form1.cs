using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Rakov3
{
    public partial class Form1 : Form
    {
        AboutBox1 aboutBox1;
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Open_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                string fileName = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void button1Save_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));

            }
            richTextBox1.Clear();
        }

        private void button2_Open_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                string fileName = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void button2Save_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));

            }
            richTextBox1.Clear();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void button_cut_1(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button_copy_1(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button_paste_1(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void button_clear_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void print_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void button_print_1(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button_print_preview_1(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button_left_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button_open_about(object sender, EventArgs e)
        {

            aboutBox1 = new AboutBox1();
            aboutBox1.Show();
            this.Hide();
        }
        public Color SelectedColor { get; set; }
        public Font SelectedFont { get; set; }

        private void button_color_click1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void button_font_click1(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void Button_color_click2(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void button_font_click2(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void button_LK_click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button_CE_click1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button_RK_click1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}

