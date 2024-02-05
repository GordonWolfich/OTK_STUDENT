using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        AboutBox1 aboutbox;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_click_1(object sender, EventArgs e)
        {
            //Добавление текста в список
            string input = textBox1.Text;
            listBox1.Items.Add(input);
        }

        private void button_insert_click1(object sender, EventArgs e)
        {
            string text = Clipboard.GetText();
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                index = listBox1.Items.Count;
                listBox1.Items.Insert(index, text);
            }
        }

        private void button_(object sender, EventArgs e)
        {

        }

        private void button_edit_click1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) //если выделенный текст не равняется пустоте
            {
                string newtext = textBox1.Text;  //новый текст
                //Выделение текста из списка
                int index = listBox1.SelectedIndex;
                object item = listBox1.SelectedItem;
                //Удаление текста и вставка нового текста
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, newtext);
                listBox1.SelectedItem = item; // Возвращает выделение
            }
        }

        private void button_delete_click1(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void button_clear_click1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_open_click1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                string fileName = openFileDialog1.FileName;
                listBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void button_save_click1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, listBox1.Text, Encoding.GetEncoding(1251));
            }
        }

        private void button_open_click2(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                string fileName = openFileDialog1.FileName;
                listBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void button_save_click2(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, listBox1.Text, Encoding.GetEncoding(1251));
            }
        }

        private void button_O_click1(object sender, EventArgs e)
        {
            aboutbox = new AboutBox1();
            aboutbox.Show();
            this.Hide();
        }

        private void button_add_click1(object sender, EventArgs e)
        {
            //Добавление текста в список
            string input = textBox1.Text;
            listBox1.Items.Add(input);
        }

        private void button_insert_click2(object sender, EventArgs e)
        {
            string text = Clipboard.GetText();
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                index = listBox1.Items.Count;
                listBox1.Items.Insert(index, text);
            }
        }

        private void button_edit_click2(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) //если выделенный текст не равняется пустоте
            {
                string newtext = textBox1.Text;  //новый текст
                //Выделение текста из списка
                int index = listBox1.SelectedIndex;
                object item = listBox1.SelectedItem;
                //Удаление текста и вставка нового текста
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, newtext);
                listBox1.SelectedItem = item; // Возвращает выделение
            }
        }

        private void button_delete_click2(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void button_clear_click2(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_exit_click1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
