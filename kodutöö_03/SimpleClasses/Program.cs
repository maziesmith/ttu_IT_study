using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassesAndLifetime {
    class Car {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }

        public Car () {}

        public Car (string make, string model, string color, double price, int year) {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            Year = year;
        }

        // https://msdn.microsoft.com/en-us/library/ms173154.aspx
        public override string ToString () {
            return "Car";
        }
    }

    class Program {
        static void Main(string[] args) {
            Car dailyDriver = new Car();
            // Or
            // Car dailyDriver = new Car("Ferrari" "F12berlinetta", "Black", 275000, 2012);

            dailyDriver.Make = "Ferrari";
            dailyDriver.Model = "F12berlinetta";
            dailyDriver.Color = "Black";
            dailyDriver.Price = 275000;
            dailyDriver.Year = 2012;

            Console.WriteLine(string.Format("My daily driver is a {0} {1} {2} ({3} year) which cost about {4}",
                dailyDriver.Color,
                dailyDriver.Make,
                dailyDriver.Model,
                dailyDriver.Year,
                dailyDriver.Price.ToString("C", new CultureInfo("et-EE"))
            ));

            Console.WriteLine(dailyDriver); // Should return "Car".

            // Reference it.
            Car familyCar = dailyDriver;

            dailyDriver = null;

            // Will throw error because reference is null.
            /* Console.WriteLine(string.Format("My family car is a {0} {1} {2} ({3} year) which cost about {4}",
                dailyDriver.Color,
                dailyDriver.Make,
                dailyDriver.Model,
                dailyDriver.Year,
                dailyDriver.Price.ToString("C", new CultureInfo("et-EE"))
            ));*/

            Console.ReadKey();
        }
    }
}
