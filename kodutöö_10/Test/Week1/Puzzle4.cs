using System.Collections.Generic;

namespace Tasks {
    public partial class Week1 {
        // Remove character double or more occurences.
        public static string Puzzle4(string s) {
            if (string.IsNullOrEmpty(s)) {
                return string.Empty;
            }

            string newString = string.Empty;
            List<char> found = new List<char>();

            foreach (char c in s) {
                if (found.Contains(c)) {
                    continue;
                }

                newString += c.ToString();
                found.Add(c);
            }

            return newString;
        }
    }
}