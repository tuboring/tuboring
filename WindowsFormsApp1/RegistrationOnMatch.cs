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
    public partial class RegistrationOnMatch : Form
    {
        public RegistrationOnMatch()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
                this.Close();
            else
            {
                dataGridView1.Visible = false;
                ClearTextBox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
            {
                dataGridView1.Visible = false;
            }
            else
            {
                AddNew();

                LoadTable();

                ClearTextBox();
            }
        }

        void ClearTextBox()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                    foreach (Control d in c.Controls)
                        if (d.GetType() == typeof(TextBox))
                            d.Text = string.Empty;

                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;
            }
        }

        void LoadTable()
        {
            string query = "select [MarathonName] from [Marathon]";
            Program.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.con);
            DataSet myDS = new DataSet();
            da.Fill(myDS, "Match");
            Матч.DataSource = null;
            Матч.Items.Clear();
            for (int i = 0; i < myDS.Tables["Match"].Rows.Count; i++)
            {
                Матч.Items.Add(myDS.Tables["Match"].Rows[i][0].ToString());
            }
            Program.con.Close();
        }

        void AddNew()
        {

        }

        private void Матч_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Матч.SelectedIndex != -1)
            {
                string query = "SELECT [CityName] FROM [Event]  where [EventName] = '" + Матч.Text + "'";
                Program.con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, Program.con);
                DataSet myDS = new DataSet();
                da.Fill(myDS, "Match");
                Город.DataSource = null;
                Город.Items.Clear();
                for (int i = 0; i < myDS.Tables["Match"].Rows.Count; i++)
                {
                    Город.Items.Add(myDS.Tables["Match"].Rows[i][0].ToString());
                }
                Program.con.Close();
            }
            else
            {
                Город.Items.Clear();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            string query = "SELECT [EventName] FROM [Event]  where convert(date,[StartDateTime]) = convert(date,'" + dateTimePicker1.Text + "') GROUP BY [EventName]";
            Program.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.con);
            DataSet myDS = new DataSet();
            da.Fill(myDS, "Match");
            Матч.DataSource = null;
            Матч.Items.Clear();
            for (int i = 0; i < myDS.Tables["Match"].Rows.Count; i++)
            {
                Матч.Items.Add(myDS.Tables["Match"].Rows[i][0].ToString());
            }
            Program.con.Close();
            dateTimePicker1.Format = DateTimePickerFormat.Long;
        }
    }
}
