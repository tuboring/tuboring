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
    public partial class Form2 : Form
    {
        SqlConnection con = Program.con;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           dateTimePicker1.Format = DateTimePickerFormat.Custom;//установка формата datapicker
            loadCity();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadInfo();
        }

        void loadCity()
        {
            string query = "select * from [Marathon]";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet myDS = new DataSet();
            da.Fill(myDS, "Marathon");
            cityComboBox.DataSource = null;
            cityComboBox.Items.Clear();
            for (int i = 0; i < myDS.Tables["Marathon"].Rows.Count; i++)
            {
                cityComboBox.Items.Add(myDS.Tables["Marathon"].Rows[i][2].ToString());
            }
            con.Close();
        }

        void loadInfo()
        {
            string query = "";

            if (cityComboBox.Text == "")
            {
                query = "SELECT [EventName], [MarathonName], [StartDateTime], [Cost] FROM [Event] join [EventType] on [Event].[EventTypeId] = [EventType].[EventTypeId] join [Marathon] on [Event].[MarathonId] = [Marathon].[MarathonId] where convert(date,[StartDateTime]) = convert(date, '" + dateTimePicker1.Text + "')";
            }
            else if(checkBox1.Checked==false)
            {
                query = "SELECT [EventName], [MarathonName], [StartDateTime], [Cost] FROM [Event] join [EventType] on [Event].[EventTypeId] = [EventType].[EventTypeId] join [Marathon] on [Event].[MarathonId] = [Marathon].[MarathonId] where [CityName]='" + cityComboBox.Text + "'";
            }
            else if(cityComboBox.Text != ""&& checkBox1.Checked == true)
            {
                query = "SELECT [EventName], [MarathonName], [StartDateTime], [Cost] FROM [Event] join [EventType] on [Event].[EventTypeId] = [EventType].[EventTypeId] join [Marathon] on [Event].[MarathonId] = [Marathon].[MarathonId] where [CityName]='" + cityComboBox.Text + "' AND convert(date,[StartDateTime]) = convert(date, '" + dateTimePicker1.Text + "')";
            }
            else
            {
                MessageBox.Show("Выберите параметр для проверки");
            }
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();

            DataSet ds = new DataSet();
            da.Fill(ds, "Матчи");
            TabledataGridView.DataSource = ds.Tables[0];
            TabledataGridView.AutoResizeColumns();
            con.Close();

            TabledataGridView.Columns[0].HeaderText = "Тип матча";
            TabledataGridView.Columns[1].HeaderText = "Название игры";
            TabledataGridView.Columns[2].HeaderText = "Полная дата";
            TabledataGridView.Columns[3].HeaderText = "Цена билета";
            TabledataGridView.AutoResizeColumns();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                dateTimePicker1.Enabled = true;
            else
                dateTimePicker1.Enabled = false;  
        }
    }
}
