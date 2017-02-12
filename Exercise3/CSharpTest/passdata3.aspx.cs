using System;
using System.Web.UI;

namespace CSharpTest {
    public partial class passdata3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Page.Request.QueryString["text"] != null) {
                LabelReceivedData.Text = Page.Request.QueryString["text"];
            }
        }
    }
}