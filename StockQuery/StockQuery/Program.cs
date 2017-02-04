using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQuery {
    class Program {
        static void Main(string[] args) {
            string[] stocks = {
                "^GSPC",     // S&P 500
                "^IXIC",     // Nasdaq
                "^FTSE",     // FTSE 100
                "GC=F",      // Gold
                "CLZ16.NYM", // Crude oil
                "AAPL",
                "DB",
                "AMZN"
            };
            Stock stock = new Stock(stocks, "s|o|p2");

            stock.GetInformation();

            Console.ReadKey();
        }
    }
}
