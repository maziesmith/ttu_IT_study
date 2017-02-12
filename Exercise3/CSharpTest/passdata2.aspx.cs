using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpTest {
    public partial class passdata2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Page.PreviousPage != null) {
                LabelReceivedData.Text = ((TextBox)Page.PreviousPage.FindControl("TextBoxText")).Text;
            }
        }
    }
}