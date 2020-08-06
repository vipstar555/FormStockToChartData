using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormStockToChartData
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
            // clear
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            ChartArea area1 = new ChartArea();            // ChartArea作成
            area1.AxisX.IntervalType = DateTimeIntervalType.Seconds;
            area1.AxisX.Title = "日時";  // X軸タイトル設定
            area1.AxisY.Title = "データ";
            chart1.ChartAreas.Add(area1);
        }
        //折れ線グラフ追加
        public void SetLineChart(string title, IEnumerable<DateTime> xData, IEnumerable<double?> yData)
        {
            Series seriesLine = new Series();
            seriesLine.ChartType = SeriesChartType.Line;
            seriesLine.LegendText = title;

            if((xData.Count() == yData.Count()) == false)
            {
                MessageBox.Show("X軸とY軸のデータ数が違います");
                return;
            }

            var xArray = xData.ToArray();
            var _yData = yData.ToArray();
            double[] yArray = new double[xArray.Count()];
            for(int i = 0; i< yArray.Count(); i++)
            {
                if (_yData[i] == null)
                {
                    yArray[i] = 0;
                }
                else
                {
                    yArray[i] = (double)_yData[i];
                }
            }            
            for (int i = 0; i < xData.Count(); i++)
            {
                seriesLine.Points.Add(new DataPoint(xArray[i].ToOADate(), yArray[i]));
            }

            chart1.Series.Add(seriesLine);
        }
        //テスト用
        public void SetChart(string title)
        {
            Random rdm = new Random();

            Series seriesLine = new Series();
            seriesLine.ChartType = SeriesChartType.Line;
            seriesLine.LegendText = "Legend:Line";

            for (int i = 0; i < 10; i++)
            {
                seriesLine.Points.Add(new DataPoint(i, rdm.Next(0, 210)));
            }

            

            //chart1.Titles.Add(title);
            chart1.Series.Add(seriesLine);
        }        
    }
}
