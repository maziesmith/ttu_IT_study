using System;

namespace Attributes {
    class MainClass {
        public static void Main() {
            AttributeTester.Print<Account>();
            AttributeTester.Print<Order>();

            Console.ReadKey();
        }
    }
}