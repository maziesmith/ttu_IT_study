using System;

namespace My_Project {
    public partial class calculator : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ButtonCalculate_Click(object sender, EventArgs e) {
            double FirstNumber = Convert.ToDouble(TextBoxFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TextBoxSecondNumber.Text);
            double Result = Math.Max(FirstNumber, SecondNumber);
            LabelResult.Text = Result.ToString();
        }

        protected void ButtonCalculate2_Click(object sender, EventArgs e) {
            string PIString = "3.14159265";
            double PIDouble = Convert.ToDouble(PIString);
            int CircleRadius = 19;
            double CircleCircumference = PIDouble * CircleRadius;
            CircleCircumference = Math.Pow(CircleCircumference, 2);
            string OutputCircumference = CircleCircumference.ToString();
            DateTime TodaysDate = DateTime.Now;
        }
    }
}