using System;
using System.Reflection;

namespace Attributes {
    public class AttributeTester {
        private static bool IsMemberTested(MemberInfo member) {
            foreach (object attribute in member.GetCustomAttributes(true)) {
                if (attribute is IsTestedAttribute) {
                    return true;
                }
            }

            return false;
        }

        private static void DumbAttributes(MemberInfo member) {
            Console.WriteLine($"Attributes for: {member.Name}");

            foreach (object attribute in member.GetCustomAttributes(true)) {
                Console.WriteLine(attribute);
            }
        }

        public static void Print<T>() {
            DumbAttributes(typeof(T));

            foreach (MethodInfo method in (typeof(T)).GetMethods()) {
                if (IsMemberTested(method)) {
                    Console.WriteLine($"Member {method.Name} is tested!");
                } else {
                    Console.WriteLine($"Member {method.Name} is NOT tested!");
                }
            }

            Console.WriteLine();
        }
    }
}
