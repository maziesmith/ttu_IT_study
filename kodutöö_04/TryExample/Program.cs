using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryExample {
    class Program {
        static void Main(string[] args) {
            try {
                string content = File.ReadAllText(@"C:\windows-version.txt");
                Console.WriteLine(content);
            } catch (FileNotFoundException ex) {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Example.txt");
            } catch (DirectoryNotFoundException ex) {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the system's hardrive filepath C:\ exists.");
            } catch (Exception ex) {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Closing application now...");
            }

            Console.ReadKey();
        }
    }
}
