namespace Tasks {
    public partial class Week2 {
        public static char Puzzle1(int position, params char[] items) {
            char result = ' ';

            if (position > items.Length) {
                for (int i = 0; i < position; i++) {
                    if (i > items.Length) {
                        result = 'c';
                    }
                }
            } else {
                result = items[position];
            }

            return result;
        }
    }
}
