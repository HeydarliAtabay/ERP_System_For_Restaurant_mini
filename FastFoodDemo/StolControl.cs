using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class StolControl : UserControl
    {
        public StolControl()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void StolControl_Load(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel5.BackColor = Color.FromArgb(178, 8, 55);
            panel5.BackColor = Color.FromArgb(178, 8, 55);
            panel11.BackColor = Color.FromArgb(178, 8, 55);
            panel14.BackColor = Color.FromArgb(178, 8, 55);
            panel16.BackColor = Color.FromArgb(178, 8, 55);
        }
    }
}
