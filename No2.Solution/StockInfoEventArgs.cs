namespace No2.Solution
{
    public class StockInfoEventArgs : StockInfo
    {
        private StockInfo stocksInfo;

        public StockInfoEventArgs()
        {
            stocksInfo = new StockInfo();
        }

    }
}

