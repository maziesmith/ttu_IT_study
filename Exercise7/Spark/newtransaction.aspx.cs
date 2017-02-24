using System;

namespace Spark {
    public partial class newtransaction : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        private decimal CalculateVAT (decimal Amount) {
            // VAT or Value Added Tax is a sales tax levied in Europe
            decimal vatAmount = Amount * 0.2m;
            vatAmount = Math.Round(vatAmount, 2);
            return vatAmount;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e) {
            try {
                if (DropDownListCustomer.SelectedValue == "6"
                    || DropDownListCustomer.SelectedValue == "9"
                    || DropDownListCustomer.SelectedValue == "11") {
                    LabelError.Text = "That customer is currently out of use";
                }
            } catch (Exception ex) {
                LabelError.Text = ex.Message;
            }
        }
    }
}