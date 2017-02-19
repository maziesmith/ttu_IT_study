using System;

namespace My_Project {
    public partial class circlecalculator : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            const int circleSize = 50;
            const double circleRadius = 7.95;
            Circle MyCircle = new Circle(circleSize);
            double MyCircleDiameter = Circle.CalculateDiameter(circleRadius);

            Response.Write(MyCircleDiameter);
        }
    }
}