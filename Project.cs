using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PR2._2
{
    public partial class Project : Form
    {
        private Dictionary<string, int> mydict1 = new Dictionary<string, int>()
        {
            ["Первое число"] = 5, 
            ["Второе число"] = 9, 
            ["Третье число"] = 12, 
            ["Четвертое число"] = 15,
        };
        private Dictionary<string, int> mydict2 = new Dictionary<string, int>();
        public Project()
        {
            InitializeComponent();
        }
        private void btnMath1_Click(object sender, EventArgs e)
        {
            int product = 1;
            foreach (int value in mydict1.Values) product *= value;
            textBoxResult1.Text = product.ToString();
        }
        private void btnMath2_Click(object sender, EventArgs e)
        {
            int product = 1, num;
            string[] numbers = textBoxInput.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите числа для расчета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxResult2.Clear();
                return;
            }
            mydict2.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!Int32.TryParse(numbers[i], out num))
                {
                    MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxInput.Clear();
                    textBoxResult2.Clear();
                    return;
                }
                mydict2[$"{i + 1}"] = num;
            }
            foreach (int value in mydict2.Values) product *= value;
            textBoxResult2.Text = product.ToString();
        }
        private void calculation1_Click(object sender, EventArgs e)
        { 
            btnMath1_Click(sender, e);
        }
        private void calculation2_Click(object sender, EventArgs e)
        {
            btnMath2_Click(sender, e);
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exitMenu_Click(object sender, EventArgs e)
        {
            exit_Click(sender, e);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBoxResult1.Clear();
            textBoxResult2.Clear();
            textBoxInput.Clear();
        }
        private void info_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Show();
        }
    }
}