namespace Tasks {
    public partial class Week1 {
        // Sum of params
        public static int Puzzle7(params int[] items) {
            int sum = 0;

            foreach (int i in items) {
                sum += i;
            }

            return sum;
        }
    }
}