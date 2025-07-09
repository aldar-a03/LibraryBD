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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form15 = new Form15();
            form15.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form17 = new Form17();
            form17.Show();
        }

        
        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form8 = new Form8();
            form8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7();
            form7.Show();
        }
    }
}
