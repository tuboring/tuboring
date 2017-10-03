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
 

    public partial class MyResults : Form
    {

        SqlConnection con = Program.con;

        public MyResults()
        {
            InitializeComponent();
        }

        private void MyResults_Load(object sender, EventArgs e)
        {

        }

        void loadResult()
        {

            string query = "SELECT Event.EventName, ResultEvent.Result From ResultEvent inner join Event on ResultEvent.EventId = Event.EventId And Event.StartDateTime >=  '" + dateTimePicker1.Value + "'And Event.StartDateTime <=  '" + dateTimePicker2.Value + "' where ResultEvent.Email = '" + Program.UserId + "'";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            label3.Text += "\r\n";
            label4.Text += "\r\n";

            for (int i =0; i< dt.Rows.Count; i++)
            {
                label3.Text += dt.Rows[i][0].ToString() + "\r\n";
                label4.Text += dt.Rows[i][1].ToString() + "\r\n";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadResult();
        }
    }
}
