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
    public partial class ControlUsers : Form
    {
        string email;
        Users users;
        string fileName;

        public ControlUsers()
        {
            InitializeComponent();
        }

        public ControlUsers(string EmailUser, Users Users)
        {
            InitializeComponent();
            this.email = EmailUser;
            this.users = Users;
            Ок.Text = "+ Редактировать";
            loadRoleAndCountry();
            LoadInfoUser();
        }
        public ControlUsers(Users Users)
        {
            InitializeComponent();
            this.users = Users;
            loadRoleAndCountry();

        }

        void loadRoleAndCountry()
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

            query = "select [RoleName] from [Role]";
            Program.con.Open();
            da = new SqlDataAdapter(query, Program.con);
            myDS = new DataSet();
            da.Fill(myDS, "Role");
            РольПользователя.DataSource = null;
            РольПользователя.Items.Clear();
            for (int i = 0; i < myDS.Tables["Role"].Rows.Count; i++)
            {
                РольПользователя.Items.Add(myDS.Tables["Role"].Rows[i][0].ToString());
            }
            Program.con.Close();
        }

        void LoadInfoUser()
        {
            string query = "SELECT [User].[Email], [User].[Password], [User].[Name], [Role].[RoleName], [User].[Photo] FROM [User] join [Role] on [User].[RoleId]=[Role].[RoleId] WHERE [Email] ='" + email + "'";
            Program.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.con);
            DataSet myDS = new DataSet();
            da.Fill(myDS, "User");

            Почта.Text = myDS.Tables["User"].Rows[0][0].ToString();
            Пароль.Text = myDS.Tables["User"].Rows[0][1].ToString();
            ФИО.Text = myDS.Tables["User"].Rows[0][2].ToString();
            РольПользователя.Text = myDS.Tables["User"].Rows[0][3].ToString();

            if (myDS.Tables["User"].Rows[0][4].ToString() != "")
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(myDS.Tables["User"].Rows[0][4]);
                MemoryStream mem = new MemoryStream(data);
                Фотография.Image = Image.FromStream(mem);
            }

            query = "SELECT [User].[Email], [Country].[CountryName] FROM [User] join [Country] on [User].[CountryCode]=[Country].[CountryCode] WHERE [Email] = '" + email + "'";
            da = new SqlDataAdapter(query, Program.con);
            myDS = new DataSet();
            da.Fill(myDS, "User");
            if (myDS.Tables["User"].Rows.Count != 0)
                Страна.Text = myDS.Tables["User"].Rows[0][1].ToString();
            Program.con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TicketMatch tm= new TicketMatch();
            tm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ФИО.Text == "" || РольПользователя.Text == "" || Почта.Text == "" || Пароль.Text == ""  || Страна.Text == "")
            {
                MessageBox.Show("Не все поля заполнены. Повторите попытку.");
                return;
            }
            if (Regex.IsMatch(Почта.Text, @"\A[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\z") == false)
            {
                MessageBox.Show("Не правильно введен адрес почты. Повторите попытку.");
                return;
            }

            if (email == null)
            {
                AddUser();
                users.UpdateForm();
                MessageBox.Show("Пользователь успешно добавлен");
                this.Close();
            }
            else
            {
                EditProfile();
                users.UpdateForm();
                MessageBox.Show("Информация пользователя успешно изменена");
                this.Close();
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

        void AddUser()
        {
            SqlCommand cmd;
            if (fileName != null)
            {
                //get image:
                Image img = Image.FromFile(fileName);
                //get byte array from image:
                byte[] byteImg = ImageToByteArray(ResizeOrigImg(img));
                string query = "insert into [User] ([Email], [Password], [Name], [RoleId], " +
                    "[CountryCode], [Photo]) values  ('" + Почта.Text + "', '" + Пароль.Text + "', N'" +
                    ФИО.Text + "', '" + LoadCodeRole().ToString() + "', '" + LoadCodeCountry().ToString() + "', @byteImg)";
                cmd = new SqlCommand(query, Program.con);
                cmd.Parameters.Add("@byteImg", SqlDbType.Binary, 8000).Value = byteImg;
            }
            else
            {
                string query = "insert into [User] ([Email], [Password], [Name], [RoleId], " +
                    "[CountryCode]) values  ('" + Почта.Text + "', '" + Пароль.Text + "', N'" +
                    ФИО.Text + "', '" + LoadCodeRole().ToString() + "', '" + LoadCodeCountry().ToString() + "')";
                cmd = new SqlCommand(query, Program.con);
            }

            Program.con.Open();
            cmd.ExecuteNonQuery();
            Program.con.Close();
        }
        
        void EditProfile()
        {
            SqlCommand cmd;
            if (fileName!=null)
            {
                //get image:
                Image img = Image.FromFile(fileName);
                //get byte array from image:
                byte[] byteImg = ImageToByteArray(ResizeOrigImg(img));
                string query = "update [User] set [Password]='" + Пароль.Text + "', [Email]= N'" + Почта.Text + "', [Name]= N'" + ФИО.Text +
                    "', [RoleId]='" + LoadCodeRole().ToString() + "', [CountryCode]='" + LoadCodeCountry().ToString() +
                    "', [Photo]=@byteImg where [Email]='" + email + "'";
                cmd = new SqlCommand(query, Program.con);
                cmd.Parameters.Add("@byteImg", SqlDbType.Binary, 8000).Value = byteImg;

            }
            else
            {
                string query = "update [User] set [Password]='" + Пароль.Text + "', [Email]= N'" + Почта.Text + "', [Name]= N'" + ФИО.Text +
                    "', [RoleId]='" + LoadCodeRole().ToString() + "', [CountryCode]='" + LoadCodeCountry().ToString() +
                    "' where [Email]='" + email + "'";
                cmd = new SqlCommand(query, Program.con);
            }

            Program.con.Open();
            cmd.ExecuteNonQuery();
            Program.con.Close();
        }

        byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        string LoadCodeRole()
        {
            string CRole = "";
            string query = "select * from Role where RoleName= N'" + РольПользователя.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
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
                    ФотоПуть.Text = fileName;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этого пользователя?", "Проверка", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE  FROM [User] WHERE [User].[Email] = N'" + email + "'";
                SqlCommand cmd = new SqlCommand(query, Program.con);
                Program.con.Open();
                cmd.ExecuteNonQuery();
                Program.con.Close();
                users.UpdateForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users.UpdateForm();
            this.Close();
        }

        private void ControlUsers_Load(object sender, EventArgs e)
        {
        }
    }
}
