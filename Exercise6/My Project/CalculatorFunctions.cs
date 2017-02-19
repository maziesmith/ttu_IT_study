using System;

namespace My_Project {
    public class CalculatorFunctions {
        public static double Add(double FirstNumber, double SecondNumber) {
            return RoundNumber(FirstNumber + SecondNumber);
        }

        public double Subtract(double FirstNumber, double SecondNumber) {
            return FirstNumber - SecondNumber;
        }

        public double Multiply(double FirstNumber, double SecondNumber) {
            return FirstNumber * SecondNumber;
        }

        public double Divide(double FirstNumber, double SecondNumber) {
            return FirstNumber / SecondNumber;
        }

        private static double RoundNumber(double Number) {
            return Math.Round(Number, 2);
        }
    }
}