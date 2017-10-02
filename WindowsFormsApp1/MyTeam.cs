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
    public partial class MyTeam : Form
    {

        SqlConnection con = Program.con;

    
        public MyTeam()
        {
            InitializeComponent();
        }

        private void MyTeam_Load(object sender, EventArgs e)
        {
            loadTeam();
        }

        void loadTeam()
        {
       
            string query = "SELECT Runner.CountryCode From Runner where Runner.Email = '" + Program.UserId + "'";
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            query = "SELECT Runner.Email, [User].Name AS Имя From Runner Left join [User] on Runner.Email = [User].Email  where Runner.CountryCode = '" + dt.Rows[0][0].ToString() + "'";
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            con.Close();

        }

    }
}
