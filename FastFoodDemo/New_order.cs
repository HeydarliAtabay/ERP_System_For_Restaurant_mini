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
    public partial class New_order : Form
    {
        public New_order()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("------Order no 17------");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("1. Pizza Napoletana x 2");
            listBox1.Items.Add("2. Cheeseburger x 2");
            listBox1.Items.Add("3. Coca-cola x 4");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("29/05/2020  21:27");

        }
    }
}
