using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Authorization : Form
    {
        SqlConnection con = Program.con;
        public Authorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string roleId = CheckLoginAndPassword(loginTextBox.Text, passwordTextBox.Text);
            if (roleId==null)
                MessageBox.Show("Неправильный логин или пароль. Попробуйте заново.");
            else
            {
                string query = "SELECT * FROM [Role] where [RoleId]='" + roleId.ToString() + "' ;";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader myReader = cmd.ExecuteReader();
                myReader.Read();
                string roleName = myReader.GetString(1).ToString();
                con.Close();
                MessageBox.Show("Добро пожаловать " + Program.nameUser);
                OpenFormUser(roleName);
            }
        }

        public string CheckLoginAndPassword(string login, string password)
        {
            string query = "SELECT * FROM [User] where [Email]='" + loginTextBox.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            con.Open();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.HasRows == false)
            {
                con.Close();
                return "";
            }
            myReader.Read();
            string passwordTable = myReader.GetString(1);

            if (passwordTable == password)
            {
                Program.nameUser = myReader.GetString(2).ToString();
                Program.UserId = myReader.GetString(0).ToString() ;
                string roleid = myReader.GetString(3).ToString();
                con.Close();
                return roleid;
            }
            else return null;
        }

        void OpenFormUser(string rName)
        {
            Form form = new Form();
            if (rName == "Администратор")
                form = new Admin();
            if(rName == "Тренер")
                form = new Сoach();
            if(rName == "Спортсмен")
                form = new Sportsman();
            if (rName == "Болельщик")
                form = new Fan();
            if (rName == "Судья")
                form = new Referee();
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
