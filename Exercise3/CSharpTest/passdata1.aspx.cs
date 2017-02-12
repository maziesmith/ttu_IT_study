using System;
using System.Web.UI;

namespace CSharpTest {
    public partial class passdata1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ButtonSend_Click(object sender, EventArgs e) {
            Session["Text"] = TextBoxText.Text;
            Page.Response.Redirect("passdata4.aspx");
        }
    }
}