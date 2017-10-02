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
    public partial class Sportsman : Form
    {
        public Sportsman()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationOnMatch regonM = new RegistrationOnMatch();
            regonM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyTeam form = new MyTeam();
            form.ShowDialog();
        }
    }
}
