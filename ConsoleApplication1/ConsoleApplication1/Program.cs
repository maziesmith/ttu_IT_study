using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static int product(int a, int b)
        {
            if (a < b)
            {
                return product(b, a);
            } else if (b != 0)
            {
                return (a + product(a, b - 1));
            }
            else
            {
                return 0;
            }
        }
        static int SparseBitcount(int n)
        {
            int count = 0;

            while (n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }

        static int Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= number;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int i;
            int v = 40;
            int[]x = new int[5];

            try
            {
                Console.WriteLine("Enter");
                index = Convert.ToInt32(Console.ReadLine())
            }
            catch (Exception e)
            {
                Console.WriteLine("eee");
            }

            Console.WriteLine("Lol");
            Console.ReadLine();
        }
    }
}
