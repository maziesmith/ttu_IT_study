using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ {
    class Program {
        static void Main(string[] args) {
            QueryOverStrings();
            QueryOverInts();

            Console.ReadKey();
        }


        static void QueryOverStrings () {
            string[] currentVideoGames = { "Morrowwind", "Uncharted 2", "Fallout 3", "Battlefield 4", "Daxter", "System Shock" };

            IEnumerable<string> subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;

            foreach (string s in subset) {
                Console.WriteLine("Item: {0}", s);
            }
        }

        static void QueryOverInts() {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            IEnumerable<int> subset = from i in numbers where i <= 50 select i;

            foreach (int s in subset) {
                Console.WriteLine("Item: {0}", s);
            }
        }
    }
}
