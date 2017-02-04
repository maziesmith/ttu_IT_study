namespace Tasks {
    public partial class Week1 {
        // Return ASCII string count.
        public static int Puzzle2(string s) {
            int sum = 0;

            if (string.IsNullOrEmpty(s)) {
                return sum;
            }

            foreach (char c in s) {
                sum += (int)c;
            }

            return sum;
        }
    }
}
