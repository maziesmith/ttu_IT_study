using System;
using System.Web.UI;

namespace CSharpTest {
    public partial class postbacktest : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            LabelIsPostBack.Text = Page.IsPostBack.ToString();
        }
    }
}