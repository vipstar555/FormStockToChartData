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
        ToolTip tooltip = new ToolTip(); // ツールチップ（グラフデータ表示用）

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

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 60;
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

        private void Chart1_MouseMove(object sender, MouseEventArgs e)
        {
            chart1.ChartAreas[0].CursorX.Interval = 0.001;
            chart1.ChartAreas[0].CursorY.Interval = 0.001;
            try
            {
                double x = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                double y = Math.Sin((double)x / 0.5 / 20);
                var pos = e.Location;

                chart1.ChartAreas[0].CursorX.Position = x;

                if (radioButtonTR.Checked)
                {
                    var seriesString = "Series2";
                    var firstX = chart1.Series[seriesString].Points.FirstOrDefault().XValue;
                    var index = chart1.Series[seriesString].Points.FirstOrDefault(X => 0 < X.XValue - x).XValue;

                    chart1.ChartAreas[0].CursorY.Position = chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).YValues.FirstOrDefault();
                    var Date = new DateTime(1899, 12, 30).AddDays(chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).XValue);
                    var YData = chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).YValues[0];
                    tooltip.Show($"日付：{Date}\r\nデータ：{YData}", chart1, pos.X, pos.Y -15);
                }
                if (radioButtonBora.Checked)
                {
                    var seriesString = "Series4";
                    var firstX = chart1.Series[seriesString].Points.FirstOrDefault().XValue;
                    var index = chart1.Series[seriesString].Points.FirstOrDefault(X => 0 < X.XValue - x).XValue;

                    chart1.ChartAreas[0].CursorY.Position = chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).YValues.FirstOrDefault();
                    var Date = new DateTime(1899, 12, 30).AddDays(chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).XValue);
                    var YData = chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).YValues[0];
                    tooltip.Show($"日付：{Date}\r\nデータ：{YData}", chart1, pos.X, pos.Y - 15);
                }
                if (radioButtonTorihiki.Checked)
                {
                    var seriesString = "Series3";
                    var firstX = chart1.Series[seriesString].Points.FirstOrDefault().XValue;
                    var index = chart1.Series[seriesString].Points.FirstOrDefault(X => 0 < X.XValue - x).XValue;

                    chart1.ChartAreas[0].CursorY.Position = chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).YValues.FirstOrDefault();
                    var Date = new DateTime(1899, 12, 30).AddDays(chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).XValue);
                    var YData = chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).YValues[0];
                    tooltip.Show($"日付：{Date}\r\nデータ：{YData}", chart1, pos.X, pos.Y - 15);
                }
                if (radioButtonMAkairi.Checked)
                {
                    var seriesString = "Series1";

                    var firstX = chart1.Series[seriesString].Points.FirstOrDefault().XValue;
                    var index = chart1.Series[seriesString].Points.FirstOrDefault(X => 0 < X.XValue - x).XValue;

                    chart1.ChartAreas[0].CursorY.Position = chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).YValues.FirstOrDefault();
                    var Date = new DateTime(1899, 12, 30).AddDays(chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).XValue);
                    var YData = chart1.Series[seriesString].Points.FirstOrDefault(X => X.XValue == index).YValues[0];
                    tooltip.Show($"日付：{Date}\r\nデータ：{YData}", chart1, pos.X, pos.Y - 15);
                }
            }
            catch
            {
                //pass
            }
        }

        private void CheckBoxTR_CheckedChanged(object sender, EventArgs e)
        {
            var seriesString = "Series2";
            if (checkBoxTR.Checked)
            {
                chart1.Series[seriesString].Color = Color.Red;
            }
            else
            {
                chart1.Series[seriesString].Color = Color.Transparent;
            }
            
        }

        private void CheckBoxBora_CheckedChanged(object sender, EventArgs e)
        {
            var seriesString = "Series4";
            if (checkBoxBora.Checked)
            {
                chart1.Series[seriesString].Color = Color.Blue;
            }
            else
            {
                chart1.Series[seriesString].Color = Color.Transparent;
            }
        }

        private void CheckBoxMA_CheckedChanged(object sender, EventArgs e)
        {
            var seriesString = "Series1";
            if (checkBoxMA.Checked)
            {
                chart1.Series[seriesString].Color = Color.Green;
            }
            else
            {
                chart1.Series[seriesString].Color = Color.Transparent;
            }
        }

        private void CheckBoxTorihiki_CheckedChanged(object sender, EventArgs e)
        {
            var seriesString = "Series3";
            if (checkBoxTorihiki.Checked)
            {
                chart1.Series[seriesString].Color = Color.Purple;
            }
            else
            {
                chart1.Series[seriesString].Color = Color.Transparent;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
