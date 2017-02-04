using WebScrape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces {
    class Program {
        static void Main(string[] args) {
            Scrape site = new Scrape();

            // Print page's content (HTML)
            Console.WriteLine(site.ScrapeWebpage("https://ained.ttu.ee"));

            Console.ReadKey();
        }
    }
}
