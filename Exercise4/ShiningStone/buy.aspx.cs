using System;
using System.Web.UI;

namespace ShiningStone {
    public partial class buy : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ButtonSubmitOrder_Click(object sender, EventArgs e) {
            if (Page.IsValid) {
                Response.Write("OK!");
            }
        }
    }
}