using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using templet;
using System.Windows.Forms;

namespace project_sw_visual
{
    public partial class sellerForm : Form
    {
        public sellerForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit prod = new Exit();
            prod.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            categoryform cat = new categoryform();
            cat.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }
    }
}
