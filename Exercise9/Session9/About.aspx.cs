using System;
using System.Web.UI;

namespace Session9 {
    public partial class About : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.User.Identity.IsAuthenticated) {
                Response.Redirect("~/Account/Login.aspx");
            }
        }
    }
}