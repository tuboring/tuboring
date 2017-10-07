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
    public partial class Users : Form
    {

        SqlConnection con = Program.con;

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseVolleyBallDataSet1.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter1.Fill(this.databaseVolleyBallDataSet1.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseVolleyBallDataSet1.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.databaseVolleyBallDataSet1.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseVolleyBallDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.databaseVolleyBallDataSet.User);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMatchs();
        }
        void loadMatchs()
        {
  
            string query = "";
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
                query = "SELECT [User].Name As Имя, Country.CountryName as Страна, Role.RoleName As Роль From [User] left join Country on [User].CountryCode = Country.CountryCode left join Role on [User].RoleId = Role.RoleId";
            else if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
                query = "SELECT [User].Name As Имя, Country.CountryName as Страна, Role.RoleName As Роль From [User] left join Country on [User].CountryCode = Country.CountryCode left join Role on [User].RoleId = Role.RoleId where [User].RoleId =  '" + comboBox1.SelectedValue + "' AND  [User].CountryCode =  '" + comboBox2.SelectedValue + "'";
            else if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex == -1)
                query = "SELECT [User].Name As Имя, Country.CountryName as Страна, Role.RoleName As Роль From [User] left join Country on [User].CountryCode = Country.CountryCode left join Role on [User].RoleId = Role.RoleId where [User].RoleId =  '" + comboBox1.SelectedValue + "'";
            else if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex != -1)
                query = "SELECT [User].Name As Имя, Country.CountryName as Страна, Role.RoleName As Роль From [User] left join Country on [User].CountryCode = Country.CountryCode left join Role on [User].RoleId = Role.RoleId where  [User].CountryCode =  '" + comboBox2.SelectedValue + "'";

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.roleTableAdapter.Fill(this.databaseVolleyBallDataSet1.Role);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
