using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrape {
    public class Scrape {
        public string ScrapeWebpage (string url) {
            return GetWebpage(url);
        }

        public string ScrapeWebpage (string url, string filepath) {
            string content = GetWebpage(url);

            File.WriteAllText(filepath, content);

            return content;
        }

        private string GetWebpage (string url) {
            WebClient client = new WebClient();

            return client.DownloadString(url);
        }
    }
}