using System;

namespace Attributes {
    public class IsTestedAttribute : Attribute {
        public override string ToString() {
            return "It is tested";
        }
    }
}
