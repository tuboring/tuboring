using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ФИО.Text == "" && Статус.Text == "" && Почта.Text == "" && Пароль.Text == "" && ПовторитьПароль.Text == "" && Телефон.Text == "" && ДатаРождения.Text == "" && Страна.Text == "")
            {
                MessageBox.Show("Не все поля заполнены. Повторите попытку.");
                return;
            }
            if (Regex.IsMatch(Почта.Text, @"/.+@.+\..+/i") == false)
            {
                MessageBox.Show("Не правильно введен адрес почты. Повторите попытку.");
                return;
            }
            if (Regex.IsMatch(Почта.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}") == false)
            {
                MessageBox.Show("Пароль должен содержать: /nМинимум 6 символов, /nМинимум 1 прописная буква, /nМинимум 1 цифра, /nПо крайней мере один из следующих символов: ! @ # $ % ^");
                return;
            }
            if(Пароль.Text != ПовторитьПароль.Text)
            {
                MessageBox.Show("Пароли не совпадают. Повторите попытку");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
