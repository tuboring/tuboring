using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MatchCheck matchi = new MatchCheck();
            matchi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
