using System;
using System.Web.UI;

namespace CSharpTest {
    public partial class movepage1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ButtonMove_Click(object sender, EventArgs e) {
            Page.Server.Transfer("movepage2.aspx");
        }
    }
}