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
    public partial class BuyTickets : Form
    {
        SqlConnection con = Program.con;

        public BuyTickets()
        {
            InitializeComponent();

        }

        void loadMatchs()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            string query = "SELECT Event.EventName, Event.EventId From Event where convert(date,[StartDateTime]) = convert(date,'" + dateTimePicker1.Text + "')";
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "EventName";
            comboBox2.ValueMember = "EventId";

            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1 && numericUpDown1.Value != 0)
            {

                string query = "SELECT Event.MaxParticipants, ISNULL(SUM(TicketsSales.Amount),1) From Event Left join TicketsSales on Event.EventId = TicketsSales.EventId where Event.EventId =  '" + comboBox2.SelectedValue + "'" +
                    "group by Event.MaxParticipants";

                SqlCommand cmd = new SqlCommand(query, Program.con);
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                 query = "SELECT (MAX(IdTicketsSales)+1) From TicketsSales";
                 da = new SqlDataAdapter(query, con);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
         
                if (numericUpDown1.Value > 0)
                    if (Convert.ToInt32(dt.Rows[0][1]) + numericUpDown1.Value <= Convert.ToInt32(dt.Rows[0][0]))
                    {
                        cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "Insert INTO TicketsSales (IdTicketsSales, EventId,UserId,Amount)  " +
                        " values('" + Convert.ToInt32(dt1.Rows[0][0]) + "','" + comboBox2.SelectedValue + "','" + Program.UserId + "','" + numericUpDown1.Value + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Билеты куплены");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Осталось " + (Convert.ToInt32(dt.Rows[0][0]) - Convert.ToInt32(dt.Rows[0][1])) + " билетов на матч");
                TicketMatch asasa = new TicketMatch();
                asasa.Show();
                this.Close();
                else
                    MessageBox.Show("Введите корректное число билетов");
               

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMatchs();
        }

        private void BuyTickets_Load(object sender, EventArgs e)
        {

        }
    }
}
