using System;
using System.Web.UI;

namespace CSharpTest {
    public partial class requestresponse : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            sendMessage();
        }

        private void sendMessage() {
            Page.Response.Write("Hello world!");
            Page.Response.End();
        }
    }
}