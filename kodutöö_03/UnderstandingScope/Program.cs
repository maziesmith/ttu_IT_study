using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope {
    class Program {
        private static string quality = "awesomeness";

        static void Main(string[] args) {
            Console.WriteLine(quality);

            for (int i = 0, j = 0; i < 100; i++) {
                j = i * 2;
            }

            // Out of scope thus will not work.
            // Console.WriteLine("i variable - " + i);
            // Console.WriteLine("j variable - " + j);

            Console.ReadKey();
        }
    }
}
