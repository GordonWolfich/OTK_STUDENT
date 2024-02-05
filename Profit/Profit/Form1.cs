using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum; //сумма
            int period; //сроки

            double percent; //Ставка
            double profit; //Доход
            try
            {
                sum = Convert.ToDouble(textBox1.Text);
                period = Convert.ToInt32(textBox2.Text);

                if (sum < 10000) // если сумма меньше 10к, то % будет 8,5. Если больше 10к, то 12 %.
                    percent = 8.5;
                else
                    percent = 12;

                profit = sum * (percent / 100 / 12) * period;

                label3.Text = "Процентная ставка: " + percent.ToString("n") + "%\n" + "Доход: " + profit.ToString("c");
            }
            catch //Ловит ошибку при расчёте
            {
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0))
                    MessageBox.Show("Оба поля должны быть заполнены.", "Доход", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Ошибка в исходных данных." + "В поле Сумма надо ввести целое или дробное число " + "(в качестве десятичного разделителя используйте " + "запятую), в поле Срок - целое", "Доход", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
