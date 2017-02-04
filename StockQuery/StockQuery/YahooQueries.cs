using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQuery {
    public class YahooQueries {
        public static List<YahooQueryItem> yahooQueries = new List<YahooQueryItem> {
            new YahooQueryItem { Name = "a", Description = "Ask" },
            new YahooQueryItem { Name = "o", Description = "Open" },
            new YahooQueryItem { Name = "s", Description = "Stock name" },
            new YahooQueryItem { Name = "j", Description = "52 week Low" },
            new YahooQueryItem { Name = "k", Description = "52 week High" },
            new YahooQueryItem { Name = "k2", Description = "Change" },

            // Date
            new YahooQueryItem { Name = "c", Description = "Change" },
            new YahooQueryItem { Name = "p2", Description = "Change %" }
        };
    }
}
