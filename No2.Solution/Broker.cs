using System;

namespace No2.Solution
{
    public class Broker 
    {
        public int USD { get; set; }
        public int Euro { get; set; }

        private IObservable stock;

        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
            //stock = observable;
            //stock.Register(this);
        }

        public void Update(object sender, StockInfoEventArgs stockInfo)
        {
            USD = stockInfo.USD;
            Euro = stockInfo.Euro;

            //StockInfo stockInfo = (StockInfo)info;

            //Console.WriteLine(
            //    stockInfo.USD > 30
            //        ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
            //        : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        //public void StopTrade()
        //{
        //    stock.Unregister(this);
        //    stock = null;
        //}
    }
}
