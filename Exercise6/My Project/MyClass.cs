using System.Text;

namespace CustomClasses.TestClasses {
    public class MyClass {
        public int IntProperty;

        public void AddToProperty() {
            IntProperty = IntProperty + 1;
        }

        public void TestMethod() {
            StringBuilder TestStringBuilder = new StringBuilder();
        }

        public MyClass(int StartingNumber) {
            IntProperty = StartingNumber;
        }
    }
}