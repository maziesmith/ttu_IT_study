using System;
using System.Linq;
using System.Web.UI;

namespace Session10 {
    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {
            try {
                if (!Page.IsPostBack) {
                    using (Session10DataContext Data = new Session10DataContext()) {
                        var myCustomer = Data.Customers.Single(customer => customer.CustomerID == 7);
                        TextBoxEditCustomerName.Text = myCustomer.CustomerName;
                    }
                }
            } catch (Exception ex) {
                LabelError.Text = ex.Message;
            }
        }

        protected void ButtonAddCustomer_Click(object sender, EventArgs e) {
            try {
                using (Session10DataContext Data = new Session10DataContext()) {
                    var newCustomer = new Customer();
                    newCustomer.CustomerName = TextBoxNewCustomerName.Text;
                    Data.Customers.InsertOnSubmit(newCustomer);
                    Data.SubmitChanges();
                }
            } catch (Exception ex) {
                LabelError.Text = ex.Message;
            }
        }

        protected void ButtonSaveCustomer_Click(object sender, EventArgs e) {
            try {
                using (Session10DataContext Data = new Session10DataContext()) {
                    var myCustomer = Data.Customers.Single(customer => customer.CustomerID == 7);
                    myCustomer.CustomerName = TextBoxEditCustomerName.Text;
                    Data.SubmitChanges();
                }
            } catch (Exception ex) {
                LabelError.Text = ex.Message;
            }
        }
    }
}