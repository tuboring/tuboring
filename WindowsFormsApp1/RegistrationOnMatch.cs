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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
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
            string query = "Select [Event].[EventName], [RegOnMatch].[CityName], [RegistrationStatus].[RegistrationStatus] FROM [RegOnMatch] JOIN [Event] ON [Event].[EventId]=[RegOnMatch].[EventId] JOIN [RegistrationStatus] ON [RegistrationStatus].[RegistrationStatusId]=[RegOnMatch].[RegistrationStatucId]";
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
            string cEvent = "";
            string query = "select [EventId], [CityName] from [Event] where convert(date,[StartDateTime]) = convert(date, '"+ dateTimePicker1.Text+ "') AND [CityName]='"+ Город.Text+"'";
            SqlCommand cmd = new SqlCommand(query, Program.con);

            Program.con.Open();
            SqlDataReader myReader = cmd.ExecuteReader();
            bool run = true;
            while (run && myReader.Read())
            {
                cEvent = myReader.GetString(0);
                run = false;
            }
            Program.con.Close();

            query = "insert into [RegOnMatch] ([EmailSportsmen], [EventId], [CityName], [RegistrationStatucId]) " +
                "values  ('" + Program.UserId + "', '" + cEvent+ "'"+ Город.Text+", 4')";

            Program.con.Open();
            cmd.ExecuteNonQuery();
            Program.con.Close();
            MessageBox.Show("Вы успешно зарегистрировались!");
            this.Close();
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
