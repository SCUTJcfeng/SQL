using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlProduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“productionDataSet.info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter.Fill(this.productionDataSet.info);

            int[] HourList = new int[23];
            for (int i = 0; i < HourList.Length; i++)
                HourList[i] = Convert.ToInt32(productionDataSet.Tables["info"].Rows[i][0]);

            int[] RunList = new int[23];
            for (int i = 0; i < RunList.Length; i++)
                RunList[i] = Convert.ToInt32(productionDataSet.Tables["info"].Rows[i][1]);

            int[] DownList = new int[23];
            for (int i = 0; i < DownList.Length; i++)
                DownList[i] = Convert.ToInt32(productionDataSet.Tables["info"].Rows[i][2]);

            int[] IdleList = new int[23];
            for (int i = 0; i < IdleList.Length; i++)
                IdleList[i] = Convert.ToInt32(productionDataSet.Tables["info"].Rows[i][3]);

            chtInfo.Series[0].Points.DataBindXY(HourList, RunList);

            chtInfo.Series[0].Name = "Run";

            chtInfo.Series.Add("Down");
            chtInfo.Series[1].Points.DataBindXY(HourList, DownList);

            chtInfo.Series.Add("Idle");
            chtInfo.Series[2].Points.DataBindXY(HourList, IdleList);

            chtInfo.ChartAreas[0].AxisX.Interval = 1;
            chtInfo.ChartAreas[0].AxisX.Minimum = 0;
            chtInfo.ChartAreas[0].AxisX.Maximum = 24;
            chtInfo.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            //Value
            chtInfo.Series[0].Label = "#VAL";
            chtInfo.Series[1].Label = "#VAL";
            chtInfo.Series[2].Label = "#VAL";

            chtInfo.ChartAreas[0].AxisX.Title = "Hour";
            chtInfo.ChartAreas[0].AxisY.Title = "Time";
            chtInfo.ChartAreas[0].AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;

            chtInfo.Series[0].Color = Color.Green;
            chtInfo.Series[1].Color = Color.Red;
            chtInfo.Series[2].Color = Color.Yellow;

            chtInfo.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }
    }
}
