﻿using System;
using System.Collections.Generic;
using CustomClasses.TestClasses;

namespace My_Project {
    public partial class calculator : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            MyClass MyClassInstance = new MyClass(17);
        }

        protected void ButtonCalculate_Click(object sender, EventArgs e) {
            double FirstNumber = Convert.ToDouble(TextBoxFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TextBoxSecondNumber.Text);
            double Result = CalculatorFunctions.Add(FirstNumber, SecondNumber);
            LabelResult.Text = Result.ToString();
        }

        protected void ButtonCalculate2_Click(object sender, EventArgs e) {
            List<int> ListToTotal = new List<int>() { 12, 17, 135 };
            CalculatorFunctions.AddToNumbers(10, ListToTotal);
            int Total = CalculatorFunctions.TotalNumbers(ListToTotal);
            Response.Write(Total);
        }
    }
}