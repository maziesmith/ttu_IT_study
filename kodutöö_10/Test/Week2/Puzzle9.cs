namespace Tasks {
    public partial class Week2 {
        public static bool Puzzle9(string text) {
            if (string.IsNullOrEmpty(text)) {
                return false;
            }

            for (int i = 0; i <= (text.Length / 2); i++) {
                if (text[i] != text[text.Length - 1 - i]) {
                    return false;
                }
            }

            return true;
        }
    }
}