using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageIterator {
    class Car {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }

        public Car (string name, int speed) {
            PetName = name;
            CurrentSpeed = speed;
        }
    }

    public class Garage: IEnumerable {
        private Car[] carArray = new Car[3];

        public Garage () {
            carArray[0] = new Car("Hi", 200);
            carArray[1] = new Car("Zippy", 300);
            carArray[2] = new Car("Tester", 150);
        }

        public IEnumerator GetEnumerator() {
            foreach (Car c in carArray) {
                yield return c;
            }
        }

        public IEnumerable GetTheCars(bool ReturnReversed) {
            if (ReturnReversed) {
                for (int i = carArray.Length; i != 0; i--) {
                    yield return carArray[i - 1];
                }
            } else {
                foreach (Car c in carArray) {
                    yield return c;
                }
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            Garage carLot = new Garage();

            foreach (Car c in carLot) {
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
            }

            Console.WriteLine("\nReverse order:");

            // In reverse
            foreach (Car c in carLot.GetTheCars(true)) {
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
            }

            Console.ReadKey();
        }
    }
}
