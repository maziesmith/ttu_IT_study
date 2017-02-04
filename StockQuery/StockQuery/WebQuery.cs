using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQuery {
    public class WebQuery {
        public static string GetResult(string url) {
            using (WebClient client = new WebClient()) {
                return client.DownloadString(url);
            }
        }
    }
}
