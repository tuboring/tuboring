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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseVolleyBallDataSet2.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter1.Fill(this.databaseVolleyBallDataSet2.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseVolleyBallDataSet1.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter1.Fill(this.databaseVolleyBallDataSet1.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseVolleyBallDataSet1.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.databaseVolleyBallDataSet1.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseVolleyBallDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.databaseVolleyBallDataSet.User);
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMatchs();
        }
        void loadMatchs()
        {
  
            string query = "";
            if (comboBox1.Text == "" && comboBox2.Text == "")
                query = "SELECT [User].Email As Почта, [User].Name As Имя, Country.CountryName as Страна, Role.RoleName As Роль From [User] left join Country on [User].CountryCode = Country.CountryCode left join Role on [User].RoleId = Role.RoleId";
            else if (comboBox1.Text != "" && comboBox2.Text != "")
                query = "SELECT [User].Email As Почта, [User].Name As Имя, Country.CountryName as Страна, Role.RoleName As Роль From [User] left join Country on [User].CountryCode = Country.CountryCode left join Role on [User].RoleId = Role.RoleId where [Role].RoleName =  N'" + comboBox1.SelectedValue + "' AND  [Country].CountryName =  N'" + comboBox2.SelectedValue + "'";
            else if (comboBox1.Text != "" && comboBox2.Text  == "")
                query = "SELECT [User].Email As Почта, [User].Name As Имя, Country.CountryName as Страна, Role.RoleName As Роль From [User] left join Country on [User].CountryCode = Country.CountryCode left join Role on [User].RoleId = Role.RoleId where [Role].RoleName =  N'" + comboBox1.SelectedValue + "'";
            else if (comboBox1.Text == "" && comboBox2.Text != "")
                query = "SELECT [User].Email As Почта, [User].Name As Имя, Country.CountryName as Страна, Role.RoleName As Роль From [User] left join Country on [User].CountryCode = Country.CountryCode left join Role on [User].RoleId = Role.RoleId where  [Country].CountryName =  N'" + comboBox2.SelectedValue + "'";

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);            
            dataGridView1.DataSource = dt;
            con.Close();

        }

        public object CorrrectCheck(int v1, int v2)
        {
            throw new NotImplementedException();
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

        public DataGridViewRow dgtrue()
        {
            DataGridViewRow dt = new DataGridViewRow();

            return dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ControlUsers cu = new ControlUsers(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), this);
            cu.ShowDialog();
        }

        public void UpdateForm()
        {
            loadMatchs();
        }

        public bool CorrrectCheck(DataGridViewRow dt, int index, int index2)
        {
            return dt != null && index < (index2 - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //bool b;
            //if (dataGridView1.CurrentRow != null)
            //    b = true;
            //else
            //    b = false;
            if (CorrrectCheck(dataGridView1.CurrentRow, dataGridView1.CurrentRow.Index , dataGridView1.RowCount))
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить этого пользователя?", "Проверка", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE  FROM [User] WHERE [User].[Email] = N'" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadMatchs();
                }
            }
            else { MessageBox.Show("Выберите запись для удаления"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlUsers cu = new ControlUsers( this);
            cu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControlUsers cu = new ControlUsers(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), this);
            cu.ShowDialog();
        }
    }
}
