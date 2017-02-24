using System;

namespace My_Project {
    public partial class test : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            MyData data = new MyData();
            Response.Write(data.AppendNames());
        }
    }
}