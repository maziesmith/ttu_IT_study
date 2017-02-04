using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimes {
    class Program {
        static private DateTime date = DateTime.Now;

        static void Main (string[] args) {
            PrintMethodValues();
            GetTotalDaysSinceBirth();

            Console.ReadLine();
        }

        private static void PrintMethodValues () {
            Console.WriteLine(date.ToString());
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToShortTimeString());
            Console.WriteLine(date.ToLongDateString());

            Console.WriteLine(date.AddDays(13).ToLongDateString());
            Console.WriteLine(date.AddDays(-10).ToLongDateString());
            Console.WriteLine(date.AddHours(13).ToLongTimeString());
        }

        private static void GetTotalDaysSinceBirth () {
            DateTime birthday = new DateTime(1996, 11, 10);
            TimeSpan age = DateTime.Now.Subtract(birthday);

            Console.WriteLine("Person born in {0} is {1} days old.", birthday.ToLongDateString(), Math.Round(age.TotalDays));
        }
    }
}
