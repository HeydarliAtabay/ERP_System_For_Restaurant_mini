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
    public partial class FourthControl : UserControl
    {
        public FourthControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("12", "Leyla", "10", "Samir", "0012,005,017x2", "36,5", "In process");
            dataGridView1.Rows.Add("14", "Anar", "2", "Vaqif", "0020x4,005x4,014x2,001x2", "78,5", "In process");
            dataGridView1.Rows.Add("15", "Sabina", "5", "Vaqif", "0012,005,017x2", "36,5", "In process");
            dataGridView1.Rows.Add("19", "Shahin", "3", "Vaqif", "001x2,003x5,017x2", "42", "In process");
            dataGridView1.Rows.Add("20", "Lala", "12", "Samir", "00123x3,005x8,020x2, 032x3", "126,5", "In process");
            dataGridView1.Rows.Add("22", "Seadet", "6", "Tofiq", "003x3,075x8,020x2, 032x3", "92,2", "In process");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FourthControl_Load(object sender, EventArgs e)
        {

        }
    }
}
