namespace Spark {
    public static class PanelVisibilityController {
        public static void SetVisbility(System.Web.UI.WebControls.Panel panel, PanelVisibility visibility) {
            switch (visibility) {
                case PanelVisibility.Hidden:
                    panel.Visible = false;
                    break;

                case PanelVisibility.Visible:
                    panel.Visible = true;
                    break;
            }
        }
    }
}