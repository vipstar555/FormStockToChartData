using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StockLib
{
    //株クラス
    public class StockPrice
    {
        public int Code { get; set; }
        public List<PriceData> PriceDatas { get; set; } = new List<PriceData>();
        
        //初期化
        public StockPrice(int code, IEnumerable<PriceData> priceDatas)
        {
            Code = code;
            PriceDatas = priceDatas.OrderBy(x => x.DateTime).ToList();
        }
        //プライスの追加
        public void AddPriceData(PriceData pricedata)
        {
            PriceDatas.Add(pricedata);
        }
        //分割・併合データを適用して新しく株価クラスを返す
        public StockPrice CreateSplitMarge(IEnumerable<SplitMargeData> splitMarges)
        {
            //リストの値を渡す
            var _priceDatas = new List<PriceData>(PriceDatas);

            foreach (var splitMarge in splitMarges)
            {
                for(int i = 0; i < _priceDatas.Count(); i++)
                {
                    if (_priceDatas[i].DateTime.Date <= splitMarge.KenriDateTime.Date )
                    {
                        _priceDatas[i].HighPrice = _priceDatas[i].HighPrice * splitMarge.Magnification;
                        _priceDatas[i].LowPrice = _priceDatas[i].LowPrice * splitMarge.Magnification;
                        _priceDatas[i].OpenPrice = _priceDatas[i].OpenPrice * splitMarge.Magnification;
                        _priceDatas[i].ClosePrice = _priceDatas[i].ClosePrice * splitMarge.Magnification;
                        _priceDatas[i].Volume = (long)(_priceDatas[i].Volume * splitMarge.Magnification);
                        _priceDatas[i].OutShare = (long)(_priceDatas[i].OutShare * splitMarge.Magnification);
                    }
                }               
            }
            return new StockPrice(Code, _priceDatas);
        }
        //日付を返す
        public IEnumerable<DateTime> GetDatetimes()
        {
            foreach (var dateTime in PriceDatas.OrderBy(x => x.DateTime).Select(x => x.DateTime))
            {
                yield return dateTime;
            }
        }
        //TR計算
        public IEnumerable<double?> CalcTR()
        {
            double? lastClosePrice = null;

            foreach(var priceData in PriceDatas.OrderBy(x => x.DateTime))
            {
                if(lastClosePrice == null)
                {
                    yield return null;
                    lastClosePrice = priceData.ClosePrice;
                    continue;
                }
                yield return new List<double?> {
                    priceData.HighPrice - priceData.LowPrice,
                    priceData.HighPrice - lastClosePrice,
                    lastClosePrice - priceData.LowPrice
                }.Max();
                lastClosePrice = priceData.ClosePrice;
            }
        }
        //%表記へ変更
        static public IEnumerable<double?> ToPercent(IEnumerable<double?> datas)
        {
            var max = datas.Max();
            var min = datas.Min();

            foreach (var data in datas)
            {
                if(data == null)
                {
                    yield return null;
                    continue;
                }

                yield return (data - min) / (max - min) *100 ;
            }
        }


        //取引比率計算
        public IEnumerable<double?> CalcTorihiki()
        {
            foreach (var priceData in PriceDatas.OrderBy(x => x.DateTime))
            {
                if (priceData.OutShare <= 0)
                {
                    yield return 0;
                    continue;
                }
                yield return (double)priceData.Volume / (double)priceData.OutShare;
            }
        }
        //ボラ計算
        public IEnumerable<double?> CalcBora()
        {
            foreach (var priceData in PriceDatas.OrderBy(x => x.DateTime))
            {
                yield return priceData.HighPrice / priceData.LowPrice;
            }
        }

        //MA乖離計算
        public IEnumerable<double?> CalcMovingAverageKairi(int ma)
        {
            var maArray = CalcMovingAverage(ma).ToArray();
            for (var i = 0; i < PriceDatas.Count(); i ++)
            {
                yield return (PriceDatas[i].ClosePrice - maArray[i]) / maArray[i] * 100;
            }


        }

        //MA計算
        public IEnumerable<double?> CalcMovingAverage(int ma)
        {
            var maQueue = new Queue<double?>();
            double? lastClocePrice = null;

            foreach (var priceData in PriceDatas.OrderBy(x => x.DateTime))
            {
                var price = priceData.ClosePrice;
                //終値が無い場合は直近の終値で計算
                if (price == null)
                {
                    price = lastClocePrice;
                }
                //終値が無いときnullを返す
                if(price == null)
                {
                    yield return null;
                    continue;
                }
                lastClocePrice = price;
                maQueue.Enqueue(price);
                //MAにキューを合わせる
                if(ma < maQueue.Count())
                {
                    maQueue.Dequeue();
                }
                //MA未満ならnullを返す
                if(maQueue.Count() < ma)
                {
                    yield return null;
                    continue;
                }

                yield return maQueue.Average();
            }
        }
        //CSVへ出力
        public void OutputCSV(string fileName)
        {
            //TR・取引・ボラ・5MA・基本ﾌﾟﾗｲｽを出力
            var sw = new StreamWriter(fileName);
            var ma = CalcMovingAverage(5).ToList();
            var bora = CalcBora().ToList();
            var Torihiki = CalcTorihiki().ToList();
            var TR = CalcTR().ToList();
            PriceDatas = PriceDatas.ToList();
            //タイトルを記入
            var csvProperty = typeof(CSVData).GetProperties();
            foreach (var title in csvProperty)
            {
                sw.Write($"{title.Name},");
            }
            sw.WriteLine();
            //CSVの中身を出力
            for (int i = 0; i < PriceDatas.Count(); i++)
            {
                var CSVData = new CSVData
                {
                    DateTime = PriceDatas[i].DateTime,
                    Code = PriceDatas[i].Code,
                    HighPrice = PriceDatas[i].HighPrice,
                    LowPrice = PriceDatas[i].LowPrice,
                    ClosePrice = PriceDatas[i].ClosePrice,
                    OpenPrice = PriceDatas[i].OpenPrice,
                    Cap = PriceDatas[i].Cap,
                    Volume = PriceDatas[i].Volume,
                    OutShare = PriceDatas[i].OutShare,
                    Bora = bora[i],
                    Torihiki = Torihiki[i],
                    TR = TR[i],
                    MA5 = ma[i],
                    MA5Kairi = (PriceDatas[i].ClosePrice- ma[i]) / ma[i] * 100,
                };

                foreach(var csvType in csvProperty)
                {
                    sw.Write($"{typeof(CSVData).GetProperty(csvType.Name).GetValue(CSVData, null)},");
                }
                sw.WriteLine();
            }
        }
    }

    //分割・併合情報を作成
    static public class SplitMarge
    {
         static public SplitMargeData CreateSplitMargeData(int code, DateTime dateTime, double beforeSplitNumber, double afterSplitNumber)
        {
            return new SplitMargeData
            {
                Code = code,
                KenriDateTime = dateTime,
                Magnification = beforeSplitNumber / afterSplitNumber //分割1→2 0.5 併合 10→1 10
            };
        }
    }

    //CSVをまとめる
    static public class CSV
    {
        static public void CSVMarge(string newFileName, IEnumerable<string> fileNames)
        {
            using (var sw = new StreamWriter(newFileName))
            {
                var IsTitle = true;
                foreach(var fileName in fileNames)
                {
                    using (var sr = new StreamReader(fileName))
                    {
                        if (IsTitle)
                        {
                            sw.WriteLine(sr.ReadToEnd());
                            IsTitle = false;
                            continue;
                        }
                        sr.ReadLine();
                        sw.WriteLine(sr.ReadToEnd());
                    }
                }
            }
            foreach(var fileName in fileNames)
            {
                File.Delete(fileName);
            }
        }
    }

    //
    public class CSVData
    {
        public DateTime DateTime { get; set; }
        public int Code { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
        public double? OpenPrice { get; set; }
        public double? ClosePrice { get; set; }
        public long Volume { get; set; }
        public long Cap { get; set; }
        public long OutShare { get; set; }

        public double? TR { get; set; }
        public double? Bora { get; set; }
        public double? MA5 { get; set; }
        public double? MA5Kairi { get; set; }
        public double? Torihiki { get; set; }
    }

    //価格情報
    public class PriceData
    {
        public DateTime DateTime { get; set; }
        public int Code { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
        public double? OpenPrice { get; set; }
        public double? ClosePrice { get; set; }
        public long Volume { get; set; }
        public long Cap { get; set; }
        public long OutShare { get; set; }
    }
    //分割・併合情報
    public class SplitMargeData
    {
        public int Code { get; set; }
        //この翌日以降分割
        public DateTime KenriDateTime { get; set; }
        public double Magnification { get; set; }
    }
}
