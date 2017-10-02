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
        string fileName;
        public Registration()
        {
            InitializeComponent();
            LoadCounty();
            LoadRole();
            ДатаРождения.Format = DateTimePickerFormat.Custom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ФИО.Text == "" || Статус.Text == "" || Почта.Text == "" || Пароль.Text == "" || ПовторитьПароль.Text == "" || Телефон.Text == "" || ДатаРождения.Text == "" || Страна.Text == "")
            {
                MessageBox.Show("Не все поля заполнены. Повторите попытку.");
                return;
            }
            if (Regex.IsMatch(Почта.Text, @"\A[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\z") == false)
            {
                MessageBox.Show("Не правильно введен адрес почты. Повторите попытку.");
                return;
            }
            if (Regex.IsMatch(Пароль.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}") == false)
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
            ConfirmRegistration fm = new ConfirmRegistration();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    fileName = System.IO.Path.GetFullPath(open_dialog.FileName);
                    Фотография.Image = image;
                    Фотография.Invalidate();
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

            //get image:
            Image img = Image.FromFile(fileName);
            //get byte array from image:
            byte[] byteImg = ImageToByteArray(img);

            string query = "insert into [User] ([Email], [Password], [Name], [RoleId], [Telephone], [DateOfBirth], " +
                "[CountryCode], [Photo]) values  ('" + Почта.Text + "', '" + ПовторитьПароль.Text + "', '" +
                ФИО.Text + "', '" + LoadCodeRole().ToString() + "', '" + Телефон.Text + "', '" + 
                ДатаРождения.Text + "', '" + LoadCodeCountry().ToString() + "', @byteImg)";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.Parameters.Add("@byteImg", SqlDbType.Binary, 8000).Value = byteImg;

            Program.con.Open();
            cmd.ExecuteNonQuery();
            Program.con.Close();
            MessageBox.Show("Вы успешно зарегались!");

            //ДатаРождения.Format = DateTimePickerFormat.Long;
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

        void LoadRole()
        {
            string query = "select [RoleName] from [Role]";
            Program.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.con);
            DataSet myDS = new DataSet();
            da.Fill(myDS, "Role");
            Статус.DataSource = null;
            Статус.Items.Clear();
            for (int i = 0; i < myDS.Tables["Role"].Rows.Count; i++)
            {
                Статус.Items.Add(myDS.Tables["Role"].Rows[i][0].ToString());
            }
            Program.con.Close();
        }

        string LoadCodeRole()
        {
            string CRole = "";
            string query = "select * from Role where RoleName= N'" + Статус.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Program.con);

            Program.con.Open();
            SqlDataReader myReader = cmd.ExecuteReader();
            bool run = true;
            while (run && myReader.Read())
            {
                CRole = myReader.GetString(0);
                run = false;
            }
            Program.con.Close();
            return CRole;
        }

        string LoadCodeCountry()
        {
            string CCountry = "";
            string query = "select * from Country where CountryName='" + Страна.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Program.con);

            Program.con.Open();
            SqlDataReader myReader = cmd.ExecuteReader();
            bool run = true;
            while (run && myReader.Read())
            {
                CCountry = myReader.GetString(0);
                run = false;
            }
            Program.con.Close();
            return CCountry;
        }

        public byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

    }
}
