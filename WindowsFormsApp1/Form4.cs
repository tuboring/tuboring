﻿using System;
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
        SqlConnection con = Program.con;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string roleId = CheckLoginAndPassword(loginTextBox.Text, passwordTextBox.Text);
            if (roleId=="")
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

        string CheckLoginAndPassword(string login, string password)
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
                Program.nameUser = myReader.GetString(2).ToString() + " " + myReader.GetValue(3).ToString();
                string roleid= myReader.GetString(4).ToString();
                con.Close();
                return roleid;
            }
            else return "";
        }

        void OpenFormUser(string rName)
        {
            Form form = new Form();
            if (rName == "Administrator")
                form = new Form9();
            if(rName == "Coordinator")
                form = new Form7();
            if(rName == "Runner")
                form = new Form5();

            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
