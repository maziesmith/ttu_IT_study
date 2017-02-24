using System.Collections.Generic;

namespace My_Project {
    public class MyData {
        public int[] GetNumbers() {
            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 1;
            numbers[2] = 3;
            numbers[3] = 5;
            numbers[4] = 8;

            return numbers;
        }

        public List<string> GetNames() {
            List<string> names = new List<string>();

            names.Add("Mike");
            names.Add("Simon");
            names.Add("Emily");
            names.Add("Jessica");

            return names;
        }

        public void ProcessNames() {
            List<string> namesToProcess = GetNames();

            for (int counter = 0; counter < namesToProcess.Count; counter++) {
                namesToProcess[counter] = namesToProcess[counter].ToUpper();
            }
        }

        public string AppendNames() {
            string appendNames = "";

            foreach (string name in GetNames()) {
                appendNames = appendNames + " " + name;
            }

            return appendNames;
        }
    }
}