using System;

namespace My_Project {
    public partial class circlecalculator : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Circle MyCircle = new Circle(50);
            double MyCircleDiameter = Circle.CalculateDiameter(7.95);
            Response.Write(MyCircleDiameter);
        }
    }
}