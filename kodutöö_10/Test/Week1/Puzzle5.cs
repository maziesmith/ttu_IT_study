namespace Tasks {
    public partial class Week1 {
        // Return ascii string represenation as string.
        public static string Puzzle5(string s) {
            string newString = string.Empty;

            if (string.IsNullOrEmpty(s)) {
                return newString;
            }

            foreach (char c in s) {
                newString += ((int)c).ToString();
            }

            return newString;
        }
    }
}