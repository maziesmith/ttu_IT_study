using System;
namespace CSharpTest {
    public partial class _default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            setLabelText("Hello!");
            setLabelFontToBold();
        }

        protected void ButtonChangeText_Click(object sender, EventArgs e) {
            setLabelText("Text!");
        }

        protected void CalendarSelect_SelectionChanged(object sender, EventArgs e) {
            setLabelText(CalendarSelect.SelectedDate.ToString());
        }

        private void setLabelText (string text) {
            LabelOutput.Text = text;
        }

        private void setLabelFontToBold () {
            LabelOutput.Font.Bold = true;
        }
    }
}