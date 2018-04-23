﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("b&b", stock);
            Broker broker = new Broker("joe", stock);
            stock.Market();
            broker.StopTrade();
            stock.Market();
            System.Console.ReadKey();
        }
    }
}
