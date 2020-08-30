using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockLib;
using SQLServerStockBunkatu;

namespace FormStockToChartData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var chartForm = new FormChart();

            if(dateTimePickerTo.Value.Date > dateTimePickerFrom.Value.Date)
            {
                MessageBox.Show("日付の入力が不正です。");
                return;
            }
            int code = 0;
            if (int.TryParse(textBoxCode.Text, out code) == false)
            {
                MessageBox.Show("銘柄コードの入力が不正です。");
                return;
            }


            //価格データを呼び出す
            var priceCon = new YahooFinanceDbContext();
            var tradeIndexs = priceCon.TradeIndexs.Where(x => (code == x.code) &&  (dateTimePickerTo.Value.Date <= x.date && x.date <= dateTimePickerFrom.Value.Date));

            var bunkatuCon = new GetBunkatuContext().GetContext();

            //価格データの作成
            var PriceDatas = tradeIndexs.Select(x => new PriceData
            {
                Code = x.code,
                DateTime = x.date,
                ClosePrice = x.price.closePrice,
                OpenPrice = x.price.openPrice,
                HighPrice = x.price.highPrice,
                LowPrice = x.price.lowPrice,
                Volume = x.price.volume,
                Cap = x.marketCapitalization,
                OutShare = x.outstandingShares,
            });
            //入力したコードのチャートを表示
            var stockPrices = new StockPrice(code, PriceDatas);
            //分割データを入れる
            var splitMargeList = new List<SplitMargeData>();
            foreach (var split in bunkatuCon.Bunkatus.Where(x => x.Code == code))
            {
                splitMargeList.Add(SplitMarge.CreateSplitMargeData(code, split.KenriDate, split.BunkatuMae, split.BunkatuAto));
            }
            foreach (var marge in bunkatuCon.Heigous.Where(x => x.Code == code))
            {
                splitMargeList.Add(SplitMarge.CreateSplitMargeData(code, marge.KenriDate, marge.HeigouMae, marge.HeigouAto));
            }
            if (splitMargeList.Count() != 0)
            {
                stockPrices = stockPrices.CreateSplitMarge(splitMargeList);
            }
            //チャートにデータを渡す
            var xData = stockPrices.GetDatetimes().ToList(); ;
            //5MA乖離
            if (checkBoxMA.Checked)
            {
                chartForm.SetLineChart("5MA乖離", xData, StockPrice.ToPercent(stockPrices.CalcMovingAverageKairi(5)).ToList());
            }
            //TR
            if(checkBoxTR.Checked)
            {
                chartForm.SetLineChart("TR", xData, StockPrice.ToPercent(stockPrices.CalcTR()).ToList());
            }
            //取引比率
            if (checkBoxTorihiki.Checked)
            {
                var test = stockPrices.CalcTorihiki().ToList();
                chartForm.SetLineChart("取引比率", xData, StockPrice.ToPercent(stockPrices.CalcTorihiki()).ToList());
            }
            //ボラ
            if (checkBoxVora.Checked)
            {
                chartForm.SetLineChart("ボラ", xData, StockPrice.ToPercent(stockPrices.CalcBora()).ToList());
            }
            chartForm.Show();
        }
    }
}
