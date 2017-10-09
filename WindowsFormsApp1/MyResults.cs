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
            con.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = " insert into ResultEvent(Email, EventId, Result) values('a.ashton@saucedout.com', '11_1FM', 'Красавчик ЖИЕСТЬ')";
            //cmd.ExecuteNonQuery();
            //cmd.CommandText = " insert into ResultEvent(Email, EventId, Result) values('a.ashton@saucedout.com', '11_1HM', 'Красавчик ЖИЕСТЬ2')";
            //cmd.ExecuteNonQuery();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy - MM - dd";

            string query = "SELECT [Event].EventName, ResultEvent.Result From ResultEvent inner join [Event] on ResultEvent.EventId = [Event].EventId And [Event].StartDateTime >=  convert(date,'" + dateTimePicker1.Text + "') And [Event].StartDateTime <=  convert(date,'" + dateTimePicker2.Text + "') where ResultEvent.Email = '" + Program.UserId + "'";
           
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
            if (dt.Rows.Count == 0)
                MessageBox.Show("Данных нет, сорян");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadResult();
        }
    }
}
