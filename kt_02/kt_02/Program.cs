using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Kontroll.Modify("Visual Studio"));

            Console.ReadKey();
        }

        static void AddOne(ref int x) {
            x++;
        }
    }

    class C {
        static int objects = 0;
        public int x, y;

        public C() {
            x = 0;
            y = 0;
            objects++;
        }

        public static int Secret {
            get { return objects; }
        }
    }

    class Box {
        public double length;
        public double breadth;
        public double height;
    }

    static class Kontroll {
        static public void Secret () {
            C a = new C();
            C b = new C();
            C c = new C();

            Console.WriteLine(C.Secret);
        }

        static public string Modify (string text) {
            if (text.Length <= 1) {
                return text;
            }

            char firstLetter = text[0];
            string rest = text.Substring(1);

            return Modify(rest) + firstLetter;
        }

        static public void References () {
            int valueOne;
            int valueTwo;

            string One = "600";
            string Two = "31i";

            int.TryParse(One, out valueOne);
            int.TryParse(Two, out valueTwo);

            Console.WriteLine($"{valueOne} {valueTwo}");
        }
        
        static public void PrintOddNumbers (int size) {
            for (int i = 0; i < size; i++) {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            }
        }

        static public void PrintEvenNumbers (int size) {
            for (int i = 0; i < size; i++) {
                if (i % 2 != 0) continue;
                Console.WriteLine(i);
            }
        }

        static public void ReverseNumbers () {
            int[] arr = { 2, 4, 6, 8, 10 };
            
            for (int i = 4; i >= 0; i--) {
                Console.WriteLine(arr[i]);
            } 
        }

        static public void DoesEndWithPoint () {
            String[] strings = new String[] { "java", "Hello", "Python.", "PHP.", "random" };

            foreach (var value in strings) {
                bool endsInPeriod = value.EndsWith(".");

                Console.WriteLine();
                Console.WriteLine($"'{value}' ends in a period: {endsInPeriod}");
            }
        }

        static public void sortArray () {
            const int size = 10;
            int[] arr = new int[size] { 3, 48, 23, 42, 33, 984, 8, 321, 15, 31 };

            bubbleSort(arr, size);

            for (int i = 0; i < size; i++) {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
        }

        static void bubbleSort (int[] data, int n) {
            int i, j;

            for (i = 0; i < n; i++) {
                for (j = n - 1; j > 1; j--) {
                    if (data[j] > data[j - 1]) {
                        int temp = data[j];
                        data[j] = data[j - 1];
                        data[j - 1] = temp;
                    }
                }
            }
        }

        static public void BoxClass () {
            Box Box1 = new kt_02.Box();
            Box Box2 = new kt_02.Box();

            double volume = 0.0;

            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            volume = Box1.height * Box1.length * Box1.breadth;

            Console.WriteLine(volume);

            volume = Box2.height * Box2.length * Box2.breadth;

            Console.WriteLine(volume);
        }

        static public void Yadda () {
            float result;
            float num;

            Console.WriteLine("Enter Number ");

            try {
                num = Convert.ToSingle(Console.ReadLine());

                result = (float)Math.Sqrt(num);
                Console.WriteLine($"The result is: {result}");

                Console.ReadLine();
            } catch (Exception) {
                Console.WriteLine("Error, cannot calculate the square root");
            }
        }
    }
}
