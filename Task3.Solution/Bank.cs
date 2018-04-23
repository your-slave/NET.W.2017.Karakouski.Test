using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Bank
    {
        public string Name { get; set; }
        private Stock stock;

        public Bank(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.StockInfoChanged += Update;
        }

        public void Update(object sender, StockInfoChangedArgs stockInfo)
        {
            StockInfoChangedArgs sInfo = stockInfo;

            if (sInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
        }
    }
}
