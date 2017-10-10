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
    public partial class Fan : Form
    {
        public Fan()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new BuyTickets();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MatchCheck form = new MatchCheck();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tickets form = new Tickets();
            form.ShowDialog();
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            Program.UserId = "";
            Program.nameUser = "";
            Authorization autorisation = new Authorization();
            autorisation.Show();
            this.Close();
        }
    }
}
