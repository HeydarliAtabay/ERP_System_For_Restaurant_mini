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
    public partial class Waitor_tables : Form
    {
        public Waitor_tables()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel8.BackColor = Color.FromArgb(178, 8, 55);
            panel5.BackColor = Color.FromArgb(178, 8, 55);
            panel11.BackColor = Color.FromArgb(178, 8, 55);
            panel10.BackColor = Color.FromArgb(178, 8, 55);
            panel13.BackColor = Color.FromArgb(178, 8, 55);
            panel18.BackColor = Color.FromArgb(178, 8, 55);
            panel17.BackColor = Color.FromArgb(178, 8, 55);
            panel7.BackColor = Color.FromArgb(178, 8, 55);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 openform = new Form2();
            openform.Show();
            this.Hide();
        }
    }
}
