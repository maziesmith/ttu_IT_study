using System;

namespace CSharpTest {
    public partial class debugme : System.Web.UI.Page {
        protected void ButtonCrash_Click(object sender, EventArgs e) {
            int Denominator = 2;
            LabelResult.Text = (10 / Denominator).ToString();
        }
    }
}