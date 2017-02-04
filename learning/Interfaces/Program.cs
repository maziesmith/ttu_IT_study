using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Interfaces {
    class Program {
        static void Main(string[] args) {
            Triangle t = new Triangle("Jack");
            Console.WriteLine("Points: {0}", t.Points);
            IPointy itfPt = null;

            // Casting with try and catch.
            try {
                itfPt = (IPointy)t;
                Console.WriteLine(itfPt.Points);
            } catch (InvalidCastException e) {
                Console.WriteLine(e.Message);
            }

            // Or with "as" keyword.
            IPointy itfPt2 = t as IPointy;

            if (itfPt2 != null) {
                Console.WriteLine("Points: {0}", t.Points);
            } else {
                Console.WriteLine("OOPS! Not point...");
            }

            // Drawings
            Octagon oct = new Octagon();

            IDrawToForm itftForm = (IDrawToForm)oct;
            itftForm.Draw();

            IDrawToMemory itftMemory = (IDrawToMemory)oct;
            itftMemory.Draw();

            IDrawToPrinter itftPrinter = (IDrawToPrinter)oct;
            itftPrinter.Draw();

            // or shorthand
            ((IDrawToPrinter)oct).Draw();

            Console.ReadKey();
        }

        private static void TypeClones () {
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();

            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);
        }

        private static void CloneMe(ICloneable c) {
            object theClone = c.Clone();

            Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
        }
    }
}
