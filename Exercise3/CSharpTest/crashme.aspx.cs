using System;

namespace CSharpTest {
    public partial class crashme : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int Zero = 0;
            int Crash = 1 / Zero;
        }
    }
}