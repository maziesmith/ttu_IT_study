using System;

namespace Tasks {
    public partial class Week1 {
        // Sort alphab. or reverse?
        public static string Puzzle1(string s) {
            if (string.IsNullOrEmpty(s)) {
                return string.Empty;
            }

            char[] a = s.ToCharArray();

            Array.Sort(a);

            return new string(a);
        }
    }
}
