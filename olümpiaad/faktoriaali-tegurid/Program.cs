using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriaali_tegurid {
    class Program {
        static int Factorial(int fact) {
            if (fact < 2) {
                return 1;
            }

            return fact * Factorial(fact - 1);
        }

        static void Main(string[] args) {
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(6));
            Console.ReadKey();
        }
    }
}
