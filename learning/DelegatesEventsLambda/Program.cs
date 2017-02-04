using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambda {
    static class AnnoyingExtensions {
        public static void PrintDataAndBeep(this System.Collections.IEnumerable iterator) {
            foreach (var item in iterator) {
                Console.WriteLine(item);
                Console.Beep();
            }
        }
    }

    public delegate void MyGenericDelegate<T>(T arg);

    public delegate int BinaryOp(int x, int y);

    public class SimpleMath {
        public int Add(int x, int y) {
            return x + y;
        }

        public int Substract(int x, int y) {
            return x - y;
        }
    }

    class Program {
        static void Main(string[] args) {
            // Create a BinaryOp delegate object that "points to " SimpleMath.Add().
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);

            DispalyDelegateInfo(b);

            // Invoke Add() method indirectly using delegate object.
            Console.WriteLine("10 + 10 is {0}", b(10, 10));

            Console.WriteLine("\n\n******* Delegates as event enablers ********\n");

            Car c1 = new DelegatesEventsLambda.Car("Bot", 100, 10);

            Car.CarEngineHandler handler1 = new Car.CarEngineHandler(OnCarEngineEvent);
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);

            c1.RegisterWithCarEngine(handler1);
            c1.RegisterWithCarEngine(handler2);

            Console.WriteLine("Speeding up");

            for (int i = 0; i < 6; i++) {
                c1.Accelerate(20);
            }

            c1.UnRegisterWithCarEngine(handler2);

            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            strTarget("Hello");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(1000);

            Action<string, ConsoleColor, int> act = new Action<string, ConsoleColor, int>(DisplayMessage);

            act("Hello", ConsoleColor.Cyan, 5);

            //
            c1.Exploded += C1_Exploded;

            // Anonymous function.
            c1.AboutToBlow += delegate {
                Console.WriteLine("Screwed!");
            };

            string[] data = { "Wow", "this", "is", "sort", "of", "annoying" };

            data.PrintDataAndBeep();

            Console.ReadKey();
        }

        static void TraditionDelegateSyntax() {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 3, 4, 5, 6, 7 });

            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
        }

        static void AnonymousMethodSytnax() {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

            List<int> evenNumbers = list.FindAll(delegate (int i) {
                return (i % 2) == 0;
            });
        }

        static void LambdaExpressionSyntax() {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
        }

        static bool IsEvenNumber(int i) {
            // Is even?
            return (i % 2) == 0;
        }

        private static void C1_Exploded(string msgForCaller) {
            Console.WriteLine(msgForCaller);
        }

        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount) {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++) {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = previous;
        }

        static void DispalyDelegateInfo(Delegate delObj) {
            foreach (Delegate d in delObj.GetInvocationList()) {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }

        // Target for incoming events.
        public static void OnCarEngineEvent(string msg) {
            Console.WriteLine("=> {0}", msg);
        }

        public static void OnCarEngineEvent2(string msg) {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }

        static void StringTarget(string arg) {
            Console.WriteLine(arg.ToUpper());
        }

        static void IntTarget(int arg) {
            Console.WriteLine(++arg);
        }
    }

    public class Car {
        public int CurrentSpeed { get; set; } = 0;
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; } = String.Empty;

        private bool carIsDead = false;

        public Car () { }
        public Car(string name, int maxSpeed, int currentSpeed) {
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
            PetName = name;
        }

        // 1) Define a delegate type.
        public delegate void CarEngineHandler(string msgForCaller);

        // 2) Define a member variable of this delegate.
        private CarEngineHandler listOfHandlers;

        // 3) Add registration function for the caller.
        public void RegisterWithCarEngine(CarEngineHandler methodToCall) {
            listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall) {
            listOfHandlers -= methodToCall;
        }

        // 4) Implement the Accelerate() method to invoke the delegate's
        //    invocation list under the correct circumstances.
        public void Accelerate(int delta) {
            if (carIsDead) {
                Exploded?.Invoke("Sorry, this car is dead...");
            } else {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed)) {
                    AboutToBlow?.Invoke("Careful buddy! Gonna blow!");
                } 

                if (CurrentSpeed >= MaxSpeed) {
                    carIsDead = true;
                } else {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }

        // The car can send these events.
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
    }
}
