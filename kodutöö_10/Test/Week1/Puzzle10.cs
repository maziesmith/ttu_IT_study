using System;

namespace Tasks {
    public partial class Week1 {
        // Mirror number
        public static int Puzzle10(int i) {
            if (i == 0) {
                return 0;
            } else if (i > 0) {
                return (i - (i * 2));
            } else {
                return (i + Math.Abs(i * 2));
            }
        }
    }
}
