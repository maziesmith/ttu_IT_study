using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inspireeritud videost toodud koodinäites kasutatud meetodidest, millest sai kirjutatud järgnev kood.
namespace kodutöö_02 {
    class StringManipulation {
        public StringManipulation() {
            string stringExample = "This is \"awesome\"!";
            string bankersFavouriteLine = string.Format("{0:C}", 99999999);

            stringExample = stringExample.ToUpper().Remove(3, 4).Replace("THI", "THIS");

            Console.WriteLine(stringExample);
            Console.WriteLine(bankersFavouriteLine);
            Console.WriteLine("{0} - {1} - {2}", stringExample.Length, stringExample.Trim(), bankersFavouriteLine.Length);

            string alphabet = "";

            // https://en.wikipedia.org/wiki/ASCII
            for (int i = 97; i < 122; i++) {
                char c = (char)i;
                alphabet += c.ToString();
            }

            Console.WriteLine(alphabet);
        }
    }

    class ArrayPlayground {
        public ArrayPlayground() {
            int[] numbers = new int[1000];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine("{0} - {1}", numbers[1].ToString(), numbers.Length);

            string[] stocks = new string[] {
                "GOOGL",
                "APPLE",
                "MICROSOFT",
                "MORGAN",
                "GOLDMAN",
                "UBS"
            };

            for (int i = 0; i < stocks.Length; i++) {
                Console.WriteLine(stocks[i]);
            }

            foreach (string company in stocks) {
                Console.WriteLine(company);
            }
        }
    }

    class EmoriUuring {
        public EmoriUuring() {
            AskQuestions();
        }

        private static void AskQuestions() {
            string firstName;
            string lastName;
            string city;

            DisplayLine();

            Console.WriteLine("Tere tulemast EMORi uuringusse.\n\nMis on teie nimi?");
            firstName = Console.ReadLine();

            Console.WriteLine("Mis on teie perekonnanimi?");
            lastName = Console.ReadLine();

            Console.WriteLine("Mis linnast olete pärit?");
            city = Console.ReadLine();

            DisplayUserInputReversed(firstName, lastName, city);
        }

        private static void DisplayLine() {
            Console.WriteLine("\n\n---------------------------------\n");
        }

        private static void DisplayUserInputReversed(string firstName, string lastName, string city) {
            Console.WriteLine("Results: ");
            Console.WriteLine(String.Format("{0} {1} {2}", ReverseString(firstName), ReverseString(lastName), ReverseString(city)));

            DisplayLine();
        }

        private static string ReverseString(string msg) {
            char[] msgArray = msg.ToCharArray();

            Array.Reverse(msgArray);

            return string.Concat(msgArray);
        }
    }

    class WhilePlayground {
        private bool displayMenu = true;

        public WhilePlayground() {
            while (displayMenu) {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu() {
            string result;

            Console.Clear();

            Console.WriteLine("Palun vali, kas:\n1)Prindi numbrid\n2)Arvamismäng\n3)Välju");

            result = Console.ReadLine();

            switch (result.ToString().Trim()) {
                case "1":
                    PrintNumbers();
                    return true;

                case "2":
                    GuessingGame();
                    return true;

                default:
                    return false;
            }
        }

        private static void PrintNumbers () {
            int gridSize = 10;

            Console.Clear();

            for (int i = 0; i < gridSize; i++) {
                for (int j = 0; j < gridSize; j++) {
                    Console.Write("1");
                }

                Console.Write("\n");
            }

            Console.ReadLine();
        }

        private static void GuessingGame () {
            Random random = new Random();

            int randomNumber = random.Next(1, 11);
            int guesses = 0;
            bool incorrectAnswer = true;

            Console.Clear();

            do {
                Console.WriteLine("Arva number 1st 10ni: ");
                string result = Console.ReadLine();

                guesses++;

                if (result == randomNumber.ToString()) {
                    incorrectAnswer = false;
                } else {
                    Console.WriteLine("Vale!");
                }

            } while (incorrectAnswer);

            Console.Write("Õige! See võttis {0} arvamist", guesses);
            Console.ReadLine();
        }
    }
    
    class main {
        static void Main(string[] args) {
            string name = "Genert Org";
            string id = "164775IABB";

            Console.WriteLine("{0} ({1}) kodutöö.", name, id);

            // Run homework classes.
            new StringManipulation();
            new ArrayPlayground();
            new EmoriUuring();
            new WhilePlayground();

            Console.ReadKey();
        }
    }
}
