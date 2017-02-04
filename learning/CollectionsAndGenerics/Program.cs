using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenerics {
    public class Person {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int age) {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() {
            return string.Format("Name: {0} {1}, Age: {2}", FirstName, LastName, Age);
        }
    }

    public class PersonCollection: IEnumerable {
        private ArrayList arPeople = new ArrayList();

        public Person GetPerson(int pos) {
            return (Person)arPeople[pos];
        }

        public void AddPerson(Person p) {
            arPeople.Add(p);
        }

        public void ClearPeople() {
            arPeople.Clear();
        }

        public int Count {
            get {
                return arPeople.Count;
            }
        }

        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator() {
            return arPeople.GetEnumerator();
        }
    }

    class SortPeopleByAge: IComparer<Person> {
        public int Compare (Person firstPerson , Person secondPerson) {
            if (firstPerson.Age > secondPerson.Age) {
                return 1;
            } else if (firstPerson.Age < secondPerson.Age) {
                return -1;
            }

            return 0;
        }
    }

    class Program {
        static void Main(string[] args) {
            Point<int> that = new Point<int>(2, 2);
            Point<double> thatToo = new Point<double>(3.3, 3.2);

            UseSortedSet();

            Console.ReadKey();
        }

        static void ArrayListOfRandomObjects() {
            ArrayList allMyObjects = new ArrayList();

            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(777);
            allMyObjects.Add("Hello");
            allMyObjects.Add(3.14);

            // Person collections.
            PersonCollection myPeople = new PersonCollection();

            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Bart", "Simpson", 14));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 13));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            // This would be a compile-time error!
            // myPeople.AddPerson(new Car());

            foreach (Person p in myPeople) {
                Console.WriteLine(p);
            }
        }

        static void UseGenericList() {
            // This can be read as "list of type Person".
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Homer", "Simpson", 40));
            Console.WriteLine(morePeople[0]);

            // This List<> can hold only integers.
            List<int> myList = new List<int>();
            myList.Add(13);
            myList.Add(777);
            Console.WriteLine($"Sum: {myList[0] + myList[1]}");
        }

        static void UseGenericListLoop() {
            List<Person> people = new List<Person>() {
                new Person { FirstName= "Homer", LastName="Simpson", Age=47},
                new Person { FirstName= "Marge", LastName="Simpson", Age=40},
                new Person { FirstName= "Bart", LastName="Simpson", Age=7}
            };

            Console.WriteLine("Items in list: {0}", people.Count);

            foreach (Person p in people) {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n->Inserting new person.");
            people.Insert(people.Count, new Person { FirstName = "Lisa", LastName = "Simpson", Age = 17 });
            Console.WriteLine("Items in list: {0}", people.Count);


            // Copy data into a new array.
            Person[] arrayOfPeople = people.ToArray();

            for (int i = 0; i < arrayOfPeople.Length; i++) {
                Console.WriteLine("First Names: {0}", arrayOfPeople[i].FirstName);
            }
        }

        static void UseSortedSet() {
            SortedSet<Person> peoples = new SortedSet<Person>(new SortPeopleByAge()) {
                new Person { FirstName= "Homer", LastName="Simpson", Age=47},
                new Person { FirstName= "Marge", LastName="Simpson", Age=40},
                new Person { FirstName= "Bart", LastName="Simpson", Age=7}
            };

            // The items are sorted by age.
            foreach(Person p in peoples) {
                Console.WriteLine(p);
            }
        }
    }

    public interface IComparable<T> {
        int CompareTo(T obj);
    }

    public class Car: IComparable<Car> {
        public int CarID { get; set; }

        // Here we do not need to check whether the incoming parameter is a Car because it can only be a Car!
        int IComparable<Car>.CompareTo(Car obj) {
            if (this.CarID > obj.CarID) {
                return 1;
            } else if (this.CarID < obj.CarID) {
                return -1;
            }

            return 0;
        }
    }

    public struct Point<T> {
        private T xPos;
        private T yPos;

        public Point(T xVal, T yVal) {
            xPos = xVal;
            yPos = yVal;
        }

        public T X {
            get { return xPos; }
            set { xPos = value; }
        }

        public T Y {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString() {
            return string.Format("[{0}, {1}]", xPos, yPos);
        }

        public void ResetPoint() {
            xPos = default(T);
            yPos = default(T);
        }
    }
}
