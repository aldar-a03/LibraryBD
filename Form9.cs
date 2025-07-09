using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7();
            form7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form11 = new Form11();
            form11.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form8 = new Form8();
            form8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form18 = new Form18();
            form18.Show();
        }
    }
}
