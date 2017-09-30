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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            LoadCounty();
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
            LoadInfoRegistration();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Загрузить_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    Фотография.Image = image;
                    Фотография.Invalidate();
                    Фотография.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void LoadInfoRegistration()
        {
            //    string query = "insert into ()";
            //    SqlCommand cmd = new SqlCommand(query, Program.con);
            //    Program.con.Open();
            //    cmd.ExecuteNonQuery();
            //    Program.con.Close();
            //    this.Close();
        }
        void LoadCounty()
        {
            string query = "select [CountryName] from [Country]";
            Program.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.con);
            DataSet myDS = new DataSet();
            da.Fill(myDS, "Country");
            Страна.DataSource = null;
            Страна.Items.Clear();
            for (int i = 0; i < myDS.Tables["Country"].Rows.Count; i++)
            {
                Страна.Items.Add(myDS.Tables["Country"].Rows[i][0].ToString());
            }
            Program.con.Close();
        }


    }
}
