using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    class Stock
    {
        public delegate void StockInfoChangedHandler(decimal oldPrice,
            decimal newPrice);

        private StockInfo stocksInfo;

        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        public void Register(IObserver observer) => observers.Add(observer);

        public void Unregister(IObserver observer) => observers.Remove(observer);

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(stocksInfo);
            }
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
