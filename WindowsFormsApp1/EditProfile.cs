using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditProfile : Form
    {
        string fileName;
        bool newImage = false;

        public EditProfile()
        {
            InitializeComponent();
            LoadCounty();
            LoadRole();
            LoadInfoUser();
            ДатаРождения.Format = DateTimePickerFormat.Custom;
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

        void LoadInfoUser()
        {
            string query = "SELECT * FROM [User] join [Role] on [User].[RoleId]=[Role].[RoleId] WHERE [Email] ='" + Program.UserId + "'";
            Program.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.con);
            DataSet myDS = new DataSet();
            da.Fill(myDS, "User");
            Пароль.Text = myDS.Tables["User"].Rows[0][1].ToString();
            ПовторитьПароль.Text = myDS.Tables["User"].Rows[0][1].ToString();
            ФИО.Text = myDS.Tables["User"].Rows[0][2].ToString();
            Статус.Text = myDS.Tables["User"].Rows[0][9].ToString();
            Почта.Text = myDS.Tables["User"].Rows[0][0].ToString();
            Телефон.Text = myDS.Tables["User"].Rows[0][4].ToString();
            ДатаРождения.Text = myDS.Tables["User"].Rows[0][5].ToString();

            if (myDS.Tables["User"].Rows[0][7].ToString() !="")
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(myDS.Tables["User"].Rows[0][7]);
                MemoryStream mem = new MemoryStream(data);
                Фотография.Image = Image.FromStream(mem);
            }

            query = "SELECT [User].[Email], [Country].[CountryName] FROM [User] join [Country] on [User].[CountryCode]=[Country].[CountryCode] WHERE [Email] = '" + Program.UserId + "'";
            da = new SqlDataAdapter(query, Program.con);
            myDS = new DataSet();
            da.Fill(myDS, "User");
            if(myDS.Tables["User"].Rows.Count!=0)
                Страна.Text = myDS.Tables["User"].Rows[0][1].ToString();
            Program.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newImage = true;
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
                    ЗагрузкаФото.Text = fileName;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Image ResizeOrigImg(Image image)
        {
            int newWidth = 196, newHeight;

            var coefH = (double)175 / (double)image.Height;
            var coefW = (double)196 / (double)image.Width;

            if (coefW >= coefH)
            {
                newHeight = (int)(image.Height * coefH);
                newWidth = (int)(image.Width * coefH);
            }
            else
            {
                newHeight = (int)(image.Height * coefW);
                newWidth = (int)(image.Width * coefW);
            }

            Image result = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(result))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(image, 0, 0, newWidth, newHeight);
                g.Dispose();
            }
            return result;
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
            if (Пароль.Text != ПовторитьПароль.Text)
            {
                MessageBox.Show("Пароли не совпадают. Повторите попытку");
                return;
            }
            LoadInfo();
        }

        void LoadInfo()
        {
            SqlCommand cmd;
            if (newImage)
            {
                //get image:
                Image img = ResizeOrigImg(Image.FromFile(fileName));
                //get byte array from image:
                byte[] byteImg = ImageToByteArray(img);
                string query = "update [User] set [Password]='" + ПовторитьПароль.Text + "', [Name]= N'" + ФИО.Text +
                    "', [RoleId]='" + LoadCodeRole().ToString() + "', [Telephone]='" + Телефон.Text +
                    "', [DateOfBirth]='" + ДатаРождения.Text + "', [CountryCode]='" + LoadCodeCountry().ToString() +
                    "', [Photo]=@byteImg where [Email]='"+Почта.Text+"'";
                cmd = new SqlCommand(query, Program.con);
                cmd.Parameters.Add("@byteImg", SqlDbType.Binary, 8000).Value = byteImg;

                //ДатаРождения.Format = DateTimePickerFormat.Long;
            }
            else
            {
                string query = "update [User] set [Password]='" + ПовторитьПароль.Text + "', [Name]= N'" + ФИО.Text +
                    "', [RoleId]='"+ LoadCodeRole().ToString() + "', [Telephone]='"+ Телефон.Text +
                    "', [DateOfBirth]='" + ДатаРождения.Text + "', [CountryCode]='" + LoadCodeCountry().ToString() + 
                    "' where [Email]='" + Почта.Text + "'";
                cmd = new SqlCommand(query, Program.con);
            }

            Program.con.Open();
            cmd.ExecuteNonQuery();
            Program.con.Close();
            MessageBox.Show("Вы успешно редактировали свой профиль!");
            this.Close();
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

        byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Телефон_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (CheckLenghtTextbox((TextBox)sender, 9) && (Char.IsDigit(e.KeyChar)))
                e.Handled = false;
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else e.Handled = true;


        }
        bool CheckLenghtTextbox(TextBox tx, int lenght)
        {
            if (tx.Text.Length > lenght)
                return false;
            else return true;
        }
    }
}
