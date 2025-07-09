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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form13 = new Form13();
            form13.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form14 = new Form14();
            form14.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7();
            form7.Show();
        }
    }
}
