using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Timers {
    class Program {
        static void Main(string[] args) {
            Timer timer = new Timer(2000);

            timer.Elapsed += TimerElapsed;

            timer.Start();

            Console.ReadKey();
        }

        private static void TimerElapsed (object sender, ElapsedEventArgs e) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Elapsed: {e.SignalTime:HH:mm:ss.fff}");
        }
    }
}