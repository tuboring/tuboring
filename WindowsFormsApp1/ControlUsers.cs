﻿using System;
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
    public partial class ControlUsers : Form
    {
        public ControlUsers()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TicketMatch tm= new TicketMatch();
            tm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
