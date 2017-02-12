using System;

namespace CSharpTest {
    public partial class exercise : System.Web.UI.Page {
        protected void ButtonChangeText_Click(object sender, EventArgs e) {
            TextBoxText.Text = "The Smart Method";
        }

        protected void ButtonSendData_Click(object sender, EventArgs e) {
            Session["Text"] = TextBoxText.Text;
            Response.Redirect("passdata4.aspx");
        }
    }
}