using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Stock
    {
        public event EventHandler<StockInfoChangedArgs> StockInfoChanged;

        private StockInfoChangedArgs stocksInfo;

        protected virtual void OnStockInfoChanged(StockInfoChangedArgs e)
        {
            StockInfoChanged?.Invoke(this, e);
        }

        public Stock()
        {
            stocksInfo = new StockInfoChangedArgs();
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnStockInfoChanged(stocksInfo);
        }
    }
}
