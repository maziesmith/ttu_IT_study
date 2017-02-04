using System.Linq;

namespace Tasks {
    public partial class Week2 {
        public static string Puzzle8(string text) {
            if (string.IsNullOrEmpty(text)) {
                return string.Empty;
            }

            return new string(text.Reverse().ToArray());
        }
    }
}
