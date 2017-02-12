using System;

namespace CSharpTest {
    public partial class passdata4 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            LabelReceivedData.Text = Session["Text"].ToString();
        }
    }
}