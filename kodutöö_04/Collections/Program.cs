using System;
using Collections;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            Car car1 = new Car("Ferrari", "FF");
            Car car2 = new Car("Mercedes Benz", "S63 Coupe");
            Car car3 = new Car("Land Rover", "Range Rover Sport SVR");
            Car car4 = new Car("Land Rover", "Range Rover Autobiography");
            Car car5 = new Car("Land Rover", "Defender");
            Car car6 = new Car("Land Rover", "Range Rover Vogue");

            // ArrayList
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(car3);

            foreach (Car car in myArrayList) {
                Console.WriteLine(car.Model);
            }

            // Type list
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);
            myList.Add(car3);
            myList.Add(car4);
            myList.Add(car5);
            myList.Add(car6);

            List<Car> dailyDrivers = new List<Car>() {
                new Car { Maker = "Bentley", Model = "Continental GT" },
                new Car { Maker = "Rolls-Royce", Model = "Ghost" }
            };

            foreach (Car car in dailyDrivers) {
                Console.WriteLine(car.Maker);
            }

            // Dictionary
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.Maker, car1);
            myDictionary.Add(car2.Maker, car2);

            Console.WriteLine(myDictionary["Ferrari"].Model);

            // LINQ crap
            var queryResults = from car in myList
                               where car.Maker == "Ferrari"
                               select car;

            Console.WriteLine("\n\nQuery");

            foreach (var result in queryResults) {
                Console.WriteLine(result.ToString());
            }

            // More LINQ crap
            var methodResults = myList.Where(p => p.Maker == "Land Rover");

            Console.WriteLine("\n\nQuery");
            foreach (var result in methodResults) {
                Console.WriteLine(result.ToString());
            }

            Console.ReadKey();
        }
    }
}