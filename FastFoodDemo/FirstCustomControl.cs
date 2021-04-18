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
    public partial class FirstCustomControl : UserControl
    {
        public FirstCustomControl()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FirstCustomControl_Load(object sender, EventArgs e)
        {
            chart1.Series["Прибыль"].Points.AddXY("January", "13425");
            chart1.Series["Прибыль"].Points.AddXY("February", "11287");
            chart1.Series["Прибыль"].Points.AddXY("March", "16895");
            chart1.Series["Прибыль"].Points.AddXY("April", "14568");
            chart1.Series["Прибыль"].Points.AddXY("May", "100");
            
            //chart title  
            chart1.Titles.Add("График прибыли");
        }
    }
}
