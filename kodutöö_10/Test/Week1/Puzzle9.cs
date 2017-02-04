namespace Tasks {
    public partial class Week1 {
        // Find largest number in params and return it
        public static int Puzzle9(params int[] items) {
            int max = 0;

            foreach (int i in items) {
                if (i > max) {
                    max = i;
                }
            }

            return max;
        }
    }
}