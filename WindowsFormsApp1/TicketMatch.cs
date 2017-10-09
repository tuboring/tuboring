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
    public partial class TicketMatch : Form
    {
        SqlConnection con = Program.con;

        public TicketMatch()
        {
            InitializeComponent();
        }

        private void TicketMatch_Load(object sender, EventArgs e)
        {            
            string query = "select top 1 * from TicketsSales order by IdTicketsSales desc";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);           
            con.Close();

            string query1 = "Select * From [User] WHERE Email= '" + dt.Rows[0][2] + "'";
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();

            string query2 = "Select * From [Event] WHERE EventId= '" + dt.Rows[0][1] + "'";
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();



            label2.Text = dt1.Rows[0][2].ToString();
            label4.Text = dt1.Rows[0][2].ToString();
            label6.Text = "RUS";
            label8.Text = dt2.Rows[0][5].ToString();            
            label10.Text = (Convert.ToDouble(dt.Rows[0][3]) * Convert.ToDouble(dt2.Rows[0][5])).ToString();
            //if ( dt1.Rows[0][7].ToString());
            //Bitmap image = new Bitmap((byte[])dt1.Rows[0][7]);
            //string fileName = System.IO.Path.GetFullPath(dt1.Rows[0][7].ToString());
            //pictureBox2.Image = image;
            //pictureBox2.Invalidate();
        }
    }
}
