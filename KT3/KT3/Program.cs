using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3 {
    class Test {
        string item = "hi";
    }

    class Program {
        private static object diskPrice;

        static void Main(string[] args) {
            int[] numbers = new int[2];

            try {
                numbers[0] = 23;
                numbers[1] = 32;
                numbers[2] = 42;

                foreach (int i in numbers) {
                    Console.WriteLine(i);
                }
            } catch {
                Console.WriteLine("Nothing!");
            }
            Console.ReadLine();
        }

        static int Add(int a, int b) {
            return a + b;
        }

        static int Add(int a, int b, int c) {
            return a + b + c;
        }

        static void AddOne(ref int x) {
            x++;
        }

        private static long Calcu(int n1) {
            if (n1 == 0) {
                return 1;
            }

            return n1 * Calcu(n1 - 1);
        }

        public static int SquareRoot (int number, int min, int max) {
            int result = 0;

            for (int i = min; i <= max; i++) {
                if ((i * i) <= number) {
                    result = i;
                }
            }

            return result;
        }

        private static int GetDoubleLettersCount (string text) {
            string txt = text.Replace(" ", "");
            int doubleLetters = 0;

            for (int i = 0; i < txt.Length - 1; i++) {
                if (txt[i] == txt[i + 1]) {
                    doubleLetters += 1;
                    i++;
                }
            }



            return doubleLetters;
        }

        private static int GetDecimalValue (int number) {
            int decimalValue = 0;
            int baseValue = 1;
            int num = number;
            int rem;

            while (num > 0) {
                rem = num % 10;
                decimalValue = decimalValue + rem * baseValue;
                num = num / 10;
                baseValue = baseValue * 2;
            }

            return decimalValue;
        }

        static void DrawParallellogram (int width, int height, char character) {
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    Console.WriteLine(character);
                }

                Console.WriteLine("");

                for (int c = 0; c <= i; c++) {
                    Console.WriteLine(" ");
                }
            }
        }

        static int GetWordsCount (string fileName) {
            StreamReader file = File.OpenText(fileName);
            string line;
            int x = 0;

            do {
                line = file.ReadLine();

                if (line != null) {
                    string[] x1 = line.Split(' ');
                    x += x1.Length;
                }
            } while (line != null);

            file.Close();

            return x;
        }
    }
}
