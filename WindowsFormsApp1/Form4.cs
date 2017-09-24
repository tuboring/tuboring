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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Server=; Database=;Integrated security=True");

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckLoginAndPassword(loginTextBox.Text, passwordTextBox.Text))
                MessageBox.Show("Неправильный логин или пароль. Попробуйте заново.");
        }

        bool CheckLoginAndPassword(string login, string password)
        {
            string query = "SELECT * FROM User where Email='" + loginTextBox.Text + "' ;";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.HasRows == false)
                return false;
            string passwordTable = myReader.GetValue(1).ToString();
            con.Close();

            if (passwordTable == password)
                return true;
            else return false;
        }
    }
}
