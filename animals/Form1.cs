using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.AutoSize = false;
            label1.Width = 200;
        }
       


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Cat";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "Capybara";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "Dog";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "Formosan Black Bear";
        }
    }
}
