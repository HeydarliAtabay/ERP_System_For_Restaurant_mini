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
    public partial class ThirdControl : UserControl
    {
        public ThirdControl()
        {
            InitializeComponent();
        }

        private void ThirdControl_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Rows.Add("13","0025","5","29/05/2020","18:00");
            dataGridView1.Rows.Add("15", "0028", "4", "29/05/2020", "18:00");
            dataGridView1.Rows.Add("16", "0029", "3", "29/05/2020", "18:15");
            dataGridView1.Rows.Add("18", "0034", "4", "29/05/2020", "18:30");
            dataGridView1.Rows.Add("20", "0047", "15", "29/05/2020", "19:30");
            dataGridView1.Rows.Add("21", "0048", "2", "29/05/2020", "20:00");
            dataGridView1.Rows.Add("22", "0049", "2", "29/05/2020", "20:00");
            dataGridView1.Rows.Add("26", "0056", "8", "29/05/2020", "20:30");
            dataGridView1.Rows.Add("28", "0058", "2", "29/05/2020", "21:00");
            dataGridView1.Rows.Add("31", "0065", "2", "29/05/2020", "21:00");
            dataGridView1.Rows.Add("32", "0068", "8", "29/05/2020", "21:30");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
