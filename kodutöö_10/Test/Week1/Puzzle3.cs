namespace Tasks {
    public partial class Week1 {
        public static string Puzzle3(string s) {
            string newString = string.Empty;

            if (string.IsNullOrEmpty(s)) {
                return newString;
            }

            foreach (char c in s) {
                int cNum = (int)c;

                // 122 - 'z'
                // 97 - 'a
                if ((cNum + 3) > 122) {
                    int dif = ((cNum + 3) - 122);
                    newString += (char)((97 - 1) + dif);
                } else {
                    newString += (char)(cNum + 3);
                }
            }

            return newString;
        }
    }
}
