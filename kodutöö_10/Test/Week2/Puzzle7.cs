namespace Tasks {
    public partial class Week2 {
        public static int Puzzle7(int number) {
            if (number < 2) {
                return 1;
            }

            return number * Puzzle7(number - 1);
        }
    }
}
