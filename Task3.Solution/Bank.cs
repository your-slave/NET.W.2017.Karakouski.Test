using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{


    class Bank
    {
        public event PriceChangedHandler PriceChanged;

        public string Name { get; set; }

        public Bank(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            stock.Register(this);
        }

        public void Update(object info)
        {
            StockInfo sInfo = (StockInfo)info;

            if (sInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
        }

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }
}
