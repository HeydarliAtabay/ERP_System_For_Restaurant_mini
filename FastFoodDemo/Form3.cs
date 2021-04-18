using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = SystemColors.ControlLight;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = SystemColors.ControlLight;
        }
    }
}
