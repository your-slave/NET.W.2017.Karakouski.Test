using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Broker
    {
        public string Name { get; set; }
        private Stock stock;

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.StockInfoChanged += Update;
        }

        public void Update(object sender, StockInfoChangedArgs info)
        {
            StockInfoChangedArgs sInfo = info;

            if (sInfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
        }

        public void StopTrade()
        {
            stock.StockInfoChanged -= Update;
        }
    }
}
