namespace Tasks {
    public partial class Week2 {
        public static int Puzzle10(int i) {
            if (i < 4) return i;
            return Puzzle10(i - 1) + Puzzle10(i - 2);
        }
    }
}
