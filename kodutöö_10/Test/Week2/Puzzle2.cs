namespace Tasks {
    public partial class Week2 {
        public static char Puzzle2(int position, char[] items) {
            if (items == null || items.Length == 0) {
                return '\0';
            }

            if (position <= 0) {
                return items[0];
            } else if (position >= items.Length) {
                return items[items.Length - 1];
            }

            return items[position];
        }
    }
}
