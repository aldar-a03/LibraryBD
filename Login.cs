﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form9 = new Form9();
            form9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form12 = new Form12();
            form12.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form16 = new Form16();
            form16.Show();
        }
    }
}
