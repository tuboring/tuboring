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
    public partial class Tickets : Form
    {
        SqlConnection con = Program.con;

        public Tickets()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseVolleyBallDataSet1.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter.Fill(this.databaseVolleyBallDataSet1.Event);
            comboBox2.SelectedIndex = -1;
        }

        DateTime DateStart;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                string query = "SELECT [Event].[CityName], [Event].[StartDateTime]  From [Event] where [Event].[EventId] = '" + comboBox2.SelectedValue + "'";
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                textBox1.Text = dt.Rows[0][0].ToString();
                DateStart = Convert.ToDateTime(dt.Rows[0][1]);
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1 )
            {
                int Sale = 0;
            if (comboBox5.SelectedIndex == 1)
                Sale += 5;
            if (numericUpDown1.Value > 2)
                Sale += 20;

            TimeSpan diff = DateStart - dateTimePicker1.Value;
            if (diff.Days >= 35)
                Sale += 10;

            label4.Text = Sale.ToString() + "%";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
