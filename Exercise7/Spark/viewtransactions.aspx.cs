using System;

namespace Spark {
    public partial class viewtransactions : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void DropDownListSelectPeriod_SelectedIndexChanged(object sender, EventArgs e) {
            if (DropDownListSelectPeriod.SelectedValue == "2010") {
                PanelVisibilityController.SetVisbility(Panel2010, PanelVisibility.Visible);
                PanelVisibilityController.SetVisbility(Panel2011, PanelVisibility.Hidden);
            } else if (DropDownListSelectPeriod.SelectedValue == "2011") {
                PanelVisibilityController.SetVisbility(Panel2010, PanelVisibility.Hidden);
                PanelVisibilityController.SetVisbility(Panel2011, PanelVisibility.Visible);
            }
        }
    }
}