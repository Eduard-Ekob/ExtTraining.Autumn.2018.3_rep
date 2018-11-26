using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public delegate void stockEventHandler(object sender, StockInfo e);

    public class Stock
    {
        private StockInfo stocksInfo;
        public event stockEventHandler StockInfoChanged;

        public Stock()
        {
            stocksInfo = new StockInfo();
        }


        public void Market()
        {
            if (StockInfoChanged != null)
            {
                Random rnd = new Random();
                stocksInfo.USD = rnd.Next(20, 40);
                stocksInfo.Euro = rnd.Next(30, 50);
            }
        }
    }
}
