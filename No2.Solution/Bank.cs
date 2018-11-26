using System;
using System.Security.Cryptography.X509Certificates;

namespace No2.Solution
{
    public class Bank
    {
        public int USD { get; set; }
        public int Euro { get; set; }


        private IObservable stock;
        public StockInfo stockInfo;

        public string Name { get; set; }
        

        public Bank(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            //stock.Register(this);
        }

        public void Update(object sender, StockInfoEventArgs stockInfo)
        {
            this.stockInfo = stockInfo;
            USD = stockInfo.USD;
            Euro = stockInfo.Euro;


    
            //var stockInfo = (StockInfo)info;

            //Console.WriteLine(
            //    stockInfo.Euro > 40
            //        ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
            //        : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }
    }
}
