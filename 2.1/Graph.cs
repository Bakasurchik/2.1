using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2_1
{
    public partial class Graph : Form
    {
        public Graph(string surname)
        {
            InitializeComponent();
            double starting = 0, ending = 10, h = 0.1, x = starting, y;
            this.chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.IntervalOffset = 0;
            chart1.ChartAreas[0].AxisY.IntervalOffset = 0;

            while (x <= ending)
            {
                y = Program.TheFunc(surname, x);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }

  
    }
}
