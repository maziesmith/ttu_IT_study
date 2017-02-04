using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning {
    class Program {
        static void Main(string[] args) {
            // Set some console stylings...
            Console.Title = "Becoming C# pro";
            Console.WindowHeight = (int)(Console.LargestWindowHeight / 1.5);
            Console.WindowWidth = (int)(Console.LargestWindowWidth / 1.5);

            // Core C# programming constructs
            DataTypes();
            NewingDataTypes();
            UseDatesAndTimes();
            StringsAreImmutable();
            DeclareExplicitVars();
            DeclareImplicitVars();
            LinqQueryOverInts();
            ForEachLoopsExample();
            IfElseExample();
            ValueChecking();
            ParamsWork();
            OptionalParametersTest();
            SimpleArrays();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();

            // Nesting relationships example.
            Employees.Employee.BenefitPackage.BenefitPackageLevel benefitLevel = Employees.Employee.BenefitPackage.BenefitPackageLevel.Gold;

            Console.ReadKey();
        }

        // [static|public|private...] returnType MethodName(parameter list) { /* Implementation */ }

        static void DataTypes() {
            // System Type: System.Boolean
            // Range:       true or false
            // Meaining:    Represents truth or falsity
            bool b = true;

            // System Type: System.SByte
            // Range:       -128 to 127
            // Meaining:    Signed 8-bit number
            sbyte sb = 126;

            // System Type: System.Byte
            // Range:       0 to 255
            // Meaining:    Unigned 8-bit number
            byte b1 = 255;

            // System Type: System.Int16
            // Range:       -32,768 to 32,767
            // Meaining:    Signed 8-bit number
            short sh = 16382;

            // System Type: System.UInt16
            // Range:       0 to 65,535
            // Meaining:    Unsigned 8-bit number
            ushort ush = 60093;

            // System Type: System.Int32
            // Range:       -2,147,483,648 to 2,147,483,647
            // Meaining:    Signed 32-bit number
            int i32 = 45829492;

            // System Type: System.uint
            // Range:       0 to 4,294,967,295
            // Meaining:    Unsigned 32-bit number
            uint ui32 = 909130120;

            // System Type: System.Int64
            // Range:       -9,223,372,036,854,775,808 to 9,223,372,036,854,775,808
            // Meaining:    Signed 64-bit number
            long l = 98239278332;

            // System Type: System.UInt64
            // Range:       0 to 18,446,744,073,709,551,615 - my bank account
            // Meaining:    Unsigned 64-bit number
            ulong ul = 9382938218938223213;

            // System Type: System.Char
            // Range:       U+0000
            // Meaining:    Single 16-bit Unicode character
            char c = 'G';

            // System Type: System.Single
            // Range:       -3,4*10^38 to 3,4*10^38
            // Meaining:    32-bit float-point number
            float fl = 889283912931.82f;

            // System Type: System.Double
            // Range:       +-5.0*10^-324 to +- 1.7*10^308
            // Meaining:    64-bit float-point number
            double dbl = 482482.0294092d;

            // System Type: System.Decimal
            // Range:       -9,223,372,036,854,775,808 to 9,223,372,036,854,775,808
            // Meaining:    Unsigned 32-bit number
            decimal dec = 82939123.323M;

            // System Type: System.String
            // Range:       Limited by system memory.
            // Meaining:    Represents a set of Unicode characters.
            string str = "Hello word!";

            // System Type: System.Object
            // Range:       Can store any data type in a object variable.
            // Meaining:    The base class of all types in the .NET universe
            Object obj = new Object();
        }

        static void NewingDataTypes() {
            Console.WriteLine("=> Using new to create variables:");

            bool b = new bool();          // Set to false.
            int i = new int();            // Set to 0.
            double d = new double();      // Set to 0.
            DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM

            Console.WriteLine($"{b}, {i}, {d}, {dt}");

            Console.WriteLine();
        }

        static void UseDatesAndTimes() {
            Console.WriteLine("=> Dates and Times:");

            // This constructor takes (year, month, day);
            DateTime dt = new DateTime(2016, 10, 2);

            // What day of the month is this?
            Console.WriteLine($"The day of {dt.Date} is {dt.DayOfWeek}");

            // Month will be now December.
            dt = dt.AddMonths(2);

            Console.WriteLine($"Daylight savings: {dt.IsDaylightSavingTime()}");

            // THis constructor takes (hours, minutes, seconds).
            TimeSpan ts = new TimeSpan(4, 20, 0); // It's lit!
            Console.WriteLine(ts); // Will output 4:20:00

            Console.WriteLine();
        }

        static void StringsAreImmutable() {
            // Set initial string value.
            string s1 = "This is my string.";
            Console.WriteLine($"s1 = {s1}");

            // Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine($"upperSTring = {upperString}");

            // Nope! s1 is in the same format!
            Console.WriteLine($"s1 = {s1}");

            Console.WriteLine();
        }

        static void DeclareExplicitVars() {
            // Explicitly typed local variables are declared as follows:
            // dataType variableName = initialValue;
            int myInt = 0;
            bool myBool = true;
            string myString = "Time, marches on...";
        }

        static void DeclareImplicitVars() {
            // Implicitly typed local variables are declared as follows:
            // var variableName = initialValue;
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Implicit typing applies only to local variables in a method or property scope.
            // It is illegal to use the var keyword to define return values, parameters, or field data of a custom type.
            // Variables MUST be assigned an inital value at the exact time of declaration
            // and cannot be assigned the inital value of null.

            // Implicity typing of local variables results in strongly typed data (not like JS or Perl).

            Console.WriteLine($"myInt is a: {myInt.GetType().Name}");
            Console.WriteLine($"myBool is a: {myBool.GetType().Name}");
            Console.WriteLine($"myString is a: {myString.GetType().Name}");

            Console.WriteLine();
        }

        static void LinqQueryOverInts() {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            // It is recommended to use var for LINQ queries.
            var subset = from i in numbers where i < 70 select i;

            Console.WriteLine();
            Console.Write("Values in subset: ");

            // var usage - The compiler will correctly infer the correct "type of type".
            foreach (var i in subset) {
                Console.Write($"{i} ");
            }

            Console.WriteLine($"subset is a: {subset.GetType().Name}");
            Console.WriteLine($"subset is defined in: {subset.GetType().Namespace}");

            Console.WriteLine();
        }

        static void ForEachLoopsExample() {
            string[] carMakers = { "BMW", "Audi", "Porsche", "Maserati", "Ferrari", "Land Rover" };

            // Foreach loop will walk the container only in a linear (n+1) fashion.
            // Thus you cannot go backward through the container, skip every third element, or whatnot.
            foreach (string maker in carMakers) {
                Console.WriteLine(maker);
            }

            Console.WriteLine();
        }

        static void IfElseExample() {
            // Unlike in C and C++, the if/else staement in C# operates only on Boolean expressions!
            string stringData = "Jack";

            // This is illegal, givent that Length returns an int, not a bool
            //if (stringData.Length) {
            // The expression has to resolve a Boolean!
            if (stringData.Length > 0) {
                Console.WriteLine("string is greater than 0 characters");
            }

            int age = 30;

            if (age == 30 && stringData == "Jack") {
                // The && and || operators both "short circuit" when necessary.
                // This means that after a complex expression has been determined to be false,
                // the remaining subexpressions will not be checked.
                // If you required all expressions o be tested regardless, you can use & and |.
            }

            Console.WriteLine();
        }

        static void ValueChecking() {
            int x = 9, y = 10;

            Console.WriteLine($"Before call: X: {x}, Y: {y}");
            Console.WriteLine($"Answer is: {Calculations.Add(x,y)}");
            Console.WriteLine($"Afert call: X: {x}, Y: {y}");

            // Output parameters do not need to be initalized before they are passed to the method.
            int ans;
            Calculations.Add(90, 90, out ans);

            Console.WriteLine($"90 + 80 = {ans}");

            int i;
            string str;
            bool b;
            Calculations.FillTheseValues(out i, out str, out b);

            // Reference parameters must be initialize before they are passed to the method.
            string str1 = "Flip";
            string str2 = "Flop";

            Console.WriteLine($"Before: {str1}, {str2}"); // Before: Flip, Flop
            Calculations.SwapStrings(ref str1, ref str2);
            Console.WriteLine($"After: {str1}, {str2}");  // After: Flop, Flip

            Console.WriteLine();
        }

        static void ParamsWork() {
            double[] data = { 4.3, 3.2, 3.3, 4.2, 77.7, 33.3 };
            double average = Calculations.CalculateAverage(data);

            Console.WriteLine($"Average of data is: {average}");

            Console.WriteLine();
        }

        // Optional parameter must be known at compile time and cannot be resolved at runtime.
        // For example, optional parameter "DateTime timeStamp = DateTime.Now" will throw error.
        static void OptionalParameters (string message, string owner = "Programmer") {
            Console.WriteLine($"{message} - {owner}");
        }

        static void OptionalParametersTest () {
            OptionalParameters(message: "Hello");
            Console.WriteLine();
        }

        static void SimpleArrays () {
            // Create an array of ints containint 3 elements indexed 0, 1, 2 and fill them.
            int[] myInts = new int[3];

            // Do be aware that if you declare an array but do not explicitly fill each index,
            // each item will be set to the default value of the data type.
            // For instance an array of bolls wil be set to false or an array of ints will be set to 0.
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Create a 100 item string array, indexed 0, 1, 2
            string[] booksOnDotNed = new string[100];

            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[] { "one", "two", "three" };

            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, true, false, true };

            // Array initialization with new keyword and size.
            int[] intArray = new int[4] { 3, 7, 9, 13 };

            // var keyword can be used to define implicitly typed local arrays.
            // You must use the new keyword when using this approach.
            var a = new[] { 1, 10, 20, 30 }; // a is really int[]
            var b = new[] { 1, 1.5, 2, 2.5 }; //
            var c = new[] { "Hello", null, "word" };

            Console.WriteLine($"a is {a.ToString()}");

            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = true;
            myObjects[2] = DateTime.Now;
            myObjects[3] = "Hello";

            Console.WriteLine();
        }

        static void RectMultidimensionalArray() {
            int[,] matrix = new int[3, 4];

            // First part is rows count and second row data.
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    matrix[i,j] = i * j;
                }
            }

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray() {
            int[][] jagArray = new int[5][];
            int len = 7;

            for (int i = 0; i < jagArray.Length; i++) {
                jagArray[i] = new int[len + i];
            }

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < jagArray[i].Length; j++) {
                    Console.Write(jagArray[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void AskForBonus(EmployeeType employee) {
            switch (employee) {
                case EmployeeType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;

                case EmployeeType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;

                case EmployeeType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
            }
        }

        static void CastingExamples() {
            // A Manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.
            object frank = new Employees.Manager("Frank", 30, 300, 4000, "111-11-1111", 5);

            // A Manager "is-an" Employee too.
            Employees.Employee moonUnit = new Employees.Manager("MoonUnit", 30, 300, 4000, "111-11-1111", 5);

            // A PTSalesPerson "is-a" SalesPerson
            Employees.SalesPerson jill = new Employees.PTSalesPerson("Jill", 30, 300, 4000, "111-11-1111", 5);

            // "as" keyword determines at runtime whether a given type is compatible with another.
            object[] things = new object[4];
            things[0] = new Car();
            things[1] = false;
            things[2] = new Employees.Manager();
            things[3] = "Hi";

            foreach (object item in things) {
                Car car = item as Car;

                if (car == null) {
                    Console.WriteLine("Item is not a car");
                } else {
                    Console.WriteLine(car.ToString());
                }
            }

            // In additional, "is" keyword determines whether two items are compatible.
            // Unlike the "as" keyword, however, the keyword returns false, rather than a null reference 
            // if the tyües are incompatible.
        }
    }

    enum EmployeeType: byte {
        Manager,
        Grunt,
        Contractor,
        VicePresident
    };

    class Person {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Age { get; set; }

        public Person () { }

        public override bool Equals(object obj) {
            if (obj is Person && obj != null) {
                Person temp = (Person)obj;

                if (temp.FirstName == this.FirstName &&
                    temp.LastName == this.LastName &&
                    temp.Age == this.Age) {
                    return true;
                }
            }

            return false;
        }
    }

    class Calculations {
        // If you do not mark an argument with a parameter modifier [out,ref]
        // a copy of the data is passed into the function.
        public static int Add(int x, int y) {
            int ans = x + y;

            // Caller will not see these changes as you are modifying a copy of the original data.
            x = 10000;
            y = 88888;

            return ans;
        }

        // Overloading 
        public static double Add(double x, double y) {
            return x + y;
        }

        public static long Add(long x, long y) {
            return x + y;
        }

        public static void Add(int x, int y, out int ans) {
            ans = x + y;
        }

        public static void FillTheseValues (out int a, out string b, out bool c) {
            // Always remember that a method that defines output parameters
            // must assign the parameter to a valid value before exiting the method scope.
            a = 9;
            b = "Awesome";
            c = true;
        }

        // Reference parameters are necessary when you want to allow a method to operate on
        // (and usually change the values of) various data points declared in the caller's scope.
        public static void SwapStrings(ref string s1, ref string s2) {
            string tmp = s1;
            s1 = s2;
            s2 = tmp;
        }

        public static double CalculateAverage(params double[] values) {
            double sum = 0;

            if (values.Length == 0) {
                return sum;
            }

            for (int i = 0; i < values.Length; i++) {
                sum += values[i];
            }

            return (sum / values.Length);
        }
    }

    class CCar {
        protected int _protectedThing { get; set; }
        private int _privateThing { get; set; }
    }

    // Only one direct base class allowed.
    // sealed - The MiniVan class cannot be extended.
    // Sealed technique is most often used when you are designing a utility class.
    sealed class Minivan: CCar {
        public void TestMethod () {
            // protected is accesible through inhertience as well.
            _protectedThing = 10;

            // private will be only for class and does not inherit
            //_privateThing = 10;
        }
    }

    public class CarIsDeadException: ApplicationException {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause, DateTime time) {
            messageDetails = message;
            ErrorTimeStamp = time;
            CauseOfError = cause;
        }

        public override string Message {
            get {
                return string.Format("Car Error Message: {0}", messageDetails);
            }
        }
    }

    public class Car {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = String.Empty;

        private bool carIsDead;
        
        public Car () { }
        public Car (string name, int speed) {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void Accelerate (int delta) {
            if (carIsDead) {
                Console.WriteLine($"{PetName} out of order...");
            } else {
                CurrentSpeed += delta;

                if (CurrentSpeed > MaxSpeed) {
                    carIsDead = true;
                    CurrentSpeed = 0;

                    CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName), "You have a lead foot", DateTime.Now);

                    ex.HelpLink = "http://www.help.ee";

                    throw ex;
                } else {
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
                }
            }
        }
    }
}

namespace Employees {
    // With abstract you can not new() it.
    // Using this form of abstraction, you are able to model that the "idea" of an employee
    // is completley valid; it is just not a concrete entity.
    abstract partial class Employee {
        // Protected state data.
        protected int ID { get; set; }
        protected float Pay { get; set; }
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string SSN { get; set; }

        protected BenefitPackage empyBenefits = new BenefitPackage();

        public class BenefitPackage {
            public enum BenefitPackageLevel {
                Standard, Gold, Platinum
            }

            public double ComputePayDeduction() {
                return 125.0;
            }
        }

        public Employee () { }

        public Employee (string fullName, int age, int empID, float currPay, string ssn) {
            ID = empID;
            Age = age;
            Name = fullName;
            Pay = currPay;
            SSN = ssn;
        }

        public double GetBenefitCost() {
            return empyBenefits.ComputePayDeduction();
        }

        public BenefitPackage Benefits {
            get { return empyBenefits; }
            set { empyBenefits = value; }
        }

        // OOP polymorphism
        // If a base class wants to define a method that may be (but does not have to be)
        // overridden by a subclass, it must mark the method with the virtual keyword.
        // sealed can also used.
        // public virtual sealed void GiveBonus (float amount)
        public virtual void GiveBonus (float amount) {
            Pay += amount;
        }

        public virtual void DisplayStats () {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"SSN: {SSN}");
        }
    }

    class SomethingNew : Employee {
        public SomethingNew () { }

        // Shadowing
        // Using new keyword expliciityl states that the derived type's implementation is
        // intentionally designed to effectively ignore the parent's version.
        public new void DisplayStats () {
            Console.WriteLine("Hello");
        }
    }

    class Manager: Employee {
        public int StockOptions { get; set; }

        public Manager () { }

        // You may use the base keyword whenever a subclass wants to acces a plublic or ptected member defined by a parent class.
        public Manager (string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts): base(fullName, age, empID, currPay, ssn) {
            StockOptions = numbOfOpts;
        }

        public override void DisplayStats() {
            base.DisplayStats();
            Console.WriteLine($"Stock options: {StockOptions}");
        }
    }

    class SalesPerson: Employee {
        public int SalesNumber { get; set; }

        public SalesPerson () { }

        public SalesPerson (string fullName, int age, int empID, float currPay, string ssn, int numbOfSales): base(fullName, age, empID, currPay, ssn) {
            SalesNumber = numbOfSales;
        }

        public override void GiveBonus(float amount) {
            int salesBonus = 0;

            if (SalesNumber >= 0 && SalesNumber <= 100) {
                salesBonus = 10;
            } else {
                if (SalesNumber > 100 && SalesNumber <= 200) {
                    salesBonus = 15;
                } else {
                    salesBonus = 20;
                }
            }

            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats() {
            base.DisplayStats();
            Console.WriteLine($"Number of sales: {SalesNumber}");
        }
    }

    sealed class PTSalesPerson: SalesPerson {
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales): base(fullName, age, empID, currPay, ssn, numbOfSales) {

        }
    }
}
